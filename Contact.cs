﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_3_3
{
    /// <summary>
    /// модель класса Contact
    /// </summary>
    public class Contact  
    {
        public Contact(string name, string lastName, long phoneNumber, String email) 
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
