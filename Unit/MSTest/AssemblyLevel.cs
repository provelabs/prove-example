using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prove.Attributes;
using Prove.Enums;

namespace Prove.Example.Unit.MSTest
{
    [TestClass]
    public class AssemblyLevel
    {
        [TestMethod]
        [Card("7", CardType.Story)]
        public void Assembly_Initialized_Called() 
        {
            Assert.IsTrue(AssemblyLevelSetup.Initialised);
        }
    }
}
