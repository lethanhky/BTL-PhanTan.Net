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
    public partial class frmTelephoneManage : Form
    {
        List<eTelephone> listTele;
        TypePhoneBUS tpBus;
        TelephoneBUS teleBus;
        public frmTelephoneManage()
        {
            InitializeComponent();
        }

        private void frmTelephoneManage_Load(object sender, EventArgs e)
        {
            tpBus = new TypePhoneBUS();
            teleBus = new TelephoneBUS();   
            // TODO: This line of code loads data into the 'qLDTDDDataSet.Telephone' table. You can move, or remove it, as needed.
            this.telephoneTableAdapter.Fill(this.qLDTDDDataSet.Telephone);
        }
        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text.Trim() == "Thêm")
            {
                txtteleID.Text = "";
                txtName.Text = "";
                txtprice.Text = "";
                txtProvi.Text = "";
                txtState.Text = "";
                txtTypeID.Text = "";
                btnInsert.Text = "Lưu";
            }
            else
            {
                try
                {
                    eTelephone tele = new eTelephone();
                    tele.TeleID = int.Parse(txtteleID.Text);
                    tele.Name = txtName.Text;
                    tele.Price = double.Parse(txtprice.Text);
                    tele.Provider = txtProvi.Text;
                    tele.TypeID = int.Parse(txtTypeID.Text);
                    int kq = teleBus.insertPhone(tele);
                    if (kq == 0) MessageBox.Show("Mã đã tồn tại");
                    else MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }
    }
}
