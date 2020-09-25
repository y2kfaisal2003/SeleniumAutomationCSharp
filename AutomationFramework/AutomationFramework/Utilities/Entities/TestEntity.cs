using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities.DataReader;

namespace AutomationFramework.Utilities.Entities
{
    public class TestEntity: BaseEntity
    {
        [DataNames("Column1")]
        public string Column1 { get; set; }
        [DataNames("Column2")]
        public string Column2 { get; set; }
        [DataNames("Column3")]
        public string Column3 { get; set; }
        [DataNames("Column4")]
        public string Column4 { get; set; }
        [DataNames("Column5")]
        public string Column5 { get; set; }
        [DataNames("Column6")]
        public string Column6 { get; set; }
        [DataNames("Column7")]
        public string Column7 { get; set; }
        [DataNames("Column8")]
        public string Column8 { get; set; }
    }
}
