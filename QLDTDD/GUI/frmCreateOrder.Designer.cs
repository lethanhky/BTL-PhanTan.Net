namespace GUI
{
    partial class frmCreateOrder
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
            this.components = new System.ComponentModel.Container();
            this.cbxTeleName = new System.Windows.Forms.ComboBox();
            this.telephoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIPID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtStateOrder = new System.Windows.Forms.TextBox();
            this.txtStatePhone = new System.Windows.Forms.TextBox();
            this.txtorderID = new System.Windows.Forms.TextBox();
            this.txtEmId = new System.Windows.Forms.TextBox();
            this.txtemName = new System.Windows.Forms.TextBox();
            this.txtcusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImpDetail = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTeleName
            // 
            this.cbxTeleName.DataSource = this.telephoneBindingSource;
            this.cbxTeleName.DisplayMember = "Name";
            this.cbxTeleName.FormattingEnabled = true;
            this.cbxTeleName.Location = new System.Drawing.Point(94, 33);
            this.cbxTeleName.Name = "cbxTeleName";
            this.cbxTeleName.Size = new System.Drawing.Size(123, 21);
            this.cbxTeleName.TabIndex = 26;
            this.cbxTeleName.ValueMember = "Name";
            // 
            // telephoneBindingSource
            // 
            this.telephoneBindingSource.DataSource = typeof(Entities.eTelephone);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 28);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm vào hoá đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtIPID
            // 
            this.txtIPID.Location = new System.Drawing.Point(308, 5);
            this.txtIPID.Name = "txtIPID";
            this.txtIPID.ReadOnly = true;
            this.txtIPID.Size = new System.Drawing.Size(123, 20);
            this.txtIPID.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tên điện thoại : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(129, 228);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 20);
            this.txtTotal.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tổng tiền : ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(129, 309);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(123, 28);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtStateOrder
            // 
            this.txtStateOrder.Location = new System.Drawing.Point(129, 263);
            this.txtStateOrder.Name = "txtStateOrder";
            this.txtStateOrder.ReadOnly = true;
            this.txtStateOrder.Size = new System.Drawing.Size(123, 20);
            this.txtStateOrder.TabIndex = 21;
            // 
            // txtStatePhone
            // 
            this.txtStatePhone.Location = new System.Drawing.Point(94, 72);
            this.txtStatePhone.Name = "txtStatePhone";
            this.txtStatePhone.Size = new System.Drawing.Size(123, 20);
            this.txtStatePhone.TabIndex = 20;
            // 
            // txtorderID
            // 
            this.txtorderID.Location = new System.Drawing.Point(129, 33);
            this.txtorderID.Name = "txtorderID";
            this.txtorderID.ReadOnly = true;
            this.txtorderID.Size = new System.Drawing.Size(123, 20);
            this.txtorderID.TabIndex = 20;
            // 
            // txtEmId
            // 
            this.txtEmId.Location = new System.Drawing.Point(129, 184);
            this.txtEmId.Name = "txtEmId";
            this.txtEmId.Size = new System.Drawing.Size(123, 20);
            this.txtEmId.TabIndex = 19;
            // 
            // txtemName
            // 
            this.txtemName.Location = new System.Drawing.Point(129, 138);
            this.txtemName.Name = "txtemName";
            this.txtemName.Size = new System.Drawing.Size(123, 20);
            this.txtemName.TabIndex = 18;
            // 
            // txtcusName
            // 
            this.txtcusName.Location = new System.Drawing.Point(129, 59);
            this.txtcusName.Name = "txtcusName";
            this.txtcusName.Size = new System.Drawing.Size(123, 20);
            this.txtcusName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã nhân viên : ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(58, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(123, 20);
            this.txtID.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(322, 31);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(232, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giá : ";
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(322, 74);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(123, 20);
            this.txtProvider.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(232, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhà cung cấp : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên nhân viên : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbxTeleName);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtIPID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.txtStatePhone);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtProvider);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(282, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 146);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "Vui lòng nhập tên điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tình trạng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày lập: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên khách hàng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.txtStateOrder);
            this.groupBox2.Controls.Add(this.txtorderID);
            this.groupBox2.Controls.Add(this.txtEmId);
            this.groupBox2.Controls.Add(this.txtemName);
            this.groupBox2.Controls.Add(this.txtcusName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 368);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hoá đơn";
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.amount.HeaderText = "thành tiền";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 150;
            // 
            // unitprice
            // 
            this.unitprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unitprice.HeaderText = "đơn giá";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            this.unitprice.Width = 140;
            // 
            // teleID
            // 
            this.teleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.teleID.HeaderText = "Mã điện thoại";
            this.teleID.Name = "teleID";
            this.teleID.ReadOnly = true;
            this.teleID.Width = 120;
            // 
            // dgvImpDetail
            // 
            this.dgvImpDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teleID,
            this.unitprice,
            this.amount});
            this.dgvImpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpDetail.Location = new System.Drawing.Point(3, 19);
            this.dgvImpDetail.MultiSelect = false;
            this.dgvImpDetail.Name = "dgvImpDetail";
            this.dgvImpDetail.ReadOnly = true;
            this.dgvImpDetail.Size = new System.Drawing.Size(448, 196);
            this.dgvImpDetail.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvImpDetail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(282, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 218);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hoá đơn";
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 372);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCreateOrder";
            this.Text = "frmCreateOrder";
            this.Load += new System.EventHandler(this.frmCreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeleName;
        private System.Windows.Forms.BindingSource telephoneBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIPID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtStateOrder;
        private System.Windows.Forms.TextBox txtStatePhone;
        private System.Windows.Forms.TextBox txtorderID;
        private System.Windows.Forms.TextBox txtEmId;
        private System.Windows.Forms.TextBox txtemName;
        private System.Windows.Forms.TextBox txtcusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleID;
        private System.Windows.Forms.DataGridView dgvImpDetail;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}