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
    public partial class ConfirmOrder : Form
    {
        UserDetails user = new UserDetails();

        CustomerPaymentMethod payM = new CustomerPaymentMethod();

        public DataAccess da { get; set; }

        public ConfirmOrder(UserDetails user, CustomerPaymentMethod payM)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.user = user;
            this.payM = payM;
        }

        private void ConfirmOrder_Load(object sender, EventArgs e)
        {
            dgvCashierViewCart.DataSource = null;
            dgvCashierViewCart.DataSource = CartManager.CartItems.Select(item => new
            {
                item.Category,
                item.ItemName,
                item.Quantity,
                item.Price,
                item.Vat
            }).ToList();

            decimal totalPrice = CartManager.CartItems.Sum(item => item.Price);
            decimal roundedPrice = Math.Round(totalPrice, 0, MidpointRounding.AwayFromZero);
            lblPayAbleAmount.Text = roundedPrice.ToString("0");

            if (payM.PaymentMethod == "Pay by Cash")
            {
                lblCusA.Visible = true;
                txtCustomerAmount.Visible = true;
                txtCustomerAmount.Enabled = true;
                lblChA.Visible = true;
                lblChangeAmount.Visible = true;

                txtCustomerAmount.Focus();
            }

            foreach (var item in CartManager.CartItems) 
            {
                da.UpdateInventoryQuantity(item.Category, item.ItemName, -item.Quantity); 
            }
        }

        private void txtCustomerAmount_TextChanged(object sender, EventArgs e)
        {
            decimal payableAmount, customerAmount, changeAmount;

            if (!decimal.TryParse(lblPayAbleAmount.Text, out payableAmount))
            {
                lblChangeAmount.Text = "0";
                return;
            }

            if (!decimal.TryParse(txtCustomerAmount.Text, out customerAmount))
            {
                lblChangeAmount.Text = "0";
                return;
            }

            changeAmount = customerAmount - payableAmount;
            lblChangeAmount.Text = changeAmount.ToString("0.##");
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Order Confirmed Successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(MessageBox.Show("Do you want to confirm the order?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                decimal totalPrice = CartManager.CartItems.Sum(item => item.Price);
                decimal roundedPrice = Math.Round(totalPrice, 0, MidpointRounding.AwayFromZero);

                // Insert each cart item into producthistorytable
                foreach (var item in CartManager.CartItems)
                {
                    string sql = @"INSERT INTO ProductHistory (entered_by, name, activity, unit, total_value)
               VALUES (@entered_by, @name, 'Sold', @unit, @total_value)";


                    using (SqlCommand cmd = new SqlCommand(sql, da.Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@entered_by", user.UserName);
                        cmd.Parameters.AddWithValue("@name", item.ItemName);
                        cmd.Parameters.AddWithValue("@unit", item.Quantity);
                        cmd.Parameters.AddWithValue("@total_value", roundedPrice);


                        if (da.Sqlcon.State != ConnectionState.Open)
                            da.Sqlcon.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order confirmed and saved to history!");

                CartManager.CartItems.Clear();
                this.Close();
            }

            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();

            CartManager.CartItems.Clear();
        }

        private void btnCancelOrderConfirmOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();

            CartManager.CartItems.Clear(); 

        }

        private void txtCustomerAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Given ammount must be digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }));
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentMethod GoBackPM = new  PaymentMethod(user);
            GoBackPM.Show();
        }
    }
}
