using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS_C
{
    class Money
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
