using System;
using System.Collections.Generic;

namespace AIvsHuman_CSharp
{
    static class Expert
    {
        public static void Run()
        {
            List<DateTime> requests = new List<DateTime>
            {
                DateTime.Parse("10:00:00"),
                DateTime.Parse("10:10:00"),
                DateTime.Parse("10:20:00"),
                DateTime.Parse("10:30:00"),
                DateTime.Parse("10:40:00"),
                DateTime.Parse("10:50:00")
            };

            (int allowed, int rejected) result = EvaluateRequests(requests);

            Console.WriteLine($"Allowed: {result.allowed}");
            Console.WriteLine($"Rejected: {result.rejected}");
        }

        /// <summary>
        /// Allows a maximum of 5 requests per rolling 60-second window.
        /// Requests exceeding this limit should be rejected.
        /// </summary>
        static (int allowed, int rejected) EvaluateRequests(List<DateTime> requests)
        {
            // TODO:
            // Implement rate-limiting logic here

            return (0, 0);
        }
    }
}
