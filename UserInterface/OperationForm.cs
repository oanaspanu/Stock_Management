using StockManagement.Entities;
using StockManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace StockManagement
{
    public partial class MainForm : Form
    {
        private string ConnectionString = "Data Source = database.sqlite ";
        private BindingList<Operation> operations = new BindingList<Operation>();
        private BindingSource operationBindingSource;
        public MainForm()
        {
            InitializeComponent();
            LoadOperations();
            DisplayOperations();

            operationBindingSource = new BindingSource();
            operationBindingSource.DataSource = operations;
            dataGridView1.DataSource = operationBindingSource;

            operationBindingSource.PositionChanged += OperationBindingSource_PositionChanged;
        }

        private void OperationBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (operationBindingSource.Current != null)
            {
                Operation currentOperation = (Operation)operationBindingSource.Current;
                numericUpDown1.Value = currentOperation.OperationId;
                numericUpDown3.Value = currentOperation.GoodId;
                numericUpDown2.Value = currentOperation.SupplierId;
                NudQuantity.Value = currentOperation.Quantity;
                CbType.SelectedItem = currentOperation.Type;
                DtpDate.Value = currentOperation.Date;
            }
        }

        private void LoadOperations()
        {
            const string query = "SELECT * FROM Operation";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int operationId = reader.GetInt32(0);
                        int goodId = reader.GetInt32(1);
                        int supplierId = reader.GetInt32(2);
                        string type = reader.GetString(3);
                        int quantity = reader.GetInt32(4);
                        DateTime date = reader.GetDateTime(5);

                        Operation operation = new Operation(operationId, goodId, supplierId, type, quantity, date);
                        operations.Add(operation);
                    }
                }
            }
        }

        private void DisplayOperations()
        {
            dataGridView1.DataSource = operations;
        }


        // link to GoodForm and SupplierForm
        private void btnAddGood_Click(object sender, EventArgs e)
        {
            var goodForm = new GoodForm();
            goodForm.ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }


        // add
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFormData())
            {
                int operationId = (int)numericUpDown1.Value;
                int goodId = (int)numericUpDown3.Value;
                int supplierId = (int)numericUpDown2.Value;
                int quantity = (int)NudQuantity.Value;
                string type = CbType.SelectedItem.ToString();
                DateTime date = DtpDate.Value;

                Operation newOperation = new Operation(operationId, goodId, supplierId, type, quantity, date);
                AddOperationToDatabase(newOperation);
                operations.Add(newOperation);
                operationBindingSource.Position = operationBindingSource.IndexOf(newOperation); 
            }
        }
        

        private void AddOperationToDatabase(Operation operation)
        {
            const string query = "INSERT INTO Operation (OperationId, GoodId, SupplierId, Type, Quantity, Date) VALUES (@OperationId, @GoodId, @SupplierId, @Type, @Quantity, @Date)";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@OperationId", operation.OperationId);
                command.Parameters.AddWithValue("@GoodId", operation.GoodId);
                command.Parameters.AddWithValue("@SupplierId", operation.SupplierId);
                command.Parameters.AddWithValue("@Type", operation.Type);
                command.Parameters.AddWithValue("@Quantity", operation.Quantity);
                command.Parameters.AddWithValue("@Date", operation.Date);
                command.ExecuteNonQuery();
            }
        }



        // update
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var operation = (Operation)dataGridView1.CurrentRow.DataBoundItem;

            if (ValidateFormData())
            {
                operation.GoodId = (int)numericUpDown3.Value;
                operation.SupplierId = (int)numericUpDown2.Value;
                operation.Quantity = (int)NudQuantity.Value;
                operation.Type = CbType.SelectedItem.ToString();
                operation.Date = DtpDate.Value;

                UpdateOperationInDatabase(operation);
                dataGridView1.Refresh();
            }
        }

        private void UpdateOperationInDatabase(Operation operation)
        {
            const string query = "UPDATE Operation SET GoodId=@GoodId, SupplierId=@SupplierId, Type=@Type, Quantity=@Quantity, Date=@Date WHERE OperationId=@OperationId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@OperationId", operation.OperationId);
                command.Parameters.AddWithValue("@GoodId", operation.GoodId);
                command.Parameters.AddWithValue("@SupplierId", operation.SupplierId);
                command.Parameters.AddWithValue("@Type", operation.Type);
                command.Parameters.AddWithValue("@Quantity", operation.Quantity);
                command.Parameters.AddWithValue("@Date", operation.Date);
                command.ExecuteNonQuery();
            }
        }



        // delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var operation = (Operation)dataGridView1.CurrentRow.DataBoundItem;
                if (operation != null)
                {
                    operations.RemoveAt(dataGridView1.CurrentRow.Index);
                    DeleteOperationFromDatabase(operation.OperationId);
                }
            }

        }

        private void DeleteOperationFromDatabase(int operationId)
        {
            const string query = "DELETE FROM Operation WHERE OperationId=@OperationId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@OperationId", operationId);
                command.ExecuteNonQuery();
            }
        }


        // validate
        private bool ValidateFormData()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if ((int)numericUpDown1.Value <= 0)
            {
                errorProvider1.SetError(numericUpDown1, "Operation ID must be greater than zero.");
                isValid = false;
            }

            return isValid;
        }



        // export as text file
        private void exportAsTextFileToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ExportReportAsTextFile();

        }

        private void ExportReportAsTextFile()
        {
            string reportContent = GenerateReport();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Export Operation Report"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, reportContent);

                MessageBox.Show("Operation report exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GenerateReport()
        {
            StringWriter report = new StringWriter();
            report.WriteLine("Operation Report");
            report.WriteLine("---------------");
            foreach (var operation in operations)
            {
                report.WriteLine($"Operation ID: {operation.OperationId}");
                report.WriteLine($"Good ID: {operation.GoodId}");
                report.WriteLine($"Supplier ID: {operation.SupplierId}");
                report.WriteLine($"Type: {operation.Type}");
                report.WriteLine($"Quantity: {operation.Quantity}");
                report.WriteLine($"Date: {operation.Date}");
                report.WriteLine();
            }
            return report.ToString();
        }



        // serialize and deserialize
        private void SerializableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        formatter.Serialize(fs, operations);
                    }
                    MessageBox.Show("Serialization completed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during serialization: {ex.Message}");
                }
            }
        }

        private void DeserializableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                    {
                        var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        operations = (BindingList<Operation>)formatter.Deserialize(fs);
                        dataGridView1.DataSource = operations;
                    }
                    MessageBox.Show("Deserialization completed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deserialization: {ex.Message}");
                }
            }
        }



        // chart
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            CustomChartForm chartForm = new CustomChartForm();
            chartForm.Show();

        }


        // print preview
        private void printPrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (s, ev) =>
            {
                Font printFont = new Font("Arial", 12);
                float yPos = 100; 

          
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    ev.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, printFont, Brushes.Black, new PointF(100 + (i * 100), yPos));
                }
                yPos += 20; 

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        ev.Graphics.DrawString(row.Cells[i].Value.ToString(), printFont, Brushes.Black, new PointF(100 + (i * 100), yPos));
                    }
                    yPos += 20; 
                }
            };

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}
