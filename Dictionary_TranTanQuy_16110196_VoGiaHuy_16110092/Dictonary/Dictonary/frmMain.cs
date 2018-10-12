using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Trần Tấn Quý
namespace Dictonary
{
    public partial class frmMain : Form
    {
        #region Menu designed by Trần Tấn Quý
        ucAddWord ucAdd = new ucAddWord();
        ucEditWord ucEdit = new ucEditWord();
        ucDeleteWord ucDelete = new ucDeleteWord();
        public frmMain()
        {
            InitializeComponent();
            ucAdd.Visible = false;
            ucEdit.Visible = false;
            ucDelete.Visible = false;


        }
        
        protected override CreateParams CreateParams
        {
            //hàm tối ưu tốc độ load (source: Internet)
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            pnlMenu.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSlideMenu_Click(object sender, EventArgs e)
        {
            //thay đổi kích cỡ của pnlMenu
            if (pnlMenu.Height == 508 && pnlMenu.Width == 43)
            {
                pnlMenu.Height = 508;
                pnlMenu.Width = 264;

                pnlMenu.BackColor = System.Drawing.Color.Black;
            }
            else
            {
                pnlMenu.Height = 508;
                pnlMenu.Width = 43;

                pnlMenu.BackColor = System.Drawing.Color.Transparent;
            }
        }
        //điều chỉnh màu nền (background), kích cỡ của Slide Menu

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlMenu.Height == 508 && pnlMenu.Width == 264)
            {
                pnlMenu.Height =508;
                pnlMenu.Width = 43;
                pnlMenu.BackColor = System.Drawing.Color.Transparent;
            }
        }
        //tự động ẩn Slide menu khi sử dụng chức năng khác không thuộc trên Menu
        private void pnlMenu_Leave(object sender, EventArgs e)
        {
            if (pnlMenu.Height == 508 && pnlMenu.Width == 264)
            {
                pnlMenu.Height = 508;
                pnlMenu.Width = 43;

                pnlMenu.BackColor = System.Drawing.Color.Transparent;
            }
        }
        public void HighlightButton()
        {
            //hàm con trỏ, được sử dụng cho các usercontrol
            btnAdd.BackColor = System.Drawing.Color.Transparent;
            btnEdit.BackColor = System.Drawing.Color.Transparent;
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucAdd);
            ucAdd.Location = new Point(65, 46);
            // ẩn/hiện user control khách
            if (ucAdd.Visible == true)
            {
                ucAdd.Visible = false;
                btnAdd.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                ucAdd.Visible = true;
                btnAdd.BackColor = System.Drawing.Color.Purple;
            }

            //ẩn con trỏ của các chức năng không hoạt động
            btnEdit.BackColor = System.Drawing.Color.Transparent;
            btnDelete.BackColor = System.Drawing.Color.Transparent;
            //ẩn Slide Menu nếu đang bật
            if (pnlMenu.Height == 508 && pnlMenu.Width == 264)
            {
                pnlMenu.Height = 508;
                pnlMenu.Width = 43;
                pnlMenu.BackColor = System.Drawing.Color.Transparent;
            }
            //ẩn các user control khác
            ucEdit.Visible = false;
            ucDelete.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucEdit);
            ucEdit.Location = new Point(65, 46);
            // ẩn/hiện user control khách
            if (ucEdit.Visible == true)
            {
                ucEdit.Visible = false;
                btnEdit.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                ucEdit.Visible = true;
                btnEdit.BackColor = System.Drawing.Color.Purple;
            }

            //ẩn con trỏ của các chức năng không hoạt động
            btnAdd.BackColor = System.Drawing.Color.Transparent;
            btnDelete.BackColor = System.Drawing.Color.Transparent;
            //ẩn Slide Menu nếu đang bật
            if (pnlMenu.Height == 508 && pnlMenu.Width == 264)
            {
                pnlMenu.Height = 508;
                pnlMenu.Width = 43;
                pnlMenu.BackColor = System.Drawing.Color.Transparent;
            }
            //ẩn các user control khác
            ucAdd.Visible = false;
            ucDelete.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucDelete);
            ucDelete.Location = new Point(65, 46);
            // ẩn/hiện user control khách
            if (ucDelete.Visible == true)
            {
                ucDelete.Visible = false;
                btnDelete.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                ucDelete.Visible = true;
                btnDelete.BackColor = System.Drawing.Color.Purple;
            }

            //ẩn con trỏ của các chức năng không hoạt động
            btnAdd.BackColor = System.Drawing.Color.Transparent;
            btnEdit.BackColor = System.Drawing.Color.Transparent;
            //ẩn Slide Menu nếu đang bật
            if (pnlMenu.Height == 508 && pnlMenu.Width == 264)
            {
                pnlMenu.Height = 508;
                pnlMenu.Width = 43;
                pnlMenu.BackColor = System.Drawing.Color.Transparent;
            }
            //ẩn các user control khác
            ucAdd.Visible = false;
            ucEdit.Visible = false;
        }
        //start location 65,46 ; size 683,444
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form frm = new frmInfo();
            frm.Show();
        }
        #endregion


    }
}
