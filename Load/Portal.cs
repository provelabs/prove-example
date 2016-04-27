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
    public class Portal
    {
        [ActorAction(Profiles = new[] { Actors.WORKER }, InStates = new[] { "Portal" }, OutState = "WorkToDo")]
        [ReturnValueName("Work")]
        public List<WorkItem> Get_WorkItems_For_User(Guid sessionId)
        {
            return WorkItem.GenerateSomeWork(sessionId);
        }

        [ActorAction(Profiles = new[] { Actors.ADMIN }, InStates = new[] { "Portal" })]
        public void Administer_Some_Things(Guid sessionId)
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var sleep = rand.Next(0, 3000);
            Task.Delay(sleep).Wait();
        }
    }
}
