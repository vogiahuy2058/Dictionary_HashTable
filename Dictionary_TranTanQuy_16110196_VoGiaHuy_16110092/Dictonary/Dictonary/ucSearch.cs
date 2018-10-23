using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Trần Tấn Quý
namespace Dictonary
{
    public partial class ucSearch : UserControl
    {
        public BangBam BB;
        public ucSearch()
        {
            InitializeComponent();
            BB= new BangBam();
            LoadDataFile();
        }
        #region Load Data 
        
        int TotalLines(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                int i = 0;
                while (r.ReadLine() != null) { i++; }
                return i;
            }
        }
        public void LoadDataFile()
        {
            var file = new FileStream(@"E:\Words\input.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var sr = new StreamReader(file);

            string s;

            for (int i = 0; i < TotalLines(@"E:\Words\input.txt"); i++)
            {
                string name = null, meaning = null;
                s = sr.ReadLine();
                int j = 0;
                while (s[j] != '@')
                {
                    name += s[j];
                    j++;
                }
                j++;
                while (j < s.Length)
                {
                    meaning += s[j];
                    j++;
                }
                Word wd = new Word(name, meaning);


                BB.Add(wd);
            }
            file.Close();
            sr.Close();
        }
        #endregion
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
                bool check = BB.Search_Check(s1);
                if (check == true)//từ tồn tại
                {
                    lblWordHere.Text = s1;
                    lblMeaningHere.Text = BB.Search_Lookup(s1);
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
