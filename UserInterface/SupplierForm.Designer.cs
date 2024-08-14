namespace StockManagement
{
    partial class SupplierForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbContactInfo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.lbSupplierId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbContactInfo = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(785, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(948, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbContactInfo
            // 
            this.tbContactInfo.Location = new System.Drawing.Point(205, 350);
            this.tbContactInfo.Name = "tbContactInfo";
            this.tbContactInfo.Size = new System.Drawing.Size(484, 31);
            this.tbContactInfo.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(205, 255);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(484, 31);
            this.tbName.TabIndex = 5;
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(205, 180);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(484, 31);
            this.nudId.TabIndex = 6;
            // 
            // lbSupplierId
            // 
            this.lbSupplierId.AutoSize = true;
            this.lbSupplierId.Location = new System.Drawing.Point(83, 138);
            this.lbSupplierId.Name = "lbSupplierId";
            this.lbSupplierId.Size = new System.Drawing.Size(114, 25);
            this.lbSupplierId.TabIndex = 7;
            this.lbSupplierId.Text = "Supplier Id";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(71, 231);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 25);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Name";
            // 
            // lbContactInfo
            // 
            this.lbContactInfo.AutoSize = true;
            this.lbContactInfo.Location = new System.Drawing.Point(71, 322);
            this.lbContactInfo.Name = "lbContactInfo";
            this.lbContactInfo.Size = new System.Drawing.Size(198, 25);
            this.lbContactInfo.TabIndex = 11;
            this.lbContactInfo.Text = "Contact Information";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(88, 480);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(147, 53);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(542, 480);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(147, 53);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(315, 480);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(147, 53);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 730);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.lbContactInfo);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSupplierId);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbContactInfo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbContactInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label lbSupplierId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbContactInfo;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
    }
}