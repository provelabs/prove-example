using Prove.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove.Example.Load
{
    public class Authentication
    {
        [ActorAction(IsAuthenticationAction = true, OutState = "Portal")]
        [ReturnValueName("sessionId")]
        public Guid Login()
        {
            return Guid.NewGuid();
        }
    }
}
