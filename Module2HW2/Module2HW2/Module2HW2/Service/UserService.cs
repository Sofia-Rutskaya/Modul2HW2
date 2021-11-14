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
        private User _user;

        public UserService()
        {
            _user = new User();
        }

        public void CreateUser(string name, string lastName, string place, int phoneNumber, string email)
        {
            _user.Name = name;
            _user.LastName = lastName;
            _user.PlaceOfResidence = place;
            _user.TelNumber = phoneNumber;
            _user.Email = email;
        }

        public string GetUserName()
        {
            return _user.Name;
        }
    }
}
