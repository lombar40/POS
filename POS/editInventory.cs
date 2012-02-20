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

        }

        /// <summary>
        /// Clears all the error labels
        /// </summary>
        private void clearErrorLabels()
        {
            skuErrorLabel.Visible = false;
            databaseErrorLabel.Visible = false;
            queryErrorLabel.Visible = false;
        }

        private void retrieveItemButton_Click(object sender, EventArgs e)
        {
            int returnValue = 0;    // Storage of database query return value
            int sku=0;              // Storage of SKU
            
            // Clear error labels
            clearErrorLabels();

            // Try the parsing of SKU Text Box
            try
            {
                // Parse SKU Text Box to integer and query database for SKU
                sku = Int32.Parse(sKUTextBox.Text);
                returnValue = inventoryTableAdapter.FillBySKU(pOSDataSet.Inventory, sku);

                // Check to see if SKU was found
                switch (returnValue)
                {
                    // SKU not found
                    case 0:
                        skuErrorLabel.Text = "SKU not found!";
                        skuErrorLabel.Visible = true;
                        break;
                    // Valid SKU found
                    case 1:
                        descriptionTextBox.Focus();
                        sKUTextBox.Enabled = false;
                        descriptionTextBox.Enabled = true;
                        priceTextBox.Enabled = true;
                        quantityTextBox.Enabled = true;
                        retrieveItemButton.Enabled = false;
                        addNewItemButton.Enabled = false;
                        saveButton.Enabled = true;
                        break;
                    // Database query error
                    default:
                        databaseErrorLabel.Visible = true;
                        break;
                }
            }
            // Catch errors when parsing SKU to an integer
            catch
            {
                skuErrorLabel.Text = "Invalid SKU!";
                skuErrorLabel.Visible = true;
            }  
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {

            // Clear error labels
            clearErrorLabels();

            // Change button visibility and set focus.
            descriptionTextBox.Focus();
            sKUTextBox.Enabled = false;
            descriptionTextBox.Enabled = true;
            priceTextBox.Enabled = true;
            quantityTextBox.Enabled = true;
            retrieveItemButton.Enabled = false;
            addNewItemButton.Enabled = false;
            saveButton.Enabled = true;
        } 
        
        private void saveButton_Click(object sender, EventArgs e)
        {

            int sku;            // Storage of SKU
            string description; // Storage of Description
            decimal price;      // Storage of Price
            int quantity;       // Storage of Quantity

            // Clear error labels
            clearErrorLabels();

            // Try parsing of the text boxes
            try
            {
                sku = Int32.Parse(sKUTextBox.Text);
                description = descriptionTextBox.Text;
                price = Decimal.Parse(priceTextBox.Text);
                quantity = Int32.Parse(quantityTextBox.Text);
                inventoryTableAdapter.UpdateQuery(description, price, quantity, sku);
            }
            // Catch invalid data entry errors and return
            catch
            {
                queryErrorLabel.Visible = true;
                return;
            }

            // Change button/textbox visibility, set focus, and clear text boxes.
            pOSDataSet.Clear();
            sKUTextBox.Enabled = true;
            descriptionTextBox.Enabled = false;
            priceTextBox.Enabled = false;
            quantityTextBox.Enabled = false;
            retrieveItemButton.Enabled = true;
            addNewItemButton.Enabled = true;
            saveButton.Enabled = false;
            sKUTextBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Clear error labels
            clearErrorLabels();

            // Change button/textbox visibility, set focus, and clear text boxes.
            inventoryTableAdapter.FillBySKU(pOSDataSet.Inventory, 9999);
            sKUTextBox.Enabled = true;
            descriptionTextBox.Enabled = false;
            priceTextBox.Enabled = false;
            quantityTextBox.Enabled = false;
            retrieveItemButton.Enabled = true;
            addNewItemButton.Enabled = true;
            saveButton.Enabled = false;
            sKUTextBox.Focus();
        }
    }
}
