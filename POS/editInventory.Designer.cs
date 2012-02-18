namespace POS_C
{
    partial class editInventory
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
            System.Windows.Forms.Label sKULabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            this.retrieveItemButton = new System.Windows.Forms.Button();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.sKUTextBox = new System.Windows.Forms.TextBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new POS_C.POSDataSet();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTableAdapter = new POS_C.POSDataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new POS_C.POSDataSetTableAdapters.TableAdapterManager();
            this.closeButton = new System.Windows.Forms.Button();
            this.queryErrorLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.skuErrorLabel = new System.Windows.Forms.Label();
            this.databaseErrorLabel = new System.Windows.Forms.Label();
            sKULabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sKULabel
            // 
            sKULabel.AutoSize = true;
            sKULabel.Location = new System.Drawing.Point(28, 26);
            sKULabel.Name = "sKULabel";
            sKULabel.Size = new System.Drawing.Size(32, 13);
            sKULabel.TabIndex = 13;
            sKULabel.Text = "SKU:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(100, 26);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(354, 26);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(463, 26);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 19;
            quantityLabel.Text = "Quantity:";
            // 
            // retrieveItemButton
            // 
            this.retrieveItemButton.Location = new System.Drawing.Point(192, 68);
            this.retrieveItemButton.Name = "retrieveItemButton";
            this.retrieveItemButton.Size = new System.Drawing.Size(93, 23);
            this.retrieveItemButton.TabIndex = 4;
            this.retrieveItemButton.Text = "Retrieve Item";
            this.retrieveItemButton.UseVisualStyleBackColor = true;
            this.retrieveItemButton.Click += new System.EventHandler(this.retrieveItemButton_Click);
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Location = new System.Drawing.Point(291, 68);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(93, 23);
            this.addNewItemButton.TabIndex = 5;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(146, 188);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sKUTextBox
            // 
            this.sKUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "SKU", true));
            this.sKUTextBox.Location = new System.Drawing.Point(28, 42);
            this.sKUTextBox.Name = "sKUTextBox";
            this.sKUTextBox.Size = new System.Drawing.Size(66, 20);
            this.sKUTextBox.TabIndex = 0;
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(103, 42);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(251, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Price", true));
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(357, 42);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Quantity", true));
            this.quantityTextBox.Enabled = false;
            this.quantityTextBox.Location = new System.Drawing.Point(466, 42);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 3;
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
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(344, 188);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // queryErrorLabel
            // 
            this.queryErrorLabel.AutoSize = true;
            this.queryErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.queryErrorLabel.Location = new System.Drawing.Point(221, 109);
            this.queryErrorLabel.Name = "queryErrorLabel";
            this.queryErrorLabel.Size = new System.Drawing.Size(144, 65);
            this.queryErrorLabel.TabIndex = 21;
            this.queryErrorLabel.Text = "Invalid data!\r\n\r\nRemember:\r\nMax length description is 100\r\nMax price is 9999.99";
            this.queryErrorLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(245, 188);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // skuErrorLabel
            // 
            this.skuErrorLabel.AutoSize = true;
            this.skuErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.skuErrorLabel.Location = new System.Drawing.Point(22, 68);
            this.skuErrorLabel.Name = "skuErrorLabel";
            this.skuErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.skuErrorLabel.TabIndex = 23;
            this.skuErrorLabel.Text = "SKU not found!";
            this.skuErrorLabel.Visible = false;
            // 
            // databaseErrorLabel
            // 
            this.databaseErrorLabel.AutoSize = true;
            this.databaseErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.databaseErrorLabel.Location = new System.Drawing.Point(177, 109);
            this.databaseErrorLabel.Name = "databaseErrorLabel";
            this.databaseErrorLabel.Size = new System.Drawing.Size(239, 39);
            this.databaseErrorLabel.TabIndex = 24;
            this.databaseErrorLabel.Text = "Database Error!\r\n\r\nCheck data entry or check database connection.";
            this.databaseErrorLabel.Visible = false;
            // 
            // editInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 223);
            this.Controls.Add(this.databaseErrorLabel);
            this.Controls.Add(this.skuErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.queryErrorLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(sKULabel);
            this.Controls.Add(this.sKUTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addNewItemButton);
            this.Controls.Add(this.retrieveItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Inventory";
            this.Load += new System.EventHandler(this.editInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retrieveItemButton;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button saveButton;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private POSDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox sKUTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label queryErrorLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label skuErrorLabel;
        private System.Windows.Forms.Label databaseErrorLabel;


    }
}