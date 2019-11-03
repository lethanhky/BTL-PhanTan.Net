using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLDTDDClient;

namespace GUI
{
    public partial class frmTeleManager : Form
    {
        QLDTDDServicesClient qldtdd;
        public frmTeleManager(Panel p, frmMenu frm)
        {
            InitializeComponent();
            qldtdd = new QLDTDDServicesClient();
        }
        private void frmTeleManager_Load(object sender, EventArgs e)
        {
                // TODO: This line of code loads data into the 'qLDTDDDataSet.Telephone' table. You can move, or remove it, as needed.
            LoadDataGriwView();
            this.txtID.Visible = false;
            this.txtIPID.Visible = false;
            txtEnableFalse();
            int s = dgvTele.CurrentCell.RowIndex;
            this.dgvTele.Rows[s].Selected = true;
        }
        public void txtEnableFalse()
        {
            this.txtName.Enabled = false;
            this.txtPrice.Enabled = false;
            this.txtProvider.Enabled = false;
            this.txtState.Enabled = false;
        }
        public void txtEnableTrue()
        {
            this.txtName.Enabled = true;
            this.txtPrice.Enabled = true;
            this.txtProvider.Enabled = true;
            this.txtState.Enabled = true;
        }
        private void LoadDataGriwView()
        {
            List<eTelephone> lstl = qldtdd.GetAllTelephone().ToList();
            dgvTele.DataSource = lstl;
        }
        #region
        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text.Trim() == "Edit" || btnEdit.Text.Trim() == "Sửa")
                {
                    txtEnableTrue();
                    this.dgvTele.Enabled = false;
                    this.btnEdit.Text = "Cancel";
                }
                else
                {
                    txtEnableFalse();
                    this.dgvTele.Enabled = true;
                    int s = dgvTele.CurrentCell.RowIndex;
                    this.dgvTele.Rows[s].Selected = true;

                    txtID.Text = dgvTele.Rows[s].Cells["teleID"].Value.ToString().TrimEnd();
                    txtName.Text = dgvTele.Rows[s].Cells["name"].Value.ToString().TrimEnd();
                    txtIPID.Text = dgvTele.Rows[s].Cells["impdetailID"].Value.ToString().TrimEnd();
                    txtPrice.Text = dgvTele.Rows[s].Cells["price"].Value.ToString().TrimEnd();
                    txtProvider.Text = dgvTele.Rows[s].Cells["provider"].Value.ToString().TrimEnd();
                    txtState.Text = dgvTele.Rows[s].Cells["state"].Value.ToString().TrimEnd();

                    this.btnEdit.Text = "Edit";

                }
            }
            catch(Exception ex)
            {
                Console.Write(ex);
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

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            List<eTelephone> le = qldtdd.SearchTelephone(txtSearch.Text.TrimEnd()).ToList();
            dgvTele.DataSource = le;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                eTelephone tele = new eTelephone();
                tele.TeleID = int.Parse(txtID.Text);
                tele.Name = txtName.Text;
                tele.Price = double.Parse(txtPrice.Text);
                tele.Provider = txtProvider.Text;
                tele.State = txtState.Text;
                tele.ImpdetailID = int.Parse(txtIPID.Text);

                int kq = qldtdd.updatePhone(tele);
                if (kq == 1)
                {
                    MessageBox.Show("Edit Success !");
                    btnEdit.Text = "Edit";
                    txtEnableFalse();
                    this.dgvTele.Enabled = true;
                }
                else MessageBox.Show("Key Exist");
                LoadDataGriwView();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }
        }
    }
}
