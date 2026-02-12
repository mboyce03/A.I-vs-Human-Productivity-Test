using System;
using System.Collections.Generic;

namespace AIvsHuman_CSharp
{
    static class BeginnerNonAI
    {
        public static void Run()
        {
            List<int> values = new List<int> { -3, 5, 0, 12, -7, 4 };

            int result = CountPositiveValues(values);

            Console.WriteLine($"Number of positive values: {result}");
        }

        static int CountPositiveValues(List<int> values)
        {
            // TODO:
            // Implement logic to count positive values in the list

            return 0;
        }
    }
}
