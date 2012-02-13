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
            this.SuspendLayout();
            // 
            // closeTransactions
            // 
            this.closeTransactions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeTransactions.Location = new System.Drawing.Point(351, 487);
            this.closeTransactions.Name = "closeTransactions";
            this.closeTransactions.Size = new System.Drawing.Size(75, 23);
            this.closeTransactions.TabIndex = 0;
            this.closeTransactions.Text = "Close";
            this.closeTransactions.UseVisualStyleBackColor = true;
            this.closeTransactions.Click += new System.EventHandler(this.closeTransactions_Click);
            // 
            // transactionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeTransactions;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.closeTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "transactionsScreen";
            this.Text = "Transactions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeTransactions;
    }
}