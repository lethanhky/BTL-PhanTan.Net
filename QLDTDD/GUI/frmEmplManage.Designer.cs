namespace GUI
{
    partial class frmEmplManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmplManage));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblnote = new System.Windows.Forms.Label();
            this.btnNewAc = new System.Windows.Forms.Button();
            this.lblaccId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAccId = new System.Windows.Forms.TextBox();
            this.txtemID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpDS = new System.Windows.Forms.GroupBox();
            this.grpNewAc = new System.Windows.Forms.GroupBox();
            this.txtaccountid = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSaveAcc = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.dgvEm = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.grpDS.SuspendLayout();
            this.grpNewAc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblnote);
            this.groupBox2.Controls.Add(this.btnNewAc);
            this.groupBox2.Controls.Add(this.lblaccId);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtAccId);
            this.groupBox2.Controls.Add(this.txtemID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPosition);
            this.groupBox2.Controls.Add(this.txtState);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblnote.Location = new System.Drawing.Point(15, 253);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(217, 14);
            this.lblnote.TabIndex = 22;
            this.lblnote.Text = "Vui lòng tạo tài khoản trước khi thêm nhân viên";
            // 
            // btnNewAc
            // 
            this.btnNewAc.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnNewAc.Location = new System.Drawing.Point(62, 273);
            this.btnNewAc.Name = "btnNewAc";
            this.btnNewAc.Size = new System.Drawing.Size(124, 31);
            this.btnNewAc.TabIndex = 21;
            this.btnNewAc.Text = "New Account";
            this.btnNewAc.UseVisualStyleBackColor = true;
            this.btnNewAc.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblaccId
            // 
            this.lblaccId.AutoSize = true;
            this.lblaccId.ForeColor = System.Drawing.SystemColors.Info;
            this.lblaccId.Location = new System.Drawing.Point(12, 279);
            this.lblaccId.Name = "lblaccId";
            this.lblaccId.Size = new System.Drawing.Size(71, 16);
            this.lblaccId.TabIndex = 20;
            this.lblaccId.Text = "Acccout id :";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnDelete.Location = new System.Drawing.Point(190, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 31);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnSave.Location = new System.Drawing.Point(129, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 31);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccId
            // 
            this.txtAccId.Location = new System.Drawing.Point(88, 271);
            this.txtAccId.Name = "txtAccId";
            this.txtAccId.Size = new System.Drawing.Size(138, 23);
            this.txtAccId.TabIndex = 17;
            // 
            // txtemID
            // 
            this.txtemID.Location = new System.Drawing.Point(88, 12);
            this.txtemID.Name = "txtemID";
            this.txtemID.Size = new System.Drawing.Size(124, 23);
            this.txtemID.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Position :";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(88, 225);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(138, 23);
            this.txtPosition.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(88, 179);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(138, 23);
            this.txtState.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(88, 133);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(138, 23);
            this.txtPhone.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(88, 87);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(138, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 23);
            this.txtName.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnEdit.Location = new System.Drawing.Point(68, 314);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 31);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnInsert.Location = new System.Drawing.Point(3, 314);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 31);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "State : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 44);
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
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(293, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Search : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(360, 16);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(317, 26);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // grpDS
            // 
            this.grpDS.BackColor = System.Drawing.Color.Transparent;
            this.grpDS.Controls.Add(this.grpNewAc);
            this.grpDS.Controls.Add(this.dgvEm);
            this.grpDS.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpDS.Location = new System.Drawing.Point(263, 67);
            this.grpDS.Name = "grpDS";
            this.grpDS.Size = new System.Drawing.Size(477, 301);
            this.grpDS.TabIndex = 31;
            this.grpDS.TabStop = false;
            this.grpDS.Text = "Danh sách nhân viên";
            // 
            // grpNewAc
            // 
            this.grpNewAc.Controls.Add(this.txtaccountid);
            this.grpNewAc.Controls.Add(this.txtUsername);
            this.grpNewAc.Controls.Add(this.btnSaveAcc);
            this.grpNewAc.Controls.Add(this.lblusername);
            this.grpNewAc.Controls.Add(this.txtPassWord);
            this.grpNewAc.Controls.Add(this.lblpassword);
            this.grpNewAc.Location = new System.Drawing.Point(0, 19);
            this.grpNewAc.Name = "grpNewAc";
            this.grpNewAc.Size = new System.Drawing.Size(477, 282);
            this.grpNewAc.TabIndex = 27;
            this.grpNewAc.TabStop = false;
            // 
            // txtaccountid
            // 
            this.txtaccountid.Location = new System.Drawing.Point(195, 41);
            this.txtaccountid.Name = "txtaccountid";
            this.txtaccountid.Size = new System.Drawing.Size(138, 23);
            this.txtaccountid.TabIndex = 27;
            this.txtaccountid.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(195, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(138, 23);
            this.txtUsername.TabIndex = 24;
            // 
            // btnSaveAcc
            // 
            this.btnSaveAcc.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnSaveAcc.Location = new System.Drawing.Point(197, 177);
            this.btnSaveAcc.Name = "btnSaveAcc";
            this.btnSaveAcc.Size = new System.Drawing.Size(98, 31);
            this.btnSaveAcc.TabIndex = 26;
            this.btnSaveAcc.Text = "Save Account";
            this.btnSaveAcc.UseVisualStyleBackColor = true;
            this.btnSaveAcc.Click += new System.EventHandler(this.btnSaveAcc_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.ForeColor = System.Drawing.Color.Snow;
            this.lblusername.Location = new System.Drawing.Point(119, 83);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(72, 16);
            this.lblusername.TabIndex = 22;
            this.lblusername.Text = "UserName : ";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(195, 126);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(138, 23);
            this.txtPassWord.TabIndex = 25;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.ForeColor = System.Drawing.Color.Snow;
            this.lblpassword.Location = new System.Drawing.Point(119, 130);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(66, 16);
            this.lblpassword.TabIndex = 23;
            this.lblpassword.Text = "PassWord :";
            // 
            // dgvEm
            // 
            this.dgvEm.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvEm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvEm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEm.EnableHeadersVisualStyles = false;
            this.dgvEm.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEm.Location = new System.Drawing.Point(3, 19);
            this.dgvEm.Name = "dgvEm";
            this.dgvEm.ReadOnly = true;
            this.dgvEm.Size = new System.Drawing.Size(471, 279);
            this.dgvEm.TabIndex = 0;
            this.dgvEm.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvEm_RowStateChanged);
            // 
            // frmEmplManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.new_PA_background_web;
            this.ClientSize = new System.Drawing.Size(738, 372);
            this.Controls.Add(this.grpDS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmplManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLDTDD";
            this.Load += new System.EventHandler(this.frmEmplManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpDS.ResumeLayout(false);
            this.grpNewAc.ResumeLayout(false);
            this.grpNewAc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Button btnNewAc;
        private System.Windows.Forms.Label lblaccId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAccId;
        private System.Windows.Forms.TextBox txtemID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpDS;
        private System.Windows.Forms.GroupBox grpNewAc;
        private System.Windows.Forms.TextBox txtaccountid;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSaveAcc;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.DataGridView dgvEm;
    }
}