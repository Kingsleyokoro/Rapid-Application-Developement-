namespace UniversityContactManagementSystem
{
    partial class SearchName
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
            this.searchFirstNameLabel = new System.Windows.Forms.Label();
            this.searchLastNameLabel = new System.Windows.Forms.Label();
            this.searchFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.searchLastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchFirstNameLabel
            // 
            this.searchFirstNameLabel.AutoSize = true;
            this.searchFirstNameLabel.Location = new System.Drawing.Point(25, 28);
            this.searchFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchFirstNameLabel.Name = "searchFirstNameLabel";
            this.searchFirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.searchFirstNameLabel.TabIndex = 0;
            this.searchFirstNameLabel.Text = "First Name:";
            // 
            // searchLastNameLabel
            // 
            this.searchLastNameLabel.AutoSize = true;
            this.searchLastNameLabel.Location = new System.Drawing.Point(25, 58);
            this.searchLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLastNameLabel.Name = "searchLastNameLabel";
            this.searchLastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.searchLastNameLabel.TabIndex = 0;
            this.searchLastNameLabel.Text = "Last Name:";
            // 
            // searchFirstNameTextBox
            // 
            this.searchFirstNameTextBox.Location = new System.Drawing.Point(134, 28);
            this.searchFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            this.searchFirstNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.searchFirstNameTextBox.TabIndex = 1;
            this.searchFirstNameTextBox.TextChanged += new System.EventHandler(this.SearchFirstNameTextBox_TextChanged);
            // 
            // searchLastNameTextBox
            // 
            this.searchLastNameTextBox.Location = new System.Drawing.Point(134, 58);
            this.searchLastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchLastNameTextBox.Name = "searchLastNameTextBox";
            this.searchLastNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.searchLastNameTextBox.TabIndex = 1;
            this.searchLastNameTextBox.TextChanged += new System.EventHandler(this.SearchLastNameTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(201, 100);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(285, 100);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 29);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 140);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLastNameTextBox);
            this.Controls.Add(this.searchFirstNameTextBox);
            this.Controls.Add(this.searchLastNameLabel);
            this.Controls.Add(this.searchFirstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchName";
            this.Text = "SearchName";
            this.Load += new System.EventHandler(this.SearchName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchFirstNameLabel;
        private System.Windows.Forms.Label searchLastNameLabel;
        private System.Windows.Forms.TextBox searchFirstNameTextBox;
        private System.Windows.Forms.TextBox searchLastNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
    }
}