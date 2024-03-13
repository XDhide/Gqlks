namespace QLKS
{
    partial class fRessige
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
            btNewacc = new Button();
            label1 = new Label();
            tbUse = new TextBox();
            tbAccount = new TextBox();
            tbPassword = new TextBox();
            tbRepass = new TextBox();
            btBackforresige = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbthbao = new Label();
            SuspendLayout();
            // 
            // btNewacc
            // 
            btNewacc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btNewacc.Location = new Point(46, 427);
            btNewacc.Name = "btNewacc";
            btNewacc.Size = new Size(133, 75);
            btNewacc.TabIndex = 0;
            btNewacc.Text = "Đăng Ký";
            btNewacc.UseVisualStyleBackColor = true;
            btNewacc.Click += btNewacc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Người Dùng";
            // 
            // tbUse
            // 
            tbUse.Location = new Point(171, 73);
            tbUse.Name = "tbUse";
            tbUse.Size = new Size(266, 27);
            tbUse.TabIndex = 2;
            // 
            // tbAccount
            // 
            tbAccount.Location = new Point(171, 149);
            tbAccount.Name = "tbAccount";
            tbAccount.Size = new Size(266, 27);
            tbAccount.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(171, 227);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(266, 27);
            tbPassword.TabIndex = 4;
            // 
            // tbRepass
            // 
            tbRepass.Location = new Point(171, 303);
            tbRepass.Name = "tbRepass";
            tbRepass.Size = new Size(266, 27);
            tbRepass.TabIndex = 5;
            tbRepass.UseSystemPasswordChar = true;
            tbRepass.TextChanged += textBox4_TextChanged;
            // 
            // btBackforresige
            // 
            btBackforresige.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btBackforresige.Location = new Point(286, 427);
            btBackforresige.Name = "btBackforresige";
            btBackforresige.Size = new Size(133, 75);
            btBackforresige.TabIndex = 7;
            btBackforresige.Text = "Quay Lại";
            btBackforresige.UseVisualStyleBackColor = true;
            btBackforresige.Click += btBackforresige_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(30, 156);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên Đăng Nhập ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(30, 230);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 9;
            label3.Text = "Mật Khẩu         ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(30, 310);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 10;
            label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // lbthbao
            // 
            lbthbao.AutoSize = true;
            lbthbao.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbthbao.ForeColor = Color.Red;
            lbthbao.Location = new Point(46, 364);
            lbthbao.Name = "lbthbao";
            lbthbao.Size = new Size(0, 25);
            lbthbao.TabIndex = 11;
            lbthbao.Click += lbthbao_Click;
            // 
            // fRessige
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(446, 617);
            ControlBox = false;
            Controls.Add(lbthbao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btBackforresige);
            Controls.Add(tbRepass);
            Controls.Add(tbPassword);
            Controls.Add(tbAccount);
            Controls.Add(tbUse);
            Controls.Add(label1);
            Controls.Add(btNewacc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "fRessige";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fRessige";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNewacc;
        private Label label1;
        private TextBox tbUse;
        private TextBox tbAccount;
        private TextBox tbPassword;
        private TextBox tbRepass;
        private Button btBackforresige;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbthbao;
    }
}