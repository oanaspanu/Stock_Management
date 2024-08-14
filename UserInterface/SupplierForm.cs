using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SQLite;

namespace StockManagement
{
    public partial class SupplierForm : Form
    {
        private string ConnectionString = "Data Source = database.sqlite ";
        private BindingList<Supplier> suppliers = new BindingList<Supplier>();
        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliers();
            DisplaySuppliers();
        }

        private void LoadSuppliers()
        {
            const string query = "SELECT * FROM Supplier";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int supplierId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string contactInfo = reader.GetString(2);

                        Supplier supplier = new Supplier(supplierId, name, contactInfo);
                        suppliers.Add(supplier);
                    }
                }
            }
        }

        private void DisplaySuppliers()
        {
            dataGridView1.DataSource = suppliers;
        }



        // add
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int supplierId = (int)nudId.Value;
            string name = tbName.Text;
            string contactInfo = tbContactInfo.Text;

            Supplier supplier = new Supplier(supplierId, name, contactInfo);
            AddSupplierToDatabase(supplier);
            suppliers.Add(supplier);
        }

        private void AddSupplierToDatabase(Supplier supplier)
        {
            const string query = "INSERT INTO Supplier (SupplierId, Name, ContactInfo) VALUES (@SupplierId, @Name, @ContactInfo)";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                command.Parameters.AddWithValue("@Name", supplier.Name);
                command.Parameters.AddWithValue("@ContactInfo", supplier.ContactInfo);
                command.ExecuteNonQuery();
            }
        }



        // update
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var supplier = (Supplier)dataGridView1.CurrentRow.DataBoundItem;

                 supplier.Name = tbName.Text;
                 supplier.ContactInfo = tbContactInfo.Text;

                 UpdateSupplierInDatabase(supplier);
                 dataGridView1.Refresh();
               
            }
        }

        private void UpdateSupplierInDatabase(Supplier supplier)
        {
            const string query = "UPDATE Supplier SET Name=@Name, ContactInfo=@ContactInfo WHERE SupplierId=@SupplierId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                command.Parameters.AddWithValue("@Name", supplier.Name);
                command.Parameters.AddWithValue("@ContactInfo", supplier.ContactInfo);
                command.ExecuteNonQuery();
            }
        }



        // delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var supplier = (Supplier)dataGridView1.CurrentRow.DataBoundItem;
                if (supplier != null)
                {
                    suppliers.RemoveAt(dataGridView1.CurrentRow.Index);
                    DeleteSupplierFromDatabase(supplier.SupplierId);
                }
            }
        }

        private void DeleteSupplierFromDatabase(int supplierId)
        {
            const string query = "DELETE FROM Supplier WHERE SupplierId=@SupplierId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SupplierId", supplierId);
                command.ExecuteNonQuery();
            }
        }

    }
}