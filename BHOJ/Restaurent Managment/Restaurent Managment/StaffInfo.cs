using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurent_Managment
{
    public partial class StaffInfo : Form
    {
        UserDetails user = new UserDetails();

        string oldName;

        public DataAccess Da { get; set; }
        public StaffInfo(UserDetails user)
        {
            this.Da = new DataAccess();
            InitializeComponent();
            this.PopulateGridView();
            this.user = user;
        }

        private void PopulateGridView(string sql = "select * from CashierUpdateInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvList.AutoGenerateColumns = true;
            this.dgvList.DataSource = ds.Tables[0];
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtID.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                 string.IsNullOrEmpty(this.txtNumber.Text) || string.IsNullOrEmpty(this.txtAddress.Text) ||
                string.IsNullOrEmpty(this.cmbRole.Text))
                return false;
            else
                return true;
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurent_ManagmentDataSet1.CashierUpdateInfo' table. You can move, or remove it, as needed.
            this.cashierUpdateInfoTableAdapter.Fill(this.restaurent_ManagmentDataSet1.CashierUpdateInfo);

        }
        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtNumber.Clear();
            this.txtAddress.Text = "";
            this.cmbRole.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvList.CurrentRow != null)
            {
                this.oldName = this.dgvList.CurrentRow.Cells[0].Value.ToString(); 
                this.txtName.Text = this.dgvList.CurrentRow.Cells[0].Value.ToString();
                this.txtID.Text = this.dgvList.CurrentRow.Cells[2].Value.ToString();
                this.txtNumber.Text = this.dgvList.CurrentRow.Cells[3].Value.ToString();
                this.txtAddress.Text = this.dgvList.CurrentRow.Cells[4].Value.ToString();
                this.cmbRole.Text = this.dgvList.CurrentRow.Cells[1].Value.ToString();
                var ds = this.Da.ExecuteQuery($"select * from LoginList where UserName = '{oldName}';");
                this.txtPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
            }
        }

        private void btnSUIback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AdminInterface(user).Visible = true;
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from CashierUpdateInfo where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var email = this.dgvList.CurrentRow.Cells[2].Value.ToString();
                var name = this.dgvList.CurrentRow.Cells[0].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from CashierUpdateInfo where Email = '" + email + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                if (string.IsNullOrEmpty(oldName))
                {
                    MessageBox.Show("Please select a staff member to update.");
                    return;
                }

                var query = $"select * from CashierUpdateInfo where Name = '{oldName}';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // update
                    var sql = $@"update CashierUpdateInfo
                                set Name = '{this.txtName.Text}',
                                ContactNo = '{this.txtNumber.Text}',
                                Address = '{this.txtAddress.Text}',
                                Gender = '{this.cmbRole.Text}',
                                Email = '{this.txtID.Text}'
                                where Name = '{oldName}'";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    var sql1 = $@"update LoginList
                               set UserName = '{this.txtName.Text}',
                                Password = '{this.txtPassword.Text}'
                               where UserName = '{oldName}'";
                    var count2 = this.Da.ExecuteDMLQuery(sql1);

                    if (count == 1 && count2 == 1)
                        MessageBox.Show("Record has been updated in the list");
                    else
                        MessageBox.Show("Record hasn't been updated in the list");
                }
                else
                {
                    MessageBox.Show("An error has occurred in the system, please try again.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave() || string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from CashierUpdateInfo where Name = '" + this.txtName.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("An user with this user name already exists!\nPlease select another username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    var sql = "insert into CashierUpdateInfo values('" + this.txtName.Text + "'," +
                        " '" + this.cmbRole.Text + "'," +
                        " '" + this.txtID.Text + "'," +
                        " ' " + this.txtNumber.Text + "'," +
                        " '" + this.txtAddress.Text + "'); ";
                    var count = this.Da.ExecuteDMLQuery(sql);
                    var sql1 = "insert into LoginList values('" + this.txtName.Text + "'," +
                        " '" + this.txtPassword.Text + "', 'Cashier'); ";
                    var count2 = this.Da.ExecuteDMLQuery(sql1);

                    if (count == 1)
                        MessageBox.Show("New record has been added in the list");
                    else
                        MessageBox.Show("New record hasn't been added in the list");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Phone number must be digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }));
                return;
            }

            if (char.IsDigit(e.KeyChar) && txtNumber.Text.Length >= 11)
            {
                e.Handled = true;
                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Phone number must be exactly 11 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }));
            }
        }
    }
}
