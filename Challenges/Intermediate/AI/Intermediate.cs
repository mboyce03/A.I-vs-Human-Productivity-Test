using System;
using System.Collections.Generic;
using System.Linq;

namespace AIvsHuman_CSharp
{
    static class Intermediate
    {
        public static void Run()
        {
            List<LoginAttempt> attempts = new List<LoginAttempt>
            {
                new LoginAttempt { Username = "Alice", Timestamp = DateTime.Parse("10:00") },
                new LoginAttempt { Username = "Alice", Timestamp = DateTime.Parse("10:04") },
                new LoginAttempt { Username = "Alice", Timestamp = DateTime.Parse("10:08") },
                new LoginAttempt { Username = "Bob", Timestamp = DateTime.Parse("09:00") },
                new LoginAttempt { Username = "Bob", Timestamp = DateTime.Parse("10:30") },
                new LoginAttempt { Username = "Charlie", Timestamp = DateTime.Parse("11:00") },
                new LoginAttempt { Username = "Charlie", Timestamp = DateTime.Parse("11:05") },
                new LoginAttempt { Username = "Charlie", Timestamp = DateTime.Parse("11:20") }
            };

            List<string> suspiciousUsers = GetSuspiciousUsers(attempts);

            Console.WriteLine("Suspicious Users:");
            foreach (string user in suspiciousUsers)
            {
                Console.WriteLine(user);
            }
        }

        static List<string> GetSuspiciousUsers(List<LoginAttempt> attempts)
        {
            // TODO: Student implementation goes here
            return new List<string>();
        }
    }

    class LoginAttempt
    {
        public string Username { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
    }
}
