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
using System.Speech.Synthesis;
using System.Speech.Recognition;
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
            Loading();
            SpeakWord();
            pnlHistory.Visible = false;
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
        #region Design
        private void txtWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnFind.Focus();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            BB = new BangBam();
            LoadDataFile();
            string s1 = txtWord.Text.Trim();
            try
            {
                if (s1 == "") throw new Exception("Pleaes type something!");
                bool check = BB.Search_Check(s1);
                if (check == true)//từ tồn tại
                {
                    lblWordHere.Text = s1;
                    lblMeaningHere.Text = BB.Search_Lookup(s1);
                    cbHistoryWord.Items.Add(s1);
                }
                else
                {
                    cbHistoryWord.Items.Add(s1);
                    lblWordHere.Text = "This word doesn't exist!";
                    lblMeaningHere.Text = "Tu khong ton tai";
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAudio_MouseEnter(object sender, EventArgs e)
        {
            this.btnAudio.Image = ((System.Drawing.Image)(Properties.Resources.audo_white));

        }

        private void btnAudio_MouseLeave(object sender, EventArgs e)
        {
            this.btnAudio.Image = ((System.Drawing.Image)(Properties.Resources.audio_purple));

        }

        private void btnAudioM_MouseEnter(object sender, EventArgs e)
        {
            this.btnAudioM.Image = ((System.Drawing.Image)(Properties.Resources.audo_white));

        }

        private void btnAudioM_MouseLeave(object sender, EventArgs e)
        {
            this.btnAudioM.Image = ((System.Drawing.Image)(Properties.Resources.audio_purple));

        }
        #endregion
        #region speakword
        private void wbEn_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading1 = false;
            Loading();
        }

        private void wbVN_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading2 = false;
            Loading();
        }
        public void Loading()
        {
            this.Enabled = !(isLoading1 && isLoading2);
        }
        public void SpeakWord()
        {
            WebBrowser wbVN = new WebBrowser();
            wbVN.Width = 0;
            wbVN.Height = 0;
            wbVN.Visible = false;
            wbVN.ScriptErrorsSuppressed = true;
            wbVN.Navigate(Link.VietNamLink);
            wbVN.DocumentCompleted += wbVN_DocumentCompleted;
            this.Controls.Add(wbVN);
            VietNamese = new SpeakText(wbVN);
        }
        private SpeakText VietNamese;
        public bool isLoading1 = true;
        public bool isLoading2 = true;
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        private void btnAudio_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(lblWordHere.Text);
            sSynth.Speak(pBuilder);
        }

        private void btnAudioM_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblMeaningHere.Text == null)
                    throw new Exception("Dictionary can not speak");
                VietNamese.Spreak(lblMeaningHere.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void btnHistory_MouseEnter(object sender, EventArgs e)
        {
            this.btnHistory.Image = ((System.Drawing.Image)(Properties.Resources.history_24_white));

        }

        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            this.btnHistory.Image = ((System.Drawing.Image)(Properties.Resources.history_24_purple));

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if(pnlHistory.Visible ==true)
            {
                pnlHistory.Visible = false;
            }
            else
            {
                pnlHistory.Visible = true;
            }
        }
    }

}
