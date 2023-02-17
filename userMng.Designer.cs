using System.Drawing;
using System.Windows.Forms;

namespace 책벌레2
{
    partial class userMng
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgview_user = new System.Windows.Forms.DataGridView();
            this.testDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.메인화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_cust_detail = new System.Windows.Forms.Panel();
            this.btnAuth = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_remark = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone2 = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dgview_reserve = new System.Windows.Forms.DataGridView();
            this.dgview_rental = new System.Windows.Forms.DataGridView();
            this.btnDisabled = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_custid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegAccount = new System.Windows.Forms.Button();
            this.btnMngAuth = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSetBindingSource)).BeginInit();
            this.menu.SuspendLayout();
            this.panel_cust_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_reserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_rental)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview_user
            // 
            this.dgview_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview_user.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgview_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgview_user.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgview_user.Location = new System.Drawing.Point(0, 83);
            this.dgview_user.MultiSelect = false;
            this.dgview_user.Name = "dgview_user";
            this.dgview_user.ReadOnly = true;
            this.dgview_user.RowTemplate.Height = 23;
            this.dgview_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview_user.Size = new System.Drawing.Size(1015, 778);
            this.dgview_user.TabIndex = 0;
            this.dgview_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_user_CellClick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Navy;
            this.menu.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인화면ToolStripMenuItem,
            this.회원관리ToolStripMenuItem,
            this.도서관리ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1584, 29);
            this.menu.TabIndex = 18;
            this.menu.Text = "menuStrip1";
            // 
            // 메인화면ToolStripMenuItem
            // 
            this.메인화면ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.메인화면ToolStripMenuItem.Name = "메인화면ToolStripMenuItem";
            this.메인화면ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.메인화면ToolStripMenuItem.Text = "메인화면";
            this.메인화면ToolStripMenuItem.Click += new System.EventHandler(this.메인화면ToolStripMenuItem_Click);
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.회원관리ToolStripMenuItem.CheckOnClick = true;
            this.회원관리ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.회원관리ToolStripMenuItem.Text = "회원관리";
            this.회원관리ToolStripMenuItem.Click += new System.EventHandler(this.회원관리ToolStripMenuItem_Click);
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.CheckOnClick = true;
            this.도서관리ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.도서관리ToolStripMenuItem.Text = "도서관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // panel_cust_detail
            // 
            this.panel_cust_detail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_cust_detail.Controls.Add(this.btnAuth);
            this.panel_cust_detail.Controls.Add(this.label7);
            this.panel_cust_detail.Controls.Add(this.tb_remark);
            this.panel_cust_detail.Controls.Add(this.tb_address);
            this.panel_cust_detail.Controls.Add(this.tb_email);
            this.panel_cust_detail.Controls.Add(this.tb_phone2);
            this.panel_cust_detail.Controls.Add(this.tb_phone);
            this.panel_cust_detail.Controls.Add(this.tb_name);
            this.panel_cust_detail.Controls.Add(this.dgview_reserve);
            this.panel_cust_detail.Controls.Add(this.dgview_rental);
            this.panel_cust_detail.Controls.Add(this.btnDisabled);
            this.panel_cust_detail.Controls.Add(this.btnEdit);
            this.panel_cust_detail.Controls.Add(this.label5);
            this.panel_cust_detail.Controls.Add(this.label2);
            this.panel_cust_detail.Controls.Add(this.label10);
            this.panel_cust_detail.Controls.Add(this.label3);
            this.panel_cust_detail.Controls.Add(this.label8);
            this.panel_cust_detail.Controls.Add(this.label6);
            this.panel_cust_detail.Controls.Add(this.label4);
            this.panel_cust_detail.Controls.Add(this.lbl_custid);
            this.panel_cust_detail.Controls.Add(this.label1);
            this.panel_cust_detail.Location = new System.Drawing.Point(1021, 83);
            this.panel_cust_detail.Name = "panel_cust_detail";
            this.panel_cust_detail.Size = new System.Drawing.Size(563, 778);
            this.panel_cust_detail.TabIndex = 23;
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.OldLace;
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAuth.Location = new System.Drawing.Point(335, 0);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(73, 40);
            this.btnAuth.TabIndex = 26;
            this.btnAuth.Text = "승인";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label7.Location = new System.Drawing.Point(13, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "기타";
            // 
            // tb_remark
            // 
            this.tb_remark.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tb_remark.Location = new System.Drawing.Point(96, 276);
            this.tb_remark.Multiline = true;
            this.tb_remark.Name = "tb_remark";
            this.tb_remark.Size = new System.Drawing.Size(203, 73);
            this.tb_remark.TabIndex = 33;
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tb_address.Location = new System.Drawing.Point(96, 242);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(203, 21);
            this.tb_address.TabIndex = 32;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tb_email.Location = new System.Drawing.Point(96, 209);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(203, 21);
            this.tb_email.TabIndex = 31;
            // 
            // tb_phone2
            // 
            this.tb_phone2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_phone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tb_phone2.Location = new System.Drawing.Point(96, 178);
            this.tb_phone2.Name = "tb_phone2";
            this.tb_phone2.Size = new System.Drawing.Size(203, 21);
            this.tb_phone2.TabIndex = 30;
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tb_phone.Location = new System.Drawing.Point(96, 146);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(203, 21);
            this.tb_phone.TabIndex = 29;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tb_name.Location = new System.Drawing.Point(96, 116);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(90, 21);
            this.tb_name.TabIndex = 28;
            this.tb_name.Text = "김이박";
            // 
            // dgview_reserve
            // 
            this.dgview_reserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview_reserve.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview_reserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgview_reserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgview_reserve.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgview_reserve.Location = new System.Drawing.Point(16, 615);
            this.dgview_reserve.Name = "dgview_reserve";
            this.dgview_reserve.RowTemplate.Height = 23;
            this.dgview_reserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview_reserve.Size = new System.Drawing.Size(535, 151);
            this.dgview_reserve.TabIndex = 27;
            // 
            // dgview_rental
            // 
            this.dgview_rental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview_rental.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview_rental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgview_rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgview_rental.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgview_rental.Location = new System.Drawing.Point(15, 379);
            this.dgview_rental.Name = "dgview_rental";
            this.dgview_rental.RowTemplate.Height = 23;
            this.dgview_rental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview_rental.Size = new System.Drawing.Size(536, 202);
            this.dgview_rental.TabIndex = 25;
            // 
            // btnDisabled
            // 
            this.btnDisabled.BackColor = System.Drawing.Color.OldLace;
            this.btnDisabled.FlatAppearance.BorderSize = 0;
            this.btnDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDisabled.Location = new System.Drawing.Point(481, 0);
            this.btnDisabled.Name = "btnDisabled";
            this.btnDisabled.Size = new System.Drawing.Size(73, 40);
            this.btnDisabled.TabIndex = 17;
            this.btnDisabled.Text = "비활성화";
            this.btnDisabled.UseVisualStyleBackColor = false;
            this.btnDisabled.Click += new System.EventHandler(this.btnDisabled_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.OldLace;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.Location = new System.Drawing.Point(408, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 40);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "정보수정";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "예약목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label2.Location = new System.Drawing.Point(13, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "대출이력";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label10.Location = new System.Drawing.Point(13, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label3.Location = new System.Drawing.Point(13, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "이메일";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label8.Location = new System.Drawing.Point(13, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "비상연락망";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "연락처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "이름";
            // 
            // lbl_custid
            // 
            this.lbl_custid.AutoSize = true;
            this.lbl_custid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.lbl_custid.Location = new System.Drawing.Point(100, 89);
            this.lbl_custid.Name = "lbl_custid";
            this.lbl_custid.Size = new System.Drawing.Size(14, 15);
            this.lbl_custid.TabIndex = 1;
            this.lbl_custid.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원번호";
            // 
            // btnRegAccount
            // 
            this.btnRegAccount.BackColor = System.Drawing.Color.OldLace;
            this.btnRegAccount.FlatAppearance.BorderSize = 0;
            this.btnRegAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegAccount.Location = new System.Drawing.Point(1429, 43);
            this.btnRegAccount.Name = "btnRegAccount";
            this.btnRegAccount.Size = new System.Drawing.Size(73, 40);
            this.btnRegAccount.TabIndex = 24;
            this.btnRegAccount.Text = "신규회원 등록";
            this.btnRegAccount.UseVisualStyleBackColor = false;
            this.btnRegAccount.Click += new System.EventHandler(this.btnRegAccount_Click);
            // 
            // btnMngAuth
            // 
            this.btnMngAuth.BackColor = System.Drawing.Color.OldLace;
            this.btnMngAuth.FlatAppearance.BorderSize = 0;
            this.btnMngAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMngAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMngAuth.Location = new System.Drawing.Point(1502, 43);
            this.btnMngAuth.Name = "btnMngAuth";
            this.btnMngAuth.Size = new System.Drawing.Size(73, 40);
            this.btnMngAuth.TabIndex = 25;
            this.btnMngAuth.Text = "미승인회원 관리";
            this.btnMngAuth.UseVisualStyleBackColor = false;
            this.btnMngAuth.Click += new System.EventHandler(this.btnMngAuth_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.OldLace;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.searchbutton.Location = new System.Drawing.Point(652, 41);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(60, 30);
            this.searchbutton.TabIndex = 26;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchbox.Location = new System.Drawing.Point(198, 42);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(447, 28);
            this.searchbox.TabIndex = 27;
            this.searchbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbox_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 28);
            this.comboBox1.TabIndex = 31;
            // 
            // userMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.btnMngAuth);
            this.Controls.Add(this.btnRegAccount);
            this.Controls.Add(this.panel_cust_detail);
            this.Controls.Add(this.dgview_user);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.searchbox);
            this.MainMenuStrip = this.menu;
            this.Name = "userMng";
            this.Text = "회원관리";
            this.Load += new System.EventHandler(this.user_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSetBindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel_cust_detail.ResumeLayout(false);
            this.panel_cust_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_reserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_rental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_user;
        private System.Windows.Forms.BindingSource testDBDataSetBindingSource;
        //private testDBDataSet testDBDataSet;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_cust_detail;
        private System.Windows.Forms.Button btnDisabled;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_custid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgview_reserve;
        private System.Windows.Forms.DataGridView dgview_rental;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone2;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btnRegAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_remark;
        private System.Windows.Forms.Button btnMngAuth;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem 메인화면ToolStripMenuItem;
    }
}

