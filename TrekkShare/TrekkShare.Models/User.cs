using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace TrekkShare.Models
{
    public class User
    {
        public User()
        {
            //Initialize collections
        }

        public Guid UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        //public int AddressId { get; set; }
        //public Address Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Tourist Tourist { get; set; }
    }
}
