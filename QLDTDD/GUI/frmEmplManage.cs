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
        AccountBUS accBUS;
        public frmEmplManage()
        {
            InitializeComponent();
        }

        private void frmEmplManage_Load(object sender, EventArgs e)
        {
            emBUS = new EmployeeBUS();
            accBUS = new AccountBUS();
            lsem = new List<eEmployee>();
            LoadDataGriwView();
            this.txtemID.Visible = false;
            this.txtAccId.Visible = false;
            this.lblaccId.Visible = false;
            this.grpNewAc.Visible = false;
            this.btnNewAc.Visible = false;
            this.lblnote.Visible = false;
            txtEnableFalse();
            int s = dgvEm.CurrentCell.RowIndex;
            this.dgvEm.Rows[s].Selected = true;
        }
        //EnableTextBox
        #region
        private void txtEnableFalse()
        {
            this.txtName.Enabled = false;
            this.txtPhone.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtPosition.Enabled = false;
            this.txtState.Enabled = false;
        }
        private void txtEnableTrue()
        {
            this.txtName.Enabled = true;
            this.txtPhone.Enabled = true;
            this.txtAddress.Enabled = true;
            this.txtPosition.Enabled = true;
            this.txtState.Enabled = true;
        }
        #endregion
        //Tra ve vi tri index dgv 
        public void returnIndex()
        {
            int s = dgvEm.CurrentCell.RowIndex;
            this.dgvEm.Rows[s].Selected = true;
        }
        private void LoadDataGriwView()
        {
            List<eEmployee> lsem = emBUS.getAllEmployee();
            dgvEm.DataSource = lsem;
        }
        private void dgvEm_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvEm.SelectedRows.Count > 0)
            {
                txtemID.Text = e.Row.Cells["empID"].Value.ToString().TrimEnd();
                txtName.Text = e.Row.Cells["name"].Value.ToString().TrimEnd();
                txtAddress.Text = e.Row.Cells["address"].Value.ToString().TrimEnd();
                txtPhone.Text = e.Row.Cells["phone"].Value.ToString().TrimEnd();
                txtState.Text = e.Row.Cells["state"].Value.ToString().TrimEnd();
                txtPosition.Text = e.Row.Cells["position"].Value.ToString().TrimEnd();
                txtAccId.Text = e.Row.Cells["accID"].Value.ToString().TrimEnd();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            List<eEmployee> le = emBUS.searchItem(txtSearch.Text.TrimEnd());
            dgvEm.DataSource = le;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try {
                if (btnEdit.Text.Trim() == "Edit" || btnEdit.Text.Trim() == "Sửa")
                {
                    txtEnableTrue();
                    this.btnInsert.Enabled = false;
                    this.btnDelete.Enabled = false;
                    dgvEm.Enabled = false;
                    this.btnEdit.Text = "Cancel";
                }
                else
                {
                    txtEnableFalse();
                    this.dgvEm.Enabled = true;
                    int s = dgvEm.CurrentCell.RowIndex;
                    this.dgvEm.Rows[s].Selected = true;
                    //set text bang gia tri ban dau
                    #region 
                    txtemID.Text = dgvEm.Rows[s].Cells["empID"].Value.ToString().TrimEnd();
                    txtName.Text = dgvEm.Rows[s].Cells["name"].Value.ToString().TrimEnd();
                    txtAddress.Text = dgvEm.Rows[s].Cells["address"].Value.ToString().TrimEnd();
                    txtPhone.Text = dgvEm.Rows[s].Cells["phone"].Value.ToString().TrimEnd();
                    txtState.Text = dgvEm.Rows[s].Cells["state"].Value.ToString().TrimEnd();
                    txtPosition.Text = dgvEm.Rows[s].Cells["position"].Value.ToString().TrimEnd();
                    txtAccId.Text = dgvEm.Rows[s].Cells["accID"].Value.ToString().TrimEnd();
                    #endregion
                    this.btnEdit.Text = "Edit";
                    this.btnInsert.Enabled = true;
                    this.btnDelete.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "Cancel")
                {
                    eEmployee em = new eEmployee();
                    em.EmpID = int.Parse(txtemID.Text.TrimEnd());
                    em.Name = txtName.Text.TrimEnd();
                    em.Address = txtAddress.Text.TrimEnd();
                    em.Phone = txtPhone.Text.TrimEnd();
                    em.State = txtState.Text.TrimEnd();
                    em.Position = txtPosition.Text.TrimEnd();
                    em.AccId = int.Parse(txtAccId.Text);

                    int kq = emBUS.editEmployee(em);
                    if (kq == 1)
                    {
                        MessageBox.Show("Edit Success !");
                        btnEdit.Text = "Edit";
                        this.btnInsert.Enabled = true;
                        this.btnDelete.Enabled = true;
                        this.dgvEm.Enabled = true;
                        txtEnableFalse();
                        returnIndex();
                    }
                    else MessageBox.Show("Key Not Exist");
                    LoadDataGriwView();
                }
                else if (btnInsert.Text == "Cancel")
                {
                    eEmployee em = new eEmployee();
                    em.EmpID = int.Parse(txtemID.Text.TrimEnd());
                    em.Name = txtName.Text.TrimEnd();
                    em.Address = txtAddress.Text.TrimEnd();
                    em.Phone = txtPhone.Text.TrimEnd();
                    em.State = txtState.Text.TrimEnd();
                    em.Position = txtPosition.Text.TrimEnd();
                    em.AccId = int.Parse(txtAccId.Text);
                    emBUS.inSertEmployee(em);
                      MessageBox.Show("Insert Success !");
                        btnInsert.Text = "Insert";
                        this.btnEdit.Enabled = true;
                        this.btnDelete.Enabled = true;

                        this.dgvEm.Enabled = true;
                    this.dgvEm.Visible = true;
                    this.grpNewAc.Visible = false;
                    lblaccId.Visible = false;
                    txtEnableFalse();
                    txtAccId.Visible = false;

                    LoadDataGriwView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : "+ex);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(btnInsert.Text == "Insert")
            {
                btnNewAc.Visible = true;
                txtEnableTrue();
                this.txtName.Text = "";
                this.txtPhone.Text = "";
                this.txtAddress.Text = "";
                this.txtPosition.Text = "";
                this.txtState.Text = "";
                this.txtAccId.Text = "";
                this.lblaccId.Visible = false;
                this.txtAccId.Visible = false;
                this.btnInsert.Text = "Cancel";
                this.btnDelete.Enabled = false;
                this.btnEdit.Enabled = false;
                this.lblnote.Visible = true;
                txtEnableFalse();
                returnIndex();
                dgvEm.Enabled = false;
            }
            else
            {
                txtEnableFalse();
                this.dgvEm.Enabled = true;
                int s = dgvEm.CurrentCell.RowIndex;
                this.dgvEm.Rows[s].Selected = true;
                //set text bang gia tri ban dau
                #region 
                txtemID.Text = dgvEm.Rows[s].Cells["empID"].Value.ToString().TrimEnd();
                txtName.Text = dgvEm.Rows[s].Cells["name"].Value.ToString().TrimEnd();
                txtAddress.Text = dgvEm.Rows[s].Cells["address"].Value.ToString().TrimEnd();
                txtPhone.Text = dgvEm.Rows[s].Cells["phone"].Value.ToString().TrimEnd();
                txtState.Text = dgvEm.Rows[s].Cells["state"].Value.ToString().TrimEnd();
                txtPosition.Text = dgvEm.Rows[s].Cells["position"].Value.ToString().TrimEnd();
                txtAccId.Text = dgvEm.Rows[s].Cells["accID"].Value.ToString().TrimEnd();
                #endregion
                this.btnInsert.Text = "Insert";
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnNewAc.Visible = false;
                this.lblnote.Visible = false;
                this.dgvEm.Visible = true;
                grpNewAc.Visible = false;
                this.btnNewAc.Text = "New Account";
            }
        }

        private void button1_Click(object sender, EventArgs e)// new account
        {
            if(btnNewAc.Text.TrimEnd() == "Cancel")
            {
                grpNewAc.Visible = false;
                grpDS.Text = "Danh sách nhân viên ";
                dgvEm.Visible = true;
                btnNewAc.Text = "New Account";


            }
            else if(btnNewAc.Text.TrimEnd() == "New Account")
            {
                grpDS.Text = "New Account";
                grpNewAc.Visible = true;
                dgvEm.Visible = false;
                this.btnEdit.Enabled = false;
                this.btnDelete.Enabled = false;
                this.txtName.Text = "";
                this.txtPhone.Text = "";
                this.txtAddress.Text = "";
                this.txtPosition.Text = "";
                this.txtState.Text = "";
                this.txtAccId.Text = "";
                btnNewAc.Text = "Cancel";
            }
        }

        private void btnSaveAcc_Click(object sender, EventArgs e)
        {
            eAccount ac = new eAccount();
            ac.UserName = txtUsername.Text.TrimEnd();
            ac.PassWord = txtPassWord.Text.TrimEnd();
            int kq1 = accBUS.InsertAccount(ac);
            if (kq1 == 1)
            {
                MessageBox.Show("Insert Success !");
                grpDS.Text = "Danh sách nhân viên ";
                this.btnNewAc.Visible = false;
                this.lblaccId.Visible = true;
                this.txtAccId.Visible = true;
                this.txtAccId.Enabled = false;
                this.lblnote.Visible = false;
                txtEnableTrue();
                returnIndex();
                txtAccId.Text = accBUS.getAccidbyUsername(txtUsername.Text.TrimEnd());
            }
            else
            {
                MessageBox.Show("Key Exist");
            }

        }
    }
}
