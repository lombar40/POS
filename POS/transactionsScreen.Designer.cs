namespace POS_C
{
    partial class transactionsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeTransactions = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.skuBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeTransactions
            // 
            this.closeTransactions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeTransactions.Location = new System.Drawing.Point(311, 443);
            this.closeTransactions.Name = "closeTransactions";
            this.closeTransactions.Size = new System.Drawing.Size(75, 23);
            this.closeTransactions.TabIndex = 0;
            this.closeTransactions.Text = "Close";
            this.closeTransactions.UseVisualStyleBackColor = true;
            this.closeTransactions.Click += new System.EventHandler(this.closeTransactions_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(311, 350);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 1;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // skuBox
            // 
            this.skuBox.Location = new System.Drawing.Point(163, 138);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(100, 20);
            this.skuBox.TabIndex = 2;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(286, 138);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 20);
            this.quantityBox.TabIndex = 3;
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(160, 119);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(29, 13);
            this.skuLabel.TabIndex = 4;
            this.skuLabel.Text = "SKU";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(283, 119);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(286, 244);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 6;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(283, 228);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total";
            // 
            // transactionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeTransactions;
            this.ClientSize = new System.Drawing.Size(696, 543);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.skuBox);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.closeTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "transactionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeTransactions;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.TextBox skuBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label totalLabel;
    }
}