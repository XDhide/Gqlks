namespace QLKS
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Button();
            tbLogin = new TextBox();
            tbPass = new TextBox();
            label1 = new Label();
            btExit = new Button();
            LBresige = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btLogin.Location = new Point(58, 333);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(138, 67);
            btLogin.TabIndex = 2;
            btLogin.Text = "Đăng Nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbLogin.Location = new Point(144, 114);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(294, 34);
            tbLogin.TabIndex = 0;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPass.Location = new Point(144, 170);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(294, 34);
            tbPass.TabIndex = 1;
            tbPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(32, 114);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 5;
            label1.Text = "Tài Khoản";
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btExit.Location = new Point(271, 333);
            btExit.Name = "btExit";
            btExit.Size = new Size(138, 67);
            btExit.TabIndex = 6;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // LBresige
            // 
            LBresige.AutoSize = true;
            LBresige.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LBresige.Location = new Point(296, 268);
            LBresige.Name = "LBresige";
            LBresige.Size = new Size(139, 28);
            LBresige.TabIndex = 7;
            LBresige.TabStop = true;
            LBresige.Text = "Tạo Tài Khoản";
            LBresige.LinkClicked += LBresige_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(33, 170);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 8;
            label2.Text = "Mật Khẩu";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(465, 558);
            ControlBox = false;
            Controls.Add(tbLogin);
            Controls.Add(label2);
            Controls.Add(LBresige);
            Controls.Add(tbPass);
            Controls.Add(btExit);
            Controls.Add(label1);
            Controls.Add(btLogin);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private TextBox tbLogin;
        private TextBox tbPass;
        private Label label1;
        private Button btExit;
        private LinkLabel LBresige;
        private Label label2;
    }
}
