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
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.amountTenderedBox = new System.Windows.Forms.TextBox();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.newTransactionButton = new System.Windows.Forms.Button();
            this.skuErrorLabel = new System.Windows.Forms.Label();
            this.tenderedErrorLabel = new System.Windows.Forms.Label();
            this.currentTransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.transactionSplitContainer = new System.Windows.Forms.SplitContainer();
            this.closePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.currentTransactionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionSplitContainer)).BeginInit();
            this.transactionSplitContainer.Panel1.SuspendLayout();
            this.transactionSplitContainer.Panel2.SuspendLayout();
            this.transactionSplitContainer.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeTransactions
            // 
            this.closeTransactions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeTransactions.Location = new System.Drawing.Point(180, 10);
            this.closeTransactions.Name = "closeTransactions";
            this.closeTransactions.Size = new System.Drawing.Size(75, 23);
            this.closeTransactions.TabIndex = 5;
            this.closeTransactions.Text = "Close [ESC]";
            this.closeTransactions.UseVisualStyleBackColor = true;
            this.closeTransactions.Click += new System.EventHandler(this.closeTransactions_Click);
            // 
            // skuBox
            // 
            this.skuBox.Location = new System.Drawing.Point(21, 25);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(100, 20);
            this.skuBox.TabIndex = 1;
            this.skuBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addItem_keyPress);
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(18, 6);
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
            this.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventoryDataGridView.MultiSelect = false;
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.ShowEditingIcon = false;
            this.inventoryDataGridView.Size = new System.Drawing.Size(550, 548);
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
            this.subtotalTitleLabel.Location = new System.Drawing.Point(20, 58);
            this.subtotalTitleLabel.Name = "subtotalTitleLabel";
            this.subtotalTitleLabel.Size = new System.Drawing.Size(62, 15);
            this.subtotalTitleLabel.TabIndex = 7;
            this.subtotalTitleLabel.Text = "Sub Total:";
            // 
            // taxTitleLabel
            // 
            this.taxTitleLabel.AutoSize = true;
            this.taxTitleLabel.Location = new System.Drawing.Point(20, 94);
            this.taxTitleLabel.Name = "taxTitleLabel";
            this.taxTitleLabel.Size = new System.Drawing.Size(30, 15);
            this.taxTitleLabel.TabIndex = 8;
            this.taxTitleLabel.Text = "Tax:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(20, 71);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(38, 15);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "$0.00";
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTitleLabel.Location = new System.Drawing.Point(20, 131);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(45, 18);
            this.totalTitleLabel.TabIndex = 10;
            this.totalTitleLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(20, 148);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 22);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "$0.00";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(20, 107);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(38, 15);
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
            this.totalItemsTitleLabel.Location = new System.Drawing.Point(20, 23);
            this.totalItemsTitleLabel.Name = "totalItemsTitleLabel";
            this.totalItemsTitleLabel.Size = new System.Drawing.Size(70, 15);
            this.totalItemsTitleLabel.TabIndex = 16;
            this.totalItemsTitleLabel.Text = "Total Items:";
            // 
            // totalItemsLabel
            // 
            this.totalItemsLabel.AutoSize = true;
            this.totalItemsLabel.Location = new System.Drawing.Point(21, 36);
            this.totalItemsLabel.Name = "totalItemsLabel";
            this.totalItemsLabel.Size = new System.Drawing.Size(14, 15);
            this.totalItemsLabel.TabIndex = 17;
            this.totalItemsLabel.Text = "0";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(20, 296);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(91, 13);
            this.tenderedLabel.TabIndex = 18;
            this.tenderedLabel.Text = "Amount tendered:";
            // 
            // amountTenderedBox
            // 
            this.amountTenderedBox.Location = new System.Drawing.Point(20, 312);
            this.amountTenderedBox.Name = "amountTenderedBox";
            this.amountTenderedBox.Size = new System.Drawing.Size(100, 20);
            this.amountTenderedBox.TabIndex = 2;
            this.amountTenderedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tender_Enter);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Enabled = false;
            this.finalizeButton.Location = new System.Drawing.Point(12, 450);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(121, 23);
            this.finalizeButton.TabIndex = 3;
            this.finalizeButton.Text = "Finalize [F5]";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.Location = new System.Drawing.Point(12, 479);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(121, 23);
            this.newTransactionButton.TabIndex = 4;
            this.newTransactionButton.Text = "New Transaction [F3]";
            this.newTransactionButton.UseVisualStyleBackColor = true;
            this.newTransactionButton.Click += new System.EventHandler(this.newTransactionButton_Click);
            // 
            // skuErrorLabel
            // 
            this.skuErrorLabel.AutoSize = true;
            this.skuErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.skuErrorLabel.Location = new System.Drawing.Point(32, 48);
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
            this.tenderedErrorLabel.Location = new System.Drawing.Point(12, 335);
            this.tenderedErrorLabel.Name = "tenderedErrorLabel";
            this.tenderedErrorLabel.Size = new System.Drawing.Size(121, 13);
            this.tenderedErrorLabel.TabIndex = 22;
            this.tenderedErrorLabel.Text = "Invalid amount tendered";
            this.tenderedErrorLabel.Visible = false;
            // 
            // currentTransactionGroupBox
            // 
            this.currentTransactionGroupBox.Controls.Add(this.totalItemsTitleLabel);
            this.currentTransactionGroupBox.Controls.Add(this.subtotalLabel);
            this.currentTransactionGroupBox.Controls.Add(this.subtotalTitleLabel);
            this.currentTransactionGroupBox.Controls.Add(this.taxTitleLabel);
            this.currentTransactionGroupBox.Controls.Add(this.totalTitleLabel);
            this.currentTransactionGroupBox.Controls.Add(this.totalLabel);
            this.currentTransactionGroupBox.Controls.Add(this.totalItemsLabel);
            this.currentTransactionGroupBox.Controls.Add(this.taxLabel);
            this.currentTransactionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTransactionGroupBox.Location = new System.Drawing.Point(12, 81);
            this.currentTransactionGroupBox.Name = "currentTransactionGroupBox";
            this.currentTransactionGroupBox.Size = new System.Drawing.Size(115, 183);
            this.currentTransactionGroupBox.TabIndex = 23;
            this.currentTransactionGroupBox.TabStop = false;
            this.currentTransactionGroupBox.Text = "Totals";
            // 
            // transactionSplitContainer
            // 
            this.transactionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionSplitContainer.IsSplitterFixed = true;
            this.transactionSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.transactionSplitContainer.Name = "transactionSplitContainer";
            // 
            // transactionSplitContainer.Panel1
            // 
            this.transactionSplitContainer.Panel1.Controls.Add(this.skuErrorLabel);
            this.transactionSplitContainer.Panel1.Controls.Add(this.tenderedErrorLabel);
            this.transactionSplitContainer.Panel1.Controls.Add(this.currentTransactionGroupBox);
            this.transactionSplitContainer.Panel1.Controls.Add(this.finalizeButton);
            this.transactionSplitContainer.Panel1.Controls.Add(this.newTransactionButton);
            // 
            // transactionSplitContainer.Panel2
            // 
            this.transactionSplitContainer.Panel2.Controls.Add(this.closePanel);
            this.transactionSplitContainer.Panel2.Controls.Add(this.inventoryDataGridView);
            this.transactionSplitContainer.Size = new System.Drawing.Size(700, 548);
            this.transactionSplitContainer.SplitterDistance = 146;
            this.transactionSplitContainer.TabIndex = 24;
            this.transactionSplitContainer.TabStop = false;
            // 
            // closePanel
            // 
            this.closePanel.Controls.Add(this.closeTransactions);
            this.closePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closePanel.Location = new System.Drawing.Point(0, 503);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(550, 45);
            this.closePanel.TabIndex = 6;
            // 
            // transactionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeTransactions;
            this.ClientSize = new System.Drawing.Size(700, 548);
            this.Controls.Add(this.amountTenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeTitleLabel);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.skuBox);
            this.Controls.Add(this.transactionSplitContainer);
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
            this.currentTransactionGroupBox.ResumeLayout(false);
            this.currentTransactionGroupBox.PerformLayout();
            this.transactionSplitContainer.Panel1.ResumeLayout(false);
            this.transactionSplitContainer.Panel1.PerformLayout();
            this.transactionSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionSplitContainer)).EndInit();
            this.transactionSplitContainer.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeTransactions;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label subtotalTitleLabel;
        private System.Windows.Forms.Label taxTitleLabel;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label totalItemsTitleLabel;
        private System.Windows.Forms.Label tenderedLabel;
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
        private System.Windows.Forms.GroupBox currentTransactionGroupBox;
        private System.Windows.Forms.SplitContainer transactionSplitContainer;
        private System.Windows.Forms.Panel closePanel;
        public System.Windows.Forms.DataGridView inventoryDataGridView;
    }
}