using System.Windows.Forms;

namespace 책벌레2
{
    internal class controlStripMenu
    {
        public void fn_operation(string formName, Form formInstance)  
        {
            mainForm mForm = new mainForm();
            bookMng bForm = new bookMng();
            userMng uForm = new userMng();

            
            switch (formName)
            {
                case "user_management":
                    foreach (Control control in formInstance.Controls) {control.Visible = false;}
                    uForm.TopLevel = false;
                    uForm.FormBorderStyle = FormBorderStyle.None;
                    uForm.Dock = DockStyle.Fill;
                    formInstance.Controls.Add(uForm);
                    mForm.Text = "회원관리 페이지";
                    uForm.Show();
                    uForm.Invalidate();
                    break;

                case "book_management":
                    foreach (Control control in formInstance.Controls) { control.Visible = false; } 
                    bForm.TopLevel = false;
                    bForm.FormBorderStyle = FormBorderStyle.None;
                    bForm.Dock = DockStyle.Fill;
                    formInstance.Controls.Add(bForm);
                    mForm.Text = "도서관리 페이지";
                    bForm.Show();
                    break;

                default:
                    foreach (Control control in formInstance.Controls) { control.Visible = false; }                    
                    mForm.TopLevel = false;
                    mForm.FormBorderStyle = FormBorderStyle.None;
                    mForm.Dock = DockStyle.Fill;
                    formInstance.Controls.Add(mForm);
                    mForm.Show();
                    break;
            }



        }
    }
}
