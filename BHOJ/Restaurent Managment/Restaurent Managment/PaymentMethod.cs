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
    public partial class PaymentMethod : Form
    {
        UserDetails user = new UserDetails();

        CustomerPaymentMethod payM = new CustomerPaymentMethod();

        public PaymentMethod(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
            this.Load += PaymentMethod_Load;
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {
            rdbCardPayment.Checked = false;
            rdbMobileBanking.Checked = false;
            Shown += (s, args) => 
            {
                rdbCardPayment.Checked = false;
                rdbMobileBanking.Checked = false;
                rdbPayByCash.Checked = false;
            };
            rdbPayByCash.Checked = false;
        }

        private void btnViewCartPayM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ViewCart GoViewCartPage = new ViewCart(user);
            GoViewCartPage.Show();
        }

        private void btnCancelOrderPayM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();

            CartManager.CartItems.Clear(); 
        }

        private void btnProceedPayM_Click(object sender, EventArgs e)
        {
            if (rdbPayByCash.Checked)
            {
                payM.PaymentMethod = "Pay by Cash";
                this.Visible = false;
                ConfirmOrder confirmOrder = new ConfirmOrder(user, payM);
                confirmOrder.Show();
            }
            else if (rdbCardPayment.Checked)
            {
                DialogResult result = MessageBox.Show("Card Payment selected. Implement navigation as needed.", "Proceed payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    payM.PaymentMethod = "Card Payment";
                    this.Visible = false;
                    ConfirmOrder GoTo = new ConfirmOrder(user, payM);
                    GoTo.Visible = true;
                }
                else
                {
                    //Do nothing. Stay on the same screen.
                }
            }
            else if (rdbMobileBanking.Checked)
            {
                payM.PaymentMethod = "Mobile Banking";
                this.Visible = false;
                CashierMobilePayment GoToMobilePayment = new CashierMobilePayment(user, payM);
                GoToMobilePayment.Show();
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddMorePayM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoToCO = new CashierOrder(user);
            GoToCO.Show();
        }

        private void rdbCardPayment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbMobileBanking_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
