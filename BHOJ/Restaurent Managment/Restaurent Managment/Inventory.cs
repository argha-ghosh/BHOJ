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
    public partial class Inventory : Form
    {
        private int availableQuantity = 0;
        private int currentQuantity = 1;

        UserDetails user = new UserDetails();
        private object dt;

        public DataAccess da { get; set; }

        public Inventory(UserDetails user)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.user = user;
            txtAvailableQuantity.ReadOnly = true;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = this.da.GetCategoryNames();

                cmbShow.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbShow.Items.Add(row["CategoryName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category details! " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAvailableQuantity.Clear();
            this.txtAddQuantity.Clear();
            this.txtInventorySearch.Clear();
            this.cmbShow.SelectedIndex = -1;
            this.dgvInventoryItems.DataSource = null;
            this.dgvInventoryItems.Visible = false;


            availableQuantity = 0;
            currentQuantity = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface GoBackTO = new Interface(user);
            GoBackTO.Show();
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShow.SelectedItem == null)
                return;

            string category = cmbShow.SelectedItem.ToString();
            dgvInventoryItems.DataSource = dt;

            try
            {
                DataTable dt = this.da.GetItemsByCategoryI(category);

                dgvInventoryItems.DataSource = dt;
                dgvInventoryItems.ClearSelection();
                dgvInventoryItems.Visible = true;
                this.txtAvailableQuantity.Clear();
                this.txtAddQuantity.Clear();
                this.txtInventorySearch.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find items! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInventorySearch_TextChanged(object sender, EventArgs e)
        {
            string category = cmbShow.SelectedItem?.ToString();
            string itemName = txtInventorySearch.Text.Trim();

            if (cmbShow.SelectedItem == null)
            {
                MessageBox.Show("Please select a category to search.");
                return;
            }

            if (cmbShow.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category to search.");
                return;
            }

            try
            {
                DataTable dt = da.GetItemsByCategoryI(category); // or the correct method for your inventory table

                dgvInventoryItems.DataSource = dt;
                dgvInventoryItems.ClearSelection();
                dgvInventoryItems.Visible = true;
                txtAvailableQuantity.Clear();
                txtAddQuantity.Clear();
                txtAddQuantity.Enabled = false;
                btnMinus.Enabled = false;
                btnPlus.Enabled = false;

                availableQuantity = 0;
                currentQuantity = 1;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No items found for the given search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAvailableQuantity.Clear();
                    txtAddQuantity.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find item! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            currentQuantity++;
            txtAddQuantity.Text = currentQuantity.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (currentQuantity > 1)
            {
                currentQuantity--;
                txtAddQuantity.Text = currentQuantity.ToString();

            }
            else
            {
                MessageBox.Show("Quantity cannot be less than 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {

            string category = cmbShow.SelectedItem.ToString();
            string itemName = dgvInventoryItems.CurrentRow.Cells["ItemName"].Value.ToString();
            int addQuantity = int.Parse(txtAddQuantity.Text);

            bool updated = da.UpdateInventoryQuantity(category, itemName, addQuantity);
            if (updated)
            {
                MessageBox.Show("Quantity added successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable dt = da.GetItemsByCategoryI(category);
                dgvInventoryItems.DataSource = dt;
                dgvInventoryItems.ClearSelection();
            }
            else
            {
                MessageBox.Show("Add failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAddQuantity_TextChanged(object sender, EventArgs e)
        {
            txtAddQuantity.TextChanged -= txtAddQuantity_TextChanged;

            if (string.IsNullOrWhiteSpace(txtAddQuantity.Text))
            {

                currentQuantity = 0;
            }

            else if (int.TryParse(txtAddQuantity.Text, out int newq) && newq > 0)
            {

                if (newq < 1)
                {
                    MessageBox.Show("Quantity cannot be less than 1!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddQuantity.Text = "1";
                    currentQuantity = 1;
                    txtAddQuantity.SelectAll();
                }

                else
                {
                    currentQuantity = newq;
                }
            }

            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddQuantity.Text = "1";
                currentQuantity = 1;
                txtAddQuantity.SelectAll();
            }

            txtAddQuantity.TextChanged += txtAddQuantity_TextChanged;
        }

        private void dgvInventoryItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventoryItems.CurrentRow == null) return;

            // Adjust column name as per your DataTable
            string availableQtyStr = dgvInventoryItems.CurrentRow.Cells["AvailableQuantity"].Value.ToString();
            int.TryParse(availableQtyStr, out availableQuantity);

            txtAvailableQuantity.Text = availableQuantity.ToString();
            txtAddQuantity.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            currentQuantity = 1;
            txtAddQuantity.Text = currentQuantity.ToString();
        }
    }
}

