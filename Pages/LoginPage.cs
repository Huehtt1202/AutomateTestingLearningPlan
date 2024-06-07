using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Pages
{

    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public User(string _userName, string _password) 
        { 
            this.userName = _userName;
            this.password = _password;
        }
        public User(string _phoneNumber) {
            this.phoneNumber = _phoneNumber;
        }
    }
}
