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
            sKULabel.Location = new System.Drawing.Point(189, 231);
            sKULabel.Name = "sKULabel";
            sKULabel.Size = new System.Drawing.Size(32, 13);
            sKULabel.TabIndex = 13;
            sKULabel.Text = "SKU:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(261, 231);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(515, 231);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(624, 231);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 19;
            quantityLabel.Text = "Quantity:";
            // 
            // retrieveItemButton
            // 
            this.retrieveItemButton.Location = new System.Drawing.Point(299, 318);
            this.retrieveItemButton.Name = "retrieveItemButton";
            this.retrieveItemButton.Size = new System.Drawing.Size(93, 23);
            this.retrieveItemButton.TabIndex = 4;
            this.retrieveItemButton.Text = "Retrieve Item";
            this.retrieveItemButton.UseVisualStyleBackColor = true;
            this.retrieveItemButton.Click += new System.EventHandler(this.retrieveItemButton_Click);
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Location = new System.Drawing.Point(399, 318);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(85, 23);
            this.addNewItemButton.TabIndex = 5;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(490, 318);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sKUTextBox
            // 
            this.sKUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "SKU", true));
            this.sKUTextBox.Location = new System.Drawing.Point(189, 247);
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
            this.descriptionTextBox.Location = new System.Drawing.Point(264, 247);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(251, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Price", true));
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(518, 247);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Quantity", true));
            this.quantityTextBox.Enabled = false;
            this.quantityTextBox.Location = new System.Drawing.Point(627, 247);
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
            // editInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 568);
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


    }
}