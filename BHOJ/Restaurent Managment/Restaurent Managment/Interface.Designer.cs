namespace Restaurent_Managment
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.pnltrash = new System.Windows.Forms.Panel();
            this.pnlAddToInventory = new System.Windows.Forms.Panel();
            this.lblAddToInventory = new System.Windows.Forms.Label();
            this.pnltrash2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPlaceOrder = new System.Windows.Forms.Panel();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUpdateInfo = new System.Windows.Forms.Panel();
            this.lblUpdateInfo = new System.Windows.Forms.Label();
            this.pnlLogOut = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pbCLogOut = new System.Windows.Forms.PictureBox();
            this.pbPlaceOrder = new System.Windows.Forms.PictureBox();
            this.pbUpdateInfo = new System.Windows.Forms.PictureBox();
            this.pbAddToInventory = new System.Windows.Forms.PictureBox();
            this.pnlAddToInventory.SuspendLayout();
            this.pnltrash2.SuspendLayout();
            this.pnlPlaceOrder.SuspendLayout();
            this.pnlUpdateInfo.SuspendLayout();
            this.pnlLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddToInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltrash
            // 
            this.pnltrash.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnltrash.Location = new System.Drawing.Point(-2, 0);
            this.pnltrash.Margin = new System.Windows.Forms.Padding(2);
            this.pnltrash.Name = "pnltrash";
            this.pnltrash.Size = new System.Drawing.Size(336, 551);
            this.pnltrash.TabIndex = 0;
            // 
            // pnlAddToInventory
            // 
            this.pnlAddToInventory.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlAddToInventory.Controls.Add(this.lblAddToInventory);
            this.pnlAddToInventory.Controls.Add(this.pbAddToInventory);
            this.pnlAddToInventory.Location = new System.Drawing.Point(66, 133);
            this.pnlAddToInventory.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddToInventory.Name = "pnlAddToInventory";
            this.pnlAddToInventory.Size = new System.Drawing.Size(193, 112);
            this.pnlAddToInventory.TabIndex = 0;
            this.pnlAddToInventory.Click += new System.EventHandler(this.pnlAddToInventory_Click);
            // 
            // lblAddToInventory
            // 
            this.lblAddToInventory.AutoSize = true;
            this.lblAddToInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblAddToInventory.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToInventory.Location = new System.Drawing.Point(13, 77);
            this.lblAddToInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddToInventory.Name = "lblAddToInventory";
            this.lblAddToInventory.Size = new System.Drawing.Size(172, 22);
            this.lblAddToInventory.TabIndex = 3;
            this.lblAddToInventory.Text = "Add  to Inventory";
            this.lblAddToInventory.Click += new System.EventHandler(this.lblAddToInventory_Click);
            // 
            // pnltrash2
            // 
            this.pnltrash2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnltrash2.Controls.Add(this.pnlLogOut);
            this.pnltrash2.Controls.Add(this.label3);
            this.pnltrash2.Controls.Add(this.label1);
            this.pnltrash2.Controls.Add(this.pnlPlaceOrder);
            this.pnltrash2.Controls.Add(this.pnlUpdateInfo);
            this.pnltrash2.Controls.Add(this.pnlAddToInventory);
            this.pnltrash2.Location = new System.Drawing.Point(327, 0);
            this.pnltrash2.Margin = new System.Windows.Forms.Padding(2);
            this.pnltrash2.Name = "pnltrash2";
            this.pnltrash2.Size = new System.Drawing.Size(519, 551);
            this.pnltrash2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ask Customer To Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To Cashier Interface";
            // 
            // pnlPlaceOrder
            // 
            this.pnlPlaceOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlPlaceOrder.Controls.Add(this.lblPlaceOrder);
            this.pnlPlaceOrder.Controls.Add(this.pbPlaceOrder);
            this.pnlPlaceOrder.Controls.Add(this.label2);
            this.pnlPlaceOrder.Location = new System.Drawing.Point(66, 403);
            this.pnlPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlaceOrder.Name = "pnlPlaceOrder";
            this.pnlPlaceOrder.Size = new System.Drawing.Size(193, 112);
            this.pnlPlaceOrder.TabIndex = 2;
            this.pnlPlaceOrder.Click += new System.EventHandler(this.pnlPlaceOrder_Click);
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaceOrder.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(39, 74);
            this.lblPlaceOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(116, 22);
            this.lblPlaceOrder.TabIndex = 2;
            this.lblPlaceOrder.Text = "Place Order";
            this.lblPlaceOrder.Click += new System.EventHandler(this.lblPlaceOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 0;
            // 
            // pnlUpdateInfo
            // 
            this.pnlUpdateInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlUpdateInfo.Controls.Add(this.pbUpdateInfo);
            this.pnlUpdateInfo.Controls.Add(this.lblUpdateInfo);
            this.pnlUpdateInfo.Location = new System.Drawing.Point(66, 267);
            this.pnlUpdateInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpdateInfo.Name = "pnlUpdateInfo";
            this.pnlUpdateInfo.Size = new System.Drawing.Size(193, 112);
            this.pnlUpdateInfo.TabIndex = 1;
            this.pnlUpdateInfo.Click += new System.EventHandler(this.pnlUpdateInfo_Click);
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.AutoSize = true;
            this.lblUpdateInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateInfo.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInfo.Location = new System.Drawing.Point(33, 77);
            this.lblUpdateInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateInfo.Name = "lblUpdateInfo";
            this.lblUpdateInfo.Size = new System.Drawing.Size(121, 22);
            this.lblUpdateInfo.TabIndex = 0;
            this.lblUpdateInfo.Text = "Update Info";
            this.lblUpdateInfo.Click += new System.EventHandler(this.lblUpdateInfo_Click);
            // 
            // pnlLogOut
            // 
            this.pnlLogOut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlLogOut.Controls.Add(this.lblLogOut);
            this.pnlLogOut.Controls.Add(this.pbCLogOut);
            this.pnlLogOut.Location = new System.Drawing.Point(296, 133);
            this.pnlLogOut.Name = "pnlLogOut";
            this.pnlLogOut.Size = new System.Drawing.Size(193, 112);
            this.pnlLogOut.TabIndex = 5;
            this.pnlLogOut.Click += new System.EventHandler(this.pnlLogOut_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOut.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(52, 77);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(85, 22);
            this.lblLogOut.TabIndex = 4;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // pbCLogOut
            // 
            this.pbCLogOut.Image = global::Restaurent_Managment.Properties.Resources.log_out2;
            this.pbCLogOut.Location = new System.Drawing.Point(65, 14);
            this.pbCLogOut.Name = "pbCLogOut";
            this.pbCLogOut.Size = new System.Drawing.Size(54, 46);
            this.pbCLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCLogOut.TabIndex = 0;
            this.pbCLogOut.TabStop = false;
            this.pbCLogOut.Click += new System.EventHandler(this.pbCLogOut_Click);
            // 
            // pbPlaceOrder
            // 
            this.pbPlaceOrder.Image = global::Restaurent_Managment.Properties.Resources.menu;
            this.pbPlaceOrder.Location = new System.Drawing.Point(67, 12);
            this.pbPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlaceOrder.Name = "pbPlaceOrder";
            this.pbPlaceOrder.Size = new System.Drawing.Size(59, 51);
            this.pbPlaceOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlaceOrder.TabIndex = 1;
            this.pbPlaceOrder.TabStop = false;
            this.pbPlaceOrder.Click += new System.EventHandler(this.pbPlaceOrder_Click);
            // 
            // pbUpdateInfo
            // 
            this.pbUpdateInfo.Image = global::Restaurent_Managment.Properties.Resources.update;
            this.pbUpdateInfo.Location = new System.Drawing.Point(67, 12);
            this.pbUpdateInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pbUpdateInfo.Name = "pbUpdateInfo";
            this.pbUpdateInfo.Size = new System.Drawing.Size(59, 51);
            this.pbUpdateInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdateInfo.TabIndex = 1;
            this.pbUpdateInfo.TabStop = false;
            this.pbUpdateInfo.Click += new System.EventHandler(this.pbUpdateInfo_Click);
            // 
            // pbAddToInventory
            // 
            this.pbAddToInventory.Image = global::Restaurent_Managment.Properties.Resources.catering;
            this.pbAddToInventory.Location = new System.Drawing.Point(67, 14);
            this.pbAddToInventory.Margin = new System.Windows.Forms.Padding(2);
            this.pbAddToInventory.Name = "pbAddToInventory";
            this.pbAddToInventory.Size = new System.Drawing.Size(59, 51);
            this.pbAddToInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddToInventory.TabIndex = 1;
            this.pbAddToInventory.TabStop = false;
            this.pbAddToInventory.Click += new System.EventHandler(this.pbAddToInventory_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(844, 552);
            this.Controls.Add(this.pnltrash);
            this.Controls.Add(this.pnltrash2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Home Page";
            this.pnlAddToInventory.ResumeLayout(false);
            this.pnlAddToInventory.PerformLayout();
            this.pnltrash2.ResumeLayout(false);
            this.pnltrash2.PerformLayout();
            this.pnlPlaceOrder.ResumeLayout(false);
            this.pnlPlaceOrder.PerformLayout();
            this.pnlUpdateInfo.ResumeLayout(false);
            this.pnlUpdateInfo.PerformLayout();
            this.pnlLogOut.ResumeLayout(false);
            this.pnlLogOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddToInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltrash;
        private System.Windows.Forms.Panel pnlAddToInventory;
        private System.Windows.Forms.PictureBox pbAddToInventory;
        private System.Windows.Forms.Panel pnltrash2;
        private System.Windows.Forms.Panel pnlPlaceOrder;
        private System.Windows.Forms.PictureBox pbPlaceOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUpdateInfo;
        private System.Windows.Forms.PictureBox pbUpdateInfo;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.Label lblAddToInventory;
        private System.Windows.Forms.Label lblUpdateInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLogOut;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.PictureBox pbCLogOut;
    }
}