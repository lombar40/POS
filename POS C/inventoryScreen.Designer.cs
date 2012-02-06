namespace POS_C
{
    partial class inventoryScreen
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
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.skuBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOS2DataSet = new POS_C.POS2DataSet();
            this.inventoryTableAdapter = new POS_C.POS2DataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new POS_C.POS2DataSetTableAdapters.TableAdapterManager();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOS2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.AllowUserToResizeColumns = false;
            this.inventoryDataGridView.AllowUserToResizeRows = false;
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
            this.inventoryDataGridView.Location = new System.Drawing.Point(192, 12);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.Size = new System.Drawing.Size(580, 538);
            this.inventoryDataGridView.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(50, 124);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // skuBox
            // 
            this.skuBox.Location = new System.Drawing.Point(63, 70);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(100, 20);
            this.skuBox.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SKU";
            this.dataGridViewTextBoxColumn1.HeaderText = "SKU";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.pOS2DataSet;
            // 
            // pOS2DataSet
            // 
            this.pOS2DataSet.DataSetName = "POS2DataSet";
            this.pOS2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = POS_C.POS2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(50, 501);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchErrorLabel.Location = new System.Drawing.Point(37, 108);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.searchErrorLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SKU:";
            // 
            // inventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchErrorLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.skuBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.inventoryDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inventoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.inventoryScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOS2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS2DataSet pOS2DataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private POS2DataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private POS2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox skuBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label searchErrorLabel;
        private System.Windows.Forms.Label label1;
    }
}