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
        Transaction items = new Transaction(); // DUNNO IF NEED

        // Plays a sound when an error occurs
        System.Media.SoundPlayer errorSound = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
       
        public transactionsScreen()
        {
            InitializeComponent();
        }

        // Closes the Transactions form
        private void closeTransactions_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**
         * The goal here is to add items into a transaction and display the sum
         * total of all the items. I don't know whether or not the
         * database needs to actually be in thus form, or if it can
         * simply be referenced.
         **/
        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                //int SKU, quantity;
                //SKU = Int32.Parse(this.skuBox.Text);
                //quantity = Int32.Parse(this.quantityBox.Text);
                //Transaction item = new Transaction(SKU, quantity);
                Transaction item = new Transaction(Int32.Parse(this.skuBox.Text), Int32.Parse(this.quantityBox.Text));
            }
            catch
            {
                // Returns an error and plays a sound when the user
                // searches for a non-SKU query (ex. anything with letters/symbols/etc.)
                errorSound.Play();
                MessageBox.Show(this, "Please input a valid SKU", "Error");
                //totalBox.Text = Money.Display(); // Something like this
            }
        }

    }

    public class Transaction
    {
        /*---------------METHODS--------------------*/
        public Transaction(int inputSKU, int inputQuantity)
        {
            SKU = inputSKU;
            quantity = inputQuantity;
        }

        // Default constructor; shouldn't be used.
        public Transaction()
        {
            SKU = 0;
            description = "";
            quantity = 0;
        }

        // Destructor
        ~Transaction()
        {
            SKU = 0;
            description = null;
            quantity = 0;
        }
        /*---------------END METHODS----------------*/

        /*---------------MEMBERS--------------------*/
        public int SKU;
        private string description; // Need to retrieve from database based on supplied SKU number
        private int quantity;
        public Money total; // The sum total of all the items.
    }

    public class Money
    {
        // Calculates the running total
        public void Calculate()
        {

        }

        // Displays the total to, ideally, totalBox.
        // totalBox can't be called from here though
        public string Display()
        {
            string output = ""; // Test
        
            return output;
        }

        private int dollars;
        private int cents;
        public string yah = "HI";
    }
}
