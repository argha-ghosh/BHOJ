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
    public partial class UpdateAdminInfo : Form
    {
        UserDetails user = new UserDetails();

        private DataAccess da = new DataAccess();

        public string gender;

        public UpdateAdminInfo(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UpdateAdminInfo_Load(object sender, EventArgs e)
        {
            var row = da.GetAdminInfo(user.UserName);
            if (row != null)
            {
                txtSUIname.Text = row["Name"].ToString();
                txtSUIemail.Text = row["Email"].ToString();
                txtSUIcontactno.Text = row["ContactNo"].ToString();
                txtSUIaddress.Text = row["Address"].ToString();
                gender = row["Gender"].ToString();
                rdbSUImale.Checked = gender == "Male";
                rdbSUIfemale.Checked = gender == "Female";

                
                    var ds = this.da.ExecuteQuery($"select * from LoginList where UserName = '{user.UserName}';");
                    this.txtNewPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
            }
            else
            {
                MessageBox.Show("Staff data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtSUIname.Text) || string.IsNullOrEmpty(this.txtSUIemail.Text) ||
                 string.IsNullOrEmpty(this.txtSUIcontactno.Text) || string.IsNullOrEmpty(this.txtSUIaddress.Text) ||
                string.IsNullOrEmpty(this.gender))
                return false;
            else
                return true;
        }

        private void btnSUIupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave() && string.IsNullOrEmpty(this.txtNewPassword.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = $"select * from AdminTable where Name = '{user.UserName}';";
                var ds = this.da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // update
                    var sql = $@"update AdminTable
                                set Name = '{this.txtSUIname.Text}',
                                ContactNo = '{this.txtSUIcontactno.Text}',
                                Address = '{this.txtSUIaddress.Text}',
                                Gender = '{this.gender}',
                                Email = '{this.txtSUIemail.Text}'
                                where Name = '{user.UserName}'";
                    this.da.ExecuteDMLQuery(sql);

                    var sql1 = $@"update LoginList
                               set UserName = '{user.UserName}',
                                Password = '{this.txtNewPassword.Text}'
                               where UserName = '{user.UserName}'";
                    this.da.ExecuteDMLQuery(sql1);
                }
                else
                {
                    MessageBox.Show("An error has occurred in the system, please try again.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }

            if (!Regex.IsMatch(txtSUIname.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Cashier name contains only letters and spaces.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtSUIemail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtSUIcontactno.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Contact number must be exactly 11 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSUIname.Text) || string.IsNullOrWhiteSpace(txtSUIemail.Text))
            {
                MessageBox.Show("Please enter Name and Email!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdbSUImale.Checked && !rdbSUIfemale.Checked)
            {
                MessageBox.Show("Please select Gender!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gender = rdbSUImale.Checked ? "Male" : "Female";
            bool updated = da.UpdateAdminInfo(
                txtSUIname.Text,
                gender,
                txtSUIemail.Text,
                txtSUIcontactno.Text,
                txtSUIaddress.Text
            );
            if (updated)
                MessageBox.Show("Admin information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update failed. No record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSUIback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface GoBackAI = new AdminInterface(user);
            GoBackAI.Show();
        }

        private void txtSUIcontactno_KeyPress(object sender, KeyPressEventArgs e)
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

            if (char.IsDigit(e.KeyChar) && txtSUIcontactno.Text.Length >= 11)
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
