using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityContactManagementSystem
{
    class Faculty : EducationPerson
    {
        //add uniques faculty property such as Title;
        public Faculty(string fname, string lname, string departMent, ContactInformation contactInfo) : base( fname, lname, departMent)
        {
            if (contactInfo.OfficeLocation.Length == 0)
            {
                throw new ArgumentException("Office location is null");
            }
            CI = contactInfo;
        }

        public Faculty(string fromFile) : base(fromFile)
        {
            char[] delimiters = { '|', ',' };

            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            ci = new ContactInformation();
            ci.EmailAddress = tokens[3];
            ci.OfficeLocation = tokens[4];
        }
        public override string ToString()
        {
            return base.ToString() + $"Ofiice Location {CI.OfficeLocation} Email Address: {CI.EmailAddress}";
        }

        public override string ToFormattedString()
        {
            string personType = "Faculty";
            return base.ToFormattedString() + $" {personType, 25} ";
        }

        public override string ToFileString()
        {
            return base.ToFileString() + $"|{CI.OfficeLocation}";
        }
    }
}
