using System;
using System.Collections.Generic;

namespace AIvsHuman_CSharp
{
    static class Beginner
    {
        public static void Run()
        {
            List<int> scores = new List<int> { 45, 78, 102, 66, -5, 88 };

            int validCount = CountValidScores(scores);

            Console.WriteLine($"Valid scores count: {validCount}");
        }

        static int CountValidScores(List<int> scores)
        {
            //Logic to count valid scores to be implemented here
            return 0;
        }
    }
}
