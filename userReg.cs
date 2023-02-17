using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;



namespace 책벌레2
{
    public partial class form_userRegister : Form
    {
        #region 전역변수
        ConDatabase conDb = new ConDatabase();
        private bookOperations bookOps = new bookOperations();
        bool isauthorized = false;   // 이메일인증 관련 변수 
        string emailAddress;
        #endregion


        public form_userRegister()
        {
            InitializeComponent();
        }

        #region 이벤트핸들러
        private void form_userRegister_Load(object sender, EventArgs e)
        {
            SetDefaultYMDComboBox();

            tbox_checknum.GotFocus += new EventHandler(this.TexTGotFocus);
            tbox_checknum.LostFocus += new EventHandler(this.TextLostFocus);
        }

        public void TexTGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "인증번호를 입력하시오")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "인증번호를 입력하시오";
                tb.ForeColor = Color.LightGray;
            }
        }

        private void SetDefaultYMDComboBox()     // 콤보박스 아이템 년월일 설정
        {
            DateTime now = DateTime.Now;

            int thisYear = now.Year;

            for (int i = thisYear - 90; i <= thisYear; i++)
            {
                cbox_byear.Items.Add(i.ToString());
            }
            cbox_byear.Text = thisYear.ToString();

            for (int i = 1; i < 13; i++)
            {
                cbox_bmonth.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 31; i++)
            {
                cbox_bday.Items.Add(i.ToString());
            }
        }


        public static Random randomNum = new Random();   // 난수발생 객체 생성 (이메일 인증) 
        public static int checkNum;

        private void btnAuth_Click(object sender, EventArgs e)    // 이메일 인증 버튼 클릭 
        {
            emailAddress = tbox_email.Text;
            checkNum = randomNum.Next(10000000, 99999999);       // 인증번호 생성
            string subject = "책벌레 회원가입 본인인증 이메일"; 
            string body = "인증번호 : " + checkNum.ToString();
            bookOps.SendEmail(emailAddress, subject, body, "인증");
        }

        private void btnCheck_Click(object sender, EventArgs e)    // 이메일인증 확인버튼 클릭 
        {
            if (tbox_checknum.Text == checkNum.ToString())
            {
                MessageBox.Show("이메일 인증 완료", "인증 성공");
                isauthorized = true;
            }
            else
            {
                MessageBox.Show("인증번호가 다릅니다", "인증 실패");
            }
        }


        private int ageCheck(string birthdate)   // 나이체크 함수 (birthdate 형식 : cbox_byear.Text + "-" + cbox_bmonth.Text + "-" + cbox_bday.Text)
        {
            DateTime birthdateDT = DateTime.Parse(birthdate);
            TimeSpan age = DateTime.Now - birthdateDT;

            return (int)age.TotalDays / 365;
        }


        private void btnReg_Click(object sender, EventArgs e)  // 등록 버튼 클릭       
        {
            string name = tbox_name.Text;
            string birthdate = cbox_byear.Text + "-" + cbox_bmonth.Text + "-" + cbox_bday.Text;
            string regdate = DateTime.Now.ToString("yyyy-MM-dd");
            string phonenum1 = tbox_phone1.Text;
            string phonenum2 = tbox_phone2.Text;
            string address = tbox_address.Text;
            string remark = tbox_remark.Text;

            if (tbox_email.Text != emailAddress)  // 인증된 이메일과 다른 이메일인 경우, 등록 불가 
            {
                MessageBox.Show("인증된 이메일이 아닙니다. 이메일 인증이 필요합니다.");
                return;
            }

            if (isauthorized == false)   // 이메일 인증이 안된 경우, 등록 불가 
            {
                MessageBox.Show("이메일 인증이 필요합니다");
                return;
            }


            if (phonenum1 == phonenum2)   // 연락처 2개가 동일한 경우 
            {
                MessageBox.Show("서로다른 연락처를 입력해주세요");
                return;
            }

            string qry = "select count(*) from tbl_member where email = @email and enabled = 0";
            SqlCommand command = conDb.sqlCmdParams(qry, parameters: new List<SqlParameter> { new SqlParameter("@email", emailAddress)});
            
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("동일 이메일이 존재합니다");
                return;
            }
                

            qry = "INSERT INTO tbl_member(name, birthdate, regdate, phonenum1, phonenum2, email, address, mem_remark, auth, enabled) VALUES (@name, @birthdate, @regdate, @phonenum1, @phonenum2, @email, @address, @remark, @auth, 0)";

            int userAge = ageCheck(birthdate);
            SqlParameter authParam;
            if (userAge > 19)
                authParam = new SqlParameter("@auth", 0);
            else
            {
                authParam = new SqlParameter("@auth", 1);
                MessageBox.Show("관리자의 승인이 추가로 필요합니다");
                return;
            }

            List<SqlParameter> sqlParams = new List<SqlParameter>
            {
                new SqlParameter("@name", name),
                new SqlParameter("@birthdate", birthdate),
                new SqlParameter("@regdate", regdate),
                new SqlParameter("@phonenum1", phonenum1),
                new SqlParameter("@phonenum2", phonenum2),
                new SqlParameter("@email", emailAddress),
                new SqlParameter("@address", address),
                new SqlParameter("@remark", remark),
                authParam
            };

            conDb.sqlCmdParams(qry, sqlParams);
            conDb.DBClose();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)   // 취소 버튼 클릭 
        {
            this.Close();       
            //ViewRefresh_user();
        }

        #endregion
    }
}

