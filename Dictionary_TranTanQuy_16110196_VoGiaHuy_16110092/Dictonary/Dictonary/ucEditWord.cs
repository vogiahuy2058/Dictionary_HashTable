using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Trần Tấn Quý
namespace Dictonary
{
    public partial class ucEditWord : UserControl
    {
        public ucEditWord()
        {
            InitializeComponent();
        }
        #region Design
        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            this.btnOK.Image = ((System.Drawing.Image)(Properties.Resources.icons8_checkmark_24));

        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            this.btnOK.Image = ((System.Drawing.Image)(Properties.Resources.tick_purple_24));

        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            this.btnCancel.Image = ((System.Drawing.Image)(Properties.Resources.close_24_white));

        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancel.Image = ((System.Drawing.Image)(Properties.Resources.close_24_purple));

        }


        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = ((System.Drawing.Image)(Properties.Resources.close_24_white));
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = ((System.Drawing.Image)(Properties.Resources.close_24_purple));

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        #endregion


    }
}
