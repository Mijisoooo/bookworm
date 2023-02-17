using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;                      // qr코드 생성 및 출력 
using ZXing.QrCode;               // qr코드 생성 및 출력
using System.Drawing.Printing;    // qr코드 생성 및 출력

namespace 책벌레2
{
    public partial class bookMng : Form
    {
        #region 전역변수
        private bookOperations bookOps = new bookOperations();
        private controlStripMenu cSMenu = new controlStripMenu();
        ConDatabase conDb = new ConDatabase();
        Dictionary<int, byte[]> imageDictionary = new Dictionary<int, byte[]>();   // pic컬럼의 값 저장 
        string qry = "";
        #endregion


        public bookMng()
        {
            InitializeComponent();
        }

        void search()  // 검색
        {
            if (comboBox1.Text == string.Empty) { MessageBox.Show("조회할 컬럼을 선택해주세요", "inform", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            else if (searchbox_book.Text == string.Empty) { MessageBox.Show("검색어를 입력해주세요", "inform", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            try
            {
                string parameter = comboBox1.Text;
                string searchVal = searchbox_book.Text;
                string qry = $@"exec Proc_BookWorm @div = 'S', @CbItem = {parameter}, @searchText = {searchVal}";
                DataSet book_table = conDb.GetDataSetFromSqlQuery(qry);
                dgview_book.DataSource = book_table.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void book_management_Load(object sender, EventArgs e)
        {
            // image column 을 데이터그리드뷰에 추가 (varbinary 컬럼은 처리 불가해서) 
            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn.Name = "pic";
            //imageColumn.HeaderText = "사진";
            //imageColumn.DataPropertyName = "pic";
            //imageColumn.DefaultCellStyle.NullValue = null;
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dgview_book.Columns.Add(imageColumn);

            ViewRefresh_book();
            panel_book_detail.Hide();
        }

        private void btn_reg_Click(object sender, EventArgs e)   // 신규도서등록 버튼 클릭 
        {
            bookReg bookRegForm = new bookReg();
            bookRegForm.ShowDialog();
        }

        public void ViewRefresh_book()     // dgview_book 새로고침  
        {
            qry = $@"exec Proc_BookWorm @div = 'S1'";
            DataSet book_table = conDb.GetDataSetFromSqlQuery(qry);
            dgview_book.DataSource = book_table.Tables[0];

            dgview_book.Columns["기증자명"].Visible = false;
            dgview_book.Columns["기증여부"].Visible = false;

            qry = "select book_id, pic from tbl_book";
            conDb.DBOpen();

            SqlDataReader reader = conDb.sqlExecuteReader(qry);
            while (reader.Read())
            {
                int book_id = (int)reader["book_id"];
                // null인 경우, new byte[0]으로 저장 (default 설정) 
                byte[] imageBytes = reader["pic"] as byte[] ?? new byte[0];

                if (imageDictionary != null) imageDictionary.Clear();
                else imageDictionary = new Dictionary<int, byte[]>();
            }
            conDb.DBClose();
                                                                                                                  
            #region 이전소스
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    conn.Open();

            //    // 프로시저로 바꾸기 
            //    string qry = $@"select d.donator as 기증자명, 
            //                           b.book_id as 등록번호, 
            //                           b.isbn as ISBN, 
            //                           b.booknum as 청구기호, 
            //                           b.title as 제목, 
            //                           b.writer as 저자, 
            //                           b.publisher as 출판사, 
            //                           b.pdate as 출판일자, 
            //                           case when d.donator is not null then 'yes' else 'no' end as '기증여부' 

            //                           from tbl_book b 
            //                                left join tbl_donate d 
            //                                on b.book_id = d.book_id 

            //                           where b.status in (0,1)";


            //    using (SqlCommand command = new SqlCommand(qry, conn))
            //    {
            //        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //        {
            //            {
            //                DataTable book_table = new DataTable();
            //                adapter.Fill(book_table);
            //                dgview_book.DataSource = book_table;

            //                // dgview_book.Columns["pic"].Visible = false;   // 이렇게 하면 에러 뜸 (dgview_book 에 저장하는 과정에서 에러)      
            //                dgview_book.Columns["기증자명"].Visible = false;  // '기증자명' 컬럼 dgview_book 에서 안보이게 
            //                dgview_book.Columns["기증여부"].Visible = false;

            //                // pic 컬럼을 dictionary 에 저장 
            //                qry = "select book_id, pic from tbl_book";
            //                using (SqlCommand cmd = new SqlCommand(qry, conn))
            //                {
            //                    using (SqlDataReader reader = cmd.ExecuteReader())
            //                    {
            //                        while (reader.Read())
            //                        {
            //                            int book_id = (int)reader["book_id"];
            //                            // null인 경우, new byte[0]으로 저장 (default 설정) 
            //                            byte[] imageBytes = reader["pic"] as byte[] ?? new byte[0];
            //                            imageDictionary.Add(book_id, imageBytes);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion
        }

        private void dgview_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pb_bpic.Image = null;
            panel_book_detail.Visible = true;

            tb_bname.Text = dgview_book.SelectedRows[0].Cells["제목"].Value.ToString();
            tb_bwriter.Text = dgview_book.SelectedRows[0].Cells["저자"].Value.ToString();
            tb_bpub.Text = dgview_book.SelectedRows[0].Cells["출판사"].Value.ToString();
            tb_bpdate.Text = dgview_book.SelectedRows[0].Cells["출판일자"].Value.ToString();
            tb_booknum.Text = dgview_book.SelectedRows[0].Cells["청구기호"].Value.ToString();
            tb_bookid.Text = dgview_book.SelectedRows[0].Cells["등록번호"].Value.ToString();
            tb_isbn.Text = dgview_book.SelectedRows[0].Cells["ISBN"].Value.ToString();

            openRental();
            openReserve();


            string isDonated = dgview_book.SelectedRows[0].Cells["기증여부"].Value.ToString();

            if (isDonated == "yes") rdobtn_yes.Checked = true;
            else rdobtn_no.Checked = true;

            if (rdobtn_yes.Checked) tb_donator.Enabled = true;
            else tb_donator.Enabled = false;

            tb_donator.Text = dgview_book.SelectedRows[0].Cells["기증자명"].Value.ToString();
            try
            {
                string isGotPic = dgview_book.SelectedRows[0].Cells["등록번호"].Value.ToString();

                qry = $@"select top 1 pic from tbl_book where book_id = {isGotPic}";
                byte[] imageByte = (byte[])conDb.GetDataSetFromSqlQuery(qry).Tables[0].Rows[0]["pic"];
                MemoryStream mss = new MemoryStream(imageByte);
                pb_bpic.Image = Image.FromStream(mss);
            }
            catch
            {
            }
        }

        private void rdobtn_yes_CheckedChanged(object sender, EventArgs e)  // 기증여부 예 클릭 -> 기증자명 tbox 활성화 
        {
            tb_donator.Enabled = true;
        }

        private void rdobtn_no_CheckedChanged(object sender, EventArgs e)  // 기증여부 아니오 클릭 -> 기증자명 tbox 비활성화 
        {
            tb_donator.Enabled = false;
        }

        private void labelQRcode_Click(object sender, EventArgs e)  // 도서바코드 확인/출력 클릭
        {
            var qrWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = 150,
                    Height = 150,
                }
            };
            var qrCode = qrWriter.Write(tb_bookid.Text);

            // QR코드 표시를 위한 새 폼 생성 
            var form = new Form();
            form.TopMost = true;
            form.ClientSize = new System.Drawing.Size(400, 400);
            var pictureBox = new PictureBox();
            pictureBox.Image = qrCode;
            pictureBox.Size = new System.Drawing.Size(150, 150);
            pictureBox.Location = new System.Drawing.Point((form.ClientSize.Width - pictureBox.Width) / 2, (form.ClientSize.Height - pictureBox.Height) / 2 - 30);
            form.Controls.Add(pictureBox);

            // 생성된 폼에 print 버튼 생성
            System.Windows.Forms.Button btnPrint = new System.Windows.Forms.Button();
            btnPrint.Text = "인쇄";
            btnPrint.Size = new System.Drawing.Size(100, 30);
            btnPrint.Location = new System.Drawing.Point((form.ClientSize.Width - btnPrint.Width) / 2, pictureBox.Location.Y + pictureBox.Height + 30);
            btnPrint.Click += btnPrint_Click;
            form.Controls.Add(btnPrint);

            form.ShowDialog();

        }

        private void btnPrint_Click(object sender, EventArgs e)  // qr코드 프린트
        {
            var pictureBox = ((System.Windows.Forms.Button)sender).Parent.Controls[0] as PictureBox;
            if (pictureBox == null)
            {
                MessageBox.Show("QR code not found");
                return;
            }

            var printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawImage(pictureBox.Image, ev.MarginBounds);
            };
            printDocument.DefaultPageSettings.Landscape = true;

            var printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e) => search();

        private void searchbox_KeyDown(object sender, KeyEventArgs e)  // enter 눌렀을때 검색 가능
        {
            if (e.KeyCode == Keys.Enter) search();
        }

        public void openRental()
        {
            qry = $@"EXEC Proc_BookWorm 	@div = 'S2', @cbItem = '{tb_bookid.Text}', @searchText = ''";
            DataSet rental_table = conDb.GetDataSetFromSqlQuery(qry);
            dgview_detail_rental.DataSource = rental_table.Tables[0];
        }

        public void openReserve()
        {
            qry = $@"EXEC Proc_BookWorm 	@div = 'S3', @cbItem = '{tb_bookid.Text}', @searchText = ''";
            DataSet reserv_detail_table = conDb.GetDataSetFromSqlQuery(qry);
            dgview_detail_reserve.DataSource = reserv_detail_table.Tables[0];
        }


        private void btnRental_Click(object sender, EventArgs e)  // 대출 버튼 클릭 
        {
            bookOps.fn_operation("대출", "book_management", this);
        }

        private void btnReturn_Click(object sender, EventArgs e)  // 반납 버튼 클릭
        {
            bookOps.fn_operation("반납", "book_management", this);
        }

        private void btnReserve_Click(object sender, EventArgs e)  // 예약 버튼 클릭
        {
            bookOps.fn_operation("예약", "book_management", this);
        }

        private void btnReservCancel_Click(object sender, EventArgs e)  // 예약취소 버튼 클릭
        {
            bookOps.fn_operation("예약취소", "book_management", this);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tName = tb_bname.Text;
            string tWriter = tb_bwriter.Text;
            string tPub = tb_bpub.Text;
            string tPubDate = tb_bpdate.Text;
            string tLocation = tb_booknum.Text;
            string tISBN = tb_isbn.Text;
            string tDonator = tb_donator.Text;

            bookReg bookRegForm = new bookReg();
            bookRegForm.UpdateRegForm(tName, tWriter, tPub, tPubDate, tLocation, tISBN, tDonator);
            bookRegForm.ShowDialog();
        }

        private void btnDisabled_Click(object sender, EventArgs e)  // 비활성화 버튼 클릭 
        {
            string bookid = dgview_book.SelectedRows[0].Cells["등록번호"].Value.ToString();
            string qry = $"UPDATE tbl_book SET status = 3 WHERE book_id = {bookid} AND status = 0";
            
            try
            {
                conDb.sqlExecuteReader(qry);
                MessageBox.Show("도서 비활성화 완료");
            }
            catch(Exception ex)
            {
                MessageBox.Show("도서 비활성화 불가 (대출중인 도서)", "에러", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchbox_book_TextChanged(object sender, EventArgs e)
        {
            if (searchbox_book.Text == "") ViewRefresh_book();
        }
    }
}

