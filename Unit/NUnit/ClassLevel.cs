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
    [Requirement("Req-9")]
    public class ClassLevel
    {
        protected static bool _initialized = false;

        [OneTimeSetUp]
        public static void Init()
        {
            _initialized = true;
        }

        [Test]
        public void Class_Initialized_Called()
        {
            Assert.IsTrue(_initialized);
        }
    }
}
