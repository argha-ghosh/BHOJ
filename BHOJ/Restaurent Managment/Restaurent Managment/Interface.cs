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
    public partial class Interface : Form
    {
        UserDetails user = new UserDetails();

        public Interface(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void pbPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();
        }

        private void lblPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();
        }

        private void pnlPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();
        }

        private void pbUpdateInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierUpdate GoStaffUpdatePage = new CashierUpdate(user);
            GoStaffUpdatePage.Show();
        }

        private void pnlUpdateInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierUpdate GoStaffUpdatePage = new CashierUpdate(user);
            GoStaffUpdatePage.Show();
        }

        private void lblUpdateInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierUpdate GoStaffUpdatePage = new CashierUpdate(user);
            GoStaffUpdatePage.Show();
        }

        private void pbAddToInventory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inventory GoIn = new Inventory(user);
            GoIn.Show();
        }

        private void pnlAddToInventory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inventory GoIn = new Inventory(user);
            GoIn.Show();
        }

        private void lblAddToInventory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inventory GoIn = new Inventory(user);
            GoIn.Show();
        }

        private void pbCLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogIn GoLI = new LogIn(user);
            GoLI.Show();
        }

        private void pnlLogOut_Click(object sender, EventArgs e)
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
    }
}
