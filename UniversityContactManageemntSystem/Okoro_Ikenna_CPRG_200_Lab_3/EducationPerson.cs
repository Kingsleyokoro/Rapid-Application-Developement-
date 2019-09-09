using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversityContactManagementSystem
{
    //properties of the base Class
    public class EducationPerson
    {
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if ((value == null) && (value.Length > 0))
                {
                    throw new ArgumentException("Invalid First name.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if ((value == null) && (value.Length < 0))
                {
                    throw new ArgumentException("Invalid Last name.");
                }
                lastName = value;
            }
        }

        public string Department
        {
            get { return department; }
            set
            {
                if ((value == null) && (value.Length < 0))
                {
                    throw new ArgumentException("Invalid Department name.");
                }
                department = value;
            }
        }

        public ContactInformation CI //the abbreviation "CI" denotes "Contact Information" 
        {
            get { return ci; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The Object conatct information is null");
                }
                ci = value;
            }
        }
        

        private string firstName;
        private string lastName;
        private string department;
        protected ContactInformation ci;

        //constructors
        public EducationPerson(string fname, string lname, string departMent, ContactInformation contactInfo)
        {
            firstName = fname;
            lastName = lname;
            department = departMent;
            ci = contactInfo;
            

        }

        public EducationPerson(string fname, string lname, string departMent)
        {
            firstName = fname;
            lastName = lname;
            department = departMent;
            ci = new ContactInformation();

        }

        public EducationPerson(string fromFile)
        {
            char[] delimiters = { '|', ',' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            firstName = tokens[0];
            lastName = tokens[1];
            department = tokens[2];
            
        }

        public virtual string ToFileString()
        {
            string theString = "";

            theString += $"{firstName}|";
            theString += $"{lastName}|";
            theString += $"{department}|";
            theString += $"{CI.EmailAddress}";

            return theString;
        }

        public override string ToString()
        {
            return $"First Name: {firstName} Last Name: {lastName} Department: {department}"; 
        }
        
        public virtual string ToFormattedString()
        {
            string thestring = "";
            thestring += $"{firstName,25}";
            thestring += $"{lastName,25}";
            thestring += $"{department,25}";

            return thestring;
        }
    }
}
