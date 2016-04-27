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
    public class TestLevel
    {
        protected bool _initialized = false;

        [TestInitialize]
        public void Init()
        {
            _initialized = true;
        }

        [TestMethod]
        [Card("5", CardType.Story)]
        public void Test_Initialized_Called()
        {
            Assert.IsTrue(_initialized);
        }
    }


}
