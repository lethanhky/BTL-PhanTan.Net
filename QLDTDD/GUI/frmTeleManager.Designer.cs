﻿namespace GUI
{
    partial class frmTeleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeleManager));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIPID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTele = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtIPID);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.txtState);
            this.groupBox2.Controls.Add(this.txtProvider);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin điện thoại";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(87, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIPID
            // 
            this.txtIPID.Location = new System.Drawing.Point(99, 244);
            this.txtIPID.Name = "txtIPID";
            this.txtIPID.ReadOnly = true;
            this.txtIPID.Size = new System.Drawing.Size(123, 23);
            this.txtIPID.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 38);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(123, 23);
            this.txtID.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(161, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(13, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(99, 202);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(123, 23);
            this.txtState.TabIndex = 7;
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(99, 156);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(123, 23);
            this.txtProvider.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 23);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "State : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provider : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(291, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Search : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(358, 21);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(337, 26);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.UseWaitCursor = true;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvTele);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(261, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 303);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách điện thoại";
            // 
            // dgvTele
            // 
            this.dgvTele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTele.Location = new System.Drawing.Point(3, 19);
            this.dgvTele.MultiSelect = false;
            this.dgvTele.Name = "dgvTele";
            this.dgvTele.ReadOnly = true;
            this.dgvTele.Size = new System.Drawing.Size(468, 281);
            this.dgvTele.TabIndex = 0;
            this.dgvTele.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvTele_RowStateChanged);
            // 
            // frmTeleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeleManager";
            this.Text = "Telephone Manage";
            this.Load += new System.EventHandler(this.frmTeleManager_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtIPID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTele;
    }
}