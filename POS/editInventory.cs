﻿using System;
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
                    // Returns an error and plays a sound when the
                    // specified SKU doesn't exist.
                    case 0:
                        errorSound.Play();
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

            // Code here







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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
