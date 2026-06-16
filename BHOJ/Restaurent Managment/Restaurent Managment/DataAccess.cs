using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent_Managment
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        private string itemName;
        private object addQuantity;

        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=TUF\SQLEXPRESS;Initial Catalog=Restaurent Managment;Integrated Security=True;");
            Sqlcon.Open();
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }
        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        public DataTable GetItemsByCategoryI(string category)
        {
            // Validate input to avoid SQL injection
            if (category == null)
                throw new ArgumentException("Invalid category");

            string sql = $"SELECT ItemName, AvailableQuantity FROM [{category}]";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            DataTable dt = new DataTable();
            this.Sda.Fill(dt);
            return dt;
        }

        public DataTable GetItemsByCategoryO(string category)
        {
            // Validate input to avoid SQL injection
            if (category == null)
                throw new ArgumentException("Invalid category");

            string sql = $"SELECT * FROM [{category}]";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            DataTable dt = new DataTable();
            this.Sda.Fill(dt);
            return dt;
        }

        // In DataAccess.cs
        public DataTable GetCategoryNames()
        {
            string sql = "SELECT CategoryName FROM CategoryTable";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            DataTable dt = new DataTable();
            this.Sda.Fill(dt);
            return dt;
        }

        public DataTable GetItemByCategoryAndNameI(string category, string itemName)
        {
            // Validate input to avoid SQL injection
            if (category == null)
                throw new ArgumentException("Invalid category");

            string sql = $"SELECT ItemName, AvailableQuantity FROM [{category}] WHERE ItemName LIKE @itemName";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddWithValue("@itemName", "%" + itemName + "%");
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            DataTable dt = new DataTable();
            this.Sda.Fill(dt);
            return dt;
        }

        public DataTable GetItemByCategoryAndNameO(string category, string itemName)
        {
            // Validate input to avoid SQL injection
            if (category == null)
                throw new ArgumentException("Invalid category");

            string sql = $"SELECT * FROM [{category}] WHERE ItemName LIKE @itemName";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddWithValue("@itemName", "%" + itemName + "%");
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            DataTable dt = new DataTable();
            this.Sda.Fill(dt);
            return dt;
        }

        public DataRow GetStaffInfo(string name)
        {
            string sql = "SELECT Name, Gender, Email, ContactNo, Address FROM CashierUpdateInfo WHERE Name = @Name";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddWithValue("@Name", name);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            DataTable dt = new DataTable();
            this.Sda.Fill(dt);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataRow GetAdminInfo(string name)
        {
            string sql = "SELECT Name, Gender, Email, ContactNo, Address FROM AdminTable WHERE Name = @Name";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddWithValue("@Name", name);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            DataTable dt = new DataTable();
            this.Sda.Fill(dt);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool UpdateAdminInfo(string name, string gender, string email, string contactNo, string address)
        {
            string sql = @"UPDATE AdminTable SET 
                            Gender = @Gender, 
                            Email = @Email, 
                            ContactNo = @ContactNo, 
                            Address = @Address
                           WHERE Name = @Name";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddWithValue("@Name", name);
            this.Sqlcom.Parameters.AddWithValue("@Gender", gender);
            this.Sqlcom.Parameters.AddWithValue("@Email", email);
            this.Sqlcom.Parameters.AddWithValue("@ContactNo", contactNo);
            this.Sqlcom.Parameters.AddWithValue("@Address", address);

            if (this.Sqlcon.State != ConnectionState.Open)
                this.Sqlcon.Open();

            int rowsAffected = this.Sqlcom.ExecuteNonQuery();
            this.Sqlcon.Close();
            return rowsAffected > 0;
        }

        public bool UpdateStaffInfo(string name, string gender, string email, string contactNo, string address)
        {
            string sql = @"UPDATE CashierUpdateInfo SET 
                            Gender = @Gender, 
                            Email = @Email, 
                            ContactNo = @ContactNo, 
                            Address = @Address
                           WHERE Name = @Name";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddWithValue("@Name", name);
            this.Sqlcom.Parameters.AddWithValue("@Gender", gender);
            this.Sqlcom.Parameters.AddWithValue("@Email", email);
            this.Sqlcom.Parameters.AddWithValue("@ContactNo", contactNo);
            this.Sqlcom.Parameters.AddWithValue("@Address", address);

            if (this.Sqlcon.State != ConnectionState.Open)
                this.Sqlcon.Open();

            int rowsAffected = this.Sqlcom.ExecuteNonQuery();
            this.Sqlcon.Close();
            return rowsAffected > 0;
        }

        public bool UpdateInventoryQuantity(string category, string itemName, int addQuantity)
        {
            // Validate input to avoid SQL injection
            if (category == null) // Add more categories as needed
                throw new ArgumentException("Invalid category");
            string sql = $@"
                UPDATE [{category}]
                SET AvailableQuantity = AvailableQuantity + @AddQuantity
                WHERE ItemName = @ItemName";
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddWithValue("@AddQuantity", addQuantity);
            this.Sqlcom.Parameters.AddWithValue("@ItemName", itemName);
            if (this.Sqlcon.State != ConnectionState.Open)
                this.Sqlcon.Open();
            int rowsAffected = this.Sqlcom.ExecuteNonQuery();
            this.Sqlcon.Close();
            return rowsAffected > 0;
        }
        // Add this helper method in DataAccess.cs
        private string GetInventoryTableName(string category)
        {
            if (category == "Burger") return "InventoryBurger";
            if (category == "Pizza") return "InventoryPizza";
            throw new ArgumentException("Invalid category");
        }

        internal void UpdateInventoryQuantity(string category, object itemName, object value)
        {
            throw new NotImplementedException();
        }
    }
}
