namespace Restaurent_Managment
{
    partial class StaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSUIback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSUIloginas = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSUIaddress = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblSUIphoneno = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblSUIemail = new System.Windows.Forms.Label();
            this.lblSUIgender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSUIname = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierUpdateInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurent_ManagmentDataSet1 = new Restaurent_Managment.Restaurent_ManagmentDataSet1();
            this.cashierUpdateInfoTableAdapter = new Restaurent_Managment.Restaurent_ManagmentDataSet1TableAdapters.CashierUpdateInfoTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierUpdateInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurent_ManagmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 542);
            this.panel1.TabIndex = 59;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(817, 471);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 37);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSUIback
            // 
            this.btnSUIback.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSUIback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSUIback.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUIback.Location = new System.Drawing.Point(927, 471);
            this.btnSUIback.Margin = new System.Windows.Forms.Padding(2);
            this.btnSUIback.Name = "btnSUIback";
            this.btnSUIback.Size = new System.Drawing.Size(117, 37);
            this.btnSUIback.TabIndex = 57;
            this.btnSUIback.Text = "BACK";
            this.btnSUIback.UseVisualStyleBackColor = false;
            this.btnSUIback.Click += new System.EventHandler(this.btnSUIback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Staff Update Info";
            // 
            // lblSUIloginas
            // 
            this.lblSUIloginas.AutoSize = true;
            this.lblSUIloginas.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUIloginas.Location = new System.Drawing.Point(533, 12);
            this.lblSUIloginas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSUIloginas.Name = "lblSUIloginas";
            this.lblSUIloginas.Size = new System.Drawing.Size(315, 32);
            this.lblSUIloginas.TabIndex = 54;
            this.lblSUIloginas.Text = "LOGGED IN AS - Admin";
            this.lblSUIloginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(440, 334);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(282, 77);
            this.txtAddress.TabIndex = 53;
            // 
            // lblSUIaddress
            // 
            this.lblSUIaddress.AutoSize = true;
            this.lblSUIaddress.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUIaddress.Location = new System.Drawing.Point(320, 338);
            this.lblSUIaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSUIaddress.Name = "lblSUIaddress";
            this.lblSUIaddress.Size = new System.Drawing.Size(112, 22);
            this.lblSUIaddress.TabIndex = 52;
            this.lblSUIaddress.Text = "ADDRESS :";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(516, 276);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(206, 32);
            this.txtNumber.TabIndex = 51;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblSUIphoneno
            // 
            this.lblSUIphoneno.AutoSize = true;
            this.lblSUIphoneno.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUIphoneno.Location = new System.Drawing.Point(320, 280);
            this.lblSUIphoneno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSUIphoneno.Name = "lblSUIphoneno";
            this.lblSUIphoneno.Size = new System.Drawing.Size(186, 22);
            this.lblSUIphoneno.TabIndex = 50;
            this.lblSUIphoneno.Text = "PHONE NUMBER :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(440, 181);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(282, 32);
            this.txtID.TabIndex = 49;
            // 
            // lblSUIemail
            // 
            this.lblSUIemail.AutoSize = true;
            this.lblSUIemail.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUIemail.Location = new System.Drawing.Point(320, 185);
            this.lblSUIemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSUIemail.Name = "lblSUIemail";
            this.lblSUIemail.Size = new System.Drawing.Size(94, 22);
            this.lblSUIemail.TabIndex = 48;
            this.lblSUIemail.Text = "E-MAIL :";
            // 
            // lblSUIgender
            // 
            this.lblSUIgender.AutoSize = true;
            this.lblSUIgender.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUIgender.Location = new System.Drawing.Point(320, 229);
            this.lblSUIgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSUIgender.Name = "lblSUIgender";
            this.lblSUIgender.Size = new System.Drawing.Size(102, 22);
            this.lblSUIgender.TabIndex = 45;
            this.lblSUIgender.Text = "GENDER :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(440, 134);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 32);
            this.txtName.TabIndex = 44;
            // 
            // lblSUIname
            // 
            this.lblSUIname.AutoSize = true;
            this.lblSUIname.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUIname.Location = new System.Drawing.Point(320, 138);
            this.lblSUIname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSUIname.Name = "lblSUIname";
            this.lblSUIname.Size = new System.Drawing.Size(84, 22);
            this.lblSUIname.TabIndex = 43;
            this.lblSUIname.Text = "NAME :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(591, 471);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 37);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(915, 399);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(264, 32);
            this.txtPassword.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 403);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "PASSWORD :";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.cashierUpdateInfoBindingSource;
            this.dgvList.Location = new System.Drawing.Point(763, 148);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(416, 232);
            this.dgvList.TabIndex = 67;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashierUpdateInfoBindingSource
            // 
            this.cashierUpdateInfoBindingSource.DataMember = "CashierUpdateInfo";
            this.cashierUpdateInfoBindingSource.DataSource = this.restaurent_ManagmentDataSet1;
            // 
            // restaurent_ManagmentDataSet1
            // 
            this.restaurent_ManagmentDataSet1.DataSetName = "Restaurent_ManagmentDataSet1";
            this.restaurent_ManagmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashierUpdateInfoTableAdapter
            // 
            this.cashierUpdateInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Peru;
            this.btnClear.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(704, 471);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 37);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbRole.Location = new System.Drawing.Point(440, 226);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(167, 30);
            this.cmbRole.TabIndex = 69;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(763, 100);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(267, 30);
            this.txtAutoSearch.TabIndex = 70;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Orange;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(469, 471);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 37);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Search here ";
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAutoSearch);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSUIback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSUIloginas);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblSUIaddress);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblSUIphoneno);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblSUIemail);
            this.Controls.Add(this.lblSUIgender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSUIname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierUpdateInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurent_ManagmentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSUIback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSUIloginas;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSUIaddress;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblSUIphoneno;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblSUIemail;
        private System.Windows.Forms.Label lblSUIgender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSUIname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvList;
        private Restaurent_ManagmentDataSet1 restaurent_ManagmentDataSet1;
        private System.Windows.Forms.BindingSource cashierUpdateInfoBindingSource;
        private Restaurent_ManagmentDataSet1TableAdapters.CashierUpdateInfoTableAdapter cashierUpdateInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
    }
}