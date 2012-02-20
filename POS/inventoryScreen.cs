﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS_C
{
    public partial class inventoryScreen : Form
    {
        int checkedRadioBox;
        int queryReturnValue;

        public inventoryScreen()
        {
            InitializeComponent();
        }

        private void inventoryScreen_Load(object sender, EventArgs e)
        {
            // Set table column properties
            inventoryDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            inventoryDataGridView.Columns[2].DefaultCellStyle.Format = "c";        // currency format
            inventoryDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Fill table upon opening of the window with inventory data
            queryReturnValue = inventoryTableAdapter.Fill(pOSDataSet.Inventory);
            queryLabel.Text = queryReturnValue + " item(s) found";

            // Set initial radioBox value to 1
            checkedRadioBox = 1;   
        }

        // Set focus to the search box and highlight any current text inside
        private void FocusSearchBox1()
        {
            searchBox1.Focus();
            searchBox1.SelectionStart = 0;
            searchBox1.SelectionLength = searchBox1.TextLength;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int sku;                        // Stores the SKU to be searched for
            string description;             // Stores search description
            decimal toPrice, fromPrice;     // Stores to and from search prices
            int toQuantity, fromQuantity;   // Stores to and from search quantities

            // Catch errors with search data
            try
            {
                // Execute SQL queries based on the selected radio box
                switch (checkedRadioBox)
                {
                    case 1:
                        // Parse data from search boxes, fill table with found data, and return number of items found
                        sku = Int32.Parse(searchBox1.Text);
                        queryReturnValue = inventoryTableAdapter.FillBySKU(pOSDataSet.Inventory, sku);
                        break;
                    case 2:
                        // Parse data from search boxes, fill table with found data, and return number of items found
                        description = '%' + searchBox1.Text + '%';
                        queryReturnValue = inventoryTableAdapter.FillByDescription(pOSDataSet.Inventory, description);
                        break;
                    case 3:
                        // Parse data from search boxes, fill table with found data, and return number of items found
                        fromPrice = Decimal.Parse(searchBox1.Text); 
                        toPrice = Decimal.Parse(searchBox2.Text);
                        queryReturnValue = inventoryTableAdapter.FillByPrice(pOSDataSet.Inventory, fromPrice, toPrice);
                        break;
                    case 4:
                        // Parse data from search boxes, fill table with found data, and return number of items found
                        fromQuantity = Int32.Parse(searchBox1.Text);
                        toQuantity = Int32.Parse(searchBox2.Text);
                        queryReturnValue = inventoryTableAdapter.FillByQuantity(pOSDataSet.Inventory, fromQuantity, toQuantity);
                        break;
                    default:
                        // Error
                        queryLabel.Text = "Invalid Search Query";
                        break;
                }

                // Set queryLabel to display number of found item(s)
                queryLabel.Text = queryReturnValue + " item(s) found";
            }
            catch
            {
                // Display error message and play sound on invalid input
                queryLabel.Text = "Invalid Search Query";    
            }

            // Set focus to searchBox1
            FocusSearchBox1();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear labels and textboxes
            queryLabel.Text = "";
            searchBox1.Text = "";
            searchBox2.Text = "";

            // Check the skuRadioButton
            skuRadioButton.Checked = true;

            // Reset table
            inventoryTableAdapter.Fill(pOSDataSet.Inventory);
            queryLabel.Text = queryReturnValue + " item(s) found";

            // Set focus to searchBox1
            searchBox1.Focus();
        }

        private void skuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and hide searchBox2
            checkedRadioBox = 1;
            searchLabel1.Text = "SKU:";
            searchLabel2.Text = "";
            searchBox2.Visible = false;

            // Set focus to searchBox1
            FocusSearchBox1();
        }

        private void descriptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and hide searchBox2
            checkedRadioBox = 2;
            searchLabel1.Text = "Description:";
            searchLabel2.Text = "";
            searchBox2.Visible = false;

            // Set focus to searchBox1
            FocusSearchBox1();
        }

        private void priceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and show searchBox2
            checkedRadioBox = 3;
            searchLabel1.Text = "From:";
            searchLabel2.Text = "To:";
            searchBox2.Visible = true;

            // Set focus to searchBox1
            FocusSearchBox1();
        }

        private void quantityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and show searchBox2
            checkedRadioBox = 4;
            searchLabel1.Text = "From:";
            searchLabel2.Text = "To:";
            searchBox2.Visible = true;

            // Set focus to searchBox1
            FocusSearchBox1();
        }

        // Close the form
        private void closeInventoryView_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
