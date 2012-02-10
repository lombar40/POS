using System;
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
            this.inventoryDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.inventoryDataGridView.Columns[2].DefaultCellStyle.Format = "c";
            this.inventoryDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Fill table upon opening of the window with inventory data
            queryReturnValue = this.inventoryTableAdapter.Fill(this.pOSDataSet.Inventory);
            this.queryLabel.Text = queryReturnValue + " item(s) found";

            // Set initial radioBox value to 1
            checkedRadioBox = 1;
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
                        sku = Int32.Parse(this.searchBox1.Text);
                        queryReturnValue = inventoryTableAdapter.FillBySKU(this.pOSDataSet.Inventory, sku);
                        break;
                    case 2:
                        // Parse data from search boxes, fill table with found data, and return number of items found
                        description = '%' + this.searchBox1.Text + '%';
                        queryReturnValue = inventoryTableAdapter.FillByDescription(this.pOSDataSet.Inventory, description);
                        break;
                    case 3:
                        // Parse data from search boxes, fill table with found data, and return number of items found
                        fromPrice = Decimal.Parse(this.searchBox1.Text); 
                        toPrice = Decimal.Parse(this.searchBox2.Text);
                        queryReturnValue = this.inventoryTableAdapter.FillByPrice(this.pOSDataSet.Inventory, fromPrice, toPrice);
                        break;
                    case 4:
                        // Parse data from search boxes, fill table with found data, and return number of items found
                        fromQuantity = Int32.Parse(this.searchBox1.Text);
                        toQuantity = Int32.Parse(this.searchBox2.Text);
                        queryReturnValue = this.inventoryTableAdapter.FillByQuantity(this.pOSDataSet.Inventory, fromQuantity, toQuantity);
                        break;
                    default:
                        // Error
                        this.queryLabel.Text = "Invalid Search Query";
                        break;
                }

                // Set queryLabel to display number of found item(s)
                this.queryLabel.Text = queryReturnValue + " item(s) found";
            }
            catch
            {
                // Display error message on invalid input
                this.queryLabel.Text = "Invalid Search Query";    
            }

            // Set focus to searchBox1
            this.searchBox1.Focus();
            this.searchBox1.SelectionStart = 0;
            this.searchBox1.SelectionLength = this.searchBox1.TextLength;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear labels and textboxes
            this.queryLabel.Text = "";
            this.searchBox1.Text = "";
            this.searchBox2.Text = "";

            // Check the skuRadioButton
            this.skuRadioButton.Checked = true;

            // Reset table
            this.inventoryTableAdapter.Fill(this.pOSDataSet.Inventory);
            this.queryLabel.Text = queryReturnValue + " item(s) found";

            // Set focus to searchBox1
            this.searchBox1.Focus();
        }

        private void skuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and hide searchBox2
            checkedRadioBox = 1;
            this.searchLabel1.Text = "SKU:";
            this.searchLabel2.Text = "";
            this.searchBox2.Visible = false;

            // Set focus to searchBox1
            this.searchBox1.Focus();
            this.searchBox1.SelectionStart = 0;
            this.searchBox1.SelectionLength = this.searchBox1.TextLength;
        }

        private void descriptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and hide searchBox2
            checkedRadioBox = 2;
            this.searchLabel1.Text = "Description:";
            this.searchLabel2.Text = "";
            this.searchBox2.Visible = false;

            // Set focus to searchBox1
            this.searchBox1.Focus();
            this.searchBox1.SelectionStart = 0;
            this.searchBox1.SelectionLength = this.searchBox1.TextLength;
        }

        private void priceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and show searchBox2
            checkedRadioBox = 3;
            this.searchLabel1.Text = "From:";
            this.searchLabel2.Text = "To:";
            this.searchBox2.Visible = true;

            // Set focus to searchBox1
            this.searchBox1.Focus();
            this.searchBox1.SelectionStart = 0;
            this.searchBox1.SelectionLength = this.searchBox1.TextLength;
        }

        private void quantityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values, labels, and show searchBox2
            checkedRadioBox = 4;
            this.searchLabel1.Text = "From:";
            this.searchLabel2.Text = "To:";
            this.searchBox2.Visible = true;

            // Set focus to searchBox1
            this.searchBox1.Focus();
            this.searchBox1.SelectionStart = 0;
            this.searchBox1.SelectionLength = this.searchBox1.TextLength;
        }
    }
}
