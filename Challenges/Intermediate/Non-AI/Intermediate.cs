using System;
using System.Collections.Generic;

namespace AIvsHuman_CSharp
{
    static class IntermediateNonAI
    {
        public static void Run()
        {
            List<int> transactions = new List<int>
            {
                100,
                -30,
                -90,
                50,
                -20
            };

            int finalBalance = CalculateFinalBalance(transactions);

            Console.WriteLine($"Final account balance: {finalBalance}");
        }

        static int CalculateFinalBalance(List<int> transactions)
        {
            // TODO:
            // Process each transaction in order
            // Apply deposits and withdrawals according to the rules
            // Return the final balance

            return 0;
        }
    }
}