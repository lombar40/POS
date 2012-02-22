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
            
            // Sets up the handling of key input in the form.
            KeyPreview = true;
            KeyDown += new KeyEventHandler(homeScreen_KeyDown);
        }

        // Handles hotkey presses on the form
        // F1 = opens the inventory view window
        // F2 = opens the transaction window
        private void homeScreen_KeyDown(object sender, KeyEventArgs key)
        {
            switch (key.KeyCode)
            {
                case Keys.F1:
                    viewInventoryButton.PerformClick();
                    break;
                case Keys.F2:
                    transactionButton.PerformClick();
                    break;
            }
        }

        // Opens up the window to view inventory on button click.
        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            inventoryScreen window = new inventoryScreen();
            window.ShowDialog();
            Show();
        }

        // Opens up the window to deal with transactions on button click.
        private void transactionButton_Click(object sender, EventArgs e)
        {
            Hide();
            transactionScreen window = new transactionScreen();
            window.ShowDialog();
            Show();
        }
        
        // Provides an exit button to close the window.
        // This quits the program.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
