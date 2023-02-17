using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace 책벌레2
{
    public class bookOperations
    {
        #region 전역변수
        private readonly string _connStr = "Data Source=localhost;Initial Catalog=testDB;Integrated Security=True";
        string book_id;
        string mem_id;
        string message = "";
        string mem_email;
        #endregion

        public void fn_operation(string action, string formName, Form formInstance)  // action 인수에는 대출, 반납, 예약, 예약취소 
        {
            formInstance.TopMost = false; 

            string dgvName;

            switch (formName)
            {
                case "main":
                    dgvName = "dgview_main";
                    break;
                case "user_management":
                    dgvName = "dgview_user";
                    break;
                case "book_management":
                    dgvName = "dgview_book";
                    break;
                default:
                    dgvName = "dgview_rental";
                    break;
            }

            DataGridView dataGridView = (DataGridView)formInstance.Controls[dgvName];

            try
            {
                if (dataGridView.SelectedRows.Count == 0 || dataGridView.SelectedRows[0].Cells["등록번호"].Value == null)//|| dataGridView.Rows[0].Cells[0].Value.ToString() == null)  // 선택한 셀이 없는 경우  
                {
                    MessageBox.Show(action + "할 도서를 선택하세요", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly | MessageBoxOptions.ServiceNotification);
                    return;
                }

                book_id = dataGridView.SelectedRows[0].Cells["등록번호"].Value.ToString();

                if (action != "반납")
                {
                    mem_id = Microsoft.VisualBasic.Interaction.InputBox("회원번호 : ", "회원번호 입력"); 
                }
                else
                    mem_id = "0";
                if (mem_id == null) { return; }



                using (SqlConnection conn = new SqlConnection(_connStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("libraryProcedure", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@action", action);
                        cmd.Parameters.AddWithValue("@book_id", book_id);
                        cmd.Parameters.AddWithValue("@mem_id", mem_id);
                        //foreach (SqlParameter param in parameters)
                        //{
                        //    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                        //}

                        SqlParameter msgParam = new SqlParameter("@message", SqlDbType.NVarChar, 100);
                        SqlParameter emailParam = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                        msgParam.Direction = ParameterDirection.Output;
                        emailParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(msgParam);
                        cmd.Parameters.Add(emailParam); 

                        try
                        {
                            cmd.ExecuteNonQuery();
                            mem_email = emailParam.Value.ToString();
                            message = msgParam.Value.ToString();
                            MessageBox.Show(message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }




                        if (action == "대출")
                        {
                            string book_title = dataGridView.SelectedRows[0].Cells["제목"].Value.ToString();

                            string subject = "[책벌레도서관] 대출 알림 메일";
                            string body = $@"[대출정보] {Environment.NewLine}
                                          대출일 : {DateTime.Today} {Environment.NewLine}
                                          반납예정일 : {DateTime.Today.AddDays(7)} {Environment.NewLine}
                                          책제목 : {book_title}";
                            SendEmail(mem_email, subject, body); 
                        }
                    }
                }
            }
            catch
            {

            }

        }

        public void SendEmail(string recipient, string subject, string body, string action = "")
        {

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("ssujisu007@gmail.com");
            mail.To.Add(recipient);
            mail.Subject = subject;
            mail.Body = body;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("ssujisu007@gmail.com", "epfpgidwldiydeja");

            try
            {
                smtp.Send(mail);
                if (action == "인증")
                    MessageBox.Show("전송완료", "전송 완료");   // 전송완료 메세지박스 출력
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());           // 이메일 발송 실패시 오류내용 메세지박스 출력 
            }
        }

        public void SendAlertMail(int setnum)  // 반납일 알림메일 전송 
        {
            string mem_email = "";
            string book_title = "";
            DateTime rental_sdate;
            DateTime rental_edate;
            string subject = "[책벌레도서관] 반납일 알림"; 


            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();

                string qry = $"SELECT b.title, r.rental_sdate, r.rental_edate, m.email FROM tbl_rental r INNER JOIN tbl_book b ON r.book_id = b.book_id INNER JOIN tbl_member m ON r.mem_id = m.mem_id WHERE r.rental_edate = CONVERT(CHAR(10), DATEADD(DAY, {setnum}, getdate()), 23) and r.rental_status = 0";
                using (SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        book_title = reader["title"].ToString();
                        rental_sdate = DateTime.Parse(reader["rental_sdate"].ToString());
                        rental_edate = DateTime.Parse(reader["rental_edate"].ToString());
                        mem_email = reader["email"].ToString();

                        string body = $@"[반납 알림] {Environment.NewLine} 반납예정일이 {setnum}일 후 입니다. {Environment.NewLine} 대출일 : {rental_sdate} {Environment.NewLine} 반납예정일 : {rental_edate} {Environment.NewLine} 책제목 : {book_title}";

                        SendEmail(mem_email, subject, body, "만료일");
                    }
                    MessageBox.Show("모두 전송완료", "전송 완료");   // 메세지가 잘 보내졌으면 해당 메세지 보내도록 
                }
            } 
        }
    }
}
