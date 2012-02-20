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
        Transaction transaction = new Transaction();

        public transactionScreen()
        {
            InitializeComponent();
        }

        private void transactionsScreen_Load(object sender, EventArgs e)
        {
            inventoryDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            inventoryDataGridView.Columns[2].DefaultCellStyle.Format = "c";        // currency format
        }

        // Closes the Transactions form
        private void closeTransactions_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            decimal tendered;
            skuErrorLabel.Visible = false;
            tenderedErrorLabel.Visible = false;
            try
            {
                tendered = Decimal.Parse(amountTenderedBox.Text);
                transaction.finalize(tendered, this);
            }

            catch
            {
                tenderedErrorLabel.Visible = true;
            }
        }


        /**
         * The goal here is to add items into a transaction and display the sum
         * total of all the items. I don't know whether or not the
         * database needs to actually be in thus form, or if it can
         * simply be referenced.
         **/
        private void addItem(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int sku;
                decimal price;
                skuErrorLabel.Visible = false;
                tenderedErrorLabel.Visible = false;
                try
                {
                    sku = Int32.Parse(this.skuBox.Text);
                    price = (decimal)inventoryTableAdapter.GetPrice(sku);
                    totalItemsLabel.Text = transaction.AddItem(sku, this).ToString();
                    //totalItemsLabel.Text = transaction.AddItem(sku, inventoryTableAdapter, pOSDataSet).ToString();
                    transaction.UpdateTotals(price, subtotalLabel, taxLabel, totalLabel);
                    e.Handled = true;
                }
                catch
                {
                    // Returns an error when the user searches for a 
                    // non-SKU query (ex. anything with letters/symbols/etc.)
                    skuErrorLabel.Visible = true;
                }
                skuBox.Focus();
                skuBox.SelectionStart = 0;
                skuBox.SelectionLength = skuBox.TextLength;
            }
        }

        private void Tender_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                decimal tendered;
                skuErrorLabel.Visible = false;
                tenderedErrorLabel.Visible = false;
                try
                {
                    tendered = Decimal.Parse(amountTenderedBox.Text);
                    transaction.finalize(tendered, this);
                }

                catch
                {
                    // Returns an error when the user puts in non digit characters
                    tenderedErrorLabel.Visible = true;
                }
            }
        }

        private void newTransactionButton_Click(object sender, EventArgs e)
        {
            transaction = new Transaction();
            transaction.ResetForm(this);
        }
    }

    public class Transaction
    {
        /*---------------METHODS--------------------*/
       
        
        // Default constructor
        public Transaction()
        {
            this.items = 0;
            this.totals = new Money();
        }

        // Destructor
        ~Transaction()
        {

        }

        public void ResetForm(transactionScreen form)
        {
            form.taxLabel.Text = "$0.00";
            form.skuBox.ResetText();
            form.totalLabel.Text = "$0.00";
            form.subtotalLabel.Text = "$0.00";
            form.changeLabel.ResetText();
            form.amountTenderedBox.Enabled = true;
            form.amountTenderedBox.ResetText();
            form.totalItemsLabel.Text = "0";
            form.changeTitleLabel.Visible = false;
            form.skuErrorLabel.Visible = false;
            form.tenderedErrorLabel.Visible = false;
            form.skuBox.Enabled = true;
            form.finalizeButton.Enabled = true;
            form.pOSDataSet.Clear();
            form.skuBox.Focus();
            form.skuBox.SelectionStart = 0;
            form.skuBox.SelectionLength = form.skuBox.TextLength;
        }

        public int AddItem(int sku, transactionScreen form)
        {
            int returnValue = form.inventoryTableAdapter.FillBySKU(form.pOSDataSet.Inventory, sku);
            if (returnValue != 0)
                this.items++;
            return this.items;
        }

        public void UpdateTotals(decimal price, System.Windows.Forms.Label subtotalLabel, System.Windows.Forms.Label taxLabel, System.Windows.Forms.Label totalLabel)
        {
            totals.UpdateTotal(price);
            totals.UpdateTotalLabels(subtotalLabel, taxLabel, totalLabel);
        }
        public void finalize(decimal tendered, transactionScreen form)
        {
            decimal change; // The amount of change to be given
            change = tendered - totals.total;
            form.changeTitleLabel.Visible = true;
            form.changeLabel.Text = change.ToString("c");
            form.amountTenderedBox.Enabled = false;
            form.finalizeButton.Enabled = false;
            form.skuBox.Text = "";
            form.skuBox.Enabled = false;

            // ENTER DATABASE CHANGES HERE

        }

        private int items;
        private Money totals;
    }

    public class Money
    {
        // Calculates the running total
        public void UpdateTotal(decimal price)
        {
            this.subtotal += price;
            this.tax = taxRate * this.subtotal;
            this.total = this.subtotal + this.tax;
        }

        // Displays the total to, ideally, totalBox.
        // totalBox can't be called from here though
        public void UpdateTotalLabels(System.Windows.Forms.Label subtotalLabel, System.Windows.Forms.Label taxLabel, System.Windows.Forms.Label totalLabel)
        {
            subtotalLabel.Text = this.subtotal.ToString("c");
            taxLabel.Text = this.tax.ToString("c");
            totalLabel.Text = this.total.ToString("c");
        }

        private decimal subtotal;   // The amount due before tax
        private decimal tax;        // The amount of tax; applied to the subtotal
        public decimal total;       // The entire cost of the transaction
        private static decimal taxRate = 0.081M; // Nevada sales tax rate
    }
}
