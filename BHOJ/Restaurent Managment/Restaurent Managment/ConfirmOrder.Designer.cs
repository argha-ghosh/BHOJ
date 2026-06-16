namespace Restaurent_Managment
{
    partial class ConfirmOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCusA = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnCancelOrderConfirmOrder = new System.Windows.Forms.Button();
            this.lblChA = new System.Windows.Forms.Label();
            this.lblAddToInventory = new System.Windows.Forms.Label();
            this.dgvCashierViewCart = new System.Windows.Forms.DataGridView();
            this.lblPayAbleAmount = new System.Windows.Forms.Label();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.txtCustomerAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashierViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 585);
            this.panel1.TabIndex = 2;
            // 
            // lblCusA
            // 
            this.lblCusA.BackColor = System.Drawing.Color.Transparent;
            this.lblCusA.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusA.Location = new System.Drawing.Point(475, 427);
            this.lblCusA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusA.Name = "lblCusA";
            this.lblCusA.Size = new System.Drawing.Size(173, 29);
            this.lblCusA.TabIndex = 34;
            this.lblCusA.Text = "Customer amount";
            this.lblCusA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCusA.Visible = false;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConfirmOrder.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(632, 524);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(99, 34);
            this.btnConfirmOrder.TabIndex = 33;
            this.btnConfirmOrder.Text = "Confirm";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnCancelOrderConfirmOrder
            // 
            this.btnCancelOrderConfirmOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelOrderConfirmOrder.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrderConfirmOrder.Location = new System.Drawing.Point(479, 524);
            this.btnCancelOrderConfirmOrder.Name = "btnCancelOrderConfirmOrder";
            this.btnCancelOrderConfirmOrder.Size = new System.Drawing.Size(127, 34);
            this.btnCancelOrderConfirmOrder.TabIndex = 32;
            this.btnCancelOrderConfirmOrder.Text = "Cancel Order";
            this.btnCancelOrderConfirmOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrderConfirmOrder.Click += new System.EventHandler(this.btnCancelOrderConfirmOrder_Click);
            // 
            // lblChA
            // 
            this.lblChA.AutoSize = true;
            this.lblChA.BackColor = System.Drawing.Color.Transparent;
            this.lblChA.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChA.Location = new System.Drawing.Point(475, 473);
            this.lblChA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChA.Name = "lblChA";
            this.lblChA.Size = new System.Drawing.Size(152, 22);
            this.lblChA.TabIndex = 31;
            this.lblChA.Text = "Change amount";
            this.lblChA.Visible = false;
            // 
            // lblAddToInventory
            // 
            this.lblAddToInventory.AutoSize = true;
            this.lblAddToInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblAddToInventory.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToInventory.Location = new System.Drawing.Point(475, 385);
            this.lblAddToInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddToInventory.Name = "lblAddToInventory";
            this.lblAddToInventory.Size = new System.Drawing.Size(156, 22);
            this.lblAddToInventory.TabIndex = 30;
            this.lblAddToInventory.Text = "Payable amount";
            // 
            // dgvCashierViewCart
            // 
            this.dgvCashierViewCart.AllowUserToAddRows = false;
            this.dgvCashierViewCart.AllowUserToDeleteRows = false;
            this.dgvCashierViewCart.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvCashierViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashierViewCart.Location = new System.Drawing.Point(398, 140);
            this.dgvCashierViewCart.Name = "dgvCashierViewCart";
            this.dgvCashierViewCart.ReadOnly = true;
            this.dgvCashierViewCart.Size = new System.Drawing.Size(552, 227);
            this.dgvCashierViewCart.TabIndex = 29;
            // 
            // lblPayAbleAmount
            // 
            this.lblPayAbleAmount.AutoSize = true;
            this.lblPayAbleAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPayAbleAmount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayAbleAmount.Location = new System.Drawing.Point(667, 380);
            this.lblPayAbleAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayAbleAmount.Name = "lblPayAbleAmount";
            this.lblPayAbleAmount.Size = new System.Drawing.Size(0, 24);
            this.lblPayAbleAmount.TabIndex = 35;
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeAmount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeAmount.Location = new System.Drawing.Point(666, 468);
            this.lblChangeAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(0, 27);
            this.lblChangeAmount.TabIndex = 36;
            this.lblChangeAmount.Visible = false;
            // 
            // txtCustomerAmount
            // 
            this.txtCustomerAmount.Enabled = false;
            this.txtCustomerAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAmount.Location = new System.Drawing.Point(653, 427);
            this.txtCustomerAmount.Name = "txtCustomerAmount";
            this.txtCustomerAmount.Size = new System.Drawing.Size(167, 29);
            this.txtCustomerAmount.TabIndex = 1;
            this.txtCustomerAmount.Visible = false;
            this.txtCustomerAmount.TextChanged += new System.EventHandler(this.txtCustomerAmount_TextChanged);
            this.txtCustomerAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 44);
            this.label3.TabIndex = 38;
            this.label3.Text = "BHOJ BILLING INVOICE";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Olive;
            this.btnBack.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(758, 524);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 34);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 586);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerAmount);
            this.Controls.Add(this.lblChangeAmount);
            this.Controls.Add(this.lblPayAbleAmount);
            this.Controls.Add(this.lblCusA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.dgvCashierViewCart);
            this.Controls.Add(this.btnCancelOrderConfirmOrder);
            this.Controls.Add(this.lblAddToInventory);
            this.Controls.Add(this.lblChA);
            this.Name = "ConfirmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmOrder";
            this.Load += new System.EventHandler(this.ConfirmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashierViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCusA;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnCancelOrderConfirmOrder;
        private System.Windows.Forms.Label lblChA;
        private System.Windows.Forms.Label lblAddToInventory;
        private System.Windows.Forms.DataGridView dgvCashierViewCart;
        private System.Windows.Forms.Label lblPayAbleAmount;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.TextBox txtCustomerAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}