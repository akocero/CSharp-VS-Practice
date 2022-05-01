using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWindowsForm
{
    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }


        public User(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }
    }
}
