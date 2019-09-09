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
    public partial class AddEditFaculty : Form
    {
        public bool ReadOnlyMode = false;
        public bool EditMode = false;
        public string FirstName;
        public string LastName;
        public string Department;
        public string EmailAddress;
        public string OfficeLocation;

        private bool haveValidFirstName = false;
        private bool haveValidLastName = false;
        private bool haveValidDepartment = false;
        private bool haveValidEmailAddress = false;
        private bool haveValidOfficeLocation = false;
        
        public AddEditFaculty()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
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
            if (!haveValidOfficeLocation)
            {
                badFieldName = "Office Location";
                adviceString = "Must enter your Office Location";
            }
            

            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}, \n{adviceString}", "Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
                FirstName          = FirstNameTextBox.Text.Trim();
            }
            
        }

        private void FacultyLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (facultyLastNameTextBox.Text.Trim().Length == 0)
            {
                haveValidLastName = false;
            }
            else
            {
                haveValidLastName = true;
                LastName          = facultyLastNameTextBox.Text.Trim();
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
                Department          = DepartmentTextBox.Text.Trim();
            }
            
        }

        private void FacultyEmailAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FacultyEmailAddressTextBox.Text.Trim().Length == 0)
            {
                haveValidEmailAddress = false;
            }
            else
            {
                haveValidEmailAddress = true;
                EmailAddress          = FacultyEmailAddressTextBox.Text.Trim();
            }
            
        }

        private void FacultyOfficeLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FacultyOfficeLocationTextBox.Text.Trim().Length == 0)
            {
                haveValidOfficeLocation = false;
            }
            else
            {
                haveValidOfficeLocation = true;
                OfficeLocation          = FacultyOfficeLocationTextBox.Text.Trim();
            }
           
        }

        private void AddEditFaculty_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                FirstNameTextBox.Text             = FirstName;
                facultyLastNameTextBox.Text       = LastName;
                DepartmentTextBox.Text            = Department;
                FacultyEmailAddressTextBox.Text   = EmailAddress;
                FacultyOfficeLocationTextBox.Text = OfficeLocation;

                AddButton.Text = "Edit";
                this.Text      = "Edit Faculty";

            }
            if (ReadOnlyMode)
            {
                FirstNameTextBox.Text             = FirstName;
                facultyLastNameTextBox.Text       = LastName;
                DepartmentTextBox.Text            = Department;
                FacultyEmailAddressTextBox.Text   = EmailAddress;
                FacultyOfficeLocationTextBox.Text = OfficeLocation;

                FirstNameTextBox.ReadOnly             = true;
                facultyLastNameTextBox.ReadOnly       = true;
                DepartmentTextBox.ReadOnly            = true;
                FacultyEmailAddressTextBox.ReadOnly   = true;
                FacultyOfficeLocationTextBox.ReadOnly = true;

                AddButton.Visible = false;
                this.Text         = "Faculty contact details";
            }
        }
    }
}
