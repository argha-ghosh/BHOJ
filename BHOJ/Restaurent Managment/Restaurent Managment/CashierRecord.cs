using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurent_Managment
{
    public partial class CashierRecord : Form
    {
        public DataAccess Da { get; set; }

        UserDetails user = new UserDetails();
        public CashierRecord(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from ProductHistory;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void CashierRecord_Load(object sender, EventArgs e)
        {
            try
            {
                restaurent_ManagmentDataSet2.EnforceConstraints = false;
                restaurent_ManagmentDataSet2.EnforceConstraints = false;
                this.productHistoryTableAdapter.Fill(this.restaurent_ManagmentDataSet2.ProductHistory);

                foreach (DataRow row in restaurent_ManagmentDataSet2.ProductHistory.Rows)
                {
                    foreach (DataColumn col in restaurent_ManagmentDataSet2.ProductHistory.Columns)
                    {
                        if (!col.AllowDBNull && row.IsNull(col))
                            MessageBox.Show($"Null value in non-nullable column: {col.ColumnName}");

                        if (col.DataType == typeof(string) && row[col] != DBNull.Value && col.MaxLength > 0)
                        {
                            string value = row[col].ToString();
                            if (value.Length > col.MaxLength)
                                MessageBox.Show($"Value too long in column: {col.ColumnName}, Value: {value}");
                        }
                    }
                }

                restaurent_ManagmentDataSet2.EnforceConstraints = true;
                restaurent_ManagmentDataSet2.EnforceConstraints = true; 
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Constraint violation: " + ex.Message);
            }
        }

        private void btnCRBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AdminInterface(user).Visible = true;
        }

        private void btnOverAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtSearch.Clear();
                this.PopulateGridView();
               // this.DataSorting("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went Wrong:" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("You must select an Order");
            }
        }

        /*private void DataSorting(string activity)
        {
            string sortOption = "";
            string condition = activity;
            if (this.cobSortOption.SelectedItem != null && this.cobSortOption.SelectedItem.Equals("Default"))
            {
                sortOption = "";
            }
            else if (this.cobSortOption.SelectedItem != null && this.cobSortOption.SelectedItem.Equals("Alphabetical"))
            {
                sortOption = "order by name";
            }
          
            var query = @"select * from ProductHistory
                         where " + condition + " (name like '%" + this.txtSearch.Text + "%' or entered_by like '%" + this.txtSearch.Text + "%' ) " + sortOption + ";";
            this.PopulateGridView(query);
        }*/

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = @"select * from ProductHistory
                         where entered_by like '%" + this.txtSearch.Text + "%' or name like '%" + this.txtSearch.Text + "%';";
                this.PopulateGridView(query);
               // this.DataSorting("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went Wrong:" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
