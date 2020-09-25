using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities.DataReader;

namespace AutomationFramework.Utilities.Entities
{
   public class BaseEntity
    {
        [DataNames("Run")]
        public string Run { get; set; }
        [DataNames("TestCatagory")]
        public string TestCatagory { get; set; }
        [DataNames("TestName")]
        public string TestName { get; set; }
        [DataNames("UserID")]
        public string UserID { get; set; }
        [DataNames("Password")]
        public string Password { get; set; }
        [DataNames("qTestID")]
        public string qTestID { get; set; }
        [DataNames("TFSID")]
        public string TFSID { get; set; }
        [DataNames("Browser")]
        public string Browser { get; set; }

        public TestEntity clone()
        {
            return (TestEntity)this.MemberwiseClone();
        }

        public void AddColumns()
        {

        }
        public void RemoveColumns()
        {

        }
    }
}
