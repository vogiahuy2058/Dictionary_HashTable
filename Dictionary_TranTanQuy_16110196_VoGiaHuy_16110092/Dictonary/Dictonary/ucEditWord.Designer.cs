namespace Dictonary
{
    partial class ucEditWord
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.cbEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblEdit.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblEdit.ForeColor = System.Drawing.Color.Purple;
            this.lblEdit.Location = new System.Drawing.Point(178, 38);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(374, 46);
            this.lblEdit.TabIndex = 12;
            this.lblEdit.Text = "EDIT YOUR WORD";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Arial", 25F);
            this.lblWord.ForeColor = System.Drawing.Color.Purple;
            this.lblWord.Location = new System.Drawing.Point(18, 138);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(247, 39);
            this.lblWord.TabIndex = 39;
            this.lblWord.Text = "Choose a word:";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.BackColor = System.Drawing.Color.Transparent;
            this.lblMeaning.Font = new System.Drawing.Font("Arial", 25F);
            this.lblMeaning.ForeColor = System.Drawing.Color.Purple;
            this.lblMeaning.Location = new System.Drawing.Point(111, 291);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(154, 39);
            this.lblMeaning.TabIndex = 40;
            this.lblMeaning.Text = "Meaning:";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Arial", 20F);
            this.txtMeaning.Location = new System.Drawing.Point(282, 293);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(374, 38);
            this.txtMeaning.TabIndex = 41;
            // 
            // cbEdit
            // 
            this.cbEdit.DropDownHeight = 300;
            this.cbEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdit.DropDownWidth = 132;
            this.cbEdit.Font = new System.Drawing.Font("Arial", 20F);
            this.cbEdit.FormattingEnabled = true;
            this.cbEdit.IntegralHeight = false;
            this.cbEdit.Location = new System.Drawing.Point(282, 140);
            this.cbEdit.Name = "cbEdit";
            this.cbEdit.Size = new System.Drawing.Size(374, 40);
            this.cbEdit.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25F);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(94, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "New word:";
            // 
            // txtNewWord
            // 
            this.txtNewWord.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNewWord.Location = new System.Drawing.Point(282, 215);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(374, 38);
            this.txtNewWord.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Dictonary.Properties.Resources.close_24_purple;
            this.btnCancel.Location = new System.Drawing.Point(345, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 42);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnOK.FlatAppearance.BorderSize = 3;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnOK.ForeColor = System.Drawing.Color.Purple;
            this.btnOK.Image = global::Dictonary.Properties.Resources.tick_purple_24;
            this.btnOK.Location = new System.Drawing.Point(237, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 42);
            this.btnOK.TabIndex = 43;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseEnter += new System.EventHandler(this.btnOK_MouseEnter);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Dictonary.Properties.Resources.close_24_purple1;
            this.btnClose.Location = new System.Drawing.Point(621, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 27);
            this.btnClose.TabIndex = 47;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // ucEditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNewWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbEdit);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblEdit);
            this.Name = "ucEditWord";
            this.Size = new System.Drawing.Size(683, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.ComboBox cbEdit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.Button btnClose;
    }
}
