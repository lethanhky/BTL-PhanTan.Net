namespace GUI
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSL
            // 
            chartArea5.Name = "ChartArea1";
            this.chartSL.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartSL.Legends.Add(legend5);
            this.chartSL.Location = new System.Drawing.Point(23, 76);
            this.chartSL.Name = "chartSL";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Số lượng bán";
            this.chartSL.Series.Add(series5);
            this.chartSL.Size = new System.Drawing.Size(500, 400);
            this.chartSL.TabIndex = 0;
            this.chartSL.Text = "chartSL";
            // 
            // chartDT
            // 
            chartArea6.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartDT.Legends.Add(legend6);
            this.chartDT.Location = new System.Drawing.Point(556, 76);
            this.chartDT.Name = "chartDT";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Doanh thu";
            this.chartDT.Series.Add(series6);
            this.chartDT.Size = new System.Drawing.Size(500, 400);
            this.chartDT.TabIndex = 1;
            this.chartDT.Text = "chartDT";
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(292, 23);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(231, 28);
            this.cbxNam.TabIndex = 2;
            this.cbxNam.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbxNam.SelectedValueChanged += new System.EventHandler(this.cbxNam_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn năm cần thống kê";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNam);
            this.Controls.Add(this.chartDT);
            this.Controls.Add(this.chartSL);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.Shown += new System.EventHandler(this.frmThongKe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chartSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Label label1;
    }
}