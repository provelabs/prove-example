using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prove.Attributes;
using Prove.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove.Example.Unit.MSTest
{
    [TestClass]
    public class Base
    {
        [TestMethod]
        [Card("1", CardType.Story)]
        public void MSTest_Pass_Example()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Card("2", CardType.Story)]
        [DebuggerStepThrough]
        [Requirement("Req-3")]

        public void MSTest_Fail_Example()
        {
            Assert.Fail("Fails");
        }

        [TestMethod]
        [Card("3", CardType.Story)]
        [DebuggerStepThrough]

        public void MSTest_Inconclusive_Example()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }


}
