namespace POS
{
    partial class POSMainForm
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
            this.components = new System.ComponentModel.Container();
            this.productListGroupbox = new System.Windows.Forms.GroupBox();
            this.productListListbox = new System.Windows.Forms.ListBox();
            this.addNewProductGroupBox = new System.Windows.Forms.GroupBox();
            this.productTypeCombobox = new System.Windows.Forms.ComboBox();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.sellProductGroupbox = new System.Windows.Forms.GroupBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.quantityToSellTextbox = new System.Windows.Forms.TextBox();
            this.quantityToSellLabel = new System.Windows.Forms.Label();
            this.restockGroupbox = new System.Windows.Forms.GroupBox();
            this.restockButton = new System.Windows.Forms.Button();
            this.quantityRestockedTextbox = new System.Windows.Forms.TextBox();
            this.quantityRestockedLabel = new System.Windows.Forms.Label();
            this.fileOperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveProductsButton = new System.Windows.Forms.Button();
            this.loadProductsButton = new System.Windows.Forms.Button();
            this.productListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListGroupbox.SuspendLayout();
            this.addNewProductGroupBox.SuspendLayout();
            this.sellProductGroupbox.SuspendLayout();
            this.restockGroupbox.SuspendLayout();
            this.fileOperationsGroupBox.SuspendLayout();
            this.productListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // productListGroupbox
            // 
            this.productListGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListGroupbox.Controls.Add(this.productListListbox);
            this.productListGroupbox.Location = new System.Drawing.Point(13, 13);
            this.productListGroupbox.Name = "productListGroupbox";
            this.productListGroupbox.Size = new System.Drawing.Size(808, 252);
            this.productListGroupbox.TabIndex = 0;
            this.productListGroupbox.TabStop = false;
            this.productListGroupbox.Text = "Product List";
            // 
            // productListListbox
            // 
            this.productListListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListListbox.ContextMenuStrip = this.productListContextMenu;
            this.productListListbox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListListbox.FormattingEnabled = true;
            this.productListListbox.ItemHeight = 22;
            this.productListListbox.Location = new System.Drawing.Point(7, 20);
            this.productListListbox.Name = "productListListbox";
            this.productListListbox.Size = new System.Drawing.Size(795, 202);
            this.productListListbox.TabIndex = 0;
            // 
            // addNewProductGroupBox
            // 
            this.addNewProductGroupBox.Controls.Add(this.productTypeCombobox);
            this.addNewProductGroupBox.Controls.Add(this.addNewProductButton);
            this.addNewProductGroupBox.Location = new System.Drawing.Point(12, 271);
            this.addNewProductGroupBox.Name = "addNewProductGroupBox";
            this.addNewProductGroupBox.Size = new System.Drawing.Size(291, 133);
            this.addNewProductGroupBox.TabIndex = 1;
            this.addNewProductGroupBox.TabStop = false;
            this.addNewProductGroupBox.Text = "Add a New Product";
            // 
            // productTypeCombobox
            // 
            this.productTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeCombobox.FormattingEnabled = true;
            this.productTypeCombobox.Items.AddRange(new object[] {
            "Computer",
            "Chocolates"});
            this.productTypeCombobox.Location = new System.Drawing.Point(8, 26);
            this.productTypeCombobox.Name = "productTypeCombobox";
            this.productTypeCombobox.Size = new System.Drawing.Size(186, 21);
            this.productTypeCombobox.TabIndex = 6;
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(200, 24);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(75, 23);
            this.addNewProductButton.TabIndex = 5;
            this.addNewProductButton.Text = "Add to List";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // sellProductGroupbox
            // 
            this.sellProductGroupbox.Controls.Add(this.sellButton);
            this.sellProductGroupbox.Controls.Add(this.quantityToSellTextbox);
            this.sellProductGroupbox.Controls.Add(this.quantityToSellLabel);
            this.sellProductGroupbox.Location = new System.Drawing.Point(310, 272);
            this.sellProductGroupbox.Name = "sellProductGroupbox";
            this.sellProductGroupbox.Size = new System.Drawing.Size(164, 132);
            this.sellProductGroupbox.TabIndex = 2;
            this.sellProductGroupbox.TabStop = false;
            this.sellProductGroupbox.Text = "Sell Product";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(60, 62);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 2;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // quantityToSellTextbox
            // 
            this.quantityToSellTextbox.Location = new System.Drawing.Point(96, 20);
            this.quantityToSellTextbox.Name = "quantityToSellTextbox";
            this.quantityToSellTextbox.Size = new System.Drawing.Size(39, 20);
            this.quantityToSellTextbox.TabIndex = 1;
            // 
            // quantityToSellLabel
            // 
            this.quantityToSellLabel.AutoSize = true;
            this.quantityToSellLabel.Location = new System.Drawing.Point(8, 23);
            this.quantityToSellLabel.Name = "quantityToSellLabel";
            this.quantityToSellLabel.Size = new System.Drawing.Size(82, 13);
            this.quantityToSellLabel.TabIndex = 0;
            this.quantityToSellLabel.Text = "Quantity To Sell";
            // 
            // restockGroupbox
            // 
            this.restockGroupbox.Controls.Add(this.restockButton);
            this.restockGroupbox.Controls.Add(this.quantityRestockedTextbox);
            this.restockGroupbox.Controls.Add(this.quantityRestockedLabel);
            this.restockGroupbox.Location = new System.Drawing.Point(487, 272);
            this.restockGroupbox.Name = "restockGroupbox";
            this.restockGroupbox.Size = new System.Drawing.Size(164, 132);
            this.restockGroupbox.TabIndex = 2;
            this.restockGroupbox.TabStop = false;
            this.restockGroupbox.Text = "Restock Product";
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(77, 62);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(75, 23);
            this.restockButton.TabIndex = 2;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            // 
            // quantityRestockedTextbox
            // 
            this.quantityRestockedTextbox.Location = new System.Drawing.Point(113, 20);
            this.quantityRestockedTextbox.Name = "quantityRestockedTextbox";
            this.quantityRestockedTextbox.Size = new System.Drawing.Size(39, 20);
            this.quantityRestockedTextbox.TabIndex = 1;
            // 
            // quantityRestockedLabel
            // 
            this.quantityRestockedLabel.AutoSize = true;
            this.quantityRestockedLabel.Location = new System.Drawing.Point(6, 23);
            this.quantityRestockedLabel.Name = "quantityRestockedLabel";
            this.quantityRestockedLabel.Size = new System.Drawing.Size(101, 13);
            this.quantityRestockedLabel.TabIndex = 0;
            this.quantityRestockedLabel.Text = "Quantity Restocked";
            // 
            // fileOperationsGroupBox
            // 
            this.fileOperationsGroupBox.Controls.Add(this.saveProductsButton);
            this.fileOperationsGroupBox.Controls.Add(this.loadProductsButton);
            this.fileOperationsGroupBox.Location = new System.Drawing.Point(658, 272);
            this.fileOperationsGroupBox.Name = "fileOperationsGroupBox";
            this.fileOperationsGroupBox.Size = new System.Drawing.Size(157, 132);
            this.fileOperationsGroupBox.TabIndex = 3;
            this.fileOperationsGroupBox.TabStop = false;
            this.fileOperationsGroupBox.Text = "File Operations";
            // 
            // saveProductsButton
            // 
            this.saveProductsButton.Location = new System.Drawing.Point(7, 46);
            this.saveProductsButton.Name = "saveProductsButton";
            this.saveProductsButton.Size = new System.Drawing.Size(122, 23);
            this.saveProductsButton.TabIndex = 0;
            this.saveProductsButton.Text = "Save Products";
            this.saveProductsButton.UseVisualStyleBackColor = true;
            this.saveProductsButton.Click += new System.EventHandler(this.SaveProductsButton_Click);
            // 
            // loadProductsButton
            // 
            this.loadProductsButton.Location = new System.Drawing.Point(7, 16);
            this.loadProductsButton.Name = "loadProductsButton";
            this.loadProductsButton.Size = new System.Drawing.Size(122, 23);
            this.loadProductsButton.TabIndex = 0;
            this.loadProductsButton.Text = "Load Products";
            this.loadProductsButton.UseVisualStyleBackColor = true;
            this.loadProductsButton.Click += new System.EventHandler(this.LoadProductsButton_Click);
            // 
            // productListContextMenu
            // 
            this.productListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.productListContextMenu.Name = "contextMenuStrip1";
            this.productListContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit ...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete ...";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // POSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 413);
            this.Controls.Add(this.fileOperationsGroupBox);
            this.Controls.Add(this.restockGroupbox);
            this.Controls.Add(this.sellProductGroupbox);
            this.Controls.Add(this.addNewProductGroupBox);
            this.Controls.Add(this.productListGroupbox);
            this.Name = "POSMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.productListGroupbox.ResumeLayout(false);
            this.addNewProductGroupBox.ResumeLayout(false);
            this.sellProductGroupbox.ResumeLayout(false);
            this.sellProductGroupbox.PerformLayout();
            this.restockGroupbox.ResumeLayout(false);
            this.restockGroupbox.PerformLayout();
            this.fileOperationsGroupBox.ResumeLayout(false);
            this.productListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productListGroupbox;
        private System.Windows.Forms.ListBox productListListbox;
        private System.Windows.Forms.GroupBox addNewProductGroupBox;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.GroupBox sellProductGroupbox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.TextBox quantityToSellTextbox;
        private System.Windows.Forms.Label quantityToSellLabel;
        private System.Windows.Forms.GroupBox restockGroupbox;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.TextBox quantityRestockedTextbox;
        private System.Windows.Forms.Label quantityRestockedLabel;
        private System.Windows.Forms.GroupBox fileOperationsGroupBox;
        private System.Windows.Forms.Button saveProductsButton;
        private System.Windows.Forms.Button loadProductsButton;
        private System.Windows.Forms.ComboBox productTypeCombobox;
        private System.Windows.Forms.ContextMenuStrip productListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

