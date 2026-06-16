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
    public partial class CashierMobilePayment : Form
    {
        UserDetails user = new UserDetails();

        CustomerPaymentMethod payM = new CustomerPaymentMethod();

        public CashierMobilePayment(UserDetails user, CustomerPaymentMethod payM)
        {
            InitializeComponent();
            this.user = user;
            this.Load += CashierMobilePayment_Load;
            this.payM = payM;
        }

        private void btnAddMoreMobileM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoToCO = new CashierOrder(user);
            GoToCO.Show();
        }

        private void btnViewCartMobileM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ViewCart GoViewCartPage = new ViewCart(user);
            GoViewCartPage.Show();
        }

        private void btnCancelOrderMobileM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();

            CartManager.CartItems.Clear();
        }

        private void CashierMobilePayment_Load(object sender, EventArgs e)
        {
            rdbBkash.Checked = false;
            rdbNagad.Checked = false;
            Shown += (s, args) =>
            {
                rdbBkash.Checked = false;
                rdbNagad.Checked = false;
                rdbRocket.Checked = false;
            };
            rdbRocket.Checked = false;
        }

        private void btnProceedMobileM_Click(object sender, EventArgs e)
        {
            if (rdbBkash.Checked)
            {
                DialogResult result = MessageBox.Show("Bkash Payment selected. Ask customer to scan.", "Proceed payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    payM.PaymentMedium = "Bkash";
                    this.Visible = false;
                    ConfirmOrder GoToB = new ConfirmOrder(user, payM);
                    GoToB.Visible = true;
                }
                else
                {
                    //Do nothing. Stay on the same screen.
                }
            }
            else if (rdbNagad.Checked)
            {
                DialogResult result = MessageBox.Show("Nagad Payment selected. Ask customer to scan.", "Proceed payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    payM.PaymentMedium = "Nagad";
                    this.Visible = false;
                    ConfirmOrder GoToN = new ConfirmOrder(user, payM);
                    GoToN.Visible = true;
                }
                else
                {
                    //Do nothing. Stay on the same screen.
                }
            }
            else if (rdbRocket.Checked)
            {
                DialogResult result = MessageBox.Show("Rocket payment selected. Ask customer to scan.", "Proceed payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK )
                {
                    payM.PaymentMedium = "Rocket";
                    this.Visible = false;
                    ConfirmOrder GoToR = new ConfirmOrder(user, payM);
                    GoToR.Show(); 
                }
                else
                {
                    //Do nothing. Stay on the same screen.
                }
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentMethod GoBackPM = new PaymentMethod(user);
            GoBackPM.Show();
        }
    }
}
