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
            this.editInventoryButton = new System.Windows.Forms.Button();
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
            this.viewInventoryButton.Location = new System.Drawing.Point(172, 96);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(122, 31);
            this.viewInventoryButton.TabIndex = 2;
            this.viewInventoryButton.Text = "View Inventory";
            this.viewInventoryButton.UseVisualStyleBackColor = true;
            this.viewInventoryButton.Click += new System.EventHandler(this.viewInventoryButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.AutoSize = true;
            this.transactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionButton.Location = new System.Drawing.Point(122, 105);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(122, 31);
            this.transactionButton.TabIndex = 3;
            this.transactionButton.Text = "Transactions";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // editInventoryButton
            // 
            this.editInventoryButton.AutoSize = true;
            this.editInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInventoryButton.Location = new System.Drawing.Point(6, 96);
            this.editInventoryButton.Name = "editInventoryButton";
            this.editInventoryButton.Size = new System.Drawing.Size(122, 31);
            this.editInventoryButton.TabIndex = 1;
            this.editInventoryButton.Text = "Edit Inventory";
            this.editInventoryButton.UseVisualStyleBackColor = true;
            this.editInventoryButton.Click += new System.EventHandler(this.editInventoryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(241, 485);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Controls.Add(this.editInventoryButton);
            this.inventoryBox.Controls.Add(this.viewInventoryButton);
            this.inventoryBox.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBox.Location = new System.Drawing.Point(164, 69);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(300, 200);
            this.inventoryBox.TabIndex = 5;
            this.inventoryBox.TabStop = false;
            this.inventoryBox.Text = "Inventory";
            // 
            // transactionBox
            // 
            this.transactionBox.Controls.Add(this.transactionButton);
            this.transactionBox.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionBox.Location = new System.Drawing.Point(119, 275);
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
            this.ClientSize = new System.Drawing.Size(630, 568);
            this.Controls.Add(this.transactionBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "homeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS v0.2";
            this.inventoryBox.ResumeLayout(false);
            this.inventoryBox.PerformLayout();
            this.transactionBox.ResumeLayout(false);
            this.transactionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewInventoryButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button editInventoryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox inventoryBox;
        private System.Windows.Forms.GroupBox transactionBox;
    }
}

