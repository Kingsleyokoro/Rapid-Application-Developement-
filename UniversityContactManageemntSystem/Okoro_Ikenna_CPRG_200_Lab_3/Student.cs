using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityContactManagementSystem
{
    class Student : EducationPerson
    {
        //declaring properties
        public int GraduationYear
        {
            get { return graduationYear; }
            set
            {
                if (value < DateTime.Now.Year)
                {
                    throw new ArgumentException("Invalid graduation year");
                }
                graduationYear = value;
            }
        }

        public List<string> CourseList = new List<string>();


        private int graduationYear;
      

        //public Student(string fname, string lname, string departMent, ContactInformation contactInfo, int gradYear) : base(fname, lname, departMent)
        //{
        //    if (contactInfo.MailingAddress.Length == 0)
        //    {
        //        throw new ArgumentException("Mailing Address is null");
        //    }
        //    ci             = contactInfo;
        //    graduationYear = gradYear;
           
        //}
        public Student(string fname, string lname, string departMent, ContactInformation contactInfo, int gradYear, List<string> List) : base(fname, lname, departMent)
        {
            if (contactInfo.MailingAddress.Length == 0)
            {
                throw new ArgumentException("Mailing Address is null");
            }
            ci = contactInfo;
            graduationYear = gradYear;
            CourseList = List;
        }

        public Student(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            ci = new ContactInformation();
            ci.EmailAddress = tokens[3];
            ci.MailingAddress = tokens[4];
            graduationYear = int.Parse(tokens[5]);
            for(int i = 6; i < tokens.Length; i++)
            {
                CourseList.Add(tokens[i]);
            }

        }



        public override string ToString()
        {
            return base.ToString() + $" Graduation Year: {graduationYear} Mailing Address: {ci.MailingAddress}";
        }

        public override string ToFileString()
        {
            string theString = base.ToFileString() + $"|{ CI.MailingAddress}" + $"|{ graduationYear}";
            foreach (string course in CourseList)
            {
                theString = theString + "|" + course;
            }
            return theString;
        }

        public override string ToFormattedString()
        {
            string personType = "Student";
            return base.ToFormattedString() + $" {personType, 25} " ;
        }
    }
}
