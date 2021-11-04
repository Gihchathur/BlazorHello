using System;
using System.Collections.Generic;
using System.Text;

namespace HelloBlazor.Shared
{
    public class UserDetails
    {
        public int Contactid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public UserDetails()
        {

        }


        public UserDetails(int contactId, string firstName, string lastName)
        {
            this.Contactid = contactId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public UserDetails(int contactId, string firstName, string lastName, string email)
        {
            this.Contactid = contactId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}
