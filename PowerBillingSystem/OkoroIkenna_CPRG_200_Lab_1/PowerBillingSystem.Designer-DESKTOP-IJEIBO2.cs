namespace OkoroIkenna_CPRG_200_Lab_1
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
            this.SuspendLayout();
            // 
            // CustomerTypeLabel
            // 
            this.CustomerTypeLabel.AutoSize = true;
            this.CustomerTypeLabel.Location = new System.Drawing.Point(60, 124);
            this.CustomerTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerTypeLabel.Name = "CustomerTypeLabel";
            this.CustomerTypeLabel.Size = new System.Drawing.Size(108, 17);
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
            this.CustomerTypecomboBox1.Location = new System.Drawing.Point(244, 118);
            this.CustomerTypecomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerTypecomboBox1.Name = "CustomerTypecomboBox1";
            this.CustomerTypecomboBox1.Size = new System.Drawing.Size(160, 24);
            this.CustomerTypecomboBox1.TabIndex = 1;
            this.CustomerTypecomboBox1.SelectedIndexChanged += new System.EventHandler(this.CustomerTypecomboBox1_SelectedIndexChanged);
            // 
            // KwhLabel
            // 
            this.KwhLabel.AutoSize = true;
            this.KwhLabel.Location = new System.Drawing.Point(61, 176);
            this.KwhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KwhLabel.Name = "KwhLabel";
            this.KwhLabel.Size = new System.Drawing.Size(111, 17);
            this.KwhLabel.TabIndex = 2;
            this.KwhLabel.Text = "How many Kwh?";
            // 
            // KwhTextBox1
            // 
            this.KwhTextBox1.Location = new System.Drawing.Point(243, 172);
            this.KwhTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KwhTextBox1.Name = "KwhTextBox1";
            this.KwhTextBox1.Size = new System.Drawing.Size(160, 22);
            this.KwhTextBox1.TabIndex = 3;
            this.KwhTextBox1.TextChanged += new System.EventHandler(this.KwhTextBox1_TextChanged);
            // 
            // CalculateBillbutton
            // 
            this.CalculateBillbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalculateBillbutton.Enabled = false;
            this.CalculateBillbutton.Location = new System.Drawing.Point(197, 316);
            this.CalculateBillbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalculateBillbutton.Name = "CalculateBillbutton";
            this.CalculateBillbutton.Size = new System.Drawing.Size(113, 30);
            this.CalculateBillbutton.TabIndex = 4;
            this.CalculateBillbutton.Text = "Calculate Bill";
            this.CalculateBillbutton.UseVisualStyleBackColor = false;
            this.CalculateBillbutton.Click += new System.EventHandler(this.CalculateBillbutton_Click);
            // 
            // EstimatedBillLabel
            // 
            this.EstimatedBillLabel.AutoSize = true;
            this.EstimatedBillLabel.Location = new System.Drawing.Point(66, 276);
            this.EstimatedBillLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EstimatedBillLabel.Name = "EstimatedBillLabel";
            this.EstimatedBillLabel.Size = new System.Drawing.Size(96, 17);
            this.EstimatedBillLabel.TabIndex = 5;
            this.EstimatedBillLabel.Text = "Estimated Bill:";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(348, 316);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(115, 30);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Gold;
            this.ResetButton.Location = new System.Drawing.Point(61, 316);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 28);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Clear";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bill Estimator";
            // 
            // OffPeakKwhlabel
            // 
            this.OffPeakKwhlabel.AutoSize = true;
            this.OffPeakKwhlabel.Location = new System.Drawing.Point(60, 214);
            this.OffPeakKwhlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OffPeakKwhlabel.Name = "OffPeakKwhlabel";
            this.OffPeakKwhlabel.Size = new System.Drawing.Size(158, 17);
            this.OffPeakKwhlabel.TabIndex = 9;
            this.OffPeakKwhlabel.Text = "How many off peak Kwh";
            this.OffPeakKwhlabel.Visible = false;
            // 
            // OffpeakKwhTextBox1
            // 
            this.OffpeakKwhTextBox1.Location = new System.Drawing.Point(245, 209);
            this.OffpeakKwhTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OffpeakKwhTextBox1.Name = "OffpeakKwhTextBox1";
            this.OffpeakKwhTextBox1.Size = new System.Drawing.Size(159, 22);
            this.OffpeakKwhTextBox1.TabIndex = 10;
            this.OffpeakKwhTextBox1.Visible = false;
            this.OffpeakKwhTextBox1.TextChanged += new System.EventHandler(this.OffpeakKwhTextBox1_TextChanged);
            // 
            // PowerBillingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 373);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

