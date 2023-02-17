using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 책벌레2
{
    public partial class bookReg : Form
    {
        #region 전역변수 
        ConDatabase conDb = new ConDatabase();
        string title;
        string writer;
        string publisher;
        string pubdate;
        string booknum;           // 청구기호
        string isbn;
        string selectedFilePath;  // 이미지파일 경로 
        byte[] imageBytes;        // 이미지파일 
        bool isDonated = false;   // 기증 여부
        string dninfo;            // 기증자정보 (기증자명, 기증기관명) 
        bool isUpdateTrue = false;
        #endregion

        public bookReg()
        {
            InitializeComponent();
        }


        public void UpdateRegForm(string data1, string data2, string data3, string data4, string data5, string data6, string data7)
        {
            isUpdateTrue = true;

            tbox_title.Text = data1;
            tbox_writer.Text = data2;
            tbox_publisher.Text = data3;
            tbox_pubdate.Text = data4;
            tbox_booknum.Text = data5;
            tbox_isbn.Text = data6;
            tbox_dninfo.Text = data7;

            if (tbox_dninfo.Text != "") rbtn_dn.Checked = true;
        }

        
        private void btn_search_Click(object sender, EventArgs e)   // 책사진 이미지 '찾아보기' 버튼 클릭 
        {
            OpenFileDialog fileDialog = new OpenFileDialog();  // OpenFileDialog : 파일열기창 
            
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            // show the dialog and check if ther user selected a file 
            if (fileDialog.ShowDialog() == DialogResult.OK)   // 파일 오픈창 로드하고 ok 버튼 클릭 시 
            {
                selectedFilePath = fileDialog.FileName;      // 파일 경로 가져오기 
            }

            imageBytes = File.ReadAllBytes(selectedFilePath);

            MemoryStream ms = new MemoryStream(imageBytes);   // MemoryStream : bridge 역할 (byte array ~ image 객체) 
            pbox_pic.Image = Image.FromStream(ms);            // pbox_pic에 책사진 뜨도록 
        }
     


        private void btn_reg_Click(object sender, EventArgs e)  // 등록 버튼 클릭 
        {
            if (!int.TryParse(tbox_isbn.Text, out int number))
            {
                MessageBox.Show("isbn 값으로 숫자를 입력하세요");
                tbox_isbn.Text = string.Empty;
                return;
            }

            title = tbox_title.Text;
            writer = tbox_writer.Text;
            publisher = tbox_publisher.Text;
            pubdate = tbox_pubdate.Text;
            booknum = tbox_booknum.Text;
            isbn = tbox_isbn.Text;



            if (rbtn_dn.Checked == true)   // 기증도서의 경우, isDonated 변수 true로 변경 
            {
                isDonated = true;
                dninfo = tbox_dninfo.Text;
            }

            if (isDonated == false && tbox_dninfo.Text != string.Empty)
            {
                MessageBox.Show("기증도서의 경우, 기증여부를 선택해주세요");
                return;
            }

            SqlParameter pdateParam = new SqlParameter("@pdate", SqlDbType.Date);
            pdateParam.Value = pubdate;

            List<SqlParameter> sqlParams = new List<SqlParameter>
            {
                    new SqlParameter("@isbn", isbn),
                    new SqlParameter("@booknum", booknum),
                    new SqlParameter("@title", title),
                    new SqlParameter("@writer", writer),
                    new SqlParameter("@publisher", publisher),
                    pdateParam
            };

            if (isUpdateTrue == true)
            {
                string qry;
                if (imageBytes == null)
                    qry = @"update tbl_book set isbn = @isbn, booknum = @booknum, title = @title, writer = @writer, publisher = @publisher, pdate = @pdate WHERE booknum = @booknum";
                else
                    qry = @"update tbl_book set isbn = @isbn, booknum = @booknum, title = @title, writer = @writer, publisher = @publisher, pdate = @pdate, pic = @pic, status=0 WHERE booknum = @booknum";

                

                if (imageBytes != null)
                {
                    SqlParameter picParam = new SqlParameter("@pic", SqlDbType.VarBinary);
                    picParam.Value = imageBytes;
                    sqlParams.Add(picParam);
                }

                conDb.sqlCmdParams(qry, sqlParams);
                conDb.DBClose();
                this.Close();
                ViewRefresh_book();
                return;
            };

            #region 이전소스
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    conn.Open();

            //    if (isUpdateTrue == true)
            //    {
            //        string qry; // = @"update tbl_book set isbn = @isbn, booknum = @booknum, title = @title, writer = @writer, publisher = @publisher, pdate = @pdate, pic = @pic WHERE booknum = @booknum";

            //        if (imageBytes == null)
            //            qry = @"update tbl_book set isbn = @isbn, booknum = @booknum, title = @title, writer = @writer, publisher = @publisher, pdate = @pdate WHERE booknum = @booknum";
            //        else
            //            qry = @"update tbl_book set isbn = @isbn, booknum = @booknum, title = @title, writer = @writer, publisher = @publisher, pdate = @pdate, pic = @pic, status=0 WHERE booknum = @booknum";

            //        using (SqlCommand command = new SqlCommand(qry_book, conn))
            //        {
            //            command.Parameters.AddWithValue("@isbn", isbn);
            //            command.Parameters.AddWithValue("@booknum", booknum);
            //            command.Parameters.AddWithValue("@title", title);
            //            command.Parameters.AddWithValue("@writer", writer);
            //            command.Parameters.AddWithValue("@publisher", publisher);
            //            command.Parameters.Add("@pdate", SqlDbType.Date).Value = pubdate;

            //            if (imageBytes != null)
            //                command.Parameters.Add("@pic", SqlDbType.VarBinary).Value = imageBytes;

            //            command.ExecuteNonQuery();

            //            this.Close();
            //            ViewRefresh_book();
            //            return;
            //        }
            //    }
            #endregion


            if (isDonated)   // 기증도서의 경우, 위 프로시저 실행 
            {
                #region insert_book_donate
                //CREATE PROCEDURE insert_book_donate
                //    @isbn bigint,
                //    @booknum varchar,
                //    @title varchar,
                //    @writer varchar,
                //    @publisher varchar,
                //    @pdate date,
                //    @pic varbinary,
                //    @donator varchar
                //AS
                //BEGIN
                //    INSERT INTO tbl_book(isbn, booknum, title, writer, publisher, pdate, pic, status)
                //    VALUES(@isbn, @booknum, @title, @writer, @publisher, @pdate, @pic, 0);

                //DECLARE @book_id int;
                //SET @book_id = SCOPE_IDENTITY();

                //INSERT INTO tbl_donate(book_id, donator)
                //    VALUES(@book_id, @donator);
                //END
                #endregion
                string qry = $@"exec insert_book_donate @isbn = {isbn}, @booknum = {booknum}, @title = {title}, @writer = {writer}, @publisher = {publisher}, @pdate = {pubdate}, @pic = {imageBytes}, @donator = {dninfo}";
                conDb.sqlExecuteReader(qry);   
                    

                //using (SqlCommand command = new SqlCommand("insert_book_donate", conn))
                //{
                //    command.CommandType = CommandType.StoredProcedure;

                //    command.Parameters.AddWithValue("@isbn", isbn);
                //    command.Parameters.AddWithValue("@booknum", booknum);
                //    command.Parameters.AddWithValue("@title", title);
                //    command.Parameters.AddWithValue("@writer", writer);
                //    command.Parameters.AddWithValue("@publisher", publisher);
                //    command.Parameters.Add("@pdate", SqlDbType.Date).Value = pubdate;
                //    command.Parameters.Add("@pic", SqlDbType.VarBinary).Value = imageBytes;
                //    command.Parameters.AddWithValue("@donator", dninfo);
                //    command.ExecuteNonQuery();
                //}
            }

            else
            {
                // status = 0 으로 삽입  
                string qry;
                if (imageBytes == null)
                    qry = "INSERT INTO tbl_book(isbn, booknum, title, writer, publisher, pdate, status) VALUES (@isbn, @booknum, @title, @writer, @publisher, @pdate, 0)";
                else
                    qry = "INSERT INTO tbl_book(isbn, booknum, title, writer, publisher, pdate, pic, status) VALUES (@isbn, @booknum, @title, @writer, @publisher, @pdate, @pic, 0)";
                    
                try
                {
                    conDb.sqlCmdParams(qry, sqlParams); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
            }

            this.Close();
            ViewRefresh_book();
            
        }

        private void btn_not_Click(object sender, EventArgs e)   // 취소버튼 클릭 
        {
            this.Close();
            ViewRefresh_book();
        }

        private void ViewRefresh_book()
        {
            bookMng bookForm = (bookMng)Application.OpenForms["book_management"];
            bookForm.ViewRefresh_book();
        }

       
    }
}
