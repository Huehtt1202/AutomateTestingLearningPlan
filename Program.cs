using AutomateTestingLearningPlan.Pages;
using AutomateTestingLearningPlan.Testing;
using System;

namespace AutomateTestingLearningPlan.Program
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            User user = new User();
            Login login = new Login();
            login.ExercuteLogin(user);
            /*int a = 2; int b = 3;
            CountRef(ref a, ref b);
            int f, d, e;
            CountOut(out f, out d);*/
        }
        /*static void CountRef(ref int a, ref int b)
        {
            a++;
            int c = a + b;
            Console.WriteLine(c);
        }
        static void CountOut(out int f, out int d)
        {
            f = 0; d = 3;
            f++;
            int e = f + d;
            Console.WriteLine(e);
        }*/
    }
}
