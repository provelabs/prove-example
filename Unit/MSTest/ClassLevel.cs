using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prove.Attributes;
using Prove.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove.Example.Unit.MSTest
{
    [TestClass]
    [Requirement("Req-8")]
    public class ClassLevel
    {
        protected static bool _initialized = false;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _initialized = true;
        }

        [TestMethod]
        [Card("6", CardType.Story)]
        public void Class_Initialized_Called()
        {
            Assert.IsTrue(_initialized);
        }
    }
}
