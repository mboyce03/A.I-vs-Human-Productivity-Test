using System;
using System.Collections.Generic;

namespace AIvsHuman_CSharp
{
    enum ActionType
    {
        Login,
        Logout,
        Upload,
        Download,
        Idle
    }

    class Activity
    {
        public string UserId { get; set; }
        public ActionType Action { get; set; }
        public int DurationMinutes { get; set; }
    }

    static class AdvancedNonAI
    {
        public static void Run()
        {
            List<Activity> activities = new List<Activity>
            {
                new Activity { UserId = "UserA", Action = ActionType.Login, DurationMinutes = 10 },
                new Activity { UserId = "UserA", Action = ActionType.Idle, DurationMinutes = 5 },
                new Activity { UserId = "UserB", Action = ActionType.Upload, DurationMinutes = 20 },
                new Activity { UserId = "UserA", Action = ActionType.Download, DurationMinutes = 15 },
                new Activity { UserId = "UserB", Action = ActionType.Logout, DurationMinutes = 0 }
            };

            Dictionary<string, int> result = CalculateActiveTime(activities);

            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} minutes");
            }
        }

        static Dictionary<string, int> CalculateActiveTime(List<Activity> activities)
        {
            // TODO:
            // - Ensure every user appears in the output
            // - Only count allowed action types
            // - Ignore invalid durations
            // - Aggregate time correctly per user

            return new Dictionary<string, int>();
        }
    }
}