using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            frmTrangChu frm = new frmTrangChu(PanelParent, this);
            ShowForm(frm);
        }
        public void ShowForm(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            PanelParent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TrangChuMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LapHoaDonMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QLNVMenuItem_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            frmEmplManage frm = new frmEmplManage(PanelParent, this);
            ShowForm(frm);
        }

        private void QLSPMenuItem_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            frmTeleManager frm = new frmTeleManager(PanelParent, this);
            ShowForm(frm);
        }

        private void TKMenuItem_Click(object sender, EventArgs e)
        {
            PanelParent.Controls.Clear();
            frmThongKe frm = new frmThongKe(PanelParent, this);
            ShowForm(frm);
        }

        private void QLNVMenuItem_MouseHover(object sender, EventArgs e)
        {
            this. ForeColor = Color.Black;
        }

        private void TrangChuMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
        }
    }
}
