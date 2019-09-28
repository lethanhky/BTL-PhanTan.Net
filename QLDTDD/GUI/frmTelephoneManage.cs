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
    public partial class frmTelephoneManage : Form
    {
        public frmTelephoneManage()
        {
            InitializeComponent();
        }

        private void frmTelephoneManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDTDDDataSet.Telephone' table. You can move, or remove it, as needed.
            this.telephoneTableAdapter.Fill(this.qLDTDDDataSet.Telephone);

        }
    }
}
