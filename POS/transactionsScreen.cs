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
    public partial class transactionsScreen : Form
    {
        Transaction transaction = new Transaction();

        public transactionsScreen()
        {
            InitializeComponent();
        }

        private void transactionsScreen_Load(object sender, EventArgs e)
        {
            inventoryDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            inventoryDataGridView.Columns[2].DefaultCellStyle.Format = "c";        // currency format
            inventoryTableAdapter.ClearBeforeFill = false;
            
        }


        /**
         * The goal here is to add items into a transaction and display the sum
         * total of all the items. I don't know whether or not the
         * database needs to actually be in thus form, or if it can
         * simply be referenced.
         **/
        private void addItem_Click(object sender, EventArgs e)
        {
            int sku;
            int quantity;
            decimal price;
            int returnValue;
            try
            {
                sku = Int32.Parse(this.skuBox.Text);
                price = (decimal)inventoryTableAdapter.GetPrice(sku);
                returnValue = transaction.AddItem(sku, inventoryTableAdapter, pOSDataSet);
                transaction.UpdateTotals(price, subtotalLabel, taxLabel, totalLabel);
                
                //quantity = (int)inventoryTableAdapter.GetQuantity(sku);
                //price = (decimal)inventoryDataGridView.Rows[0].Cells[2].Value;
                //testBox.Text = returnValue.ToString();
            }
            catch
            {
                // Returns an error and plays a sound when the user
                // searches for a non-SKU query (ex. anything with letters/symbols/etc.)
                
            }
        }

        

        // Closes the Transactions form
        private void closeTransactions_Click(object sender, EventArgs e)
        {
            Close();
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

        public int AddItem(int sku, POSDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter, POSDataSet pOSDataSet)
        {
            int returnValue = inventoryTableAdapter.FillBySKU(pOSDataSet.Inventory, sku);
            if (returnValue != 0)
                this.items++;
            return returnValue;
        }

        public void UpdateTotals(decimal price, System.Windows.Forms.Label subtotalLabel, System.Windows.Forms.Label taxLabel, System.Windows.Forms.Label totalLabel)
        {
            totals.UpdateTotal(price);
            totals.UpdateTotalLabels(subtotalLabel, taxLabel, totalLabel);
        }
        /*---------------END METHODS----------------*/

        /*---------------MEMBERS--------------------*/
        private int items;
        public Money totals;
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

        private decimal subtotal;
        private decimal tax;
        private decimal total;
        private static decimal taxRate = 0.081M;
    }
}
