using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Login login = new Login();
            login.testLogin();

        }
    }
}
