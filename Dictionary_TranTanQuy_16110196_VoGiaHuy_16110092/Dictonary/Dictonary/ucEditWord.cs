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
    public partial class ucEditWord : UserControl
    {
        public BangBam BB;
        public ucEditWord()
        {
            InitializeComponent();
            BB = new BangBam();
            LoadDataFile();
            AddComboBox(BB, cbEdit);
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
        #region Edit (VoGiaHuy)
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
        public static void AddComboBox(BangBam BB, ComboBox cbedit)
        {
            int n = 0;
            StreamReader sr = new StreamReader(@"E:\Words\input.txt");
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                n++;
            }

            Node p = new Node();
            for (int i = 0; i < n; i++)
            {
                p = BB.Table[i].Head;
                while (p != null)
                {
                    cbedit.Items.Add(p.word.Name);
                    p = p.pNext;
                }
            }
            sr.Close();
        }
        public void reset()
        {
            cbEdit.Items.Clear();
            LoadDataFile();
            AddComboBox(BB, cbEdit);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            BB = new BangBam();
            LoadDataFile();
            string s1 = cbEdit.Text;
            if (s1 == "")
            {
                s1 = "ccccc";
            }
            string s2 = txtNewWord.Text.Trim();
            if (s2 == "")
            {
                s2 = "aaaaa";
            }
            string s3 = txtMeaning.Text;
            if (s3 == "")
            {
                s3 = "bbbbb";
            }
            string s4 = s1 + "@" + BB.Search_Lookup(s1);
            string tempFile = Path.GetTempFileName();
            if (s1 == "ccccc" || s2 == "aaaaa" || s3 == "bbbbb")
                MessageBox.Show("Please type something!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            else
            {
                try
                {
                    bool check = BB.Search_Check(s1);
                    if (check == false)
                        MessageBox.Show("This word doesn't exist", "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    else
                    {
                        using (var sr1 = new StreamReader(@"E:\Words\input.txt"))
                        using (var sw2 = new StreamWriter(tempFile))
                        {
                            string line;
                            while ((line = sr1.ReadLine()) != null)
                            {
                                if (line != s4)
                                    sw2.WriteLine(line);
                            }
                            sr1.Close();
                            sw2.Close();
                        }
                        BB.RemoveWord(s1);
                        File.Delete(@"E:\Words\input.txt");
                        File.Move(tempFile, @"E:\Words\input.txt");
                        string[] names = new string[] { txtNewWord.Text.Trim() + "@" + txtMeaning.Text };
                        var file = new FileStream(@"E:\Words\input.txt",
                            FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                        using (StreamWriter sw1 = new StreamWriter(file))
                        {
                            foreach (string s in names)
                            {
                                sw1.WriteLine(s);
                            }
                            sw1.Close();
                        }
                        file.Close();
                        MessageBox.Show("Edited succesfully!", "Congratulations", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Word wd = new Word(s2, s3);
                        BB.Add(wd);
                        cbEdit.ResetText();
                        txtNewWord.ResetText();
                        txtMeaning.ResetText();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        #endregion
    }
}
