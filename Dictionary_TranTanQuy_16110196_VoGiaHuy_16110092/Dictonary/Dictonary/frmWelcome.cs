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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            this.Hide();
            frm.Show();
        }
        private void frmWelcome_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Hide();
            Form frm = new frmMain();
            frm.Show();
        }
        private void btnStart_Enter(object sender, EventArgs e)
        {
            //this.btnStart.BackgroundImage = ((System.Drawing.Image)
            //    (Properties.Resources.Sign_in_bg));
        }

        private void btnStart_Leave(object sender, EventArgs e)
        {
            this.btnStart.BackColor = System.Drawing.Color.Black;

        }
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = ((System.Drawing.Image)
                (Properties.Resources.background_1));
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = null;

        }
    }
}
