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

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOS2DataSet);

        }

        private void inventoryScreen_Load(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.pOS2DataSet.Inventory);    // Fill table upon opening of the window with inventory data
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int sku;    // Stores the SKU to be searched for

            // Catch errors with search data
            try
            {
                sku = Int32.Parse(this.skuBox.Text);    // Convert sku string from search box to an integer
                this.searchErrorLabel.Text = "";        // Clear error label
                this.inventoryTableAdapter.FillBySKU(this.pOS2DataSet.Inventory, sku);  // Fill table with data found
            }
            catch
            {
                this.searchErrorLabel.Text = "Invalid Search Query";    // Display error message
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.searchErrorLabel.Text = "";    // Clear error label
            this.inventoryTableAdapter.Fill(this.pOS2DataSet.Inventory);    // Reset inventory display to all items
        }
    }
}
