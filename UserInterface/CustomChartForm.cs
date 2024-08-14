using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using StockManagement.Entities;
using System.Windows.Forms.DataVisualization.Charting;
using ChartLibrary;
using System.Data.SQLite;

namespace StockManagement.UserInterface
{

    public partial class CustomChartForm : Form
    {
        private string ConnectionString = "Data Source = database.sqlite ";

        public CustomChartForm()
        {
            InitializeComponent();
        }


        private void CustomChartForm_Load(object sender, EventArgs e)
        {
            List<HighLowCloseData> chartData = LoadDataFromDatabase();
            highLowCloseChart.SetData(chartData, "Operation Quantity Chart", "Date", "Quantity");
        }

        private List<HighLowCloseData> LoadDataFromDatabase()
        {
            List<HighLowCloseData> chartData = new List<HighLowCloseData>();

            const string query = "SELECT Date, MAX(Quantity) AS High, MIN(Quantity) AS Low, AVG(Quantity) AS Close FROM Operation GROUP BY Date";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        int high = reader.GetInt32(1); 
                        int low = reader.GetInt32(2);
                        float close = (float)reader.GetDouble(3);

                        HighLowCloseData data = new HighLowCloseData
                        {
                            Date = date,
                            High = high,
                            Low = low,
                            Close = close
                        };

                        chartData.Add(data);
                    }
                }
            }


            return chartData;
        }
    }
}
