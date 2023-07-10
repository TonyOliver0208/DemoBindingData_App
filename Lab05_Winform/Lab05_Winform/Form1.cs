using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void mnuTracuu_Click(object sender, EventArgs e)
        {
            frmTracuu frmTracuu = new frmTracuu();
            frmTracuu.Text = "Tra cứu";
            frmTracuu.MdiParent = this;
            frmTracuu.Show();
        }

        private void mnuNhap_Click(object sender, EventArgs e)
        {
            frmNhap frmNhap = new frmNhap();
            frmNhap.Text = "Nhập thông tin";
            frmNhap.MdiParent = this;   
            frmNhap.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
