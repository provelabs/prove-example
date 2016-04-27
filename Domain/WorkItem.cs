using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove.Example.Domain
{
    public class WorkItem
    {
        public WorkItem(Guid sessionId)
        {
            var random = new Random(DateTime.Now.Millisecond);

            Id = Guid.NewGuid();
            AnInt = random.Next(0, 1000);
            AssignedSessionId = sessionId;
        }

        public Guid Id { get; protected set; }

        public int AnInt { get; protected set; }

        public bool Completed { get; set; }

        public string Comment { get; set; }

        public Guid AssignedSessionId { get; set; }

        public static List<WorkItem> GenerateSomeWork(Guid sessionId)
        {
            var random = new Random(DateTime.Now.Millisecond);
            var numberOfWorkItems = random.Next(1, 50);
            var workItems = new List<WorkItem>();

            for (var i = 0; i < numberOfWorkItems; i++)
            {
                workItems.Add(new WorkItem(sessionId));
            }

            return workItems;
        }
    }
}
