using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_C
{
    public partial class editInventory : Form
    {
        public editInventory()
        {
            InitializeComponent();
        }

        private void editInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.pOSDataSet.Inventory);
 
        }

        private void retrieveItemButton_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            int sku;
            try
            {
                sku = Int32.Parse(this.sKUTextBox.Text);
                returnValue = this.inventoryTableAdapter.FillBySKU(this.pOSDataSet.Inventory, sku);
                switch (returnValue)
                {
                    case 0:
                        MessageBox.Show(this, "SKU not found", "Error");
                        break;
                    default:
                        this.descriptionTextBox.Focus();
                        this.sKUTextBox.Enabled = false;
                        this.descriptionTextBox.Enabled = true;
                        this.priceTextBox.Enabled = true;
                        this.quantityTextBox.Enabled = true;
                        this.retrieveItemButton.Enabled = false;
                        this.addNewItemButton.Enabled = false;
                        this.saveButton.Enabled = true;
                        break;
                }
            }
            catch
            {
                MessageBox.Show(this, "Invalid SKU", "Error");
            }
            
            
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {

            // Code here




            this.descriptionTextBox.Focus();
            this.sKUTextBox.Enabled = false;
            this.descriptionTextBox.Enabled = true;
            this.priceTextBox.Enabled = true;
            this.quantityTextBox.Enabled = true;
            this.retrieveItemButton.Enabled = false;
            this.addNewItemButton.Enabled = false;
            this.saveButton.Enabled = true;
        } 
        
        private void saveButton_Click(object sender, EventArgs e)
        {

            int sku;
            string description;
            decimal price;
            int quantity;

            try
            {
                sku = Int32.Parse(sKUTextBox.Text);
                description = descriptionTextBox.Text;
                price = Decimal.Parse(priceTextBox.Text);
                quantity = Int32.Parse(quantityTextBox.Text);
                this.inventoryTableAdapter.UpdateQuery(description, price, quantity, sku);
            }
            catch
            {
                MessageBox.Show(this, "Invalid Update Values", "Error");
            }

            this.sKUTextBox.Focus();
            this.sKUTextBox.Enabled = true;
            this.descriptionTextBox.Enabled = false;
            this.priceTextBox.Enabled = false;
            this.quantityTextBox.Enabled = false;
            this.retrieveItemButton.Enabled = true;
            this.addNewItemButton.Enabled = true;
            this.saveButton.Enabled = false;
            this.sKUTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.priceTextBox.Text = "";
            this.quantityTextBox.Text = "";
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSDataSet);

        }
    }
}
