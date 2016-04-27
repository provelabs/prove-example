using NUnit.Framework;
using Prove.Attributes;
using Prove.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove.Example.Unit.NUnit
{
    [TestFixture]
    public class Base
    {
        [Test]
        public void Passes()
        {
            Assert.IsTrue(true);
        }

        [Test]
        [DebuggerStepThrough]
        public void Fails()
        {
            Assert.Fail("Fails");
        }

        [Test]
        [DebuggerStepThrough]
        public void Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }


}
