using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictonary
{
    public partial class frmNoti : Form
    {
        public frmNoti()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new frmWelcome();
            frm.ShowDialog();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form frm = (frmMain)this.Owner;
            frm.Show();
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.ForeColor = System.Drawing.Color.Purple;

        }

        private void btnYes_MouseEnter(object sender, EventArgs e)
        {
            btnYes.ForeColor = System.Drawing.Color.WhiteSmoke;

        }
    }
}
