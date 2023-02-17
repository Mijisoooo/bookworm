using System.Drawing;
using System.Windows.Forms;

namespace 책벌레2
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgview_main = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.메인화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_reserv = new System.Windows.Forms.Button();
            this.mailSetNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_reserv_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_main)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailSetNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview_main
            // 
            this.dgview_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview_main.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgview_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgview_main.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgview_main.Location = new System.Drawing.Point(0, 83);
            this.dgview_main.Name = "dgview_main";
            this.dgview_main.ReadOnly = true;
            this.dgview_main.RowTemplate.Height = 23;
            this.dgview_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview_main.Size = new System.Drawing.Size(974, 778);
            this.dgview_main.TabIndex = 1;
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
            this.menu.TabIndex = 19;
            this.menu.Text = "menuStrip1";
            // 
            // 메인화면ToolStripMenuItem
            // 
            this.메인화면ToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.메인화면ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.메인화면ToolStripMenuItem.Name = "메인화면ToolStripMenuItem";
            this.메인화면ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.메인화면ToolStripMenuItem.Text = "메인화면";
            this.메인화면ToolStripMenuItem.Click += new System.EventHandler(this.메인화면ToolStripMenuItem_Click);
            // 
            // 회원관리ToolStripMenuItem
            // 
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
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.OldLace;
            this.searchbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbutton.Font = new System.Drawing.Font("[더존] 본문체 30", 9.749999F, System.Drawing.FontStyle.Bold);
            this.searchbutton.Location = new System.Drawing.Point(652, 41);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(60, 30);
            this.searchbutton.TabIndex = 28;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("[더존] 본문체 10", 12F);
            this.searchbox.Location = new System.Drawing.Point(198, 42);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(447, 28);
            this.searchbox.TabIndex = 29;
            this.searchbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbox_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("[더존] 본문체 30", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 27);
            this.comboBox1.TabIndex = 30;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.OldLace;
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("[더존] 본문체 30", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_return.Location = new System.Drawing.Point(1220, 42);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(73, 40);
            this.btn_return.TabIndex = 31;
            this.btn_return.Text = "반납";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_reserv
            // 
            this.btn_reserv.BackColor = System.Drawing.Color.OldLace;
            this.btn_reserv.FlatAppearance.BorderSize = 0;
            this.btn_reserv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reserv.Font = new System.Drawing.Font("[더존] 본문체 30", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_reserv.Location = new System.Drawing.Point(1293, 42);
            this.btn_reserv.Name = "btn_reserv";
            this.btn_reserv.Size = new System.Drawing.Size(73, 40);
            this.btn_reserv.TabIndex = 32;
            this.btn_reserv.Text = "예약";
            this.btn_reserv.UseVisualStyleBackColor = false;
            this.btn_reserv.Click += new System.EventHandler(this.btn_reserv_Click);
            // 
            // mailSetNum
            // 
            this.mailSetNum.Location = new System.Drawing.Point(1467, 73);
            this.mailSetNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.mailSetNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mailSetNum.Name = "mailSetNum";
            this.mailSetNum.Size = new System.Drawing.Size(46, 21);
            this.mailSetNum.TabIndex = 35;
            this.mailSetNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mailSetNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("[더존] 본문체 30", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1519, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "일 전";
            // 
            // btn_alarm
            // 
            this.btn_alarm.BackColor = System.Drawing.Color.OldLace;
            this.btn_alarm.FlatAppearance.BorderSize = 0;
            this.btn_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alarm.Font = new System.Drawing.Font("[더존] 본문체 30", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_alarm.Location = new System.Drawing.Point(1473, 100);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(77, 40);
            this.btn_alarm.TabIndex = 37;
            this.btn_alarm.Text = "메일전송";
            this.btn_alarm.UseVisualStyleBackColor = false;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_reserv_cancel
            // 
            this.btn_reserv_cancel.BackColor = System.Drawing.Color.OldLace;
            this.btn_reserv_cancel.FlatAppearance.BorderSize = 0;
            this.btn_reserv_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reserv_cancel.Font = new System.Drawing.Font("[더존] 본문체 30", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_reserv_cancel.Location = new System.Drawing.Point(1366, 42);
            this.btn_reserv_cancel.Name = "btn_reserv_cancel";
            this.btn_reserv_cancel.Size = new System.Drawing.Size(73, 40);
            this.btn_reserv_cancel.TabIndex = 46;
            this.btn_reserv_cancel.Text = "예약취소";
            this.btn_reserv_cancel.UseVisualStyleBackColor = false;
            this.btn_reserv_cancel.Click += new System.EventHandler(this.btn_reserv_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("[더존] 본문체 30", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1449, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "[ 만료일 알림 설정 ]";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btn_alarm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailSetNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_reserv_cancel);
            this.Controls.Add(this.btn_reserv);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dgview_main);
            this.Controls.Add(this.searchbox);
            this.Name = "mainForm";
            this.Text = "책벌레도서관";
            this.Activated += new System.EventHandler(this.main_Activated);
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_main)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailSetNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_main;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_reserv;
        private System.Windows.Forms.NumericUpDown mailSetNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_reserv_cancel;
        private System.Windows.Forms.ToolStripMenuItem 메인화면ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}