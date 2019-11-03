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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.chartSL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn năm cần thống kê";
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(333, 33);
            this.cbxNam.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(155, 21);
            this.cbxNam.TabIndex = 4;
            // 
            // chartSL
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSL.Legends.Add(legend1);
            this.chartSL.Location = new System.Drawing.Point(36, 109);
            this.chartSL.Margin = new System.Windows.Forms.Padding(2);
            this.chartSL.Name = "chartSL";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng bán";
            this.chartSL.Series.Add(series1);
            this.chartSL.Size = new System.Drawing.Size(333, 260);
            this.chartSL.TabIndex = 7;
            this.chartSL.Text = "chartSL";
            // 
            // chartDT
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDT.Legends.Add(legend2);
            this.chartDT.Location = new System.Drawing.Point(421, 109);
            this.chartDT.Margin = new System.Windows.Forms.Padding(2);
            this.chartDT.Name = "chartDT";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.chartDT.Series.Add(series2);
            this.chartDT.Size = new System.Drawing.Size(333, 260);
            this.chartDT.TabIndex = 8;
            this.chartDT.Text = "chartDT";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDT);
            this.Controls.Add(this.chartSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNam);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
    }
}