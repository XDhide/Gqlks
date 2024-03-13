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
    public partial class fRessige : Form
    {
        public fRessige()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBackforresige_Click(object sender, EventArgs e)
        {
            fLogin l = new fLogin();
            this.Close();
        }

        private void btNewacc_Click(object sender, EventArgs e)
        {
            if (tbAccount == null || tbPassword == null || tbRepass == null)
            {
                lbthbao.Text = "Bạn Chưa Nhập Đủ Thông Tin";
            }
            else
            {
                if (tbPassword != tbRepass)
                {
                    lbthbao.Text = "Mật Khẩu Không trùng nhau vui lòng nhập lại";
                }
            }
            
        }

        private void lbthbao_Click(object sender, EventArgs e)
        {

        }
    }
}
