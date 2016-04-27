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
    public class WorkToDo
    {
        [ActorAction(Profiles = new[] { Actors.WORKER }, InStates = new[] { "WorkToDo" }, OutState = "WorkItemQueued")]
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

        [ActorAction(Profiles = new[] { Actors.WORKER }, InStates = new[] { "WorkItemQueued" }, OutState = "WorkToDo")]
        [PerformanceRequirement(180)]
        [Card("9", Enums.CardType.Story)]
        public void Do_Some_Work(WorkItem nextWorkItem)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var sleep = rand.Next(0, 200);
            Task.Delay(sleep).Wait();

            nextWorkItem.Completed = true;
        }

        [ActorAction(Profiles = new[] { Actors.WORKER }, InStates = new[] { "WorkItemQueued" }, OutState = "WorkItemQueued")]
        public void Procrastinate(WorkItem nextWorkItem)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var sleep = rand.Next(0, 400);
            Task.Delay(sleep).Wait();
        }

        [ActorAction(Profiles = new[] { Actors.WORKER }, InStates = new[] { "WorkItemQueued" }, OutState = "WorkItemQueued")]
        public void Go_Get_Coffee(WorkItem nextWorkItem)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var sleep = rand.Next(0, 600);
            Task.Delay(sleep).Wait();
        }
    }
}
