namespace Restaurent_Managment
{
    partial class CashierRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierRecord));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enteredbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurent_ManagmentDataSet2 = new Restaurent_Managment.Restaurent_ManagmentDataSet2();
            this.productHistoryTableAdapter = new Restaurent_Managment.Restaurent_ManagmentDataSet2TableAdapters.ProductHistoryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCRBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOverAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurent_ManagmentDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enteredbyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.totalvalueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(544, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // enteredbyDataGridViewTextBoxColumn
            // 
            this.enteredbyDataGridViewTextBoxColumn.DataPropertyName = "entered_by";
            this.enteredbyDataGridViewTextBoxColumn.HeaderText = "Cashier Name";
            this.enteredbyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enteredbyDataGridViewTextBoxColumn.Name = "enteredbyDataGridViewTextBoxColumn";
            this.enteredbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.enteredbyDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // activityDataGridViewTextBoxColumn
            // 
            this.activityDataGridViewTextBoxColumn.DataPropertyName = "activity";
            this.activityDataGridViewTextBoxColumn.HeaderText = "Activity";
            this.activityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            this.activityDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalvalueDataGridViewTextBoxColumn
            // 
            this.totalvalueDataGridViewTextBoxColumn.DataPropertyName = "total_value";
            this.totalvalueDataGridViewTextBoxColumn.HeaderText = "Sell Amount";
            this.totalvalueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalvalueDataGridViewTextBoxColumn.Name = "totalvalueDataGridViewTextBoxColumn";
            this.totalvalueDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalvalueDataGridViewTextBoxColumn.Width = 125;
            // 
            // productHistoryBindingSource
            // 
            this.productHistoryBindingSource.DataMember = "ProductHistory";
            this.productHistoryBindingSource.DataSource = this.restaurent_ManagmentDataSet2;
            // 
            // restaurent_ManagmentDataSet2
            // 
            this.restaurent_ManagmentDataSet2.DataSetName = "Restaurent_ManagmentDataSet2";
            this.restaurent_ManagmentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productHistoryTableAdapter
            // 
            this.productHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is Cashier Record Page.";
            // 
            // btnCRBack
            // 
            this.btnCRBack.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCRBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCRBack.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRBack.Location = new System.Drawing.Point(484, 382);
            this.btnCRBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnCRBack.Name = "btnCRBack";
            this.btnCRBack.Size = new System.Drawing.Size(117, 37);
            this.btnCRBack.TabIndex = 58;
            this.btnCRBack.Text = "BACK";
            this.btnCRBack.UseVisualStyleBackColor = false;
            this.btnCRBack.Click += new System.EventHandler(this.btnCRBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(184, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 29);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnOverAll
            // 
            this.btnOverAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverAll.Location = new System.Drawing.Point(412, 58);
            this.btnOverAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnOverAll.Name = "btnOverAll";
            this.btnOverAll.Size = new System.Drawing.Size(73, 26);
            this.btnOverAll.TabIndex = 61;
            this.btnOverAll.Text = "Over All Show";
            this.btnOverAll.UseVisualStyleBackColor = true;
            this.btnOverAll.Click += new System.EventHandler(this.btnOverAll_Click);
            // 
            // CashierRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 436);
            this.Controls.Add(this.btnOverAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCRBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierRecord";
            this.Load += new System.EventHandler(this.CashierRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurent_ManagmentDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Restaurent_ManagmentDataSet2 restaurent_ManagmentDataSet2;
        private System.Windows.Forms.BindingSource productHistoryBindingSource;
        private Restaurent_ManagmentDataSet2TableAdapters.ProductHistoryTableAdapter productHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enteredbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCRBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOverAll;
    }
}