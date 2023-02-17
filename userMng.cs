using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace 책벌레2
{
    public partial class userMng : Form
    {
        #region 전역변수
        ConDatabase conDb = new ConDatabase();
        private controlStripMenu cSMenu = new controlStripMenu();
        string searchValue;
        #endregion


        public userMng()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "이름", "연락처", "이메일" });
            btnAuth.Hide();
        }

        private void user_management_Load(object sender, EventArgs e)
        {
            ViewRefresh_user(0);
            dgview_user.ClearSelection();
        }

        private void searchbox_KeyDown(object sender, KeyEventArgs e)  
        {
            searchValue = searchbox.Text;

            if (e.KeyCode == Keys.Enter) search();      
        }


        private void user_management_Activated(object sender, EventArgs e)
        {
            ViewRefresh_user(0);
        }


        public void btnRegAccount_Click(object sender, EventArgs e)   // 신규회원등록 버튼 클릭 
        {
            form_userRegister userRegForm = new form_userRegister();
            userRegForm.ShowDialog();      

        }

        private void user_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            userMng userForm = (userMng)Application.OpenForms["user_management"];
            if (userForm != null)
            {
                userForm.ViewRefresh_user(0);
            }
        }

        public void openRental()
        {
            try
            {
                string lblid = lbl_custid.Text;
                string qry = $@"select a.title as 제목, b.rental_sdate as 대여날짜, b.rental_edate as 반납날짜 from tbl_book a inner join tbl_rental b on a.book_id = b.book_id where b.mem_id = {lblid}";
                dgview_rental.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
            }

            catch { }
        }

        public void openReserve()
        {
            try
            {
                string lblid = lbl_custid.Text;

                string qry;
                qry = $@"select r.reserv_id as 예약번호, b.title as 책제목, r.reserv_sdate as 예약일, r.reserv_edate as 예약만료일 from tbl_reserv r inner join tbl_book b on r.book_id = b.book_id inner join tbl_member m on r.mem_id = m.mem_id where r.mem_id = {lblid}";
                
                dgview_reserve.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
            }
            catch { }

        }

        public void ViewRefresh_user(int auth)    // dgview_user 새로고침 
        {
            // auth = 0 : 승인된 회원 표시, auth = 1 : 미승인 회원 표시 

            string qry = string.Format("select mem_id as 회원번호, name as 이름, phonenum1 as 연락처1, phonenum2 as 연락처2, email as 이메일, address as 주소, birthdate as 생년월일, regdate as 등록일자, mem_remark as 비고 from tbl_member where auth = {0}", auth);
            dgview_user.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
        }


        private void btnMngAuth_Click(object sender, EventArgs e)   // 미승인회원 관리 버튼 클릭 시 - 해당 창의 DataGridView 내용 변경됨
        {
            ViewRefresh_user(1);
            btnAuth.Show();          
        }

        private void btnAuth_Click(object sender, EventArgs e)   // 승인버튼 클릭 시 
        {
            string memid = lbl_custid.Text;
            string qry = $@"update tbl_member set auth = '0' where mem_id = '{memid}'";

            dgview_user.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
            ViewRefresh_user(0);
        }

        private void searchbutton_Click(object sender, EventArgs e) => search();

        private void search()
        {
            string SearchBox = searchbox.Text;
            string qry = string.Empty;
            string parameter = string.Empty;

            if (comboBox1.Text == string.Empty) { MessageBox.Show("조회할 컬럼을 선택해주세요", "inform", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            else if (SearchBox == string.Empty) { MessageBox.Show("검색어를 입력해주세요", "inform", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            switch (comboBox1.Text)
            {
                case "이름":
                    parameter = "name";
                    break;
                case "연락처":
                    parameter = "phonenum1";
                    break;
                case "이메일":
                    parameter = "email";
                    break;
            }

            qry = $@"select mem_id as 회원번호, name as 이름, phonenum1 as 연락처1, phonenum2 as 연락처2, email as 이메일, address as 주소, birthdate as 생년월일, 
                        regdate as 등록일자, mem_remark as 비고 from tbl_member where {parameter} like '{SearchBox}'";

            dgview_user.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string phone = tb_phone.Text;
            string phone2 = tb_phone2.Text;
            string email = tb_email.Text;
            string address = tb_address.Text;
            string remark = tb_remark.Text;
            string memid = lbl_custid.Text;
            string qry = $@"update tbl_member set name = '{name}', phonenum1 = '{phone}', phonenum2 = '{phone2}', email = '{email}', address = '{address}', mem_remark = '{remark}' where mem_id = '{memid}'";

            dgview_user.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
            ViewRefresh_user(0);
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            string memid = lbl_custid.Text;

            string qry = $@"update tbl_member set auth = '1' where mem_id = '{memid}'";

            dgview_user.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
            ViewRefresh_user(0);
        }


        private void dgview_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_cust_detail.Visible = true;

            lbl_custid.Text = dgview_user.Rows[this.dgview_user.CurrentCellAddress.Y].Cells[0].Value.ToString();
            tb_name.Text = dgview_user.Rows[this.dgview_user.CurrentCellAddress.Y].Cells[1].Value.ToString();
            tb_phone.Text = dgview_user.Rows[this.dgview_user.CurrentCellAddress.Y].Cells[2].Value.ToString();
            tb_phone2.Text = dgview_user.Rows[this.dgview_user.CurrentCellAddress.Y].Cells[3].Value.ToString();
            tb_email.Text = dgview_user.Rows[this.dgview_user.CurrentCellAddress.Y].Cells[4].Value.ToString();
            tb_address.Text = dgview_user.Rows[this.dgview_user.CurrentCellAddress.Y].Cells[5].Value.ToString();
            tb_remark.Text = dgview_user.Rows[this.dgview_user.CurrentCellAddress.Y].Cells[8].Value.ToString();

            openRental();
            openReserve();

        }
        public void 메인화면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cSMenu.fn_operation("main", this);
        }

        public void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cSMenu.fn_operation("user_management", this);

        }
        public void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cSMenu.fn_operation("book_management", this);
        }
    }
}
