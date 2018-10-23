using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
//Trần Tấn Quý
namespace Dictonary
{
    public partial class ucAddWord : UserControl
    {
        public BangBam BB;
        public ucAddWord()
        {
            InitializeComponent();
            BB = new BangBam();
            LoadDataFile();
        }

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
        #region Võ Gia Huy
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            string s1 = txtWord.Text;
            string s2 = txtMeaning.Text;

            try
            {
                if (s1 == "" || s2 == "")
                    throw new Exception("You have to fill enough word");
                bool check = BB.Search_Check(s1);
                if (check == true)
                    MessageBox.Show("This word has been in this Dictionary", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                else
                {
                    string[] names = new string[] { txtWord.Text + "@" + txtMeaning.Text };
                    var file = new FileStream(@"E:\Words\input.txt",
                        FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        foreach (string s in names)
                        {
                            sw.WriteLine(s);
                        }
                    }
                    BangBam BB;
                    BB = new BangBam();
                    LoadDataFile();
                   
                    MessageBox.Show("This word has been added", "Congratulation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        
    }
}
