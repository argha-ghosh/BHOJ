using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurent_Managment
{
    public partial class LogIn : Form
    {
        public UserDetails user = new UserDetails();

        private DataAccess Da { get; set; }
        public LogIn(UserDetails user)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.user = user ?? new UserDetails();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            panelLogIn.BackColor = Color.FromArgb(100, 50, 50, 50);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT * FROM LoginList WHERE Username = '" + this.txtLogInEmail.Text + "' AND Password = '" + this.txtLogInPass.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var name = ds.Tables[0].Rows[0][0].ToString();
                    user.UserName = name;
                    var role = ds.Tables[0].Rows[0][2].ToString().ToLower();
                    user.UserRole = role;

                    this.Visible = false;

                    if (role == "cashier")
                    {
                        new Interface(user).Visible = true;
                    }
                    else if (role == "admin")
                    {
                        new AdminInterface(user).Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username and password", "BHOJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogInEmail.Clear();
                    txtLogInPass.Clear();
                    txtLogInEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtLogInPass.UseSystemPasswordChar = false;
            }

            else
            {
                txtLogInPass.UseSystemPasswordChar = true;
            }
        }
    }
}
