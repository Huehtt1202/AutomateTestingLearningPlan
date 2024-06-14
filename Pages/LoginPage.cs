using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Pages
{

    public class LoginScreen
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public LoginScreen(string _userName, string _password) 
        { 
            this.userName = _userName;
            this.password = _password;
        }
        public LoginScreen(string _phoneNumber) {
            this.phoneNumber = _phoneNumber;
        }
    }
}
