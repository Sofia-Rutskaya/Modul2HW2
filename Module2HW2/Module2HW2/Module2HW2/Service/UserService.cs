using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
    public class UserService
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PlaceOfResidence { get; set; }
        public int TelNumber { get; set; }
        public string Email { get; set; }

        public void CreateUser(string name, string lastName, string place, int phoneNumber, string email)
        {
            Name = name;
            LastName = lastName;
            PlaceOfResidence = place;
            TelNumber = phoneNumber;
            Email = email;
        }
    }
}
