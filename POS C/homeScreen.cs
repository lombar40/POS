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

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {

            inventoryScreen window = new inventoryScreen();
            window.ShowDialog();
        }
    }
}
