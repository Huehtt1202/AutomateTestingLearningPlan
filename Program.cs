using AutomateTestingLearningPlan.Pages;
using AutomateTestingLearningPlan.Testing;
using NUnit.Framework;
using System;

namespace AutomateTestingLearningPlan.Program
{
    public class Program1
    {
        public static void Main(string[] args)
        {
            ForgotPasswordTest forgotpw = new ForgotPasswordTest();
            forgotpw.SetUp();
            forgotpw.FindAccountTest_PhoneNumberExist_FoundAccount();
        }
    }
}
