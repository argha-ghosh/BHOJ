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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Restaurent_Managment
{
    public partial class CashierOrder : Form
    {
        private int availableQuantity = 0;
        private decimal UnitPrice = 0;
        //private decimal Price = 0;
        private decimal Vat = 0;
        private int currentQuantity = 1;

        UserDetails user = new UserDetails();

        public DataAccess da { get; set; }
        public CashierOrder(UserDetails user)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.user = user;
            txtAvailableQuantity.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtVat.ReadOnly = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAvailableQuantity.Clear();
            this.txtPrice.Clear();
            this.txtCashierQuantity.Clear();
            this.txtVat.Clear();
            this.txtCashierSearch.Clear();
            this.dgvCashierItems.DataSource = null;
            this.dgvCashierItems.Visible = false;
            this.cmbCategory.SelectedIndex = -1;

            availableQuantity = 0;
            UnitPrice = 0;
            //Price = 0;
            Vat = 0;
            currentQuantity = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface GoBack = new Interface(user);
            GoBack.Show();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (CartManager.CartItems == null || CartManager.CartItems.Count == 0)
            {
                MessageBox.Show("Add items to the cart to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Visible = false;
            PaymentMethod GoPaymentMethod = new PaymentMethod(user);
            GoPaymentMethod.Show();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if (CartManager.CartItems == null || CartManager.CartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty!\nAdd items to the cart to view.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Visible = false;
            ViewCart GoViewCartPage = new ViewCart(user);
            GoViewCartPage.Show();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCategory.SelectedItem == null)
                return;

            string category = cmbCategory.SelectedItem.ToString();

            try
            {
                DataTable dt = this.da.GetItemsByCategoryO(category);

                dgvCashierItems.DataSource = dt;
                dgvCashierItems.ClearSelection();

                this.txtAvailableQuantity.Clear();
                this.txtPrice.Clear();
                this.txtCashierQuantity.Clear();
                this.txtVat.Clear();
                this.txtCashierSearch.Clear();
                this.txtCashierSearch.Clear();
                dgvCashierItems.Visible = true;

                availableQuantity = 0;
                UnitPrice = 0;
                //Price = 0;
                Vat = 0;
                currentQuantity = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find items! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CashierOrder_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = this.da.GetCategoryNames();

                cmbCategory.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbCategory.Items.Add(row["CategoryName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category details! " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCashierSearch_TextChanged(object sender, EventArgs e)
        {
            string category = cmbCategory.SelectedItem?.ToString();
            string itemName = txtCashierSearch.Text.Trim();

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category to search.");
                return;
            }

            try
            {
                DataTable dt = this.da.GetItemByCategoryAndNameO(category, itemName);
                dgvCashierItems.DataSource = dt;
                dgvCashierItems.ClearSelection();
                dgvCashierItems.Visible = true;
                txtAvailableQuantity.Clear();
                txtPrice.Clear();
                txtCashierQuantity.Clear();
                txtVat.Clear();
                txtCashierQuantity.Enabled = false;  
                btnMinus.Enabled = false;
                btnPlus.Enabled = false;

                availableQuantity = 0;
                UnitPrice = 0;
                //Price = 0;
                Vat = 0;
                currentQuantity = 1;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No items found for the given search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAvailableQuantity.Clear();
                    txtPrice.Clear();
                    txtCashierQuantity.Clear();
                    txtVat.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find item! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (currentQuantity < availableQuantity)
            {
                currentQuantity++;
                txtCashierQuantity.Text = currentQuantity.ToString();

                decimal totalPrice = UnitPrice * currentQuantity + (UnitPrice * currentQuantity) * Vat / 100;
                //Price = totalPrice;
                txtPrice.Text = totalPrice.ToString("0.##");
                txtVat.Text = Vat.ToString("0.##");
            }
            else
            {
                MessageBox.Show("Cannot exceed available quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (currentQuantity > 1)
            {
                currentQuantity--;
                txtCashierQuantity.Text = currentQuantity.ToString();
                decimal totalPrice = UnitPrice * currentQuantity + (UnitPrice * currentQuantity) * Vat / 100;
                //Price = totalPrice;
                txtPrice.Text = totalPrice.ToString("0.##");
                txtVat.Text = Vat.ToString("0.##");
            }

            else
            {
                MessageBox.Show("Quantity cannot be less than 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvCashierItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to add to cart.");
                return;
            }

            string category = cmbCategory.SelectedItem?.ToString();
            string itemName = dgvCashierItems.CurrentRow.Cells["ItemName"].Value.ToString();

            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Invalid item selection.");
                return;
            }

            int quantity;
            decimal price, vat;
            if (!int.TryParse(txtCashierQuantity.Text, out quantity) ||
                !decimal.TryParse(txtPrice.Text, out price) ||
                !decimal.TryParse(txtVat.Text, out vat))
            {
                MessageBox.Show("Invalid quantity, price, or VAT.");
                return;
            }

            var existingItem = CartManager.CartItems
                .FirstOrDefault(ci => ci.Category == category && ci.ItemName == itemName);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.Price += price; 
            }
            else
            {
                CartManager.CartItems.Add(new CartItem
                {
                    Category = category,
                    ItemName = itemName,
                    UnitPrice = UnitPrice,
                    Quantity = quantity,
                    Price = UnitPrice * currentQuantity + (UnitPrice * currentQuantity * Vat / 100),
                    Vat = vat
                });
            }
            txtAvailableQuantity.Clear();
            txtPrice.Clear();
            txtCashierQuantity.Clear();
            txtVat.Clear();
            txtCashierSearch.Clear();
            dgvCashierItems.DataSource = null;
            dgvCashierItems.Visible = false;

            availableQuantity = 0;
            UnitPrice = 0;
            //Price = 0;
            Vat = 0;
            currentQuantity = 1;

            MessageBox.Show("Item added to cart!");
        }

        private void txtCashierQuantity_TextChanged(object sender, EventArgs e)
        {
            txtCashierQuantity.TextChanged -= txtCashierQuantity_TextChanged;

            if (string.IsNullOrWhiteSpace(txtCashierQuantity.Text))
            {
                txtPrice.Clear();
                currentQuantity = 0;
            }

            else if (int.TryParse(txtCashierQuantity.Text, out int newq) && newq > 0)
            {

                if (newq < 1)
                {
                    MessageBox.Show("Quantity cannot be less than 1!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCashierQuantity.Text = "1";
                    currentQuantity = 1;
                    txtCashierQuantity.SelectAll();
                }

                else
                {
                    currentQuantity = newq;

                    if (currentQuantity > availableQuantity)
                    {
                        MessageBox.Show("Quantity cannot exceed available quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCashierQuantity.Clear();  
                        txtPrice.Clear();
                        currentQuantity = 0;
                        txtCashierQuantity.SelectAll();
                        txtCashierQuantity.TextChanged += txtCashierQuantity_TextChanged;
                        return;
                    }

                    if (Vat == 0)
                        txtPrice.Text = (UnitPrice * currentQuantity).ToString();

                    else
                        txtPrice.Text = (UnitPrice * currentQuantity + UnitPrice * currentQuantity * Vat / 100).ToString("0.00");
                }
            }

            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCashierQuantity.Text = "1";
                currentQuantity = 1;
                txtCashierQuantity.SelectAll();
            }

            txtCashierQuantity.TextChanged += txtCashierQuantity_TextChanged;

        }

        private void dgvCashierItems_Click(object sender, EventArgs e)
        {
            txtCashierQuantity.Enabled = true;
            btnMinus.Enabled = true;
            btnPlus.Enabled = true;

            this.txtAvailableQuantity.Text = this.dgvCashierItems.CurrentRow.Cells[0].Value.ToString();
            this.txtPrice.Text = this.dgvCashierItems.CurrentRow.Cells[1].Value.ToString();
            this.txtVat.Text = this.dgvCashierItems.CurrentRow.Cells[2].Value.ToString();

            if (dgvCashierItems.CurrentRow == null) return;
            string availableQtyStr = dgvCashierItems.CurrentRow.Cells["AvailableQuantity"].Value.ToString();
            string priceStr = dgvCashierItems.CurrentRow.Cells["Price"].Value.ToString();
            string vatStr = dgvCashierItems.CurrentRow.Cells["VAT"].Value.ToString();

            decimal.TryParse(vatStr, out Vat);
            int.TryParse(availableQtyStr, out availableQuantity);
            decimal.TryParse(priceStr, out UnitPrice);

            currentQuantity = 1;

            if (availableQuantity < 1)
            {
                MessageBox.Show("Not enough quantity available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtAvailableQuantity.Text = availableQuantity.ToString();
            txtCashierQuantity.Text = currentQuantity.ToString();
            decimal totalVat = (UnitPrice * currentQuantity) * Vat / 100;
            decimal totalPriceWithVat = (UnitPrice * currentQuantity) + totalVat;

            txtPrice.Text = totalPriceWithVat.ToString("0.##");
            txtVat.Text = Vat.ToString("0.##");
        }

        private void txtCashierQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                e.Handled = true;
                return;
            }

            if (currentQuantity > availableQuantity)
            {
                MessageBox.Show("Quantiy cannot exceed available quantity!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numeric values are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtCashierQuantity_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

        }
    }
}

