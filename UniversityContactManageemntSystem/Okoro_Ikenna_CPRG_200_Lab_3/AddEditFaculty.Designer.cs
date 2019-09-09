namespace UniversityContactManagementSystem
{
    partial class AddEditFaculty
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.ContactInformationLabel = new System.Windows.Forms.Label();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.OfficeLocationLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.facultyLastNameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.FacultyOfficeLocationTextBox = new System.Windows.Forms.TextBox();
            this.FacultyEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(67, 49);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.AutoSize = true;
            this.LastNameTextBox.Location = new System.Drawing.Point(67, 86);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(76, 17);
            this.LastNameTextBox.TabIndex = 0;
            this.LastNameTextBox.Text = "Last Name";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(67, 124);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(82, 17);
            this.DepartmentLabel.TabIndex = 0;
            this.DepartmentLabel.Text = "Department";
            // 
            // ContactInformationLabel
            // 
            this.ContactInformationLabel.AutoSize = true;
            this.ContactInformationLabel.Location = new System.Drawing.Point(67, 158);
            this.ContactInformationLabel.Name = "ContactInformationLabel";
            this.ContactInformationLabel.Size = new System.Drawing.Size(134, 17);
            this.ContactInformationLabel.TabIndex = 0;
            this.ContactInformationLabel.Text = "Contact Information;";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(202, 192);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(102, 17);
            this.EmailAddressLabel.TabIndex = 0;
            this.EmailAddressLabel.Text = "Email Address:";
            // 
            // OfficeLocationLabel
            // 
            this.OfficeLocationLabel.AutoSize = true;
            this.OfficeLocationLabel.Location = new System.Drawing.Point(202, 223);
            this.OfficeLocationLabel.Name = "OfficeLocationLabel";
            this.OfficeLocationLabel.Size = new System.Drawing.Size(107, 17);
            this.OfficeLocationLabel.TabIndex = 0;
            this.OfficeLocationLabel.Text = "Office Location:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(205, 49);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(531, 22);
            this.FirstNameTextBox.TabIndex = 1;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // facultyLastNameTextBox
            // 
            this.facultyLastNameTextBox.Location = new System.Drawing.Point(205, 81);
            this.facultyLastNameTextBox.Name = "facultyLastNameTextBox";
            this.facultyLastNameTextBox.Size = new System.Drawing.Size(531, 22);
            this.facultyLastNameTextBox.TabIndex = 1;
            this.facultyLastNameTextBox.TextChanged += new System.EventHandler(this.FacultyLastNameTextBox_TextChanged);
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(205, 119);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(531, 22);
            this.DepartmentTextBox.TabIndex = 1;
            this.DepartmentTextBox.TextChanged += new System.EventHandler(this.DepartmentTextBox_TextChanged);
            // 
            // FacultyOfficeLocationTextBox
            // 
            this.FacultyOfficeLocationTextBox.Location = new System.Drawing.Point(310, 223);
            this.FacultyOfficeLocationTextBox.Name = "FacultyOfficeLocationTextBox";
            this.FacultyOfficeLocationTextBox.Size = new System.Drawing.Size(426, 22);
            this.FacultyOfficeLocationTextBox.TabIndex = 1;
            this.FacultyOfficeLocationTextBox.TextChanged += new System.EventHandler(this.FacultyOfficeLocationTextBox_TextChanged);
            // 
            // FacultyEmailAddressTextBox
            // 
            this.FacultyEmailAddressTextBox.Location = new System.Drawing.Point(310, 187);
            this.FacultyEmailAddressTextBox.Name = "FacultyEmailAddressTextBox";
            this.FacultyEmailAddressTextBox.Size = new System.Drawing.Size(426, 22);
            this.FacultyEmailAddressTextBox.TabIndex = 1;
            this.FacultyEmailAddressTextBox.TextChanged += new System.EventHandler(this.FacultyEmailAddressTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(522, 279);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 36);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(655, 278);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 37);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEditFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FacultyEmailAddressTextBox);
            this.Controls.Add(this.FacultyOfficeLocationTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.facultyLastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.OfficeLocationLabel);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.ContactInformationLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "AddEditFaculty";
            this.Text = "Add Faculty";
            this.Load += new System.EventHandler(this.AddEditFaculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameTextBox;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label ContactInformationLabel;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.Label OfficeLocationLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox facultyLastNameTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox FacultyOfficeLocationTextBox;
        private System.Windows.Forms.TextBox FacultyEmailAddressTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}