using System;
using System.Collections.Generic;
using System.Linq;

namespace AIvsHuman_CSharp
{
    static class Advanced
    {
        public static void Run()
        {
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, ProcessingTime = 30, Priority = 2 },
                new Order { OrderId = 2, ProcessingTime = 15, Priority = 1 },
                new Order { OrderId = 3, ProcessingTime = 45, Priority = 2 },
                new Order { OrderId = 4, ProcessingTime = 20, Priority = 1 }
            };

            List<int> schedule = ScheduleOrders(orders);

            Console.WriteLine("Scheduled Order IDs:");
            foreach (int id in schedule)
            {
                Console.WriteLine(id);
            }
        }

        /// <summary>
        /// Orders must be scheduled by:
        /// 1. Higher priority first (1 = highest)
        /// 2. Shorter processing time first if priorities are equal
        /// </summary>
        static List<int> ScheduleOrders(List<Order> orders)
        {
            // TODO:
            // Implement scheduling logic here

            return new List<int>();
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int ProcessingTime { get; set; }
        public int Priority { get; set; }
    }
}
