namespace AddComputerDialogTest
{
    partial class AddComputerProductDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productIDTextbox = new System.Windows.Forms.TextBox();
            this.productCostLabel = new System.Windows.Forms.Label();
            this.productCostTextbox = new System.Windows.Forms.TextBox();
            this.initialQuantityLabel = new System.Windows.Forms.Label();
            this.initialQuantityTextbox = new System.Windows.Forms.TextBox();
            this.ramSizeLabel = new System.Windows.Forms.Label();
            this.ramSizeTextbox = new System.Windows.Forms.TextBox();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuSpeedTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(288, 184);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(207, 184);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.Location = new System.Drawing.Point(13, 13);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(112, 23);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name: ";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameTextbox.Location = new System.Drawing.Point(131, 15);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(232, 20);
            this.productNameTextbox.TabIndex = 0;
            this.productNameTextbox.TextChanged += new System.EventHandler(this.ProductNameTextbox_TextChanged);
            // 
            // productIDLabel
            // 
            this.productIDLabel.Location = new System.Drawing.Point(13, 39);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(112, 23);
            this.productIDLabel.TabIndex = 0;
            this.productIDLabel.Text = "Product ID: ";
            this.productIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productIDTextbox
            // 
            this.productIDTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productIDTextbox.Location = new System.Drawing.Point(131, 41);
            this.productIDTextbox.Name = "productIDTextbox";
            this.productIDTextbox.Size = new System.Drawing.Size(83, 20);
            this.productIDTextbox.TabIndex = 1;
            this.productIDTextbox.TextChanged += new System.EventHandler(this.ProductIDTextbox_TextChanged);
            // 
            // productCostLabel
            // 
            this.productCostLabel.Location = new System.Drawing.Point(13, 65);
            this.productCostLabel.Name = "productCostLabel";
            this.productCostLabel.Size = new System.Drawing.Size(112, 23);
            this.productCostLabel.TabIndex = 0;
            this.productCostLabel.Text = "Product Cost: ";
            this.productCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productCostTextbox
            // 
            this.productCostTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCostTextbox.Location = new System.Drawing.Point(131, 67);
            this.productCostTextbox.Name = "productCostTextbox";
            this.productCostTextbox.Size = new System.Drawing.Size(83, 20);
            this.productCostTextbox.TabIndex = 2;
            this.productCostTextbox.TextChanged += new System.EventHandler(this.ProductCostTextbox_TextChanged);
            // 
            // initialQuantityLabel
            // 
            this.initialQuantityLabel.Location = new System.Drawing.Point(13, 91);
            this.initialQuantityLabel.Name = "initialQuantityLabel";
            this.initialQuantityLabel.Size = new System.Drawing.Size(112, 23);
            this.initialQuantityLabel.TabIndex = 0;
            this.initialQuantityLabel.Text = "Initial Quantity: ";
            this.initialQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // initialQuantityTextbox
            // 
            this.initialQuantityTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initialQuantityTextbox.Location = new System.Drawing.Point(131, 93);
            this.initialQuantityTextbox.Name = "initialQuantityTextbox";
            this.initialQuantityTextbox.Size = new System.Drawing.Size(83, 20);
            this.initialQuantityTextbox.TabIndex = 3;
            this.initialQuantityTextbox.TextChanged += new System.EventHandler(this.InitialQuantityTextbox_TextChanged);
            // 
            // ramSizeLabel
            // 
            this.ramSizeLabel.Location = new System.Drawing.Point(13, 117);
            this.ramSizeLabel.Name = "ramSizeLabel";
            this.ramSizeLabel.Size = new System.Drawing.Size(112, 23);
            this.ramSizeLabel.TabIndex = 0;
            this.ramSizeLabel.Text = "RAM Size (GB): ";
            this.ramSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ramSizeTextbox
            // 
            this.ramSizeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ramSizeTextbox.Location = new System.Drawing.Point(131, 119);
            this.ramSizeTextbox.Name = "ramSizeTextbox";
            this.ramSizeTextbox.Size = new System.Drawing.Size(83, 20);
            this.ramSizeTextbox.TabIndex = 4;
            this.ramSizeTextbox.TextChanged += new System.EventHandler(this.RamSizeTextbox_TextChanged);
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.Location = new System.Drawing.Point(13, 143);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(112, 23);
            this.cpuSpeedLabel.TabIndex = 0;
            this.cpuSpeedLabel.Text = "CPU Speed (GHz)";
            this.cpuSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuSpeedTextbox
            // 
            this.cpuSpeedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuSpeedTextbox.Location = new System.Drawing.Point(131, 145);
            this.cpuSpeedTextbox.Name = "cpuSpeedTextbox";
            this.cpuSpeedTextbox.Size = new System.Drawing.Size(83, 20);
            this.cpuSpeedTextbox.TabIndex = 5;
            this.cpuSpeedTextbox.TextChanged += new System.EventHandler(this.CpuSpeedTextbox_TextChanged);
            // 
            // AddComputerProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 219);
            this.Controls.Add(this.cpuSpeedTextbox);
            this.Controls.Add(this.cpuSpeedLabel);
            this.Controls.Add(this.ramSizeTextbox);
            this.Controls.Add(this.ramSizeLabel);
            this.Controls.Add(this.initialQuantityTextbox);
            this.Controls.Add(this.initialQuantityLabel);
            this.Controls.Add(this.productCostTextbox);
            this.Controls.Add(this.productCostLabel);
            this.Controls.Add(this.productIDTextbox);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.productNameTextbox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "AddComputerProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Computer Product";
            this.Load += new System.EventHandler(this.AddComputerProductDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox productIDTextbox;
        private System.Windows.Forms.Label productCostLabel;
        private System.Windows.Forms.TextBox productCostTextbox;
        private System.Windows.Forms.Label initialQuantityLabel;
        private System.Windows.Forms.TextBox initialQuantityTextbox;
        private System.Windows.Forms.Label ramSizeLabel;
        private System.Windows.Forms.TextBox ramSizeTextbox;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.TextBox cpuSpeedTextbox;
    }
}