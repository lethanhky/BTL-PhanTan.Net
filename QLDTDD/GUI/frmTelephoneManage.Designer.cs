namespace GUI
{
    partial class frmTelephoneManage
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
            this.telephoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDTDDDataSet = new GUI.QLDTDDDataSet();
            this.telephoneTableAdapter = new GUI.QLDTDDDataSetTableAdapters.TelephoneTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtProvi = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtteleID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLDTDDDataSet1 = new GUI.QLDTDDDataSet();
            this.telephoneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impdetaiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDDDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // telephoneBindingSource
            // 
            this.telephoneBindingSource.DataMember = "Telephone";
            this.telephoneBindingSource.DataSource = this.qLDTDDDataSet;
            // 
            // qLDTDDDataSet
            // 
            this.qLDTDDDataSet.DataSetName = "QLDTDDDataSet";
            this.qLDTDDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telephoneTableAdapter
            // 
            this.telephoneTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(232, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách diện thoại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.txtTypeID);
            this.groupBox2.Controls.Add(this.txtState);
            this.groupBox2.Controls.Add(this.txtProvi);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtteleID);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 361);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin điện thoại";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Type ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "State : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Provider :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TelePhone ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(151, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(54, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(11, 294);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(55, 39);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(84, 233);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(110, 20);
            this.txtTypeID.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(84, 195);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(110, 20);
            this.txtState.TabIndex = 4;
            // 
            // txtProvi
            // 
            this.txtProvi.Location = new System.Drawing.Point(84, 158);
            this.txtProvi.Name = "txtProvi";
            this.txtProvi.Size = new System.Drawing.Size(110, 20);
            this.txtProvi.TabIndex = 3;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(84, 120);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(110, 20);
            this.txtprice.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtteleID
            // 
            this.txtteleID.Location = new System.Drawing.Point(84, 45);
            this.txtteleID.Name = "txtteleID";
            this.txtteleID.Size = new System.Drawing.Size(110, 20);
            this.txtteleID.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(277, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(625, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 20);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teleIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.impdetaiIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.telephoneBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // qLDTDDDataSet1
            // 
            this.qLDTDDDataSet1.DataSetName = "QLDTDDDataSet";
            this.qLDTDDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telephoneBindingSource1
            // 
            this.telephoneBindingSource1.DataMember = "Telephone";
            this.telephoneBindingSource1.DataSource = this.qLDTDDDataSet1;
            // 
            // teleIDDataGridViewTextBoxColumn
            // 
            this.teleIDDataGridViewTextBoxColumn.DataPropertyName = "teleID";
            this.teleIDDataGridViewTextBoxColumn.HeaderText = "teleID";
            this.teleIDDataGridViewTextBoxColumn.Name = "teleIDDataGridViewTextBoxColumn";
            this.teleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // impdetaiIDDataGridViewTextBoxColumn
            // 
            this.impdetaiIDDataGridViewTextBoxColumn.DataPropertyName = "impdetaiID";
            this.impdetaiIDDataGridViewTextBoxColumn.HeaderText = "impdetaiID";
            this.impdetaiIDDataGridViewTextBoxColumn.Name = "impdetaiIDDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "\r\n\t[typeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "\r\n\t[typeID";
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            // 
            // frmTelephoneManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 383);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTelephoneManage";
            this.Text = "frmTelephoneManage";
            this.Load += new System.EventHandler(this.frmTelephoneManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDDDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDTDDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDTDDDataSet qLDTDDDataSet;
        private System.Windows.Forms.BindingSource telephoneBindingSource;
        private QLDTDDDataSetTableAdapters.TelephoneTableAdapter telephoneTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtProvi;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtteleID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLDTDDDataSet qLDTDDDataSet1;
        private System.Windows.Forms.BindingSource telephoneBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impdetaiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
    }
}