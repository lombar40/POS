using System.Windows.Forms;
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox1 = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.queryLabel = new System.Windows.Forms.Label();
            this.searchLabel1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchLabel2 = new System.Windows.Forms.Label();
            this.searchBox2 = new System.Windows.Forms.TextBox();
            this.radioBox = new System.Windows.Forms.GroupBox();
            this.skuRadioButton = new System.Windows.Forms.RadioButton();
            this.quantityRadioButton = new System.Windows.Forms.RadioButton();
            this.descriptionRadioButton = new System.Windows.Forms.RadioButton();
            this.priceRadioButton = new System.Windows.Forms.RadioButton();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new POS_C.POSDataSet();
            this.inventoryTableAdapter = new POS_C.POSDataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new POS_C.POSDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.radioBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(61, 415);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox1
            // 
            this.searchBox1.Location = new System.Drawing.Point(75, 70);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(119, 20);
            this.searchBox1.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(61, 444);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // queryLabel
            // 
            this.queryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryLabel.ForeColor = System.Drawing.Color.Red;
            this.queryLabel.Location = new System.Drawing.Point(39, 399);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(121, 13);
            this.queryLabel.TabIndex = 5;
            this.queryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchLabel1
            // 
            this.searchLabel1.AutoSize = true;
            this.searchLabel1.Location = new System.Drawing.Point(8, 73);
            this.searchLabel1.Name = "searchLabel1";
            this.searchLabel1.Size = new System.Drawing.Size(32, 13);
            this.searchLabel1.TabIndex = 6;
            this.searchLabel1.Text = "SKU:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.searchLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox2);
            this.splitContainer1.Panel1.Controls.Add(this.radioBox);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox1);
            this.splitContainer1.Panel1.Controls.Add(this.searchLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            this.splitContainer1.Panel1.Controls.Add(this.queryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.resetButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.inventoryDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.TabStop = false;
            // 
            // searchLabel2
            // 
            this.searchLabel2.AutoSize = true;
            this.searchLabel2.Location = new System.Drawing.Point(8, 100);
            this.searchLabel2.Name = "searchLabel2";
            this.searchLabel2.Size = new System.Drawing.Size(0, 13);
            this.searchLabel2.TabIndex = 10;
            // 
            // searchBox2
            // 
            this.searchBox2.Location = new System.Drawing.Point(75, 97);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.Size = new System.Drawing.Size(119, 20);
            this.searchBox2.TabIndex = 2;
            this.searchBox2.Visible = false;
            // 
            // radioBox
            // 
            this.radioBox.Controls.Add(this.skuRadioButton);
            this.radioBox.Controls.Add(this.quantityRadioButton);
            this.radioBox.Controls.Add(this.descriptionRadioButton);
            this.radioBox.Controls.Add(this.priceRadioButton);
            this.radioBox.Location = new System.Drawing.Point(42, 147);
            this.radioBox.Name = "radioBox";
            this.radioBox.Size = new System.Drawing.Size(118, 111);
            this.radioBox.TabIndex = 3;
            this.radioBox.TabStop = false;
            this.radioBox.Text = "Select Search Type";
            // 
            // skuRadioButton
            // 
            this.skuRadioButton.AutoSize = true;
            this.skuRadioButton.Checked = true;
            this.skuRadioButton.Location = new System.Drawing.Point(6, 19);
            this.skuRadioButton.Name = "skuRadioButton";
            this.skuRadioButton.Size = new System.Drawing.Size(47, 17);
            this.skuRadioButton.TabIndex = 1;
            this.skuRadioButton.TabStop = true;
            this.skuRadioButton.Text = "SKU";
            this.skuRadioButton.UseVisualStyleBackColor = true;
            this.skuRadioButton.CheckedChanged += new System.EventHandler(this.skuRadioButton_CheckedChanged);
            // 
            // quantityRadioButton
            // 
            this.quantityRadioButton.AutoSize = true;
            this.quantityRadioButton.Location = new System.Drawing.Point(6, 88);
            this.quantityRadioButton.Name = "quantityRadioButton";
            this.quantityRadioButton.Size = new System.Drawing.Size(64, 17);
            this.quantityRadioButton.TabIndex = 4;
            this.quantityRadioButton.Text = "Quantity";
            this.quantityRadioButton.UseVisualStyleBackColor = true;
            this.quantityRadioButton.CheckedChanged += new System.EventHandler(this.quantityRadioButton_CheckedChanged);
            // 
            // descriptionRadioButton
            // 
            this.descriptionRadioButton.AutoSize = true;
            this.descriptionRadioButton.Location = new System.Drawing.Point(6, 42);
            this.descriptionRadioButton.Name = "descriptionRadioButton";
            this.descriptionRadioButton.Size = new System.Drawing.Size(78, 17);
            this.descriptionRadioButton.TabIndex = 2;
            this.descriptionRadioButton.Text = "Description";
            this.descriptionRadioButton.UseVisualStyleBackColor = true;
            this.descriptionRadioButton.CheckedChanged += new System.EventHandler(this.descriptionRadioButton_CheckedChanged);
            // 
            // priceRadioButton
            // 
            this.priceRadioButton.AutoSize = true;
            this.priceRadioButton.Location = new System.Drawing.Point(6, 65);
            this.priceRadioButton.Name = "priceRadioButton";
            this.priceRadioButton.Size = new System.Drawing.Size(49, 17);
            this.priceRadioButton.TabIndex = 3;
            this.priceRadioButton.Text = "Price";
            this.priceRadioButton.UseVisualStyleBackColor = true;
            this.priceRadioButton.CheckedChanged += new System.EventHandler(this.priceRadioButton_CheckedChanged);
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
            this.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventoryDataGridView.MultiSelect = false;
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.Size = new System.Drawing.Size(575, 562);
            this.inventoryDataGridView.TabIndex = 0;
            this.inventoryDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SKU";
            this.dataGridViewTextBoxColumn1.HeaderText = "SKU";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 53;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = POS_C.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryScreen
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inventoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.inventoryScreen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.radioBox.ResumeLayout(false);
            this.radioBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Label searchLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private POSDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private GroupBox radioBox;
        private RadioButton skuRadioButton;
        private RadioButton quantityRadioButton;
        private RadioButton descriptionRadioButton;
        private RadioButton priceRadioButton;
        private TextBox searchBox2;
        private Label searchLabel2;
    }
}