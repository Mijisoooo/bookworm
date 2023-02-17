namespace 책벌레2
{
    partial class loginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.tboxId = new System.Windows.Forms.TextBox();
            this.labelPw = new System.Windows.Forms.Label();
            this.tboxPw = new System.Windows.Forms.TextBox();
            this.labelFindpw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("[더존] 본문체 30", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogin.Location = new System.Drawing.Point(218, 272);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 54);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("[더존] 본문체 30", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelid.Location = new System.Drawing.Point(111, 99);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(33, 23);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "ID";
            // 
            // tboxId
            // 
            this.tboxId.Font = new System.Drawing.Font("[더존] 본문체 30", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxId.Location = new System.Drawing.Point(240, 96);
            this.tboxId.Multiline = true;
            this.tboxId.Name = "tboxId";
            this.tboxId.Size = new System.Drawing.Size(203, 33);
            this.tboxId.TabIndex = 2;
            // 
            // labelPw
            // 
            this.labelPw.AutoSize = true;
            this.labelPw.Font = new System.Drawing.Font("[더존] 본문체 30", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPw.Location = new System.Drawing.Point(111, 173);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(102, 23);
            this.labelPw.TabIndex = 3;
            this.labelPw.Text = "Password";
            // 
            // tboxPw
            // 
            this.tboxPw.Font = new System.Drawing.Font("[더존] 본문체 30", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxPw.Location = new System.Drawing.Point(240, 169);
            this.tboxPw.Multiline = true;
            this.tboxPw.Name = "tboxPw";
            this.tboxPw.Size = new System.Drawing.Size(203, 33);
            this.tboxPw.TabIndex = 4;
            this.tboxPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxPw_KeyDown);
            // 
            // labelFindpw
            // 
            this.labelFindpw.AutoSize = true;
            this.labelFindpw.Font = new System.Drawing.Font("[더존] 본문체 30", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindpw.Location = new System.Drawing.Point(435, 19);
            this.labelFindpw.Name = "labelFindpw";
            this.labelFindpw.Size = new System.Drawing.Size(105, 19);
            this.labelFindpw.TabIndex = 5;
            this.labelFindpw.Text = "비밀번호 찾기";
            this.labelFindpw.Click += new System.EventHandler(this.labelFindpw_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 358);
            this.Controls.Add(this.labelFindpw);
            this.Controls.Add(this.tboxPw);
            this.Controls.Add(this.labelPw);
            this.Controls.Add(this.tboxId);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnLogin);
            this.Name = "loginForm";
            this.Text = "관리자 로그인 페이지";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox tboxId;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.TextBox tboxPw;
        private System.Windows.Forms.Label labelFindpw;
    }
}