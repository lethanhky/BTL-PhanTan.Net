using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entities;

namespace GUI
{
    public partial class frmEmplManage : Form
    {
        List<eEmployee> lsem;
        EmployeeBUS emBUS;
        public frmEmplManage()
        {
            InitializeComponent();
        }

        private void frmEmplManage_Load(object sender, EventArgs e)
        {
            emBUS = new EmployeeBUS();
            lsem = new List<eEmployee>();
        }
    }
}
