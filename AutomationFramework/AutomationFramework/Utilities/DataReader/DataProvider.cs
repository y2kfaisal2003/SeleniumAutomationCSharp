using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutomationFramework.Utilities.Entities;
using NUnit.Framework;

namespace AutomationFramework.Utilities.DataReader
{
    public class DataProvider
    {
        private static Dictionary<string, TestEntity> megaDistonary = new Dictionary<string, TestEntity>();
        public static IEnumerable TestData(string testCatagory, string testCaseName)
        {
            megaDistonary = new DataAccess().GetExcelData();
            IEnumerable<TestEntity> testEntities = megaDistonary.Where(q => q.Key.Split(';')[0].Equals(testCatagory)
            && q.Key.Split(';')[1].Contains(testCaseName)).Select(q => q.Value).AsEnumerable<TestEntity>();
            string browser = "Chrome";
            string env = "Local";
            foreach (TestEntity testEntity in testEntities)
            {
                yield return new TestCaseData(testEntity).SetName($"[{testEntity.Model}] - [{testEntity.Name}] - {browser} - {env}").SetCategory(testEntity.Model);
            }
        }
    }
}
