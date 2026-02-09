using System;
using System.Collections.Generic;

namespace AIvsHuman_CSharp
{
    enum SessionEventType
    {
        Start,
        End
    }

    class SessionEvent
    {
        public string UserId { get; set; }
        public SessionEventType Type { get; set; }
        public int Time { get; set; } // Minutes since system start
    }

    static class ExpertNonAI
    {
        public static void Run()
        {
            List<SessionEvent> events = new List<SessionEvent>
            {
                new SessionEvent { UserId = "UserA", Type = SessionEventType.Start, Time = 0 },
                new SessionEvent { UserId = "UserA", Type = SessionEventType.Start, Time = 5 },
                new SessionEvent { UserId = "UserA", Type = SessionEventType.End, Time = 20 },
                new SessionEvent { UserId = "UserB", Type = SessionEventType.End, Time = 10 },
                new SessionEvent { UserId = "UserB", Type = SessionEventType.Start, Time = 15 },
                new SessionEvent { UserId = "UserB", Type = SessionEventType.End, Time = 30 }
            };

            Dictionary<string, int> result = CalculateSessionTime(events);

            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} minutes");
            }
        }

        static Dictionary<string, int> CalculateSessionTime(List<SessionEvent> events)
        {
            // TODO:
            // - Track active sessions per user
            // - Handle invalid start/end sequences
            // - Accumulate only valid session durations
            // - Ensure all users appear in the output

            return new Dictionary<string, int>();
        }
    }
}