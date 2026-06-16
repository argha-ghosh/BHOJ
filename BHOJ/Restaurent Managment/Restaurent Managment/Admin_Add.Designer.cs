namespace Restaurent_Managment
{
    partial class Admin_Add_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Add_Category));
            this.txtbxSrch = new System.Windows.Forms.TextBox();
            this.txtbxEntrCtgryNm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnDlt = new System.Windows.Forms.Button();
            this.bttnUpdt = new System.Windows.Forms.Button();
            this.bttnClr = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxSrch
            // 
            this.txtbxSrch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSrch.Location = new System.Drawing.Point(98, 60);
            this.txtbxSrch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxSrch.Name = "txtbxSrch";
            this.txtbxSrch.Size = new System.Drawing.Size(158, 29);
            this.txtbxSrch.TabIndex = 0;
            this.txtbxSrch.TextChanged += new System.EventHandler(this.txtbxSrch_TextChanged);
            this.txtbxSrch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSrch_KeyPress);
            // 
            // txtbxEntrCtgryNm
            // 
            this.txtbxEntrCtgryNm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEntrCtgryNm.Location = new System.Drawing.Point(37, 158);
            this.txtbxEntrCtgryNm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxEntrCtgryNm.Name = "txtbxEntrCtgryNm";
            this.txtbxEntrCtgryNm.Size = new System.Drawing.Size(203, 29);
            this.txtbxEntrCtgryNm.TabIndex = 1;
            this.txtbxEntrCtgryNm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxEntrCtgryNm_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Category Naame";
            // 
            // bttnDlt
            // 
            this.bttnDlt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bttnDlt.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDlt.Location = new System.Drawing.Point(216, 302);
            this.bttnDlt.Name = "bttnDlt";
            this.bttnDlt.Size = new System.Drawing.Size(99, 34);
            this.bttnDlt.TabIndex = 82;
            this.bttnDlt.Text = "Delete";
            this.bttnDlt.UseVisualStyleBackColor = false;
            this.bttnDlt.Click += new System.EventHandler(this.bttnDlt_Click);
            // 
            // bttnUpdt
            // 
            this.bttnUpdt.BackColor = System.Drawing.Color.DarkViolet;
            this.bttnUpdt.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdt.Location = new System.Drawing.Point(37, 302);
            this.bttnUpdt.Name = "bttnUpdt";
            this.bttnUpdt.Size = new System.Drawing.Size(91, 34);
            this.bttnUpdt.TabIndex = 81;
            this.bttnUpdt.Text = "Update";
            this.bttnUpdt.UseVisualStyleBackColor = false;
            this.bttnUpdt.Click += new System.EventHandler(this.bttnUpdt_Click);
            // 
            // bttnClr
            // 
            this.bttnClr.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnClr.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClr.Location = new System.Drawing.Point(216, 236);
            this.bttnClr.Name = "bttnClr";
            this.bttnClr.Size = new System.Drawing.Size(99, 34);
            this.bttnClr.TabIndex = 80;
            this.bttnClr.Text = "Clear";
            this.bttnClr.UseVisualStyleBackColor = false;
            this.bttnClr.Click += new System.EventHandler(this.bttnClr_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnAdd.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.Location = new System.Drawing.Point(37, 236);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(91, 34);
            this.bttnAdd.TabIndex = 79;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Olive;
            this.btnBack.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(568, 347);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 34);
            this.btnBack.TabIndex = 83;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(309, 276);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "Add Category To The Inventory";
            // 
            // Admin_Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bttnDlt);
            this.Controls.Add(this.bttnUpdt);
            this.Controls.Add(this.bttnClr);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxEntrCtgryNm);
            this.Controls.Add(this.txtbxSrch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_Add_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Add_Category";
            this.Load += new System.EventHandler(this.Admin_Add_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxSrch;
        private System.Windows.Forms.TextBox txtbxEntrCtgryNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnDlt;
        private System.Windows.Forms.Button bttnUpdt;
        private System.Windows.Forms.Button bttnClr;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
    }
}