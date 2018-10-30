namespace Dictonary
{
    partial class ucDeleteWord
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
            this.cbDelete = new System.Windows.Forms.ComboBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.lblOr = new System.Windows.Forms.Label();
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
            this.lblEdit.Location = new System.Drawing.Point(125, 38);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(442, 46);
            this.lblEdit.TabIndex = 13;
            this.lblEdit.Text = "DELETE YOUR WORD";
            // 
            // cbDelete
            // 
            this.cbDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDelete.DropDownHeight = 300;
            this.cbDelete.DropDownWidth = 132;
            this.cbDelete.Font = new System.Drawing.Font("Arial", 20F);
            this.cbDelete.FormattingEnabled = true;
            this.cbDelete.IntegralHeight = false;
            this.cbDelete.Location = new System.Drawing.Point(273, 133);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(374, 40);
            this.cbDelete.TabIndex = 44;
            this.cbDelete.SelectedIndexChanged += new System.EventHandler(this.cbDelete_SelectedIndexChanged);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.Transparent;
            this.lblChoose.Font = new System.Drawing.Font("Arial", 25F);
            this.lblChoose.ForeColor = System.Drawing.Color.Purple;
            this.lblChoose.Location = new System.Drawing.Point(21, 131);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(247, 39);
            this.lblChoose.TabIndex = 43;
            this.lblChoose.Text = "Choose a word:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Arial", 25F);
            this.lblType.ForeColor = System.Drawing.Color.Purple;
            this.lblType.Location = new System.Drawing.Point(64, 271);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(204, 39);
            this.lblType.TabIndex = 45;
            this.lblType.Text = "Type a word:";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Arial", 20F);
            this.txtMeaning.Location = new System.Drawing.Point(273, 273);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(374, 38);
            this.txtMeaning.TabIndex = 46;
            this.txtMeaning.TextChanged += new System.EventHandler(this.txtMeaning_TextChanged);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.BackColor = System.Drawing.Color.Transparent;
            this.lblOr.Font = new System.Drawing.Font("Arial", 25F);
            this.lblOr.ForeColor = System.Drawing.Color.Purple;
            this.lblOr.Location = new System.Drawing.Point(149, 203);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(46, 39);
            this.lblOr.TabIndex = 47;
            this.lblOr.Text = "or";
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
            this.btnCancel.TabIndex = 49;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnOK.TabIndex = 48;
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
            this.btnClose.TabIndex = 50;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // ucDeleteWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblEdit);
            this.Name = "ucDeleteWord";
            this.Size = new System.Drawing.Size(683, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.ComboBox cbDelete;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
    }
}
