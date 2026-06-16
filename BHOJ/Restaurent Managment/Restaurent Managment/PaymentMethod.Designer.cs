namespace Restaurent_Managment
{
    partial class PaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewCartPayM = new System.Windows.Forms.Button();
            this.btnProceedPayM = new System.Windows.Forms.Button();
            this.btnAddMorePayM = new System.Windows.Forms.Button();
            this.btnCancelOrderPayM = new System.Windows.Forms.Button();
            this.rdbMobileBanking = new System.Windows.Forms.RadioButton();
            this.rdbCardPayment = new System.Windows.Forms.RadioButton();
            this.rdbPayByCash = new System.Windows.Forms.RadioButton();
            this.lblAddToInventory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnViewCartPayM
            // 
            this.btnViewCartPayM.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnViewCartPayM.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCartPayM.Location = new System.Drawing.Point(586, 276);
            this.btnViewCartPayM.Name = "btnViewCartPayM";
            this.btnViewCartPayM.Size = new System.Drawing.Size(99, 34);
            this.btnViewCartPayM.TabIndex = 39;
            this.btnViewCartPayM.Text = "View Cart";
            this.btnViewCartPayM.UseVisualStyleBackColor = false;
            this.btnViewCartPayM.Click += new System.EventHandler(this.btnViewCartPayM_Click);
            // 
            // btnProceedPayM
            // 
            this.btnProceedPayM.BackColor = System.Drawing.Color.Olive;
            this.btnProceedPayM.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedPayM.Location = new System.Drawing.Point(586, 375);
            this.btnProceedPayM.Name = "btnProceedPayM";
            this.btnProceedPayM.Size = new System.Drawing.Size(99, 34);
            this.btnProceedPayM.TabIndex = 38;
            this.btnProceedPayM.Text = "Proceed";
            this.btnProceedPayM.UseVisualStyleBackColor = false;
            this.btnProceedPayM.Click += new System.EventHandler(this.btnProceedPayM_Click);
            // 
            // btnAddMorePayM
            // 
            this.btnAddMorePayM.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddMorePayM.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMorePayM.Location = new System.Drawing.Point(586, 326);
            this.btnAddMorePayM.Name = "btnAddMorePayM";
            this.btnAddMorePayM.Size = new System.Drawing.Size(99, 34);
            this.btnAddMorePayM.TabIndex = 37;
            this.btnAddMorePayM.Text = "Add More";
            this.btnAddMorePayM.UseVisualStyleBackColor = false;
            this.btnAddMorePayM.Click += new System.EventHandler(this.btnAddMorePayM_Click);
            // 
            // btnCancelOrderPayM
            // 
            this.btnCancelOrderPayM.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelOrderPayM.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrderPayM.Location = new System.Drawing.Point(390, 375);
            this.btnCancelOrderPayM.Name = "btnCancelOrderPayM";
            this.btnCancelOrderPayM.Size = new System.Drawing.Size(131, 34);
            this.btnCancelOrderPayM.TabIndex = 36;
            this.btnCancelOrderPayM.Text = "Cancel Order";
            this.btnCancelOrderPayM.UseVisualStyleBackColor = false;
            this.btnCancelOrderPayM.Click += new System.EventHandler(this.btnCancelOrderPayM_Click);
            // 
            // rdbMobileBanking
            // 
            this.rdbMobileBanking.AutoSize = true;
            this.rdbMobileBanking.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMobileBanking.Location = new System.Drawing.Point(390, 254);
            this.rdbMobileBanking.Name = "rdbMobileBanking";
            this.rdbMobileBanking.Size = new System.Drawing.Size(147, 23);
            this.rdbMobileBanking.TabIndex = 35;
            this.rdbMobileBanking.TabStop = true;
            this.rdbMobileBanking.Text = "Mobile Banking";
            this.rdbMobileBanking.UseVisualStyleBackColor = true;
            this.rdbMobileBanking.CheckedChanged += new System.EventHandler(this.rdbMobileBanking_CheckedChanged);
            // 
            // rdbCardPayment
            // 
            this.rdbCardPayment.AutoSize = true;
            this.rdbCardPayment.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCardPayment.Location = new System.Drawing.Point(390, 210);
            this.rdbCardPayment.Name = "rdbCardPayment";
            this.rdbCardPayment.Size = new System.Drawing.Size(133, 23);
            this.rdbCardPayment.TabIndex = 34;
            this.rdbCardPayment.TabStop = true;
            this.rdbCardPayment.Text = "Card Payment";
            this.rdbCardPayment.UseVisualStyleBackColor = true;
            this.rdbCardPayment.CheckedChanged += new System.EventHandler(this.rdbCardPayment_CheckedChanged);
            // 
            // rdbPayByCash
            // 
            this.rdbPayByCash.AutoSize = true;
            this.rdbPayByCash.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPayByCash.Location = new System.Drawing.Point(390, 166);
            this.rdbPayByCash.Name = "rdbPayByCash";
            this.rdbPayByCash.Size = new System.Drawing.Size(123, 23);
            this.rdbPayByCash.TabIndex = 33;
            this.rdbPayByCash.TabStop = true;
            this.rdbPayByCash.Text = "Pay By Cash";
            this.rdbPayByCash.UseVisualStyleBackColor = true;
            // 
            // lblAddToInventory
            // 
            this.lblAddToInventory.AutoSize = true;
            this.lblAddToInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblAddToInventory.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToInventory.Location = new System.Drawing.Point(386, 125);
            this.lblAddToInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddToInventory.Name = "lblAddToInventory";
            this.lblAddToInventory.Size = new System.Drawing.Size(166, 22);
            this.lblAddToInventory.TabIndex = 32;
            this.lblAddToInventory.Text = "Payment Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "Payment Methods For Customer";
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewCartPayM);
            this.Controls.Add(this.btnProceedPayM);
            this.Controls.Add(this.btnAddMorePayM);
            this.Controls.Add(this.btnCancelOrderPayM);
            this.Controls.Add(this.rdbMobileBanking);
            this.Controls.Add(this.rdbCardPayment);
            this.Controls.Add(this.rdbPayByCash);
            this.Controls.Add(this.lblAddToInventory);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMethod";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewCartPayM;
        private System.Windows.Forms.Button btnProceedPayM;
        private System.Windows.Forms.Button btnAddMorePayM;
        private System.Windows.Forms.Button btnCancelOrderPayM;
        private System.Windows.Forms.RadioButton rdbMobileBanking;
        private System.Windows.Forms.RadioButton rdbCardPayment;
        private System.Windows.Forms.RadioButton rdbPayByCash;
        private System.Windows.Forms.Label lblAddToInventory;
        private System.Windows.Forms.Label label1;
    }
}