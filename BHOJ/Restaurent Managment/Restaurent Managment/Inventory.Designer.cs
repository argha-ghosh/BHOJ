namespace Restaurent_Managment
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.txtAddQuantity = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dgvInventoryItems = new System.Windows.Forms.DataGridView();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddToInventory = new System.Windows.Forms.Button();
            this.lblAddQuantity = new System.Windows.Forms.Label();
            this.txtAvailableQuantity = new System.Windows.Forms.TextBox();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.txtInventorySearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddQuantity
            // 
            this.txtAddQuantity.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuantity.Location = new System.Drawing.Point(211, 285);
            this.txtAddQuantity.Name = "txtAddQuantity";
            this.txtAddQuantity.Size = new System.Drawing.Size(96, 32);
            this.txtAddQuantity.TabIndex = 30;
            this.txtAddQuantity.TextChanged += new System.EventHandler(this.txtAddQuantity_TextChanged);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(169, 285);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(36, 32);
            this.btnMinus.TabIndex = 29;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(313, 285);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 32);
            this.btnPlus.TabIndex = 28;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // dgvInventoryItems
            // 
            this.dgvInventoryItems.AllowUserToAddRows = false;
            this.dgvInventoryItems.AllowUserToDeleteRows = false;
            this.dgvInventoryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryItems.Location = new System.Drawing.Point(540, 30);
            this.dgvInventoryItems.Name = "dgvInventoryItems";
            this.dgvInventoryItems.ReadOnly = true;
            this.dgvInventoryItems.RowHeadersWidth = 51;
            this.dgvInventoryItems.RowTemplate.Height = 24;
            this.dgvInventoryItems.Size = new System.Drawing.Size(332, 459);
            this.dgvInventoryItems.TabIndex = 27;
            this.dgvInventoryItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryItems_CellContentClick);
            // 
            // cmbShow
            // 
            this.cmbShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShow.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Location = new System.Drawing.Point(32, 127);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.Size = new System.Drawing.Size(274, 30);
            this.cmbShow.TabIndex = 26;
            this.cmbShow.SelectedIndexChanged += new System.EventHandler(this.cmbShow_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(134, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 37);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Chocolate;
            this.btnBack.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(227, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 37);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddToInventory
            // 
            this.btnAddToInventory.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddToInventory.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToInventory.Location = new System.Drawing.Point(32, 342);
            this.btnAddToInventory.Name = "btnAddToInventory";
            this.btnAddToInventory.Size = new System.Drawing.Size(197, 37);
            this.btnAddToInventory.TabIndex = 23;
            this.btnAddToInventory.Text = "Add To Inventory";
            this.btnAddToInventory.UseVisualStyleBackColor = false;
            this.btnAddToInventory.Click += new System.EventHandler(this.btnAddToInventory_Click);
            // 
            // lblAddQuantity
            // 
            this.lblAddQuantity.AutoSize = true;
            this.lblAddQuantity.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuantity.Location = new System.Drawing.Point(28, 291);
            this.lblAddQuantity.Name = "lblAddQuantity";
            this.lblAddQuantity.Size = new System.Drawing.Size(133, 22);
            this.lblAddQuantity.TabIndex = 22;
            this.lblAddQuantity.Text = "Add Quantity :";
            // 
            // txtAvailableQuantity
            // 
            this.txtAvailableQuantity.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQuantity.Location = new System.Drawing.Point(211, 235);
            this.txtAvailableQuantity.Name = "txtAvailableQuantity";
            this.txtAvailableQuantity.Size = new System.Drawing.Size(95, 32);
            this.txtAvailableQuantity.TabIndex = 21;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableQuantity.Location = new System.Drawing.Point(28, 241);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(177, 22);
            this.lblAvailableQuantity.TabIndex = 20;
            this.lblAvailableQuantity.Text = "Available Quantity :";
            // 
            // txtInventorySearch
            // 
            this.txtInventorySearch.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventorySearch.Location = new System.Drawing.Point(108, 186);
            this.txtInventorySearch.Name = "txtInventorySearch";
            this.txtInventorySearch.Size = new System.Drawing.Size(198, 32);
            this.txtInventorySearch.TabIndex = 19;
            this.txtInventorySearch.TextChanged += new System.EventHandler(this.txtInventorySearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(28, 192);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 22);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search :";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(28, 87);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(200, 22);
            this.lblShow.TabIndex = 17;
            this.lblShow.Text = "Show Available Items :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 34);
            this.label1.TabIndex = 31;
            this.label1.Text = "ADD ITEMS IN INVENTORY";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddQuantity);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.dgvInventoryItems);
            this.Controls.Add(this.cmbShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddToInventory);
            this.Controls.Add(this.lblAddQuantity);
            this.Controls.Add(this.txtAvailableQuantity);
            this.Controls.Add(this.lblAvailableQuantity);
            this.Controls.Add(this.txtInventorySearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddQuantity;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.DataGridView dgvInventoryItems;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddToInventory;
        private System.Windows.Forms.Label lblAddQuantity;
        private System.Windows.Forms.TextBox txtAvailableQuantity;
        private System.Windows.Forms.Label lblAvailableQuantity;
        private System.Windows.Forms.TextBox txtInventorySearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label label1;
    }
}