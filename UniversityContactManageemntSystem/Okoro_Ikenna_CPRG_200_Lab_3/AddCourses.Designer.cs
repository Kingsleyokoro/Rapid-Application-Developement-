namespace UniversityContactManagementSystem
{
    partial class AddCourses
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
            this.addACourseLabel = new System.Windows.Forms.Label();
            this.addCoursesTextBox = new System.Windows.Forms.TextBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.cancelCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addACourseLabel
            // 
            this.addACourseLabel.AutoSize = true;
            this.addACourseLabel.Location = new System.Drawing.Point(47, 31);
            this.addACourseLabel.Name = "addACourseLabel";
            this.addACourseLabel.Size = new System.Drawing.Size(43, 13);
            this.addACourseLabel.TabIndex = 0;
            this.addACourseLabel.Text = "Course:";
            // 
            // addCoursesTextBox
            // 
            this.addCoursesTextBox.Location = new System.Drawing.Point(96, 28);
            this.addCoursesTextBox.Name = "addCoursesTextBox";
            this.addCoursesTextBox.Size = new System.Drawing.Size(214, 20);
            this.addCoursesTextBox.TabIndex = 1;
            this.addCoursesTextBox.TextChanged += new System.EventHandler(this.AddCoursesTextBox_TextChanged);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(154, 90);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(75, 23);
            this.AddCourseButton.TabIndex = 2;
            this.AddCourseButton.Text = "Add";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // cancelCourseButton
            // 
            this.cancelCourseButton.Location = new System.Drawing.Point(235, 90);
            this.cancelCourseButton.Name = "cancelCourseButton";
            this.cancelCourseButton.Size = new System.Drawing.Size(75, 23);
            this.cancelCourseButton.TabIndex = 3;
            this.cancelCourseButton.Text = "Cancel";
            this.cancelCourseButton.UseVisualStyleBackColor = true;
            this.cancelCourseButton.Click += new System.EventHandler(this.CancelCourseButton_Click);
            // 
            // AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 136);
            this.Controls.Add(this.cancelCourseButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.addCoursesTextBox);
            this.Controls.Add(this.addACourseLabel);
            this.Name = "AddCourses";
            this.Text = "AddCourses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addACourseLabel;
        private System.Windows.Forms.TextBox addCoursesTextBox;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button cancelCourseButton;
    }
}