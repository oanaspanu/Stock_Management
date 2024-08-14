using System.Windows.Forms;

namespace StockManagement.UserInterface
{
    partial class CustomChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ChartLibrary.HighLowCloseChart highLowCloseChart;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.highLowCloseChart = new ChartLibrary.HighLowCloseChart();
            this.SuspendLayout();
            // 
            // highLowCloseChart
            // 
            this.highLowCloseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highLowCloseChart.Location = new System.Drawing.Point(0, 0);
            this.highLowCloseChart.Name = "highLowCloseChart";
            this.highLowCloseChart.Size = new System.Drawing.Size(856, 612);
            this.highLowCloseChart.TabIndex = 0;
            // 
            // CustomChartForm
            // 
            this.ClientSize = new System.Drawing.Size(856, 612);
            this.Controls.Add(this.highLowCloseChart);
            this.Name = "CustomChartForm";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.CustomChartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}