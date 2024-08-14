namespace StockManagement
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSupplierId = new System.Windows.Forms.Label();
            this.lbOperationId = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbGoodId = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.NudQuantity = new System.Windows.Forms.NumericUpDown();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsTextFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPrieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddGood = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(512, 579);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(157, 75);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(316, 579);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(157, 75);
            this.BtnUpdate.TabIndex = 18;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(111, 579);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(157, 75);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(759, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(921, 764);
            this.dataGridView1.TabIndex = 16;
            // 
            // lbSupplierId
            // 
            this.lbSupplierId.AutoSize = true;
            this.lbSupplierId.Location = new System.Drawing.Point(106, 244);
            this.lbSupplierId.Name = "lbSupplierId";
            this.lbSupplierId.Size = new System.Drawing.Size(114, 25);
            this.lbSupplierId.TabIndex = 15;
            this.lbSupplierId.Text = "Supplier Id";
            // 
            // lbOperationId
            // 
            this.lbOperationId.AutoSize = true;
            this.lbOperationId.Location = new System.Drawing.Point(106, 74);
            this.lbOperationId.Name = "lbOperationId";
            this.lbOperationId.Size = new System.Drawing.Size(129, 25);
            this.lbOperationId.TabIndex = 13;
            this.lbOperationId.Text = "Operation Id";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(265, 238);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(404, 31);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(265, 74);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(404, 31);
            this.numericUpDown1.TabIndex = 10;
            // 
            // lbGoodId
            // 
            this.lbGoodId.AutoSize = true;
            this.lbGoodId.Location = new System.Drawing.Point(106, 161);
            this.lbGoodId.Name = "lbGoodId";
            this.lbGoodId.Size = new System.Drawing.Size(87, 25);
            this.lbGoodId.TabIndex = 21;
            this.lbGoodId.Text = "Good Id";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(265, 155);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(404, 31);
            this.numericUpDown3.TabIndex = 20;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(106, 404);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(92, 25);
            this.lbQuantity.TabIndex = 22;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(106, 322);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(60, 25);
            this.lbType.TabIndex = 23;
            this.lbType.Text = "Type";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(106, 484);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 25);
            this.lbDate.TabIndex = 24;
            this.lbDate.Text = "Date";
            // 
            // NudQuantity
            // 
            this.NudQuantity.Location = new System.Drawing.Point(265, 398);
            this.NudQuantity.Name = "NudQuantity";
            this.NudQuantity.Size = new System.Drawing.Size(404, 31);
            this.NudQuantity.TabIndex = 25;
            // 
            // CbType
            // 
            this.CbType.FormattingEnabled = true;
            this.CbType.Items.AddRange(new object[] {
            "Acquisition",
            "Sell"});
            this.CbType.Location = new System.Drawing.Point(265, 313);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(404, 33);
            this.CbType.TabIndex = 26;
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(265, 478);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(404, 31);
            this.DtpDate.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1758, 48);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(98, 44);
            this.cToolStripMenuItem.Text = "Chart ";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem1,
            this.printPrieToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(71, 44);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsTextFileToolStripMenuItem1});
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(278, 44);
            this.exportToolStripMenuItem1.Text = "Export";
            // 
            // exportAsTextFileToolStripMenuItem1
            // 
            this.exportAsTextFileToolStripMenuItem1.Name = "exportAsTextFileToolStripMenuItem1";
            this.exportAsTextFileToolStripMenuItem1.Size = new System.Drawing.Size(340, 44);
            this.exportAsTextFileToolStripMenuItem1.Text = "Export As Text File";
            this.exportAsTextFileToolStripMenuItem1.Click += new System.EventHandler(this.exportAsTextFileToolStripMenuItem1_Click_1);
            // 
            // printPrieToolStripMenuItem
            // 
            this.printPrieToolStripMenuItem.Name = "printPrieToolStripMenuItem";
            this.printPrieToolStripMenuItem.Size = new System.Drawing.Size(278, 44);
            this.printPrieToolStripMenuItem.Text = "PrintPreview";
            this.printPrieToolStripMenuItem.Click += new System.EventHandler(this.printPrieToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exportAsTextFileToolStripMenuItem
            // 
            this.exportAsTextFileToolStripMenuItem.Name = "exportAsTextFileToolStripMenuItem";
            this.exportAsTextFileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializableToolStripMenuItem,
            this.deserializableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 80);
            // 
            // serializableToolStripMenuItem
            // 
            this.serializableToolStripMenuItem.Name = "serializableToolStripMenuItem";
            this.serializableToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.serializableToolStripMenuItem.Text = "Serializable";
            this.serializableToolStripMenuItem.Click += new System.EventHandler(this.SerializableToolStripMenuItem_Click);
            // 
            // deserializableToolStripMenuItem
            // 
            this.deserializableToolStripMenuItem.Name = "deserializableToolStripMenuItem";
            this.deserializableToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.deserializableToolStripMenuItem.Text = "Deserializable";
            this.deserializableToolStripMenuItem.Click += new System.EventHandler(this.DeserializableToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(111, 721);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(265, 71);
            this.btnAddGood.TabIndex = 30;
            this.btnAddGood.Text = "Add Good";
            this.btnAddGood.UseVisualStyleBackColor = true;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(404, 721);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(265, 71);
            this.btnAddSupplier.TabIndex = 31;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(StockManagement.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 878);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnAddGood);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.CbType);
            this.Controls.Add(this.NudQuantity);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbGoodId);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbSupplierId);
            this.Controls.Add(this.lbOperationId);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "OperationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSupplierId;
        private System.Windows.Forms.Label lbOperationId;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbGoodId;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.NumericUpDown NudQuantity;
        private System.Windows.Forms.ComboBox CbType;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsTextFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializableToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportAsTextFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printPrieToolStripMenuItem;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
    }
}