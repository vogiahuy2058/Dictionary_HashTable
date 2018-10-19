namespace Dictonary
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSlideMenu = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClose.Image = global::Dictonary.Properties.Resources.close_24_white;
            this.btnClose.Location = new System.Drawing.Point(708, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 27);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnInfo.Image = global::Dictonary.Properties.Resources.icons8_about_filled_24;
            this.btnInfo.Location = new System.Drawing.Point(643, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(62, 27);
            this.btnInfo.TabIndex = 14;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnDelete);
            this.pnlMenu.Controls.Add(this.btnEdit);
            this.pnlMenu.Controls.Add(this.btnAdd);
            this.pnlMenu.Controls.Add(this.btnSlideMenu);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(43, 508);
            this.pnlMenu.TabIndex = 15;
            this.pnlMenu.Leave += new System.EventHandler(this.pnlMenu_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Image = global::Dictonary.Properties.Resources.Find_24;
            this.btnSearch.Location = new System.Drawing.Point(-258, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(559, 55);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "                                         Search a word";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = global::Dictonary.Properties.Resources.delete_24;
            this.btnDelete.Location = new System.Drawing.Point(-258, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(559, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "                                    Edit a word";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Image = global::Dictonary.Properties.Resources.edit_24;
            this.btnEdit.Location = new System.Drawing.Point(-258, 282);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(559, 55);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "                                    Edit a word";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Image = global::Dictonary.Properties.Resources.add_24_white;
            this.btnAdd.Location = new System.Drawing.Point(-258, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(559, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "                                     Add a word";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSlideMenu
            // 
            this.btnSlideMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSlideMenu.FlatAppearance.BorderSize = 0;
            this.btnSlideMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnSlideMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSlideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideMenu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnSlideMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSlideMenu.Image = global::Dictonary.Properties.Resources.icons8_menu_24;
            this.btnSlideMenu.Location = new System.Drawing.Point(-258, 0);
            this.btnSlideMenu.Name = "btnSlideMenu";
            this.btnSlideMenu.Size = new System.Drawing.Size(559, 55);
            this.btnSlideMenu.TabIndex = 1;
            this.btnSlideMenu.Text = "                         Start";
            this.btnSlideMenu.UseVisualStyleBackColor = false;
            this.btnSlideMenu.Click += new System.EventHandler(this.btnSlideMenu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::Dictonary.Properties.Resources._32752012_374348339639748_8966757361645518848_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 508);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSlideMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}