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
    public partial class ViewCart : Form
    {
        UserDetails user = new UserDetails();
        private CartItem selectedCartItem = null;
        
        public DataAccess da { get; set; }
        public decimal UnitPrice { get; set; }


        public ViewCart(UserDetails user)
        {
            if (selectedCartItem != null)
            {
                //selectedCartItem.Quantity++;
                //selectedCartItem.Vat = selectedCartItem.Vat * selectedCartItem.Quantity;
                UpdateCartView();
            }
            InitializeComponent();
            this.da = new DataAccess();
            this.user = user;
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            dgvCashierViewCart.ClearSelection();
            dgvCashierViewCart.DataSource = null;
            dgvCashierViewCart.DataSource = CartManager.CartItems.Select(item => new
            {
                item.Category,
                item.ItemName,
                item.UnitPrice,
                item.Quantity,
                item.Price,
                item.Vat
            }).ToList();


            decimal totalPrice = CartManager.CartItems.Sum(item => item.Price);
            lbltotalPrice.Text = totalPrice.ToString("0.##");

            decimal roundedPrice = Math.Round(totalPrice, 0, MidpointRounding.AwayFromZero);
            lblRoundedPrice.Text = roundedPrice.ToString("0");
        }

        private void btnViewCartProceed_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            PaymentMethod GoPaymentMethodPage = new PaymentMethod(user);
            GoPaymentMethodPage.Show();
        }

        private void btnCancelOrderViewCart_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierPage = new CashierOrder(user);
            GoCashierPage.Show();

            CartManager.CartItems.Clear();

            if (CartManager.CartItems != null)
                CartManager.CartItems.Clear();

            dgvCashierViewCart.DataSource = null;

          
        }

        private void btnAddMoreViewCart_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            CashierOrder GoCashierOrderPage = new CashierOrder(user);
            GoCashierOrderPage.Show();
        }

        private void dgvCashierViewCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCashierViewCart.CurrentRow != null && dgvCashierViewCart.CurrentRow.Index >= 0)
            {
                string category = dgvCashierViewCart.CurrentRow.Cells["Category"].Value.ToString();
                string itemName = dgvCashierViewCart.CurrentRow.Cells["ItemName"].Value.ToString();

                selectedCartItem = CartManager.CartItems
                    .FirstOrDefault(ci => ci.Category == category && ci.ItemName == itemName);

                if (selectedCartItem != null)
                {
                    txtAvailableQuantity.Text = selectedCartItem.Quantity.ToString();
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (selectedCartItem != null)
            {
                selectedCartItem.Quantity++;
                selectedCartItem.Price = selectedCartItem.UnitPrice * selectedCartItem.Quantity + selectedCartItem.UnitPrice * selectedCartItem.Quantity * selectedCartItem.Vat / 100;
                UpdateCartView();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
          
            if (selectedCartItem != null && selectedCartItem.Quantity > 1)
            {
                selectedCartItem.Quantity--;
                selectedCartItem.Price = selectedCartItem.UnitPrice * selectedCartItem.Quantity + selectedCartItem.UnitPrice * selectedCartItem.Quantity * selectedCartItem.Vat / 100;
                UpdateCartView();
            }
        }

        private void UpdateCartView()
        {
            //dgvCashierViewCart.ClearSelection();
            if (selectedCartItem != null)
            {
                txtAvailableQuantity.Text = selectedCartItem.Quantity.ToString();
            }

            //dgvCashierViewCart.DataSource = null;
            dgvCashierViewCart.DataSource = CartManager.CartItems.Select(item => new
            {
                item.Category,
                item.ItemName,
                item.UnitPrice,
                item.Quantity,
                item.Price,
                item.Vat
            }).ToList();

            decimal totalPrice = CartManager.CartItems.Sum(item => item.Price);
            lbltotalPrice.Text = totalPrice.ToString("0.##");

            decimal roundedPrice = Math.Round(totalPrice, 0, MidpointRounding.AwayFromZero);
            lblRoundedPrice.Text = roundedPrice.ToString("0");
        }

        private void dgvCashierViewCart_Click(object sender, EventArgs e)
        {
            if (dgvCashierViewCart.CurrentRow != null && dgvCashierViewCart.CurrentRow.Index >= 0)
            {
                string category = dgvCashierViewCart.CurrentRow.Cells["Category"].Value.ToString();
                string itemName = dgvCashierViewCart.CurrentRow.Cells["ItemName"].Value.ToString();

                selectedCartItem = CartManager.CartItems
                    .FirstOrDefault(ci => ci.Category == category && ci.ItemName == itemName);

                if (selectedCartItem != null)
                {
                    txtAvailableQuantity.Text = selectedCartItem.Quantity.ToString();
                }
            }
        }
    }
}

