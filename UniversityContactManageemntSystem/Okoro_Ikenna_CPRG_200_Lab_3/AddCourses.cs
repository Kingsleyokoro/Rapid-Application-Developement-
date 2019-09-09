using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityContactManagementSystem
{
    public partial class AddCourses : Form
    {
        public string Courses;

        private bool haveValidCourseName = false;


        public AddCourses()
        {
            InitializeComponent();
        }

        private void AddCoursesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addCoursesTextBox.Text.Length == 0)
            {
                haveValidCourseName = false;
            }
            else
            {
                haveValidCourseName = true;
                Courses = addCoursesTextBox.Text.Trim();
            }
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            string badFieldName = null;
            string adviceString = null;

            if (!haveValidCourseName)
            {
                badFieldName = "Firstname";
                adviceString = "Must enter your First Name";
            }
            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}, \n{adviceString}", "Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelCourseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
