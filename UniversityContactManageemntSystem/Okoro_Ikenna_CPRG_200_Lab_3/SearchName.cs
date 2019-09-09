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
    public partial class SearchName : Form
    {

        public string FirstName;
        public string LastName;

        public bool searchFname  = false;
        public bool searchLname  = false;

        private bool haveValidFirstName = false;
        private bool haveValidLastName  = false;
        public SearchName()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
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

        private void SearchFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchFirstNameTextBox.Text.Trim().Length == 0)
            {
                haveValidFirstName = false;
            }
            else
            {
                haveValidFirstName = true;
                FirstName          = searchFirstNameTextBox.Text.Trim();
            }
        }

        private void SearchLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchLastNameTextBox.Text.Trim().Length == 0)
            {
                haveValidLastName = false;
            }
            else
            {
                haveValidLastName = true;
                LastName          = searchLastNameTextBox.Text.Trim();
            }
        }

        private void SearchName_Load(object sender, EventArgs e)
        {
            if (searchFname)
            {
                searchLastNameLabel.Visible   = false;
                searchLastNameTextBox.Visible = false;
                haveValidLastName             = true;
            }
            if (searchLname)
            {
                searchFirstNameLabel.Visible   = false;
                searchFirstNameTextBox.Visible = false;
                haveValidFirstName             = true;
            }
        }
    }
}
