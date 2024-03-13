namespace QLKS
{
    partial class fMenu
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
            components = new System.ComponentModel.Container();
            pnMenuBar = new Panel();
            btComeHome = new Button();
            panel1 = new Panel();
            ExMenu = new PictureBox();
            tmMenuEx = new System.Windows.Forms.Timer(components);
            pnMenuBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExMenu).BeginInit();
            SuspendLayout();
            // 
            // pnMenuBar
            // 
            pnMenuBar.BackColor = SystemColors.ButtonShadow;
            pnMenuBar.Controls.Add(btComeHome);
            pnMenuBar.Dock = DockStyle.Left;
            pnMenuBar.ForeColor = SystemColors.ActiveCaptionText;
            pnMenuBar.Location = new Point(0, 56);
            pnMenuBar.Name = "pnMenuBar";
            pnMenuBar.Size = new Size(0, 847);
            pnMenuBar.TabIndex = 1;
            // 
            // btComeHome
            // 
            btComeHome.BackgroundImage = Properties.Resources.Home;
            btComeHome.BackgroundImageLayout = ImageLayout.None;
            btComeHome.FlatStyle = FlatStyle.Flat;
            btComeHome.Font = new Font("Century", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btComeHome.ImageAlign = ContentAlignment.MiddleLeft;
            btComeHome.Location = new Point(0, 59);
            btComeHome.Name = "btComeHome";
            btComeHome.Size = new Size(300, 67);
            btComeHome.TabIndex = 3;
            btComeHome.Text = "Home";
            btComeHome.UseVisualStyleBackColor = true;
            btComeHome.Click += btComeHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(ExMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1682, 56);
            panel1.TabIndex = 0;
            // 
            // ExMenu
            // 
            ExMenu.Image = Properties.Resources.Menu;
            ExMenu.Location = new Point(0, -2);
            ExMenu.Name = "ExMenu";
            ExMenu.Size = new Size(68, 58);
            ExMenu.TabIndex = 2;
            ExMenu.TabStop = false;
            ExMenu.Click += ExMenu_Click;
            // 
            // tmMenuEx
            // 
            tmMenuEx.Interval = 10;
            tmMenuEx.Tick += tmMenuEx_Tick;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 903);
            ControlBox = false;
            Controls.Add(pnMenuBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "fMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fMenu";
            pnMenuBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnMenuBar;
        private Panel panel1;
        private PictureBox ExMenu;
        private System.Windows.Forms.Timer tmMenuEx;
        private Button btComeHome;
    }
}