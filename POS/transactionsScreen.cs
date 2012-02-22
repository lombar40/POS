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
    public partial class transactionScreen : Form
    {
        Transaction transaction = new Transaction();        // Creation of initial transaction upon load

        public transactionScreen()
        {
            InitializeComponent();

            // Sets up the handling of key input in the form.
            KeyPreview = true;
            KeyDown += new KeyEventHandler(transactionScreen_KeyDown);
        }

        private void transactionsScreen_Load(object sender, EventArgs e)
        {
            // Set DataGridView properties upon load
            inventoryDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            inventoryDataGridView.Columns[2].DefaultCellStyle.Format = "c";        // currency format
        }

        // Handles hotkey presses on the form
        // F3 = New Transaction
        // F5 = Finalize
        private void transactionScreen_KeyDown(object sender, KeyEventArgs key)
        {
            switch (key.KeyCode)
            {
                case Keys.F3:
                    newTransactionButton.PerformClick();
                    break;
                case Keys.F5:
                    finalizeButton.PerformClick();
                    break;
            }
        }
        
        // Closes the Transactions form
        private void closeTransactions_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Finalize the transaction
        private void finalizeButton_Click(object sender, EventArgs e)
        {
            decimal tendered;
            skuErrorLabel.Visible = false;
            tenderedErrorLabel.Visible = false;

            // Try the parsing of tendered box, display error if invalid decimal or invalid tendered amount (less than total)
            try
            {
                tendered = Decimal.Parse(amountTenderedBox.Text);
                transaction.finalize(tendered, this);
            }
            catch
            {
                // Displays the tendered error label when a tender error is caught.
                tenderedErrorLabel.Visible = true;
                amountTenderedBox.Focus();
                amountTenderedBox.SelectionStart = 0;
                amountTenderedBox.SelectionLength = amountTenderedBox.TextLength;
            }
        }

        // Hitting the Return/Enter key when in the SKU textbox.
        private void addItem_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int sku;                            // Stores the SKU of the item entered
                decimal price;                      // Stores the price of the item entered

                // Reset error labels
                skuErrorLabel.Visible = false;
                tenderedErrorLabel.Visible = false;

                // Try parsing of entered SKU, if failed, display an error indicating the SKU wasn't found
                try
                {
                    sku = Int32.Parse(this.skuBox.Text);
                    price = (decimal)inventoryTableAdapter.GetPrice(sku);
                    totalItemsLabel.Text = transaction.AddItem(sku, this).ToString();
                    transaction.UpdateTotals(price, this);
                    if (Int32.Parse(totalItemsLabel.Text) == 1)
                        finalizeButton.Enabled = true;
                    e.Handled = true;
                }
                catch
                {
                    // Displays an error when the user searches for a 
                    // non-SKU query (ex. anything with letters/symbols/etc.)
                    skuErrorLabel.Visible = true;
                }

                // Highlight text in skuBox
                skuBox.Focus();
                skuBox.SelectionStart = 0;
                skuBox.SelectionLength = skuBox.TextLength;
            }
        }

        // Hitting the Return/Enter key when in the Amount Tendered textbox.
        private void Tender_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                finalizeButton.PerformClick();
            }
        }

        // Sets up the form for a new transaction.
        private void newTransactionButton_Click(object sender, EventArgs e)
        {
            transaction = new Transaction();
            resetForm();
        }

        // Resets the form.
        private void resetForm()
        {
            finalizeButton.Enabled = false;
            taxLabel.Text = "$0.00";
            skuBox.ResetText();
            totalLabel.Text = "$0.00";
            subtotalLabel.Text = "$0.00";
            changeLabel.ResetText();
            amountTenderedBox.Enabled = true;
            amountTenderedBox.ResetText();
            totalItemsLabel.Text = "0";
            changeTitleLabel.Visible = false;
            skuErrorLabel.Visible = false;
            tenderedErrorLabel.Visible = false;
            skuBox.Enabled = true;
            pOSDataSet.Clear();
            skuBox.Focus();
            skuBox.SelectionStart = 0;
            skuBox.SelectionLength = skuBox.TextLength;
        }
    }

    public class Transaction
    {
        // Default constructor
        public Transaction()
        {
            this.numOfItems = 0;
            this.totals = new Money();
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
                this.numOfItems++;

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
                form.inventoryTableAdapter.DecreaseQuantity((int)form.inventoryDataGridView.Rows[i].Cells[0].Value);
            }
        }

        private int numOfItems;      // Store the number of items in the transaction
        private Money totals;   // Stores totals of the transaction
    }

    public class Money
    {
        // Default constructor
        public Money()
        {
            this.subtotal = 0.00M;
            this.tax = 0.00M;
            this.total = 0.00M;
        }

        // Calculates the running totals
        public void UpdateTotal(decimal price)
        {
            this.subtotal += price;
            this.tax = Math.Round(taxRate * this.subtotal, 2, MidpointRounding.AwayFromZero);
            this.total = this.subtotal + this.tax;
        }

        // Updates total labels
        public void UpdateTotalLabels(transactionScreen form)
        {
            form.subtotalLabel.Text = this.subtotal.ToString("c");
            form.taxLabel.Text = this.tax.ToString("c");
            form.totalLabel.Text = this.total.ToString("c");
        }

        private decimal subtotal;                   // The amount due before tax
        private decimal tax;                        // The amount of tax; applied to the subtotal
        public decimal total;                       // The entire cost of the transaction
        private static decimal taxRate = 0.081M;    // Nevada sales tax rate
    }
}
