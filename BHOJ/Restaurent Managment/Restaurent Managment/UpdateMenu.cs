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
    public partial class UpdateMenu : Form
    {
        private DataAccess da = new DataAccess();
        UserDetails user = new UserDetails();
        public UpdateMenu(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface GoBackADI = new AdminInterface(user);
            GoBackADI.Show();
        }

        private void bttnAddCtagory_Click(object sender, EventArgs e)
        {
            new Admin_Add_Category(user).Show();
            this.Hide();
        }

        private void CmboBxShwFrmCtgry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = CmboBxShwFrmCtgry.SelectedItem.ToString();

            txtbxSrch.Cursor = Cursors.IBeam;

            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                string loadItems_Query = $"SELECT * FROM {category}";

                SqlCommand loadItemsCmd = new SqlCommand(loadItems_Query, da.Sqlcon);

                SqlDataAdapter sda = new SqlDataAdapter(loadItemsCmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dtgrdvwItmLst.DataSource = dt;
                dtgrdvwItmLst.ClearSelection();

                txtbxItmNm.Clear();
                txtbxPrc.Clear();
                txtbxStVAT.Clear();
                txtbxSrch.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Could not find items!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (da.Sqlcon.State == ConnectionState.Open)
                    da.Sqlcon.Close();
            }
        }

        private void UpdateMenu_Load(object sender, EventArgs e)
        {
            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                string CtgryName_Query = "SELECT CategoryName FROM CategoryTable";
                SqlCommand CtgryNameCmd = new SqlCommand(CtgryName_Query, da.Sqlcon);

                SqlDataReader reader = CtgryNameCmd.ExecuteReader();

                CmboBxShwFrmCtgry.Items.Clear();
                while (reader.Read())
                    CmboBxShwFrmCtgry.Items.Add(reader["CategoryName"].ToString());
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading category details!" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (da.Sqlcon.State == ConnectionState.Open)
                    da.Sqlcon.Close();
            }
        }

        private void bttnClr_Click(object sender, EventArgs e)
        {
            txtbxSrch.Clear();
            txtbxItmNm.Clear();
            txtbxPrc.Clear();
            txtbxStVAT.Clear();

            dtgrdvwItmLst.DataSource = new DataTable();

            UpdateMenu_Load(null, null);
        }

        private void txtbxSrch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbxSrch.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Sorry! You cannot search with more than 50 characters!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtbxSrch_TextChanged(object sender, EventArgs e)
        {
            string category = CmboBxShwFrmCtgry.SelectedItem.ToString();

            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                string ItemList_Query = $"SELECT * FROM [{category}] WHERE " +
                                         "ItemName LIKE '%' + @search + '%' OR " +
                                         "Price LIKE '%' + @search + '%' OR " +
                                         "VAT LIKE '%' + @search + '%'";

                SqlCommand ItemListCmd = new SqlCommand(ItemList_Query, da.Sqlcon);
                ItemListCmd.Parameters.AddWithValue("@search", txtbxSrch.Text);

                SqlDataAdapter sda = new SqlDataAdapter(ItemListCmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dtgrdvwItmLst.DataSource = dt;

                dtgrdvwItmLst.ClearSelection();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (da.Sqlcon.State == ConnectionState.Open)
                    da.Sqlcon.Close();
            }
        }

        private void txtbxPrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbxPrc.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Price cannot be more than 11 characters!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Only numeric values are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                MessageBox.Show("Price cannot contain multiple decimal points!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtbxStVAT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtbxStVAT.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("VAT cannot be more than 5 characters!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Only numeric values are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                MessageBox.Show("VAT cannot contain multiple decimal points!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (CmboBxShwFrmCtgry.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtbxItmNm.Text == "")
                MessageBox.Show("Please enter item name to proceed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (txtbxPrc.Text == "")
                MessageBox.Show("Please enter price to proceed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string category = CmboBxShwFrmCtgry.SelectedItem.ToString();

                decimal price = decimal.Parse(txtbxPrc.Text);
                price = Math.Round(price, 2);

                decimal vat;
                if (string.IsNullOrWhiteSpace(txtbxStVAT.Text))
                    vat = 0;

                else
                {
                    vat = decimal.Parse(txtbxStVAT.Text);
                    vat = Math.Round(vat, 2);
                }

                try
                {
                    if (da.Sqlcon.State == ConnectionState.Closed)
                        da.Sqlcon.Open();

                    string checkItem_Query = $"SELECT COUNT(*) FROM [{category}] WHERE ItemName = @name";
                    SqlCommand checkItemCmd = new SqlCommand(checkItem_Query, da.Sqlcon);
                    checkItemCmd.Parameters.AddWithValue("@name", txtbxItmNm.Text.Trim());
                    int itemExists = (int)checkItemCmd.ExecuteScalar();

                    if (itemExists > 0)
                    {
                        MessageBox.Show("An item with this name already exists of this category!\nPlease choose a different item name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbxItmNm.Focus();
                        return;
                    }

                    SqlTransaction transaction = da.Sqlcon.BeginTransaction();

                    try
                    {
                        string insertItemTable_Query = $"INSERT INTO [{category}] (ItemName, Price, VAT, AvailableQuantity) VALUES (@name , @price, @vat, 0 )";

                        SqlCommand insertItemCmd = new SqlCommand(insertItemTable_Query, da.Sqlcon, transaction);
                        insertItemCmd.Parameters.AddWithValue("@name", txtbxItmNm.Text.Trim());
                        insertItemCmd.Parameters.AddWithValue("@price", price);
                        insertItemCmd.Parameters.AddWithValue("@vat", vat);

                        insertItemCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string query = $"SELECT * FROM [{category}]";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, da.Sqlcon);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtgrdvwItmLst.DataSource = dt;
                        dtgrdvwItmLst.ClearSelection();

                        txtbxItmNm.Clear();
                        txtbxPrc.Clear();
                        txtbxSrch.Clear();
                        txtbxStVAT.Clear();
                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Database connection was not established!\n" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    if (da.Sqlcon.State == ConnectionState.Open)
                        da.Sqlcon.Close();
                }
            }
        }

        private void bttnUpdt_Click(object sender, EventArgs e)
        {
            if (CmboBxShwFrmCtgry.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtgrdvwItmLst.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select an item first!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtbxItmNm.Text == "" || txtbxPrc.Text == "")
            {
                MessageBox.Show("Please fill item name and price before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = CmboBxShwFrmCtgry.SelectedItem.ToString();

            string selectedItem = dtgrdvwItmLst.SelectedRows[0].Cells["ItemName"].Value.ToString();
            string updatedItem = txtbxItmNm.Text.Trim();
            decimal updatedPrice = decimal.Parse(txtbxPrc.Text);
            updatedPrice = Math.Round(updatedPrice, 2);

            decimal updatedVat;
            if (string.IsNullOrWhiteSpace(txtbxStVAT.Text))
                updatedVat = 0;

            else
            {
                updatedVat = decimal.Parse(txtbxStVAT.Text);
                updatedVat = Math.Round(updatedVat, 2);
            }

            SqlTransaction transaction = null;

            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                if (selectedItem != updatedItem)
                {
                    string checkItem_Query = $"SELECT COUNT(*) FROM [{category}] WHERE ItemName = @NewName";
                    SqlCommand checkItemCmd = new SqlCommand(checkItem_Query, da.Sqlcon);
                    checkItemCmd.Parameters.AddWithValue("@NewName", updatedItem);
                    int itemExists = (int)checkItemCmd.ExecuteScalar();

                    if (itemExists > 0)
                    {
                        MessageBox.Show("An item with this name already exists of this category!\nPlease choose a different item name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbxItmNm.Focus();
                        return;
                    }
                }

                transaction = da.Sqlcon.BeginTransaction();

                string updateItemTable_Query = $"UPDATE [{category}] SET ItemName = @NewItem, Price = @price, VAT = @vat WHERE ItemName = @OldItem";
                SqlCommand updateItemCmd = new SqlCommand(updateItemTable_Query, da.Sqlcon, transaction);
                updateItemCmd.Parameters.AddWithValue("@NewItem", updatedItem);
                updateItemCmd.Parameters.AddWithValue("@price", updatedPrice);
                updateItemCmd.Parameters.AddWithValue("@vat", updatedVat);
                updateItemCmd.Parameters.AddWithValue("@OldItem", selectedItem);

                int rowsaffected = updateItemCmd.ExecuteNonQuery();

                if (rowsaffected > 0)
                {
                    transaction.Commit();
                    MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query = $"SELECT * FROM [{category}]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, da.Sqlcon);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtgrdvwItmLst.DataSource = dt;
                    dtgrdvwItmLst.ClearSelection();

                    txtbxItmNm.Clear();
                    txtbxPrc.Clear();
                    txtbxSrch.Clear();
                    txtbxStVAT.Clear();
                }

                else
                    MessageBox.Show("Record could not be updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (da.Sqlcon.State == ConnectionState.Open)
                    da.Sqlcon.Close();
            }
        }

        private void bttnDlt_Click(object sender, EventArgs e)
        {
            if (CmboBxShwFrmCtgry.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtgrdvwItmLst.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select an item first!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string itemName = dtgrdvwItmLst.SelectedRows[0].Cells["ItemName"].Value.ToString();
                string category = CmboBxShwFrmCtgry.SelectedItem.ToString();

                SqlTransaction transaction = null;

                try
                {
                    if (da.Sqlcon.State == ConnectionState.Closed)
                        da.Sqlcon.Open();

                    transaction = da.Sqlcon.BeginTransaction();

                    string dltItem_Query = $"DELETE FROM [{category}] WHERE ItemName = @item";
                    SqlCommand dltItemCmd = new SqlCommand(dltItem_Query, da.Sqlcon, transaction);
                    dltItemCmd.Parameters.AddWithValue("item", itemName);
                    int rowsAffected = dltItemCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        transaction.Commit();

                        MessageBox.Show("Item successfully deleted!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string query = $"SELECT * FROM [{category}]";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, da.Sqlcon);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtgrdvwItmLst.DataSource = dt;
                        dtgrdvwItmLst.ClearSelection();

                        txtbxItmNm.Clear();
                        txtbxPrc.Clear();
                        txtbxSrch.Clear();
                        txtbxStVAT.Clear();
                    }

                    else
                        MessageBox.Show("Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    if (da.Sqlcon.State == ConnectionState.Open)
                        da.Sqlcon.Close();
                }
            }
        }

        private void txtbxSrch_Click(object sender, EventArgs e)
        {
            if (CmboBxShwFrmCtgry.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmboBxShwFrmCtgry.Focus();
                return;
            }
        }

        private void dtgrdvwItmLst_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgrdvwItmLst.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = dtgrdvwItmLst.Rows[e.RowIndex];

                txtbxItmNm.Text = row.Cells["ItemName"].Value.ToString();
                txtbxPrc.Text = row.Cells["Price"].Value.ToString();
                txtbxStVAT.Text = row.Cells["VAT"].Value.ToString();
                row.Selected = true;
            }
        }
    }
}
