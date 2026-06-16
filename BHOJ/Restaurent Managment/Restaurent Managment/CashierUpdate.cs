using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurent_Managment
{
    public partial class CashierUpdate : Form
    {
        UserDetails user = new UserDetails();


        private DataAccess da = new DataAccess();

        public CashierUpdate(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void StaffUpdate_Load(object sender, EventArgs e)
        {
            var row = da.GetStaffInfo(user.UserName);
            if (row != null)
            {
                txtSUIname.Text = row["Name"].ToString();
                txtSUIemail.Text = row["Email"].ToString();
                txtSUIcontactno.Text = row["ContactNo"].ToString();
                txtSUIaddress.Text = row["Address"].ToString();
                string gender = row["Gender"].ToString();
                rdbSUImale.Checked = gender == "Male";
                rdbSUIfemale.Checked = gender == "Female";
            }
            else
            {
                MessageBox.Show("Staff data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSUIupdate_Click(object sender, EventArgs e)
        {
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
            bool updated = da.UpdateStaffInfo(
                txtSUIname.Text,
                gender,
                txtSUIemail.Text,
                txtSUIcontactno.Text,
                txtSUIaddress.Text
            );
            if (updated)
                MessageBox.Show("Staff information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update failed. No record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSUIback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface GoBack = new Interface(user);
            GoBack.Show();
        }

        private void btnSUIlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Log out?", "Blood Bank Bangladesh", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LogIn GoBack = new LogIn(user);
                GoBack.Visible = true;
            }
            else
            {
                //Do nothing. Stay on the same screen.
            }
        }

        private void txtSUIname_KeyPress(object sender, KeyPressEventArgs e)
        {

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
