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
            this.SuspendLayout();
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.AutoSize = true;
            this.viewInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInventoryButton.Location = new System.Drawing.Point(297, 131);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(122, 30);
            this.viewInventoryButton.TabIndex = 0;
            this.viewInventoryButton.Text = "View Inventory";
            this.viewInventoryButton.UseVisualStyleBackColor = true;
            this.viewInventoryButton.Click += new System.EventHandler(this.viewInventoryButton_Click);
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.viewInventoryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "homeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewInventoryButton;
    }
}

