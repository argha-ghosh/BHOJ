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
    public partial class AdminInterface : Form
    {
        UserDetails user = new UserDetails();

        public AdminInterface(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void pbStaffInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StaffInfo GoSI = new StaffInfo(user);
            GoSI.Show();
        }

        private void lblStaffInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StaffInfo GoSI = new StaffInfo(user);
            GoSI.Show();
        }

        private void pnlStaffInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StaffInfo GoSI = new StaffInfo(user);
            GoSI.Show();
        }

        private void lblUpdateOwnInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateAdminInfo GoUAI = new UpdateAdminInfo(user);
            GoUAI.Show();
        }

        private void pbUpdateOwnInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateAdminInfo GoUAI = new UpdateAdminInfo(user);
            GoUAI.Show();
        }

        private void pnlUpdateOwnInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateAdminInfo GoUAI = new UpdateAdminInfo(user);
            GoUAI.Show();
        }

        private void pnlLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogIn GoLI = new LogIn(user);
            GoLI.Show();
        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogIn GoLI = new LogIn(user);
            GoLI.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogIn GoLI = new LogIn(user);
            GoLI.Show();
        }

        private void pbUpdateMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateMenu GoUM = new UpdateMenu(user);
            GoUM.Show();
        }

        private void pnlUpdateMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateMenu GoUM = new UpdateMenu(user);
            GoUM.Show();
        }

        private void lblUpdateMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateMenu GoUM = new UpdateMenu(user);
            GoUM.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierRecord GoCR = new CashierRecord(user);
            GoCR.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierRecord GoCR = new CashierRecord(user);
            GoCR.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierRecord GoCR = new CashierRecord(user);
            GoCR.Show();
        }
    }
}
