namespace POS_C
{
    partial class transactionScreen
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
            this.closeTransactions = new System.Windows.Forms.Button();
            this.skuBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.pOSDataSet = new POS_C.POSDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new POS_C.POSDataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new POS_C.POSDataSetTableAdapters.TableAdapterManager();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalTitleLabel = new System.Windows.Forms.Label();
            this.taxTitleLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.totalTitleLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.changeTitleLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.totalItemsTitleLabel = new System.Windows.Forms.Label();
            this.totalItemsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTenderedBox = new System.Windows.Forms.TextBox();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.newTransactionButton = new System.Windows.Forms.Button();
            this.skuErrorLabel = new System.Windows.Forms.Label();
            this.tenderedErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeTransactions
            // 
            this.closeTransactions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeTransactions.Location = new System.Drawing.Point(296, 508);
            this.closeTransactions.Name = "closeTransactions";
            this.closeTransactions.Size = new System.Drawing.Size(75, 23);
            this.closeTransactions.TabIndex = 5;
            this.closeTransactions.Text = "Close";
            this.closeTransactions.UseVisualStyleBackColor = true;
            this.closeTransactions.Click += new System.EventHandler(this.closeTransactions_Click);
            // 
            // skuBox
            // 
            this.skuBox.Location = new System.Drawing.Point(12, 25);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(100, 20);
            this.skuBox.TabIndex = 1;
            this.skuBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addItem);
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(9, 6);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(32, 13);
            this.skuLabel.TabIndex = 4;
            this.skuLabel.Text = "SKU:";
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.pOSDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = false;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = POS_C.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.dataGridViewTextBoxColumn3});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
            this.inventoryDataGridView.Location = new System.Drawing.Point(133, 28);
            this.inventoryDataGridView.MultiSelect = false;
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.ShowEditingIcon = false;
            this.inventoryDataGridView.Size = new System.Drawing.Size(551, 474);
            this.inventoryDataGridView.TabIndex = 5;
            this.inventoryDataGridView.TabStop = false;
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
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // subtotalTitleLabel
            // 
            this.subtotalTitleLabel.AutoSize = true;
            this.subtotalTitleLabel.Location = new System.Drawing.Point(12, 152);
            this.subtotalTitleLabel.Name = "subtotalTitleLabel";
            this.subtotalTitleLabel.Size = new System.Drawing.Size(56, 13);
            this.subtotalTitleLabel.TabIndex = 7;
            this.subtotalTitleLabel.Text = "Sub Total:";
            // 
            // taxTitleLabel
            // 
            this.taxTitleLabel.AutoSize = true;
            this.taxTitleLabel.Location = new System.Drawing.Point(12, 195);
            this.taxTitleLabel.Name = "taxTitleLabel";
            this.taxTitleLabel.Size = new System.Drawing.Size(28, 13);
            this.taxTitleLabel.TabIndex = 8;
            this.taxTitleLabel.Text = "Tax:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 165);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(34, 13);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "$0.00";
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTitleLabel.Location = new System.Drawing.Point(12, 233);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(45, 18);
            this.totalTitleLabel.TabIndex = 10;
            this.totalTitleLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 250);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 22);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "$0.00";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(12, 208);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(34, 13);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "$0.00";
            // 
            // changeTitleLabel
            // 
            this.changeTitleLabel.AutoSize = true;
            this.changeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTitleLabel.Location = new System.Drawing.Point(12, 369);
            this.changeTitleLabel.Name = "changeTitleLabel";
            this.changeTitleLabel.Size = new System.Drawing.Size(58, 16);
            this.changeTitleLabel.TabIndex = 14;
            this.changeTitleLabel.Text = "Change:";
            this.changeTitleLabel.Visible = false;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(18, 402);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 22);
            this.changeLabel.TabIndex = 15;
            // 
            // totalItemsTitleLabel
            // 
            this.totalItemsTitleLabel.AutoSize = true;
            this.totalItemsTitleLabel.Location = new System.Drawing.Point(13, 103);
            this.totalItemsTitleLabel.Name = "totalItemsTitleLabel";
            this.totalItemsTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.totalItemsTitleLabel.TabIndex = 16;
            this.totalItemsTitleLabel.Text = "Total Items:";
            // 
            // totalItemsLabel
            // 
            this.totalItemsLabel.AutoSize = true;
            this.totalItemsLabel.Location = new System.Drawing.Point(13, 116);
            this.totalItemsLabel.Name = "totalItemsLabel";
            this.totalItemsLabel.Size = new System.Drawing.Size(13, 13);
            this.totalItemsLabel.TabIndex = 17;
            this.totalItemsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Amount tendered:";
            // 
            // amountTenderedBox
            // 
            this.amountTenderedBox.Location = new System.Drawing.Point(12, 312);
            this.amountTenderedBox.Name = "amountTenderedBox";
            this.amountTenderedBox.Size = new System.Drawing.Size(100, 20);
            this.amountTenderedBox.TabIndex = 2;
            this.amountTenderedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tender_Enter);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(6, 450);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(106, 23);
            this.finalizeButton.TabIndex = 3;
            this.finalizeButton.Text = "Finalize";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.Location = new System.Drawing.Point(6, 479);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(106, 23);
            this.newTransactionButton.TabIndex = 4;
            this.newTransactionButton.Text = "New Transaction";
            this.newTransactionButton.UseVisualStyleBackColor = true;
            this.newTransactionButton.Click += new System.EventHandler(this.newTransactionButton_Click);
            // 
            // skuErrorLabel
            // 
            this.skuErrorLabel.AutoSize = true;
            this.skuErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.skuErrorLabel.Location = new System.Drawing.Point(21, 48);
            this.skuErrorLabel.Name = "skuErrorLabel";
            this.skuErrorLabel.Size = new System.Drawing.Size(77, 13);
            this.skuErrorLabel.TabIndex = 21;
            this.skuErrorLabel.Text = "SKU not found";
            this.skuErrorLabel.Visible = false;
            // 
            // tenderedErrorLabel
            // 
            this.tenderedErrorLabel.AutoSize = true;
            this.tenderedErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.tenderedErrorLabel.Location = new System.Drawing.Point(3, 335);
            this.tenderedErrorLabel.Name = "tenderedErrorLabel";
            this.tenderedErrorLabel.Size = new System.Drawing.Size(121, 13);
            this.tenderedErrorLabel.TabIndex = 22;
            this.tenderedErrorLabel.Text = "Invalid amount tendered";
            this.tenderedErrorLabel.Visible = false;
            // 
            // transactionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeTransactions;
            this.ClientSize = new System.Drawing.Size(696, 551);
            this.Controls.Add(this.tenderedErrorLabel);
            this.Controls.Add(this.skuErrorLabel);
            this.Controls.Add(this.newTransactionButton);
            this.Controls.Add(this.amountTenderedBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalItemsLabel);
            this.Controls.Add(this.totalItemsTitleLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeTitleLabel);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTitleLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.taxTitleLabel);
            this.Controls.Add(this.subtotalTitleLabel);
            this.Controls.Add(this.inventoryDataGridView);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.skuBox);
            this.Controls.Add(this.closeTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "transactionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.transactionsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeTransactions;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label subtotalTitleLabel;
        private System.Windows.Forms.Label taxTitleLabel;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label totalItemsTitleLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox amountTenderedBox;
        public System.Windows.Forms.TextBox skuBox;
        public System.Windows.Forms.Label subtotalLabel;
        public System.Windows.Forms.Label totalLabel;
        public System.Windows.Forms.Label taxLabel;
        public System.Windows.Forms.Label changeLabel;
        public System.Windows.Forms.Label totalItemsLabel;
        private System.Windows.Forms.Button newTransactionButton;
        public POSDataSet pOSDataSet;
        public System.Windows.Forms.Label changeTitleLabel;
        public System.Windows.Forms.Label skuErrorLabel;
        public System.Windows.Forms.Label tenderedErrorLabel;
        public System.Windows.Forms.Button finalizeButton;
        public POSDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
    }
}