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
        inventoryScreen inventoryScreen;    // Stores control of the inventoryScreen
        int queryState;                     // State of the query, 1 = Retrive item, 2 = New Item

        public editInventory(inventoryScreen form)
        {
            InitializeComponent();
            this.inventoryScreen = form;    // Store control of inventoryScreen

            // Sets up the handling of key input in the form.
            KeyPreview = true;
            KeyDown += new KeyEventHandler(editInventory_KeyDown);
        }

        // Function that clears all the error labels on the form.
        private void clearErrorLabels()
        {
            skuErrorLabel.Visible = false;
            databaseErrorLabel.Visible = false;
            queryErrorLabel.Visible = false;
        }

        // Changes buttons and textboxes to one of two states
        private void stateChange(int code)
        {
            switch (code)
            {
                case 1:
                    sKUTextBox.Enabled = true;
                    descriptionTextBox.Enabled = false;
                    priceTextBox.Enabled = false;
                    quantityTextBox.Enabled = false;
                    retrieveItemButton.Enabled = true;
                    addNewItemButton.Enabled = true;
                    saveButton.Enabled = false;
                    sKUTextBox.Focus();
                    break;
                case 2:
                    sKUTextBox.Enabled = false;
                    descriptionTextBox.Enabled = true;
                    priceTextBox.Enabled = true;
                    quantityTextBox.Enabled = true;
                    retrieveItemButton.Enabled = false;
                    addNewItemButton.Enabled = false;
                    saveButton.Enabled = true;
                    descriptionTextBox.Focus();
                    break;
            }
        }

        // Perform the proper actions when the Retrieve Item button is clicked.
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
                        stateChange(2);     // Change buttons and text boxes to state 2
                        queryState = 1;
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

        // Perform the proper actions when the Add New Item button is clicked.
        private void newItemButton_Click(object sender, EventArgs e)
        {
            int returnValue = 0;    // Storage of database query return value
            int sku = 0;              // Storage of SKU

            // Clear error labels
            clearErrorLabels();

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
                        stateChange(2);     // Change buttons and text boxes to state 2
                        sKUTextBox.Text = sku.ToString();
                        queryState = 2;
                        break;
                    // Valid SKU found
                    case 1:
                        skuErrorLabel.Text = "SKU already exists!";
                        skuErrorLabel.Visible = true;
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
        
        // Perform the proper actions when the Save button is clicked.
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
                switch (queryState)
                {
                    case 1:
                        inventoryTableAdapter.UpdateQuery(sku, description, price, quantity);
                        break;
                    case 2:
                        inventoryTableAdapter.AddItem(sku, description, price, quantity);
                        break;
                }
            }
            // Catch invalid data entry errors and return
            catch
            {
                queryErrorLabel.Visible = true;
                return;
            }

            // Change button/textbox visibility, set focus, and clear text boxes.
            inventoryScreen.queryLabel.Text = inventoryScreen.inventoryTableAdapter.Fill(inventoryScreen.pOSDataSet.Inventory) +" item(s) found";
            pOSDataSet.Clear();
            stateChange(1);     // Set buttons and text boxes to state 1
        }

        // Close the form.
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Perform the proper actions when the Cancel button is clicked.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Clear error labels
            clearErrorLabels();

            // Change button/textbox visibility, set focus, and clear text boxes.
            pOSDataSet.Clear();
            stateChange(1);     // Set buttons and text boxes to state 1
        }

        // Handles hotkey presses on the form
        // F1 = Retrieve Item
        // F2 = Add New Item
        // F3 = Cancel
        // F5 = Save
        private void editInventory_KeyDown(object sender, KeyEventArgs key)
        {
            switch (key.KeyCode)
            {
                case Keys.F1:
                    retrieveItemButton.PerformClick();
                    break;
                case Keys.F2:
                    addNewItemButton.PerformClick();
                    break;
                case Keys.F3:
                    cancelButton.PerformClick();
                    break;
                case Keys.F5:
                    saveButton.PerformClick();
                    break;
            }
        }
    }
}
