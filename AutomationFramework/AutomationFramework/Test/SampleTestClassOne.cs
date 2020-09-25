using AutomationFramework.Utilities.DataReader;
using AutomationFramework.Utilities.Entities;
using NUnit.Framework;
using AutomationFramework.Utilities.Framework;

namespace AutomationFramework.Test
{
    [TestFixture]
    class SampleTestClassOne:TestFactory
    {
        [Test]
        [TestCaseSource(typeof(DataProvider), "TestData", new object[] { "ModelSheet1", "" })]
        public void TestCaseOne(TestEntity testData)
        {
            string strTestModel = testData.Model;
            string strTestName = testData.Name;
            string strTestColumn1 = testData.Column1;
            string strTestColumn2 = testData.Column2;
            string strTestColumn3 = testData.Column3;
            string strTestColumn4 = testData.Column4;
            Assert.AreEqual("ModelSheet1", strTestModel);
        }
    }
}
