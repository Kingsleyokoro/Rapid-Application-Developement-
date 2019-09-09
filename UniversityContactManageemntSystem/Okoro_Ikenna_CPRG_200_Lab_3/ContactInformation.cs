using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityContactManagementSystem
{
    public class ContactInformation
    {

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if ((value == null) && (value.Length < 0))
                {
                    throw new ArgumentException("Invalid Email Address");
                }
                emailAddress = value;
            }
        }

        

        public string MailingAddress //check again
        {
            get { return mailingAddress; }
            set {
                if ((value == null) || (value.Length == 0))
                {
                    throw new ArgumentException("Invalid Mailing Address");
                }
                mailingAddress = value;
            }
        }

        public string OfficeLocation //check again
        {
            get { return officeLocation; }
            set {
                if ((value == null) || (value.Length == 0))
                {
                    throw new ArgumentException("Invalid Phone number");
                }
                officeLocation = value;
            }
        }

        private string emailAddress;
        private string officeLocation;
        private string mailingAddress;

        
        public ContactInformation()
        {
            emailAddress = "";
            officeLocation = "";
            mailingAddress = "";
        }

        

    }

}
