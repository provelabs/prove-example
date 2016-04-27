using NUnit.Framework;
using Prove.Attributes;
using Prove.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove.Example.Unit.NUnit
{
    [TestFixture]
    public class TestLevel
    {
        protected bool _initialized = false;

        [SetUp]
        public void Init()
        {
            _initialized = true;
        }

        [Test]
        public void Test_Initialized_Called()
        {
            Assert.IsTrue(_initialized);
        }
    }


}
