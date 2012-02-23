using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace POS_C
{
    class Transaction
    {
        // Default constructor
        public Transaction()
        {
            this.numOfItems = 0;
            this.totals = new Money();
            this.items = new int[100];
        }

        // Adds items to the transaction and increases the item count
        public int AddItem(int sku, transactionScreen form)
        {
            // Attempt to find and fill the table with the SKU
            int returnValue = form.inventoryTableAdapter.FillBySKU(form.pOSDataSet.Inventory, sku);

            // Check if an item was returned, and that the quantity is less than or equal to 0, and display the row in red
            if (returnValue != 0 && form.inventoryTableAdapter.GetQuantity(sku) <= 0)
                form.inventoryDataGridView.Rows[numOfItems].DefaultCellStyle.BackColor = Color.Red;

            // Clear selection of the view upon entry of a sku
            form.inventoryDataGridView.ClearSelection();

            // If an item was returned, increase number of items
            if (returnValue != 0)
            {
                this.items[numOfItems] = sku;
                this.numOfItems++;
            }

            // Return number of items
            return this.numOfItems;
        }

        // Updates the total and the labels during the transaction.
        public void UpdateTotals(decimal price, transactionScreen form)
        {
            totals.UpdateTotal(price);
            totals.UpdateTotalLabels(form);
        }

        // Calculates the transaction and displays the amount of change.
        public void finalize(decimal tendered, transactionScreen form)
        {
            decimal change;                     // Stores the amount of change to be given
            change = tendered - totals.total;   // Calculated change

            // If change is negative, throw an error indicating invalid tendered ammount (tendered < total)
            if (change < 0.00M)
                throw new System.ArgumentException("Invalid Tendered Ammount");

            // Set/display change and update the form upon completion of transaction
            form.changeTitleLabel.Visible = true;
            form.changeLabel.Text = change.ToString("c");
            form.amountTenderedBox.Enabled = false;
            form.finalizeButton.Enabled = false;
            form.skuBox.ResetText();
            form.skuBox.Enabled = false;

            // Decrement quantities in database
            for (int i = 0; i < numOfItems; i++)
            {
                form.inventoryTableAdapter.DecreaseQuantity(this.items[i]);
            }
        }

        private int numOfItems;      // Store the number of items in the transaction
        private Money totals;   // Stores totals of the transaction
        private int[] items;    // Stores the items in the transaction
    }
}
