using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace UniversityContactManagementSystem
{
    public partial class ContactMangerMainForm : Form
    {
        public string Filepath = null; //this variables is used to store the file path for the save contact tool strip
        public List<EducationPerson> educationPeople = new List<EducationPerson>(); //*this list stores the EducationPerson object


        //this boolean flag checks if changes have been made by either adding,
        //editing or deleting a faulty or student 
        private bool changesMade = false;
        
        public ContactMangerMainForm()
        {
            InitializeComponent();
        }

        private void AddFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty faculty = null;

            faculty = createFacultyPerson();

            if (faculty != null)
            {
                educationPeople.Add(faculty);
                ContactDisplayListBoz.Items.Add(faculty.ToFormattedString());
            }
            changesMade = true;
        }
        //this method creates a faculty object reference
        private Faculty createFacultyPerson()
        {
            AddEditFaculty aef = new AddEditFaculty();

            DialogResult result;
            result = aef.ShowDialog();
            if (result != DialogResult.OK)
            {
                return null;
            }

            ContactInformation contact = new ContactInformation();
            contact.EmailAddress = aef.EmailAddress;
            contact.OfficeLocation = aef.OfficeLocation;

            Faculty F = new Faculty(aef.FirstName,
                                    aef.LastName,
                                    aef.Department,
                                    contact);
            return F;


        }
        //this method creates a student Object reference
        private Student createStudent()
        {
            AddEditStudent aes = new AddEditStudent();

            DialogResult result;
            result = aes.ShowDialog();
            if (result != DialogResult.OK)
            {
                return null;
            }

            ContactInformation contact = new ContactInformation();
            contact.EmailAddress = aes.EmailAddress;
            contact.MailingAddress = aes.MailingAddress;

            Student S = new Student(aes.FirstName,
                                    aes.LastName,
                                    aes.Department,
                                    contact,
                                    aes.GradYear,aes.CourseList);

            return S;

        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = null;

            student = createStudent();

            if (student != null)
            {
                educationPeople.Add(student);
                ContactDisplayListBoz.Items.Add(student.ToFormattedString());
            }
            changesMade = true;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open a File";
            ofd.Filter = "Text Files|*.txt|All Files|*.*";
            ofd.FilterIndex = 1;

            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            EducationPerson person = null;
            Filepath = ofd.FileName.ToString();  //save the current file path into the filapath variable.
            try
            {
                StreamReader input = new StreamReader(ofd.FileName);

                while (!input.EndOfStream)
                {
                    string personType = input.ReadLine();
                    switch (personType)
                    {
                        case "FACULTY":
                            person = new Faculty(input.ReadLine());
                            break;
                        case "STUDENT":
                            person = new Student(input.ReadLine());
                            break;
                        default:
                            MessageBox.Show("Unknown Person in the file");
                            person = null;
                            break;
                    }

                    if (person != null)
                    {
                        educationPeople.Add(person);
                        ContactDisplayListBoz.Items.Add(person.ToFormattedString());
                    }
                }
                input.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show($"File failed to load. {excp.Message}");
                return;
            }
        }

        private void SaveContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if filepath is null pop a dialogue for the user
            //save the filepath name 
            //when next the save contact tool strip is clicked save conatct details to existing filepath
            if (Filepath == null)
            {
                //use the save as method/event which pops a dialogue
                SaveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                try
                {
                    StreamWriter output = new StreamWriter(Filepath);
                    foreach (EducationPerson p in educationPeople)
                    {
                        output.WriteLine(personTypeString(p));
                        output.WriteLine(p.ToFileString());
                    }
                    output.Close();
                }
                catch (Exception excp)
                {
                    MessageBox.Show($"File did not write. {excp.Message}","Error!");
                    return;
                }
                changesMade = false;
                MessageBox.Show($"Contact information have been saved in {Filepath}","Save successful");
            }

        }
        //this method differentiates btween faculty and student
        //by writing faculty above before the data is inserted
        private string personTypeString(EducationPerson p)
        {
            if (p is Faculty)
                return "FACULTY";
            else if (p is Student)
                return "STUDENT";
            else
                return "UNKNOWN";
        }

        private void DeleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to see if the user selcted an item
            //before performing the delete opertaion
            int index = ContactDisplayListBoz.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("You must select an item to be deleted");
                return;
            }
            //check if the user selected more than one item
            if(ContactDisplayListBoz.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select one item to delete");
                return;
            }
            //pop confirmation dialogue that the item is about to be deleted
            EducationPerson person = educationPeople[index];

            if (DialogResult.Yes != MessageBox.Show($"Are you sure you wish to delete {person.FirstName}'s details?",
                                    "Confirmation", MessageBoxButtons.YesNo))
            {
                return;
            }
            //delete the item and remote it from the education people list
            //remove it from the listbox display as well
            educationPeople.RemoveAt(index);
            ContactDisplayListBoz.Items.RemoveAt(index);
            changesMade = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changesMade)
            {
                if (DialogResult.Yes != MessageBox.Show($"Would you like to save changes before you Exit?",
                                    "Confirmation", MessageBoxButtons.YesNo))
                {
                    //if the user does not wish to save the file go ahead and exit the application
                    Application.Exit();
                }
                else
                {
                    //if changes have been made and the user wishes to save the file
                    //call the save event handler to perform the save action before exit.
                    SaveContactsToolStripMenuItem_Click(sender, e);
                }
            }
            //if no changes have been made just exit the application
            Application.Exit();
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pop a dialogue for the user to save a file
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Select File to save Contact List ";

            sfd.Filter = "Text Files|*.txt|All Files|*.*";
            sfd.FilterIndex = 1;

            DialogResult result = sfd.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }
            //save the filepath variable 
            Filepath = sfd.FileName.ToString();
            try
            {
                StreamWriter output = new StreamWriter(sfd.FileName);
                foreach (EducationPerson person in educationPeople)
                {
                    output.WriteLine(personTypeString(person));
                    output.WriteLine(person.ToFileString());
                }
                output.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not write. {excp.Message}");
                return;
            }

            MessageBox.Show($"Contact details have been saved in {sfd.FileName}","Save successful");
        }
        //this method is used to edit faculty individuals or persons
        //pop the faculty dialogue and configure it
        private void editFaculty(int index)
        {
            AddEditFaculty aef = new AddEditFaculty();
            aef.EditMode = true;

            Faculty F = (Faculty)educationPeople[index];

            aef.FirstName = F.FirstName;
            aef.LastName = F.LastName;
            aef.Department = F.Department;
            aef.EmailAddress = F.CI.EmailAddress;
            aef.OfficeLocation = F.CI.OfficeLocation;

            DialogResult result = aef.ShowDialog();


            if (result != DialogResult.OK)
            {
                return;
            }

            ContactInformation contact = new ContactInformation();
            contact.EmailAddress = aef.EmailAddress;
            contact.OfficeLocation = aef.OfficeLocation;
            EducationPerson person = new Faculty(aef.FirstName,
                                                  aef.LastName,
                                                  aef.Department,
                                                  contact);

            result = MessageBox.Show($"Are you sure you like to update {person.FirstName}'s details?",
                                        "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                educationPeople[index] = person;
                ContactDisplayListBoz.Items[index] = person.ToFormattedString();
            }
            else { return; }
        }
        //this method is used to edit student individuals or persons
        //pop the student dialogue and populate the contents of the fields
        private void editStudent(int index)
        {
            AddEditStudent aes = new AddEditStudent();
            aes.EditMode = true;

            Student s = (Student)educationPeople[index];

            aes.FirstName = s.FirstName;
            aes.LastName = s.LastName;
            aes.Department = s.Department;
            aes.MailingAddress = s.CI.MailingAddress;
            aes.EmailAddress = s.CI.EmailAddress;
            aes.GradYear = s.GraduationYear;
            aes.CourseList = s.CourseList;

            DialogResult result = aes.ShowDialog();//show the dialog and anticipate an ok response

            if (result != DialogResult.OK)//if the user selects an option other than ok, Return
            {
                return;
            }

            ContactInformation contact = new ContactInformation();
            contact.EmailAddress = aes.EmailAddress;
            contact.MailingAddress = aes.MailingAddress;

            EducationPerson person = new Student(aes.FirstName,
                                                  aes.LastName,
                                                  aes.Department,
                                                  contact, aes.GradYear,aes.CourseList);
            //pop a message box to confirm if the user wishes to change selected details
            result = MessageBox.Show($"Are you sure you like to change {person.FirstName}'s details?",
                                        "Confirmation", MessageBoxButtons.YesNo);
            //if the user selects Yes continue
            if (result == DialogResult.Yes)
            {
                educationPeople[index] = person;
                ContactDisplayListBoz.Items[index] = person.ToFormattedString();
            }
            else { return; }
        }

        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = ContactDisplayListBoz.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("You must select an item to edit or update");
                return;
            }
            //check if the user selected more than one item
            if (ContactDisplayListBoz.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select one item to edit or update");
                return;
            }

            EducationPerson person = educationPeople[index];

            if (person is Faculty)
            {
                editFaculty(index);
                changesMade = true;

            }
            else if (person is Student)
            {
                editStudent(index);
                changesMade = true;
            }
            else
            {
                MessageBox.Show("Unknown Contact details to be edited");
            }
        }

        //this method initiates read only mode
        // and creates the faculty object to be displayed
        private void showFacultyContact(int index)
        {
            AddEditFaculty aef = new AddEditFaculty();
            aef.ReadOnlyMode = true;

            Faculty F = (Faculty)educationPeople[index];

            aef.FirstName = F.FirstName;
            aef.LastName = F.LastName;
            aef.Department = F.Department;
            aef.EmailAddress = F.CI.EmailAddress;
            aef.OfficeLocation = F.CI.OfficeLocation;

            DialogResult result = aef.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            ContactInformation contact = new ContactInformation();
            contact.EmailAddress = aef.EmailAddress;
            contact.OfficeLocation = aef.OfficeLocation;
            EducationPerson person = new Faculty(aef.FirstName,
                                                  aef.LastName,
                                                  aef.Department,
                                                  contact);
        }
        //this method initiates read only mode
        // and creates the student object to be displayed
        private void showStudentContact(int index)
        {
            AddEditStudent aes = new AddEditStudent();
            aes.ReadOnlyMode = true;

            Student s = (Student)educationPeople[index];

            aes.FirstName = s.FirstName;
            aes.LastName = s.LastName;
            aes.Department = s.Department;
            aes.MailingAddress = s.CI.MailingAddress;
            aes.EmailAddress = s.CI.EmailAddress;
            aes.GradYear = s.GraduationYear;
            aes.CourseList = s.CourseList;

            DialogResult result = aes.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            ContactInformation contact = new ContactInformation();
            contact.EmailAddress = aes.EmailAddress;
            contact.MailingAddress = aes.MailingAddress;

            EducationPerson person = new Student(aes.FirstName,
                                                  aes.LastName,
                                                  aes.Department,
                                                  contact, aes.GradYear,
                                                  aes.CourseList);
        }

        private void ContactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if an item is selected in the lsitbox
            int index = ContactDisplayListBoz.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("You must select an item to view Contact Details");
                return;
            }
            //check if the user selected more than one item
            if (ContactDisplayListBoz.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select one item to view the contact details");
                return;
            }
            //instantiate the base class object
            EducationPerson person = educationPeople[index];

            //add the object to the dialogue by calling the method
            if (person is Faculty)
            {
                showFacultyContact(index);

            }
            else if (person is Student)
            {
                showStudentContact(index);
            }
            else
            {
                MessageBox.Show("Unknown Contact details cannot be displayed");
                return;
            }
        }

        private void FirstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pop the seach name dialoge
            //get the name from the user and find a match in the listbox
            //if a mactch is found select the item on the lsit box

            SearchName searchDialog = new SearchName();
            searchDialog.searchFname = true;
            

            DialogResult result = searchDialog.ShowDialog();

            if (result != DialogResult.OK)//if the user selects an option other than ok, Return
            {
                return;
            }

            ContactDisplayListBoz.ClearSelected();  //clear all previously selected items on the list box
            for(int i = 0; i < educationPeople.Count; i++)
            {
                if (educationPeople[i].FirstName.ToLower().Contains(searchDialog.FirstName.ToLower()))
                {
                    ContactDisplayListBoz.SetSelected(i, true);
                    
                } 
            }
            MessageBox.Show($"{ContactDisplayListBoz.SelectedItems.Count.ToString()} match(es) found", "Search Result");
            return;
        }

        private void LastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pop the seach name dialoge
            //get the name from the user and find a match in the listbox
            //if a mactch is found select the item on the lsit box

            SearchName searchDialog = new SearchName();
            searchDialog.searchLname = true;
            

            DialogResult result = searchDialog.ShowDialog();

            if (result != DialogResult.OK)//if the user selects an option other than ok, Return
            {
                return;
            }

            ContactDisplayListBoz.ClearSelected();  //clear all previously selected items on the list box
            for (int i = 0; i < educationPeople.Count; i++)
            {
                if (educationPeople[i].LastName.ToLower().Contains(searchDialog.LastName.ToLower()))
                {
                    ContactDisplayListBoz.SetSelected(i, true);    
                }
            }
            MessageBox.Show($"{ContactDisplayListBoz.SelectedItems.Count.ToString()} match(es) found", "Search Result");
            return;
        }

        private void FirstAndLastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pop the seach name dialoge
            //get the name from the user and find a match in the listbox
            //if a mactch is found select the item on the lsit box

            SearchName searchDialog = new SearchName();
            
            DialogResult result = searchDialog.ShowDialog();

            if (result != DialogResult.OK)//if the user selects an option other than ok, Return
            {
                return;
            }

            ContactDisplayListBoz.ClearSelected();  //clear all previously selected items on the list box
            for (int i = 0; i < educationPeople.Count; i++)
            {
                if (educationPeople[i].FirstName.ToLower().Contains(searchDialog.FirstName.ToLower()) &&
                    educationPeople[i].LastName.ToLower().Contains(searchDialog.LastName.ToLower()))
                {
                    ContactDisplayListBoz.SetSelected(i, true);  
                }
            }
            MessageBox.Show($"{ContactDisplayListBoz.SelectedItems.Count.ToString()} match(es) found", "Search Result");
            return;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This a University contact management software \n" +
                            "Developed by: Okoro Ikenna Kingsley \n" +
                            "For more Information Contact: ikenna.okoro@edu.sait.ca", "About");
        }
    }
}
