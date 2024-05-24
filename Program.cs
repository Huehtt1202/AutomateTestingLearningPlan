using AutomateTestingLearningPlan.Pages;
using AutomateTestingLearningPlan.Testing;
using System;

namespace AutomateTestingLearningPlan.Program
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            /*Login login = new Login();*/
            int countLoop = 0;
            int countLoopTime = 0;
            int valueNum = 10;
            int loopTime = 5;
            int minRandomValue = 0;
            int maxRandomValue = 100;
            Random random = new Random();
            while (countLoopTime < loopTime)
            {
                countLoop = 0;
                while (countLoop < valueNum)
                {
                    int showValue = random.Next(minRandomValue, maxRandomValue);
                    Console.Write("{0.8}", showValue);
                    countLoop++;
                }
            }
            Console.ReadLine();
        }
    }
}
