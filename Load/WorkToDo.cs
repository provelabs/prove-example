using Prove.Attributes;
using Prove.Example.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove.Example.Load
{
    [Default(Profiles = new[] { Actors.WORKER }, Categories = new[] { "Work" })]
    public class WorkToDo
    {
        [ActorAction(InStates = new[] { "WorkToDo" }, OutState = "WorkItemQueued")]
        [ReturnValueName("NextWorkItem")]
        [Card("8", Enums.CardType.Story)]
        public WorkItem Queue_Work_To_Do(Guid sessionId, List<WorkItem> work)
        {
            if(!work.Any(wi => !wi.Completed))
            {
                work.AddRange(WorkItem.GenerateSomeWork(sessionId));
            }

            return work.First(wi => !wi.Completed);
        }

        [ActorAction(InStates = new[] { "WorkItemQueued" }, OutState = "WorkToDo")]
        [PerformanceRequirement(180)]
        [Card("9", Enums.CardType.Story)]
        [Requirement("Req-5")]
        public void Do_Some_Work(WorkItem nextWorkItem)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var sleep = rand.Next(0, 200);
            Task.Delay(sleep).Wait();

            nextWorkItem.Completed = true;
        }

        [ActorAction(InStates = new[] { "WorkItemQueued" }, OutState = "WorkItemQueued")]
        [Category(new[] { "Not Productive" })]
        public void Procrastinate(WorkItem nextWorkItem)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var sleep = rand.Next(0, 400);
            Task.Delay(sleep).Wait();
        }

        [ActorAction(InStates = new[] { "WorkItemQueued" }, OutState = "WorkItemQueued")]
        [Category(new[] { "Not Productive" })]
        public void Go_Get_Coffee(WorkItem nextWorkItem)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var sleep = rand.Next(0, 600);
            Task.Delay(sleep).Wait();
        }
    }
}
