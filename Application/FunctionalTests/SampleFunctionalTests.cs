using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballApi.FunctionalTests
{
    [TestClass]
    public class SampleFunctionalTests
    {
        private static TestContext _testContext;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestClean()
        {
        }
        
        [TestMethod]
        public void CanFetchAnything()
        {
        }
    }
}