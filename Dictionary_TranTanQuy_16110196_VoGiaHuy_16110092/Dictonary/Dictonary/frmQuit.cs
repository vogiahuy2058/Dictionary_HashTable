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
    public partial class frmQuit : Form
    {
        public frmQuit()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
