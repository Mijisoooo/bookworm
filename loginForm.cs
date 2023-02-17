using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace 책벌레2
{
    public partial class loginForm : Form
    {
        #region 전역변수
        ConDatabase conDb = new ConDatabase();
        string qry = "";
        string username = "";
        string password = "";
        #endregion

        public loginForm()
        {
            InitializeComponent();
        }

        private void tboxPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && sender == tboxPw)
            {
                if (tboxId.Text == "")
                {
                    tboxId.Focus();
                    return;
                }
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)  // 관리자 로그인 (admin1, 12345) 
        {
            username = tboxId.Text;
            password = tboxPw.Text;

            qry = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
            
            List<SqlParameter> sqlParams = new List<SqlParameter>
            {
                new SqlParameter("@username", username), 
                new SqlParameter("@password", password)
            };

            SqlCommand command = conDb.sqlCmdParams(qry, sqlParams);

            int result = Convert.ToInt32(command.ExecuteScalar());
            if (result > 0)
            { 
                mainForm mainForm = new mainForm();
                mainForm.Show();
                this.Hide();
            }
            else MessageBox.Show("로그인 실패");

            conDb.DBClose();

        }

        private void labelFindpw_Click(object sender, EventArgs e) // 비밀번호 찾기 
        {
            username = Microsoft.VisualBasic.Interaction.InputBox("관리자 아이디 : ", "비밀번호 찾기");
            qry = "SELECT password FROM users WHERE username = @username";

            SqlCommand command = conDb.sqlCmdParams(qry, new List<SqlParameter>{new SqlParameter("@username", username)});
            object result = command.ExecuteScalar();

            if (result != null)
            {
                string password = result.ToString();
                MessageBox.Show("비밀번호 : " + password);
            }
            else
                MessageBox.Show("해당 아이디가 없습니다.");

            conDb.DBClose();

        }

        
    }
}
