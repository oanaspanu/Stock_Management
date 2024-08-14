using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockManagement
{
    public partial class GoodForm : Form
    {
        private string ConnectionString = "Data Source = database.sqlite ";
        private BindingList<Good > goods = new BindingList<Good >();
        public GoodForm()
        {
            InitializeComponent();
            LoadGoods();
            DisplayGoods();
        }

        private void LoadGoods()
        {
            const string query = "SELECT * FROM Good";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int goodId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int supplierId = reader.GetInt32(0);

                        Good good = new Good(goodId, name, supplierId);
                        goods.Add(good);
                    }
                }
            }
        }

        private void DisplayGoods()
        {
            dataGridView1.DataSource = goods;
        }



        // add
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            int goodId = (int)numericUpDown1.Value;
            string name = textBox1.Text;
            int supplierId = (int)numericUpDown2.Value;

            Good good = new Good(goodId, name, supplierId);
            AddGoodToDatabase(good);
            goods.Add(good);

        }

        private void AddGoodToDatabase(Good good)
        {
            const string query = "INSERT INTO Good (GoodId, Name, SupplierId) VALUES (@GoodId, @Name, @SupplierId)";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@GoodId", good.GoodId);
                command.Parameters.AddWithValue("@Name", good.Name);
                command.Parameters.AddWithValue("@SupplierId", good.SupplierId);
                command.ExecuteNonQuery();
            }
        }



        // update
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var good = (Good)dataGridView1.CurrentRow.DataBoundItem;

                good.Name = textBox1.Text;
                good.SupplierId = (int)numericUpDown2.Value;

                UpdateGoodInDatabase(good);
                dataGridView1.Refresh();
             
            }
        }

        private void UpdateGoodInDatabase(Good good)
        {
            const string query = "UPDATE Good SET Name=@Name, SupplierId=@SupplierId WHERE GoodId=@GoodId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@GoodId", good.GoodId);
                command.Parameters.AddWithValue("@Name", good.Name);
                command.Parameters.AddWithValue("@SupplierId", good.SupplierId);
                command.ExecuteNonQuery();
            }
        }



        // delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var good = (Good)dataGridView1.CurrentRow.DataBoundItem;
                if (good != null)
                {
                    goods.RemoveAt(dataGridView1.CurrentRow.Index);
                    DeleteGoodFromDatabase(good.GoodId);
                }
            }
        }

        private void DeleteGoodFromDatabase(int goodId)
        {
            const string query = "DELETE FROM Good WHERE GoodId=@GoodId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@GoodId", goodId);
                command.ExecuteNonQuery();
            }
        }


    }
}
