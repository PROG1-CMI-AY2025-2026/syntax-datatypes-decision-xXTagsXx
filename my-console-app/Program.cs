using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose which activity to run (1, 2, or 3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Activity1 activity1 = new Activity1();
                    Console.WriteLine(activity1.GetVariableDataTypes());
                    break;
                case "2":
                    Activity2 activity2 = new Activity2();

                    Console.Write("Enter the weather condition [sunny or rainy]: ");
                    string weatherCondition = Console.ReadLine();

                    Console.WriteLine(activity2.UmbrellaChecker(weatherCondition));
                    break;
                case "3":
                    Activity3 activity3 = new Activity3();

                    Console.Write("Enter your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Are you a citizen? (yes/no): ");
                    string citizen = Console.ReadLine();

                    Console.WriteLine(activity3.VoterEligibiltyChecker(age, citizen));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }
        }
    }
}