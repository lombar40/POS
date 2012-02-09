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
        public inventoryScreen()
        {
            InitializeComponent();
        }

        private void inventoryScreen_Load(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.pOSDataSet.Inventory);    // Fill table upon opening of the window with inventory data
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int sku;    // Stores the SKU to be searched for
            int returnValue=0;
            // Catch errors with search data
            try
            {
                sku = Int32.Parse(this.skuBox.Text);    // Convert sku string from search box to an integer
                this.searchErrorLabel.Text = "";        // Clear error label
                this.inventoryTableAdapter.FillBySKU(this.pOSDataSet.Inventory, sku);  // Fill table with data found

                // Check to see if any items were returned, if not, display SKU not found error
                returnValue = inventoryTableAdapter.FillBySKU(this.pOSDataSet.Inventory, sku);
                if (returnValue == 0)
                    this.searchErrorLabel.Text = "No items found";
            }
            catch
            {
                this.searchErrorLabel.Text = "Invalid Search Query";    // Display error message
            }
            this.skuBox.Focus();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.searchErrorLabel.Text = "";    // Clear error label
            this.skuBox.Text = "";  // Clear search box
            this.inventoryTableAdapter.Fill(this.pOSDataSet.Inventory);    // Reset inventory display to all items
            this.skuBox.Focus();
        }
    }
}
