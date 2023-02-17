using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestSharp;

namespace 책벌레2
{
    public partial class mainForm : Form
    {
        #region 전역변수
        ConDatabase conDb = new ConDatabase();
        private bookOperations bookOps = new bookOperations();
        private controlStripMenu cSMenu = new controlStripMenu();
        string searchValue;
        #endregion


        public mainForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "이름", "제목", "대여번호" });
        }

        private void main_Load(object sender, EventArgs e)    // main의 datagridview에 대출현황 표시 
        {
            ViewRefresh_rental();
            //dgview_main.ClearSelection();
            //dgview_main.Rows[0].Selected = false;
        }


        private void ViewRefresh_rental()  // dgview_main 새로고침 
        {
            string qry = "SELECT r.rental_id AS 대여번호, r.book_id AS 등록번호, b.title AS 제목, m.mem_id AS 회원번호, m.name AS 회원이름, r.rental_sdate AS 대여일, " +
                             "r.rental_edate AS 대여만료일, COUNT(*) -1 AS 예약인원 FROM tbl_rental r INNER JOIN tbl_book b ON r.book_id = b.book_id " +
                             "INNER JOIN tbl_member m ON r.mem_id = m.mem_id LEFT OUTER JOIN tbl_reserv rs ON r.book_id = rs.book_id AND rs.reserv_edate >= GETDATE() " +
                             "WHERE r.rental_status = 0 GROUP BY r.book_id, r.rental_id, b.title, m.mem_id, m.name, r.rental_sdate, r.rental_edate;";
            dgview_main.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
        }

        private void searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            searchValue = searchbox.Text;

            if (e.KeyCode == Keys.Enter) search();
        }

        private void searchbutton_Click(object sender, EventArgs e) => search(); 
            

        private void search()
        {
            string searchOption = comboBox1.Text;
            searchValue = searchbox.Text;

            string qry;
            string parameter = string.Empty;

            if (comboBox1.Text == string.Empty) { MessageBox.Show("조회할 컬럼을 선택해주세요", "inform", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            else if (searchValue == string.Empty) { MessageBox.Show("검색어를 입력해주세요", "inform", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            switch (searchOption)
            {
                case "이름":
                    parameter = "m.name";
                    break;
                case "제목":
                    parameter = "b.title";
                    break;
                case "회원번호":
                    parameter = "m.mem_id";
                    break;
            }

            qry = $@"select r.rental_id as 대여번호, b.book_id as 등록번호, b.title as 제목, m.mem_id as 회원번호, m.name as 회원이름, r.rental_sdate as 대여일, r.rental_edate as 대여만료일 
                    from tbl_rental as r inner join tbl_book as b on r.book_id = b.book_id inner join tbl_member as m on r.mem_id = m.mem_id 
                    where {parameter} like {searchValue} and r.rental_status=0";
            dgview_main.DataSource = conDb.GetDataSetFromSqlQuery(qry).Tables[0];
           
        }

        private void btn_return_Click(object sender, EventArgs e)  // 반납 버튼 클릭 
        {
            bookOps.fn_operation("반납", "main", this);
        }

        private void btn_reserv_Click(object sender, EventArgs e)  // 예약 버튼 클릭  
        {
            bookOps.fn_operation("예약", "main", this);  
        }

        private void btn_reserv_cancel_Click(object sender, EventArgs e)  // 예약취소 버튼 클릭 
        {
            bookOps.fn_operation("예약취소", "main", this);
        }


        private void main_Activated(object sender, EventArgs e)
        {
            ViewRefresh_rental();
        }

        private void 메인화면ToolStripMenuItem_Click(object sender, EventArgs e)   // menu의 메인화면 클릭 
        {
            cSMenu.fn_operation("main", this);
        }


        public void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)   // menu의 회원관리 클릭 
        {
            cSMenu.fn_operation("user_management", this);

        }

        public void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)   // menu의 도서관리 클릭 
        {
            cSMenu.fn_operation("book_management", this);
        }

        private void btn_alarm_Click(object sender, EventArgs e)  // 메일전송 버튼 클릭 
        {
            int setnum = (int)mailSetNum.Value;
            bookOps.SendAlertMail(setnum);
        }

        
    }
}



