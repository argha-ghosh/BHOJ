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
    public partial class Admin_Add_Category : Form
    {
        private DataAccess da = new DataAccess();

        UserDetails user = new UserDetails();

        int nextID;
        public Admin_Add_Category(UserDetails user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void GenerateNextDId()
        {
            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                string query = "SELECT MAX(ID) FROM CategoryTable";
                SqlCommand cmd = new SqlCommand(query, da.Sqlcon);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextID = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the next Category ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (da.Sqlcon.State == ConnectionState.Open)
                    da.Sqlcon.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateMenu GoBackADI = new UpdateMenu(user);
            GoBackADI.Show();
        }

        private void txtbxEntrCtgryNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbxEntrCtgryNm.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Category name must be upto 50 characters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Only letters are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbxEntrCtgryNm.Text))
            {
                MessageBox.Show("Please enter a category name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                string checkCtgry_Query = "SELECT COUNT(*) FROM CategoryTable WHERE CategoryName = @category";
                SqlCommand checkCtgryrCmd = new SqlCommand(checkCtgry_Query, da.Sqlcon);
                checkCtgryrCmd.Parameters.AddWithValue("@category", txtbxEntrCtgryNm.Text.Trim());
                int ctgryExists = (int)checkCtgryrCmd.ExecuteScalar();

                if (ctgryExists > 0)
                {
                    MessageBox.Show("A category with this name already exists!\nPlease choose a different category name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbxEntrCtgryNm.Focus();
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to add this category?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    GenerateNextDId();
                    SqlTransaction transaction = null;

                    try
                    {
                        if (da.Sqlcon.State == ConnectionState.Closed)
                            da.Sqlcon.Open();

                        transaction = da.Sqlcon.BeginTransaction();

                        string tableName = txtbxEntrCtgryNm.Text.Trim();
                        string AddCtgry_Query = "INSERT INTO CategoryTable (ID, CategoryName) VALUES (@nextID, @category)";
                        SqlCommand AddCtgryCmd = new SqlCommand(AddCtgry_Query, da.Sqlcon, transaction);
                        AddCtgryCmd.Parameters.AddWithValue("@nextID", this.nextID);
                        AddCtgryCmd.Parameters.AddWithValue("@category", tableName);
                        AddCtgryCmd.ExecuteNonQuery();

                        string CrtTbl_Query = $"CREATE TABLE [{tableName}] (ItemName varchar(50) PRIMARY KEY, Price int NOT NULL, VAT float, AvailableQuantity int)";
                        SqlCommand CrtTblCmd = new SqlCommand(CrtTbl_Query, da.Sqlcon, transaction);
                        CrtTblCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtbxEntrCtgryNm.Clear();
                        Admin_Add_Category_Load(null, null);
                    }

                    catch (Exception ex)
                    {
                        if (transaction != null)
                            transaction.Rollback();
                        MessageBox.Show("Category could not be added! " + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        if (da.Sqlcon.State == ConnectionState.Open)
                            da.Sqlcon.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Category could not be added!\nDatabase error!" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (da.Sqlcon.State == ConnectionState.Open)
                    da.Sqlcon.Close();
            }
        }

        private void bttnClr_Click(object sender, EventArgs e)
        {
            txtbxEntrCtgryNm.Clear();
            txtbxSrch.Clear();

            //dtgrdvwCtgryLst.DataSource = new DataTable();
        }

        private void bttnDlt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a category first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtbxEntrCtgryNm.Clear();

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                SqlTransaction transaction = null;

                try
                {
                    if (da.Sqlcon.State == ConnectionState.Closed)
                        da.Sqlcon.Open();

                    transaction = da.Sqlcon.BeginTransaction();

                    string dltCtgry = dataGridView1.SelectedRows[0].Cells["CategoryName"].Value.ToString().Trim();

                    string DltCtgry_Query = "DELETE FROM CategoryTable WHERE CategoryName = @category";
                    SqlCommand DltCtgryCmd = new SqlCommand(DltCtgry_Query, da.Sqlcon, transaction);
                    DltCtgryCmd.Parameters.AddWithValue("@category", dltCtgry);
                    DltCtgryCmd.ExecuteNonQuery();

                    string DltCtgryTbl_Query = $"DROP TABLE [{dltCtgry}]";
                    SqlCommand DltCtgryTblCmd = new SqlCommand(DltCtgryTbl_Query, da.Sqlcon, transaction);
                    DltCtgryTblCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Category successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Admin_Add_Category_Load(null, null);
                }

                catch (Exception ex)
                {
                    if (transaction != null)
                        transaction.Rollback();

                    MessageBox.Show("Category could not be deleted!" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    if (da.Sqlcon.State == ConnectionState.Open)
                        da.Sqlcon.Close();
                }
            }
        }

        private void Admin_Add_Category_Load(object sender, EventArgs e)
        {

            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                string CategoryList_Query = "SELECT * FROM CategoryTable";

                SqlDataAdapter sda = new SqlDataAdapter(CategoryList_Query, da.Sqlcon);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();

                txtbxEntrCtgryNm.Clear();
                txtbxSrch.Clear();
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

        private void bttnUpdt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a category first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedCtgry = selectedRow.Cells["CategoryName"].Value.ToString();

                string updatedCtgry = txtbxEntrCtgryNm.Text.Trim();

                SqlTransaction transaction = null;

                try
                {
                    if (da.Sqlcon.State == ConnectionState.Closed)
                        da.Sqlcon.Open();

                    transaction = da.Sqlcon.BeginTransaction();

                    string checkCtgry_Query = "SELECT COUNT(*) FROM CategoryTable WHERE CategoryName = @ctgry AND CategoryName <> @oldName";
                    SqlCommand checkCtgryCmd = new SqlCommand(checkCtgry_Query, da.Sqlcon, transaction);
                    checkCtgryCmd.Parameters.AddWithValue("@ctgry", updatedCtgry);
                    checkCtgryCmd.Parameters.AddWithValue("@oldName", selectedCtgry);

                    int categoryExists = (int)checkCtgryCmd.ExecuteScalar();

                    if (categoryExists > 0)
                    {
                        MessageBox.Show("A category with this name already exists!\nPlease choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbxEntrCtgryNm.Focus();
                        return;
                    }

                    string checkID_Query = "SELECT ID FROM CategoryTable WHERE CategoryName = @ctgry";
                    SqlCommand checkIDCmd = new SqlCommand(checkID_Query, da.Sqlcon, transaction);
                    checkIDCmd.Parameters.AddWithValue("@ctgry", selectedCtgry);
                    int selectedID = (int)checkIDCmd.ExecuteScalar();

                    string UpdtCategoryTable_Query = "UPDATE CategoryTable SET CategoryName = @name WHERE ID = @id";
                    SqlCommand UpdtCategoryTableCmd = new SqlCommand(UpdtCategoryTable_Query, da.Sqlcon, transaction);
                    UpdtCategoryTableCmd.Parameters.AddWithValue("@name", updatedCtgry);
                    UpdtCategoryTableCmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(selectedID);
                    UpdtCategoryTableCmd.ExecuteNonQuery();

                    string UpdtCtgry_Query = "EXEC sp_rename @oldName, @newName, 'OBJECT'";
                    SqlCommand cmd = new SqlCommand(UpdtCtgry_Query, da.Sqlcon, transaction);
                    cmd.Parameters.AddWithValue("@oldName", $"dbo.{selectedCtgry}");
                    cmd.Parameters.AddWithValue("@newName", updatedCtgry);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Category renamed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Admin_Add_Category_Load(null, null);
                }

                catch (Exception ex)
                {
                    if (transaction != null)
                        transaction.Rollback();

                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    if (da.Sqlcon.State == ConnectionState.Open)
                        da.Sqlcon.Close();
                }
            }

            else
                MessageBox.Show("Please select a category to rename.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtbxSrch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (da.Sqlcon.State == ConnectionState.Closed)
                    da.Sqlcon.Open();

                string CategoryList_Query = "SELECT * FROM CategoryTable WHERE " +
                            "ID LIKE '%' + @search + '%' OR " +
                            "CategoryName LIKE '%' + @search + '%'";

                SqlCommand cmd = new SqlCommand(CategoryList_Query, da.Sqlcon);
                cmd.Parameters.AddWithValue("@search", txtbxSrch.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.ClearSelection();
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

        private void txtbxSrch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbxSrch.Text.Length >= 50)
                MessageBox.Show("Sorry! You cannot search with more than 50 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtbxEntrCtgryNm.Text = row.Cells["CategoryName"].Value.ToString();
            }
        }
    }
}
