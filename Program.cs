using AutomateTestingLearningPlan.Pages;
using AutomateTestingLearningPlan.Testing;
using NUnit.Framework;
using System;

namespace AutomateTestingLearningPlan.Program
{
    [TestFixture]
    public class Program1
    {
        public static void Main(string[] args)
        {
            Login login = new Login();
            login.ExercuteLogin();
        }  
    }
}
