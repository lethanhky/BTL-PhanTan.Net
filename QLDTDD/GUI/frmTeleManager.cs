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
    public partial class frmTeleManager : Form
    {
        List<eTelephone> listtele;
        TelephoneBUS teleBus;
        public frmTeleManager()
        {
            InitializeComponent();
        }
        private void frmTeleManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDTDDDataSet.Telephone' table. You can move, or remove it, as needed.
            teleBus = new TelephoneBUS();
            listtele = new List<eTelephone>();
            listtele = teleBus.GetAllTelephone();
            dgvTele.DataSource = listtele;
            this.txtID.Visible = false;
            this.txtIPID.Visible = false;
            this.txtName.Enabled = false;
            this.txtPrice.Enabled = false;
            this.txtProvider.Enabled = false;
            this.txtState.Enabled = false;
            int s = dgvTele.CurrentCell.RowIndex;
            this.dgvTele.Rows[s].Selected = true;
        }
        private void LoadDataGriwView()
        {
            List<eTelephone> lstl = new List<eTelephone>();
        }
        #region
        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text.Trim() == "Edit" || btnEdit.Text.Trim() == "Sửa")
            {
                this.txtName.Enabled = true;
                this.txtPrice.Enabled = true;
                this.txtProvider.Enabled = true;
                this.txtState.Enabled = true;
                this.dgvTele.Enabled = false;
                this.btnEdit.Text = "Save";
            }
            else
            {
                eTelephone tele = new eTelephone();
                tele.TeleID = int.Parse(txtID.Text);
                tele.Name = txtName.Text;
                tele.Price = double.Parse(txtPrice.Text);
                tele.Provider = txtProvider.Text;
                tele.State = txtState.Text;
                tele.ImpdetailID = int.Parse(txtIPID.Text);

                int kq = teleBus.updatePhone(tele);
                if (kq == 1)
                {
                    MessageBox.Show("Edit Success !");
                    btnEdit.Text = "Edit";
                    this.dgvTele.Enabled = true;
                }
                else MessageBox.Show("Key Exist");

                List<eTelephone> lstl = teleBus.GetAllTelephone();
                dgvTele.DataSource = lstl;
            }
        }
        private void dgvTele_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvTele.SelectedRows.Count > 0)
            {
                txtID.Text = e.Row.Cells["teleID"].Value.ToString().TrimEnd();
                txtName.Text = e.Row.Cells["name"].Value.ToString().TrimEnd();
                txtIPID.Text = e.Row.Cells["impdetailID"].Value.ToString().TrimEnd();
                txtPrice.Text = e.Row.Cells["price"].Value.ToString().TrimEnd();
                txtProvider.Text = e.Row.Cells["provider"].Value.ToString().TrimEnd();
                txtState.Text = e.Row.Cells["state"].Value.ToString().TrimEnd();
            }
        }

        private void dgvTele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dgvTele.CurrentCell.RowIndex;
            this.dgvTele.Rows[a].Selected = true;
            if(dgvTele.Enabled==false)
            {
                MessageBox.Show("Please save");
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            List<eTelephone> le = teleBus.SearchTelephone(txtSearch.Text.TrimEnd());
            dgvTele.DataSource = le;
        }
    }
}
