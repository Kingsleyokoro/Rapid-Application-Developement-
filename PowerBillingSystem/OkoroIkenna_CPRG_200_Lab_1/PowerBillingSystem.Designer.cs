namespace CustomerData
{
    partial class PowerBillingSystem
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
            this.CustomerTypeLabel = new System.Windows.Forms.Label();
            this.CustomerTypecomboBox1 = new System.Windows.Forms.ComboBox();
            this.KwhLabel = new System.Windows.Forms.Label();
            this.KwhTextBox1 = new System.Windows.Forms.TextBox();
            this.CalculateBillbutton = new System.Windows.Forms.Button();
            this.EstimatedBillLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OffPeakKwhlabel = new System.Windows.Forms.Label();
            this.OffpeakKwhTextBox1 = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox1 = new System.Windows.Forms.TextBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerListListBox = new System.Windows.Forms.ListBox();
            this.TotalResidentialCustomerLabel = new System.Windows.Forms.Label();
            this.totalCommercialCustomersLabel = new System.Windows.Forms.Label();
            this.totalIndustrialCustomersLabel = new System.Windows.Forms.Label();
            this.totalChargeLabel = new System.Windows.Forms.Label();
            this.totalCustomersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerTypeLabel
            // 
            this.CustomerTypeLabel.AutoSize = true;
            this.CustomerTypeLabel.Location = new System.Drawing.Point(45, 101);
            this.CustomerTypeLabel.Name = "CustomerTypeLabel";
            this.CustomerTypeLabel.Size = new System.Drawing.Size(81, 13);
            this.CustomerTypeLabel.TabIndex = 0;
            this.CustomerTypeLabel.Text = "Customer Type:";
            // 
            // CustomerTypecomboBox1
            // 
            this.CustomerTypecomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerTypecomboBox1.FormattingEnabled = true;
            this.CustomerTypecomboBox1.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.CustomerTypecomboBox1.Location = new System.Drawing.Point(178, 98);
            this.CustomerTypecomboBox1.Name = "CustomerTypecomboBox1";
            this.CustomerTypecomboBox1.Size = new System.Drawing.Size(121, 21);
            this.CustomerTypecomboBox1.TabIndex = 1;
            this.CustomerTypecomboBox1.SelectedIndexChanged += new System.EventHandler(this.CustomerTypecomboBox1_SelectedIndexChanged);
            // 
            // KwhLabel
            // 
            this.KwhLabel.AutoSize = true;
            this.KwhLabel.Location = new System.Drawing.Point(42, 244);
            this.KwhLabel.Name = "KwhLabel";
            this.KwhLabel.Size = new System.Drawing.Size(87, 13);
            this.KwhLabel.TabIndex = 2;
            this.KwhLabel.Text = "How many Kwh?";
            // 
            // KwhTextBox1
            // 
            this.KwhTextBox1.Location = new System.Drawing.Point(178, 240);
            this.KwhTextBox1.Name = "KwhTextBox1";
            this.KwhTextBox1.Size = new System.Drawing.Size(121, 20);
            this.KwhTextBox1.TabIndex = 3;
            this.KwhTextBox1.TextChanged += new System.EventHandler(this.KwhTextBox1_TextChanged);
            // 
            // CalculateBillbutton
            // 
            this.CalculateBillbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalculateBillbutton.Enabled = false;
            this.CalculateBillbutton.Location = new System.Drawing.Point(40, 362);
            this.CalculateBillbutton.Name = "CalculateBillbutton";
            this.CalculateBillbutton.Size = new System.Drawing.Size(85, 24);
            this.CalculateBillbutton.TabIndex = 4;
            this.CalculateBillbutton.Text = "Estimate Bill";
            this.CalculateBillbutton.UseVisualStyleBackColor = false;
            this.CalculateBillbutton.Click += new System.EventHandler(this.CalculateBillbutton_Click);
            // 
            // EstimatedBillLabel
            // 
            this.EstimatedBillLabel.AutoSize = true;
            this.EstimatedBillLabel.Location = new System.Drawing.Point(39, 325);
            this.EstimatedBillLabel.Name = "EstimatedBillLabel";
            this.EstimatedBillLabel.Size = new System.Drawing.Size(72, 13);
            this.EstimatedBillLabel.TabIndex = 5;
            this.EstimatedBillLabel.Text = "Estimated Bill:";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(856, 438);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(86, 24);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Gold;
            this.ResetButton.Location = new System.Drawing.Point(10, 438);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Clear";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bill Estimator";
            // 
            // OffPeakKwhlabel
            // 
            this.OffPeakKwhlabel.AutoSize = true;
            this.OffPeakKwhlabel.Location = new System.Drawing.Point(41, 275);
            this.OffPeakKwhlabel.Name = "OffPeakKwhlabel";
            this.OffPeakKwhlabel.Size = new System.Drawing.Size(123, 13);
            this.OffPeakKwhlabel.TabIndex = 9;
            this.OffPeakKwhlabel.Text = "How many off peak Kwh";
            this.OffPeakKwhlabel.Visible = false;
            // 
            // OffpeakKwhTextBox1
            // 
            this.OffpeakKwhTextBox1.Location = new System.Drawing.Point(178, 271);
            this.OffpeakKwhTextBox1.Name = "OffpeakKwhTextBox1";
            this.OffpeakKwhTextBox1.Size = new System.Drawing.Size(122, 20);
            this.OffpeakKwhTextBox1.TabIndex = 10;
            this.OffpeakKwhTextBox1.Visible = false;
            this.OffpeakKwhTextBox1.TextChanged += new System.EventHandler(this.OffpeakKwhTextBox1_TextChanged);
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(47, 134);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.accountNumberLabel.TabIndex = 11;
            this.accountNumberLabel.Text = "Account Number: ";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(178, 130);
            this.accountNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.accountNumberTextBox.TabIndex = 12;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(50, 170);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 13;
            this.customerNameLabel.Text = "CustomerName:";
            // 
            // customerNameTextBox1
            // 
            this.customerNameTextBox1.Location = new System.Drawing.Point(178, 170);
            this.customerNameTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerNameTextBox1.Name = "customerNameTextBox1";
            this.customerNameTextBox1.Size = new System.Drawing.Size(122, 20);
            this.customerNameTextBox1.TabIndex = 14;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(212, 362);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(66, 24);
            this.addCustomerButton.TabIndex = 15;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // customerListListBox
            // 
            this.customerListListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListListBox.FormattingEnabled = true;
            this.customerListListBox.Location = new System.Drawing.Point(384, 29);
            this.customerListListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerListListBox.Name = "customerListListBox";
            this.customerListListBox.Size = new System.Drawing.Size(479, 238);
            this.customerListListBox.TabIndex = 16;
            // 
            // TotalResidentialCustomerLabel
            // 
            this.TotalResidentialCustomerLabel.AutoSize = true;
            this.TotalResidentialCustomerLabel.Location = new System.Drawing.Point(454, 349);
            this.TotalResidentialCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalResidentialCustomerLabel.Name = "TotalResidentialCustomerLabel";
            this.TotalResidentialCustomerLabel.Size = new System.Drawing.Size(138, 13);
            this.TotalResidentialCustomerLabel.TabIndex = 18;
            this.TotalResidentialCustomerLabel.Text = "Total Residential Customers";
            // 
            // totalCommercialCustomersLabel
            // 
            this.totalCommercialCustomersLabel.AutoSize = true;
            this.totalCommercialCustomersLabel.Location = new System.Drawing.Point(454, 378);
            this.totalCommercialCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCommercialCustomersLabel.Name = "totalCommercialCustomersLabel";
            this.totalCommercialCustomersLabel.Size = new System.Drawing.Size(140, 13);
            this.totalCommercialCustomersLabel.TabIndex = 19;
            this.totalCommercialCustomersLabel.Text = "Total Commercial Customers";
            // 
            // totalIndustrialCustomersLabel
            // 
            this.totalIndustrialCustomersLabel.AutoSize = true;
            this.totalIndustrialCustomersLabel.Location = new System.Drawing.Point(453, 405);
            this.totalIndustrialCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalIndustrialCustomersLabel.Name = "totalIndustrialCustomersLabel";
            this.totalIndustrialCustomersLabel.Size = new System.Drawing.Size(128, 13);
            this.totalIndustrialCustomersLabel.TabIndex = 20;
            this.totalIndustrialCustomersLabel.Text = "Total Industrial Customers";
            // 
            // totalChargeLabel
            // 
            this.totalChargeLabel.AutoSize = true;
            this.totalChargeLabel.Location = new System.Drawing.Point(453, 325);
            this.totalChargeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalChargeLabel.Name = "totalChargeLabel";
            this.totalChargeLabel.Size = new System.Drawing.Size(74, 13);
            this.totalChargeLabel.TabIndex = 21;
            this.totalChargeLabel.Text = "Total Charge :";
            // 
            // totalCustomersLabel
            // 
            this.totalCustomersLabel.AutoSize = true;
            this.totalCustomersLabel.Location = new System.Drawing.Point(453, 303);
            this.totalCustomersLabel.Name = "totalCustomersLabel";
            this.totalCustomersLabel.Size = new System.Drawing.Size(86, 13);
            this.totalCustomersLabel.TabIndex = 22;
            this.totalCustomersLabel.Text = "Total Customers:";
            // 
            // PowerBillingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 471);
            this.Controls.Add(this.totalCustomersLabel);
            this.Controls.Add(this.totalChargeLabel);
            this.Controls.Add(this.totalIndustrialCustomersLabel);
            this.Controls.Add(this.totalCommercialCustomersLabel);
            this.Controls.Add(this.TotalResidentialCustomerLabel);
            this.Controls.Add(this.customerListListBox);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerNameTextBox1);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.OffpeakKwhTextBox1);
            this.Controls.Add(this.OffPeakKwhlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EstimatedBillLabel);
            this.Controls.Add(this.CalculateBillbutton);
            this.Controls.Add(this.KwhTextBox1);
            this.Controls.Add(this.KwhLabel);
            this.Controls.Add(this.CustomerTypecomboBox1);
            this.Controls.Add(this.CustomerTypeLabel);
            this.Name = "PowerBillingSystem";
            this.Text = "Power Billing Estimator";
            this.Load += new System.EventHandler(this.PowerBillingSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerTypeLabel;
        private System.Windows.Forms.ComboBox CustomerTypecomboBox1;
        private System.Windows.Forms.Label KwhLabel;
        private System.Windows.Forms.TextBox KwhTextBox1;
        private System.Windows.Forms.Button CalculateBillbutton;
        private System.Windows.Forms.Label EstimatedBillLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OffPeakKwhlabel;
        private System.Windows.Forms.TextBox OffpeakKwhTextBox1;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox1;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.ListBox customerListListBox;
        private System.Windows.Forms.Label TotalResidentialCustomerLabel;
        private System.Windows.Forms.Label totalCommercialCustomersLabel;
        private System.Windows.Forms.Label totalIndustrialCustomersLabel;
        private System.Windows.Forms.Label totalChargeLabel;
        private System.Windows.Forms.Label totalCustomersLabel;
    }
}

