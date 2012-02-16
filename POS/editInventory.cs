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
        // Plays a sound when an error occurs
        System.Media.SoundPlayer errorSound = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        public editInventory()
        {
            InitializeComponent();
        }

        private void editInventory_Load(object sender, EventArgs e)
        {

        }
        private void retrieveItemButton_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            int sku=0;
            try
            {
                sku = Int32.Parse(this.sKUTextBox.Text);
                returnValue = this.inventoryTableAdapter.FillBySKU(this.pOSDataSet.Inventory, sku);
                switch (returnValue)
                {
                    case 0:
                        // Returns an error and plays a sound when the
                        // specified SKU doesn't exist.
                        errorSound.Play();
                        MessageBox.Show(this, "SKU not found", "Error");
                        break;
                    case 1:
                        this.descriptionTextBox.Focus();
                        this.sKUTextBox.Enabled = false;
                        this.descriptionTextBox.Enabled = true;
                        this.priceTextBox.Enabled = true;
                        this.quantityTextBox.Enabled = true;
                        this.retrieveItemButton.Enabled = false;
                        this.addNewItemButton.Enabled = false;
                        this.saveButton.Enabled = true;
                        break;
                    default:
                        // Returns an error and plays a sound when the user
                        // searches for a non-SKU query (ex. anything with letters/symbols/etc.)
                        errorSound.Play();
                        MessageBox.Show(this, "Database Error", "Error");
                        break;
                }
            }
            catch
            {
                // Returns an error and plays a sound when the user
                // searches for a non-SKU query (ex. anything with letters/symbols/etc.)
                errorSound.Play();
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
                sku = Int32.Parse(this.sKUTextBox.Text);
                description = this.descriptionTextBox.Text;
                price = Decimal.Parse(this.priceTextBox.Text);
                quantity = Int32.Parse(this.quantityTextBox.Text);
                this.inventoryTableAdapter.UpdateQuery(description, price, quantity, sku);
            }
            catch
            {
                MessageBox.Show(this, "Invalid Update Values", "Error");
                return;
            }

            // Clear text boxes and enable/disable buttons
            this.inventoryTableAdapter.FillBySKU(this.pOSDataSet.Inventory, 9999);
            this.sKUTextBox.Enabled = true;
            this.descriptionTextBox.Enabled = false;
            this.priceTextBox.Enabled = false;
            this.quantityTextBox.Enabled = false;
            this.retrieveItemButton.Enabled = true;
            this.addNewItemButton.Enabled = true;
            this.saveButton.Enabled = false;
            this.sKUTextBox.Focus();
            
        }
    }
}
