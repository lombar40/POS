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
    public partial class homeScreen : Form
    {
        public homeScreen()
        {
            InitializeComponent();
        }

        // Opens up the window to view inventory
        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            inventoryScreen window = new inventoryScreen();
            window.ShowDialog();
        }

        // Opens up the window to deal with transactions
        private void transactionButton_Click(object sender, EventArgs e)
        {
            transactionsScreen window = new transactionsScreen();
            window.ShowDialog();
        }

        // Opens up the window to edit inventory on hand
        private void editInventoryButton_Click(object sender, EventArgs e)
        {
            editInventory window = new editInventory();
            window.ShowDialog();
        }

        // Provides an exit button to close the window
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
