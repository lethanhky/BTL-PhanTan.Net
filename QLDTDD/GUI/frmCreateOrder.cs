﻿using System;
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
    public partial class frmCreateOrder : Form
    {
        QLDTDDServicesClient qldtdd;
        public frmCreateOrder(Panel p, frmMenu frm)
        {
            InitializeComponent();
            qldtdd = new QLDTDDServicesClient();
        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            txtIPID.Visible = false;
            telephoneBindingSource.DataSource = qldtdd.GetAllTelephone().ToList();
        }

        private void cbxTeleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            eTelephone tele = new eTelephone();
            tele = qldtdd.GetETelephoneByName(cbxTeleName.Text);
            if (tele != null)
            {

                txtID.Text = tele.TeleID.ToString();
                txtPrice.Text = tele.Price.ToString();
                txtProvider.Text = tele.Provider;
                txtStatePhone.Text = tele.State;
                txtIPID.Text = tele.ImpdetailID.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxTeleName.Text == "")// rỗng
                {
                    MessageBox.Show("Vui lòng điện thoại ");
                    cbxTeleName.Focus();
                }
                else
                {
                    btnThanhToan.Enabled = true;
                    eTelephone x = qldtdd.GetETelephoneByName(txtID.Text.Trim());
                    dgvImpDetail.Rows.Add(txtID.Text, txtPrice.Text, txtPrice.Text);
                    cbxTeleName.SelectedIndex = -1;
                    txtID.Text = "";
                    txtPrice.Text = "";
                    txtProvider.Text = "";
                    txtStatePhone.Text = "";
                    txtIPID.Text = "";
                    if (dgvImpDetail.RowCount >= 11)
                    {
                        btnAdd.Text = "Tối đa 10 điện thoại";
                        btnAdd.Enabled = false;
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Loi" + a);
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            eOrder o = new eOrder();
            o.CusName = txtcusName.Text.TrimEnd();
            o.OrderDate = DateTime.Now;
            o.EmpID = int.Parse(txtEmId.Text.TrimEnd());
            o.EmpName = txtemName.Text.Trim();
            o.Total = double.Parse(txtTotal.Text.Trim());
            o.State = "Moi lap";
            qldtdd.InsertOrder(o);
            MessageBox.Show("Thanh toán thành công");
            for (int i = 0; i <= dgvImpDetail.Rows.Count - 1; i++)
            {
                eOrderDetail cthd = new eOrderDetail();
                cthd.OrderID = o.OrderID;
                //cthd.Amount = double.Parse(dgvImpDetail.Rows[i].Cells["amount"].Value.ToString().Trim());
                //cthd.Unitprice = double.Parse(dgvImpDetail.Rows[i].Cells["unitprice"].Value.ToString().Trim());
                //cthd.TeleID = int.Parse(dgvImpDetail.Rows[i].Cells["teleID"].Value.ToString());
                //qldtdd.InsertOrderDetail(cthd);
                MessageBox.Show("a" + o.OrderID);
            }

        }
    }
}