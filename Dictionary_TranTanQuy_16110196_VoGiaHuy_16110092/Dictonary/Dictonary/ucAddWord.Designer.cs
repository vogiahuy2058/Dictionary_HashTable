namespace Dictonary
{
    partial class ucAddWord
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblAdd.ForeColor = System.Drawing.Color.Purple;
            this.lblAdd.Location = new System.Drawing.Point(171, 38);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(369, 46);
            this.lblAdd.TabIndex = 11;
            this.lblAdd.Text = "ADD YOUR WORD";
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Arial", 20F);
            this.txtWord.Location = new System.Drawing.Point(267, 168);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(374, 38);
            this.txtWord.TabIndex = 23;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Arial", 25F);
            this.lblWord.ForeColor = System.Drawing.Color.Purple;
            this.lblWord.Location = new System.Drawing.Point(29, 167);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(204, 39);
            this.lblWord.TabIndex = 38;
            this.lblWord.Text = "Type a word:";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.BackColor = System.Drawing.Color.Transparent;
            this.lblMeaning.Font = new System.Drawing.Font("Arial", 25F);
            this.lblMeaning.ForeColor = System.Drawing.Color.Purple;
            this.lblMeaning.Location = new System.Drawing.Point(79, 270);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(154, 39);
            this.lblMeaning.TabIndex = 39;
            this.lblMeaning.Text = "Meaning:";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Arial", 20F);
            this.txtMeaning.Location = new System.Drawing.Point(267, 272);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(374, 38);
            this.txtMeaning.TabIndex = 40;
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
            this.btnCancel.TabIndex = 42;
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
            this.btnOK.TabIndex = 41;
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
            this.btnClose.TabIndex = 46;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // ucAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblAdd);
            this.Name = "ucAddWord";
            this.Size = new System.Drawing.Size(683, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}
