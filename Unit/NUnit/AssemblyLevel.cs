using NUnit.Framework;
using Prove.Attributes;
using Prove.Enums;

namespace Prove.Example.Unit.NUnit
{
    [TestFixture]
    public class AssemblyLevel
    {
        [Test]
        public void Assembly_Initialized_Called()
        {
            Assert.IsTrue(AssemblyLevelSetup.Initialised);
        }
    }
}