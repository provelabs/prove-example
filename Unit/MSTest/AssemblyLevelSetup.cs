using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prove.Example.Unit.MSTest
{
    [TestClass]
    public class AssemblyLevelSetup
    {
        [AssemblyInitialize]
        public static void Init(TestContext context)
        {
            Initialised = true;
        }

        public static bool Initialised { get; protected set; }
    }
}