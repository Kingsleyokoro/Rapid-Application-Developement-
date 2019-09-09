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
    public partial class AddEditStudent : Form
    {
        public bool EditMode = false;//this boolean variable control the edit student functionality
        public bool ReadOnlyMode = false;// this boolean variable control the viewing of contact details
        public string FirstName;
        public string LastName;
        public string Department;
        public string EmailAddress;
        public string MailingAddress;
        public int GradYear;
        public List<string> CourseList = new List<string>();


        private bool haveValidFirstName      = false;
        private bool haveValidLastName       = false;
        private bool haveValidDepartment     = false;
        private bool haveValidEmailAddress   = false;
        private bool haveValidMailingAddress = false;
        private bool haveValidGradYear       = false;
        public AddEditStudent()
        {
            InitializeComponent();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(FirstNameTextBox.Text.Trim().Length == 0)
            {
                haveValidFirstName = false;
            }
            else
            {
                haveValidFirstName = true;
                FirstName = FirstNameTextBox.Text.Trim();
            }
            
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Trim().Length == 0)
            {
                haveValidLastName = false;
            }
            else
            {
                haveValidLastName = true;
                LastName = LastNameTextBox.Text.Trim();
            }
            
        }

        private void DepartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DepartmentTextBox.Text.Trim().Length == 0)
            {
                haveValidDepartment = false;
            }
            else
            {
                haveValidDepartment = true;
                Department = DepartmentTextBox.Text.Trim();
            }
            
        }

        private void EmailAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailAddressTextBox.Text.Trim().Length == 0)
            {
                haveValidEmailAddress = false;
            }
            else
            {
                haveValidEmailAddress = true;
                EmailAddress = EmailAddressTextBox.Text.Trim();
            }
            
        }

        private void MailingAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MailingAddressTextBox.Text.Trim().Length == 0)
            {
                haveValidMailingAddress = false;
            }
            else
            {
                haveValidMailingAddress = true;
                MailingAddress = MailingAddressTextBox.Text.Trim();
            }
            
        }

        private void GraduationYearTextBox_TextChanged(object sender, EventArgs e)
        {
            haveValidGradYear = false;
            if(int.TryParse(GraduationYearTextBox.Text.Trim(), out GradYear))
            {
                if(GradYear > DateTime.Now.Year) //graduation year should be greater than the current year
                {
                    haveValidGradYear = true;
                }
            }
            //GradYear = int.Parse(GraduationYearTextBox.Text.Trim());
        }

        private void AddStudentbutton_Click(object sender, EventArgs e)
        {
            string badFieldName = null;
            string adviceString = null;

            if (!haveValidFirstName)
            {
                badFieldName = "Firstname";
                adviceString = "Must enter your First Name";
            }
            if (!haveValidLastName)
            {
                badFieldName = "Lastname";
                adviceString = "Must enter your Last Name";
            }
            if (!haveValidDepartment)
            {
                badFieldName = "Department";
                adviceString = "Must enter your Department";
            }
            if (!haveValidEmailAddress)
            {
                badFieldName = "Email Address";
                adviceString = "Must enter your Email Address";
            }
            if (!haveValidMailingAddress)
            {
                badFieldName = "Mailing Address";
                adviceString = "Must enter your Mailing Address";
            }
            if (!haveValidGradYear)
            {
                badFieldName = "Graduation year";
                adviceString = "Must enter your Graduation Year";
            }

            if(badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}, \n{adviceString}", "Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelStudentButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddEditStudent_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                FirstNameTextBox.Text      = FirstName;
                LastNameTextBox.Text       = LastName;
                DepartmentTextBox.Text     = Department;
                EmailAddressTextBox.Text   = EmailAddress;
                MailingAddressTextBox.Text = MailingAddress;
                GraduationYearTextBox.Text = (GradYear.ToString());

                foreach (string course in CourseList)
                {
                    studentCoursesListBox.Items.Add(course);
                }

                addStudentbutton.Text = "Edit";
                this.Text = "Edit Student";
            }

            if (ReadOnlyMode)
            {
                FirstNameTextBox.Text      = FirstName;
                LastNameTextBox.Text       = LastName;
                DepartmentTextBox.Text     = Department;
                EmailAddressTextBox.Text   = EmailAddress;
                MailingAddressTextBox.Text = MailingAddress;
                GraduationYearTextBox.Text = (GradYear.ToString());

                foreach(string course in CourseList)
                {
                    studentCoursesListBox.Items.Add(course);
                }
                

                FirstNameTextBox.ReadOnly      = true;
                LastNameTextBox.ReadOnly       = true;
                DepartmentTextBox.ReadOnly     = true;
                EmailAddressTextBox.ReadOnly   = true;
                MailingAddressTextBox.ReadOnly = true;
                GraduationYearTextBox.ReadOnly = true;

                addCoursesButton.Visible = false; //disable the addcourses Button
                addStudentbutton.Visible = false; //remove the add button on the form since the textbox is read only
                this.Text = " Student Contact Details";
            }
        }

        private void AddCoursesButton_Click(object sender, EventArgs e)
        {
            AddCourses addCourses = new AddCourses();//creating an object addcourses which is an instance of the AddCourses form class
            DialogResult result = addCourses.ShowDialog();//show the dialog and anticipate an ok response

            if (result != DialogResult.OK)//if the user selects an option other than ok, Return
            {
                return;
            }

            CourseList.Add(addCourses.Courses);
            studentCoursesListBox.Items.Add(addCourses.Courses);
        }
    }
}
