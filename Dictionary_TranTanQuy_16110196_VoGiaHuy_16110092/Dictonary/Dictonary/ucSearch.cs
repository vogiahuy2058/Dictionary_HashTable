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
    public partial class ucSearch : UserControl
    {
        private frmMain _Main;
        public ucSearch(Form Main)
        {
            _Main = (frmMain)Main;
            InitializeComponent();
           

        }

        private void txtWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string s1 = txtWord.Text;
            try
            {
                if (s1 == "") throw new Exception("Pleaes type something!");
                bool check = _Main.BB.Search_Check(s1);
                if (check == true)//từ tồn tại
                {
                    lblWordHere.Text = s1;
                    lblMeaningHere.Text = _Main.BB.Search_Lookup(s1);
                }
                else
                {
                    lblWordHere.Text = "This word doesn't exist";
                    lblMeaningHere.Text = "Tu khong ton tai";
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = ((System.Drawing.Image)(Properties.Resources.close_24_white));
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = ((System.Drawing.Image)(Properties.Resources.close_24_purple));

        }

       
    }
}
