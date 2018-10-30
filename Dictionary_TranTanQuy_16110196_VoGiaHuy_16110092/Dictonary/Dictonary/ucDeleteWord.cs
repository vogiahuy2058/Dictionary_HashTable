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
    public partial class ucDeleteWord : UserControl
    {
        public BangBam BB;

        public ucDeleteWord()
        {
            InitializeComponent();
            
            BB = new BangBam();
            LoadDataFile();
            AddComboBox(BB, cbDelete);
            
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
        public static void AddComboBox(BangBam BB, ComboBox cbdelete)
        {
            int n = 0;
            StreamReader sr = new StreamReader(@"E:\Words\input.txt");
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                n++;
            }
            sr.Close();
            Node p = new Node();
            for (int i = 0; i < n; i++)
            {
                p = BB.Table[i].Head;
                while (p != null)
                {
                    cbdelete.Items.Add(p.word.Name);
                    p = p.pNext;
                }
            }
        }

        private void cbDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDelete.Text != null)
            {
                txtMeaning.Enabled = false;
                lblType.Enabled = false;
                lblOr.Enabled = false;
            }
            

        }

        private void txtMeaning_TextChanged(object sender, EventArgs e)
        {
            if (txtMeaning != null)
            {
                cbDelete.Enabled = false;
                lblChoose.Enabled = false;
                lblOr.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BB = new BangBam();
            LoadDataFile();
            string s1 = txtMeaning.Text;
            if (s1 == "")
            {
                s1 = "zzzzz";
            }
            string s3 = cbDelete.Text;
            if (s3 == "")
            {
                s3 = "cccccc";
            }
            string s2 = s1 + "@" + BB.Search_Lookup(s1);
            string s4 = s3 + "@" + BB.Search_Lookup(s3);
            string tempFile = Path.GetTempFileName();
            //if (s1 == "zzzzz" && s3 =="cccccc")
            //{
            //    MessageBox.Show("you have to fill enough word", "Error", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //}
            if (s3 == "cccccc")
            {

                if (s1 == "zzzzz")
                {
                    MessageBox.Show("you have to fill enough word", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {


                        bool check = BB.Search_Check(s1);
                        if (check == false)
                            MessageBox.Show("This word has not been in this Dictionary", "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        else
                        {
                            using (var sr2 = new StreamReader(@"E:\Words\input.txt"))
                            using (var sw3 = new StreamWriter(tempFile))
                            {
                                string line;

                                while ((line = sr2.ReadLine()) != null)
                                {
                                    if (line != s2)
                                        sw3.WriteLine(line);
                                }
                                sr2.Close();
                                sw3.Close();
                            }
                            File.Delete(@"E:\Words\input.txt");
                            File.Move(tempFile, @"E:\Words\input.txt");

                            MessageBox.Show("This word has been delete", "Congratulation", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            BB.RemoveWord(s1);
                            cbDelete.ResetText();
                            txtMeaning.ResetText();
                        }
                    }

                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (s1 == "zzzzz")
            {
                //if (s3 == "cccccc")
                //{
                //    MessageBox.Show("you have to fill enough word", "Error", MessageBoxButtons.OK,
                //                MessageBoxIcon.Error);
                //}
                //else
                //{
                try
                {
                    bool check = BB.Search_Check(s3);
                    if (check == false)
                        MessageBox.Show("This word has not been in this Dictionary", "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    else
                    {
                        using (var sr = new StreamReader(@"E:\Words\input.txt"))
                        using (var sw = new StreamWriter(tempFile))
                        {
                            string line;

                            while ((line = sr.ReadLine()) != null)
                            {
                                if (line != s4)
                                    sw.WriteLine(line);
                            }
                            sr.Close();
                            sw.Close();
                        }
                        File.Delete(@"E:\Words\input.txt");
                        File.Move(tempFile, @"E:\Words\input.txt");

                        MessageBox.Show("This word has been delete", "Congratulation", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BB.RemoveWord(s3);
                        cbDelete.ResetText();
                        txtMeaning.ResetText();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
            cbDelete.Items.Clear();
            AddComboBox(BB, cbDelete);
        }

        private void cbDelete_Click(object sender, EventArgs e)
        {
            LoadDataFile();

            AddComboBox(BB, cbDelete);
        }
    }
}
