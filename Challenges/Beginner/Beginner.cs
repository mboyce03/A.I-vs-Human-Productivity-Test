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
            int count = 0;

            foreach (int score in scores)
            {
                if (score >= 0 && score <= 100)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
