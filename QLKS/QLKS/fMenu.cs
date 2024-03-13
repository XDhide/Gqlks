using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS

{
    public partial class fMenu : Form
    {
        SceenMenu SCmenu;
        public fMenu()
        {
            InitializeComponent();
            SCmenu = new SceenMenu();
            SCmenu.FormClosed += SCmenu_FormClosed;
            SCmenu.Dock = DockStyle.Fill;
            SCmenu.MdiParent = this;
            SCmenu.Show();
        }
        bool tfEXmenu = false;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExMenu_Click(object sender, EventArgs e)
        {
            tmMenuEx.Start();
        }

        private void tmMenuEx_Tick(object sender, EventArgs e)
        {
            if (tfEXmenu == false)
            {
                pnMenuBar.Width += 5;
                if (pnMenuBar.Width >= 300)
                {
                    tmMenuEx.Stop();
                    tfEXmenu = true;
                }
            }
            else
            {
                pnMenuBar.Width -= 5;
                if (pnMenuBar.Width <= 0)
                {
                    tmMenuEx.Stop();
                    tfEXmenu = false;
                }
            }
        }

        private void btComeHome_Click(object sender, EventArgs e)
        {
            if (SCmenu == null)
            {
                SCmenu = new SceenMenu();
                SCmenu.FormClosed += SCmenu_FormClosed;
                SCmenu.Dock = DockStyle.Fill;
                SCmenu.MdiParent = this;
                SCmenu.Show();
            }
        }

        private void SCmenu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            SCmenu = null;
        }
    }
}
