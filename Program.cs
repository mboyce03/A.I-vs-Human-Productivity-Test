using System;

namespace AIvsHuman_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select mode:");
            Console.WriteLine("1 - Non-AI");
            Console.WriteLine("2 - AI");

            string? modeChoice = Console.ReadLine();

            Console.WriteLine("\nSelect challenge to run:");
            Console.WriteLine("1 - Beginner");
            Console.WriteLine("2 - Intermediate");
            Console.WriteLine("3 - Advanced");
            Console.WriteLine("4 - Expert");

            string? difficultyChoice = Console.ReadLine();

            if (modeChoice == "1")
            {
                RunNonAI(difficultyChoice);
            }
            else if (modeChoice == "2")
            {
                RunAI(difficultyChoice);
            }
            else
            {
                Console.WriteLine("Invalid mode selection.");
            }
        }

        static void RunNonAI(string? choice)
        {
            switch (choice)
            {
                case "1":
                    BeginnerNonAI.Run();
                    break;
                case "2":
                    IntermediateNonAI.Run();
                    break;
                case "3":
                    AdvancedNonAI.Run();
                    break;
                case "4":
                    ExpertNonAI.Run();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        static void RunAI(string? choice)
        {
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