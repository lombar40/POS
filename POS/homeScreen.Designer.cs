namespace POS_C
{
    partial class homeScreen
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
            this.viewInventoryButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inventoryBox = new System.Windows.Forms.GroupBox();
            this.transactionBox = new System.Windows.Forms.GroupBox();
            this.inventoryBox.SuspendLayout();
            this.transactionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.AutoSize = true;
            this.viewInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInventoryButton.Location = new System.Drawing.Point(73, 84);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(153, 31);
            this.viewInventoryButton.TabIndex = 2;
            this.viewInventoryButton.Text = "View Inventory [F1]";
            this.viewInventoryButton.UseVisualStyleBackColor = true;
            this.viewInventoryButton.Click += new System.EventHandler(this.viewInventoryButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.AutoSize = true;
            this.transactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionButton.Location = new System.Drawing.Point(118, 76);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(141, 31);
            this.transactionButton.TabIndex = 3;
            this.transactionButton.Text = "Transactions [F2]";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(159, 349);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit [Esc]";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Controls.Add(this.viewInventoryButton);
            this.inventoryBox.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBox.Location = new System.Drawing.Point(55, 12);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(300, 151);
            this.inventoryBox.TabIndex = 5;
            this.inventoryBox.TabStop = false;
            this.inventoryBox.Text = "Inventory";
            // 
            // transactionBox
            // 
            this.transactionBox.Controls.Add(this.transactionButton);
            this.transactionBox.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionBox.Location = new System.Drawing.Point(17, 184);
            this.transactionBox.Name = "transactionBox";
            this.transactionBox.Size = new System.Drawing.Size(377, 142);
            this.transactionBox.TabIndex = 6;
            this.transactionBox.TabStop = false;
            this.transactionBox.Text = "Transactions";
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(410, 393);
            this.Controls.Add(this.transactionBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "homeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS v1.0";
            this.inventoryBox.ResumeLayout(false);
            this.inventoryBox.PerformLayout();
            this.transactionBox.ResumeLayout(false);
            this.transactionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewInventoryButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox inventoryBox;
        private System.Windows.Forms.GroupBox transactionBox;
    }
}

