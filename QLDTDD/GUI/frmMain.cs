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
            frmEmplManage frm = new frmEmplManage(PanelParent, this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            PanelParent.Controls.Add(frm);
        }
        public void ShowForm(Form frm)
        {
            PanelParent.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            PanelParent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
