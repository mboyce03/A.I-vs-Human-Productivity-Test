using System;

namespace AIvsHuman_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select challenge to run:");
            Console.WriteLine("1 - Beginner");
            Console.WriteLine("2 - Intermediate");
            Console.WriteLine("3 - Advanced");
            Console.WriteLine("4 - Expert");


            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Beginner.Run();
                    break;
                case "2":
                    Intermediate.Run();
                    break;
                case "3":
                    Advanced.Run();
                    break;
                case "4":
                    Expert.Run();
                break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}
