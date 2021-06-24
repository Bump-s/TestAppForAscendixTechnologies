using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppForAscendixTechnologies;


namespace JsonFunctionalityTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ModulesInvalidJsonTest()
        {
            try
            {
                var modules = new Modules(@"invalid.json");

            }
            catch (System.Exception)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void ModulesValidJsonTest()
        {
            try
            {
                var modules = new Modules();
            }
            catch (System.Exception ex)
            {
                Assert.IsTrue(false);
                return;
            }
            Assert.IsTrue(true);
        }
    }
}
