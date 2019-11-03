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
    public partial class frmThongKe : Form
    {
        QLDTDDServicesClient qldtdd;

        public frmThongKe(Panel p, frmMenu frm)
        {

            InitializeComponent();
            qldtdd = new QLDTDDServicesClient();

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                cbxNam.Items.Add(i.ToString());
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartSL.Series["Số lượng bán"].Points.Clear();
            chartDT.Series["Doanh thu"].Points.Clear();
            for (int i = 1; i < 12; i++)
            {
                this.chartSL.Series["Số lượng bán"].Points.AddXY(i, qldtdd.LayTheoSLB(i, int.Parse(cbxNam.Text)));
                this.chartDT.Series["Doanh thu"].Points.AddXY(i, qldtdd.ThongKeTheoTTB(i, int.Parse(cbxNam.Text)));
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxNam_SelectedValueChanged(object sender, EventArgs e)
        {
            //for (int i = 1; i < 13; i++)
            //{
            //    this.chartSL.Series["Số lượng bán"].Points.AddXY(i, qldtdd.LayTheoSLB(i, int.Parse(cbxNam.Text)));
            //    this.chartDT.Series["Doanh thu"].Points.AddXY(i, qldtdd.ThongKeTheoTTB(i, int.Parse(cbxNam.Text)));
            //}

        }

        private void frmThongKe_Shown(object sender, EventArgs e)
        {
            cbxNam.SelectedIndex = cbxNam.Items.Count - 1;
        }
    }
}
