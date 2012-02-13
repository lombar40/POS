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
    public partial class editInventory : Form
    {
        public editInventory()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSDataSet);

        }

        private void editInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.pOSDataSet.Inventory);

        }

        private void closeEditInventory_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
