using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using AutomationFramework.Utilities.Entities;

namespace AutomationFramework.Utilities.DataReader
{
    class DataAccess
    {
        /// <summary>
        /// Below Code logic reference:
        /// https://exceptionnotfound.net/mapping-datatables-and-datarows-to-objects-in-csharp-and-net-using-reflection/
        /// </summary>
        /// <param name="args"></param>
        
        public IList<TestEntity> GetExcelData(IList<DataTable> dataTableList)
        {
            IList<TestEntity> entityList = new List<TestEntity>();
            foreach (DataTable dt in dataTableList)
            {
                IList<TestEntity> listEnityt = DataNamesMapper<TestEntity>.Map(dt);
                foreach (TestEntity entity in listEnityt)
                    entityList.Add(entity);
            }
            return entityList;
        }

        public Dictionary<string, TestEntity> GetExcelData()
        {
            IList<DataTable> dataTableList = new DataAccess().ReadExcel("", "");
            IList<TestEntity> megaList = new DataAccess().GetExcelData(dataTableList);
            Dictionary<string, TestEntity> megaDistonary = new Dictionary<string, TestEntity>();
            foreach (TestEntity testEntity in megaList)
            {
                try
                {
                    megaDistonary.Add($"{testEntity.Model};{testEntity.Name}", testEntity);
                }
                catch
                {
                    throw new Exception($"Duplicate values of Test Catagory: {testEntity.Model} and Test Name: {testEntity.Name} available in Test Data Sheet");
                }
               
            }
            return megaDistonary;
        }

        public IList<DataTable> ReadExcel(string fileName, string fileExt)
        {

            fileName = @"C:\Project\CSharp\AutomationFramework\AutomationFramework\AutomationFramework\DataSource\TestData.xlsx";
            string conn = string.Empty;
            string extension = Path.GetExtension(fileName);
            IList<DataTable> dtexcel = new List<DataTable>();
            List<TestEntity> megaList = new List<TestEntity>();
            if (extension.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=YES';"; //for above excel 2007
            using (OleDbConnection excelConnection = new OleDbConnection(conn))
            {
                try
                {
                    excelConnection.Open();
                    DataTable DataSheets = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    foreach (DataRow dataSheet in DataSheets.Rows)
                    {
                        string sheetName = dataSheet["TABLE_NAME"].ToString();
                        if (sheetName.Contains("$"))
                        {
                            //DataTable sheetColumns = excelConnection.GetSchema("Columns", new string[] { null, null, sheetName });
                            string dataQuery = $"select * from [{sheetName}] where Run='Y'";
                            OleDbDataAdapter oleAdpt = new OleDbDataAdapter(dataQuery, excelConnection);
                            DataTable dataTable = new DataTable();
                            oleAdpt.Fill(dataTable);
                           // LoadEntities(coumns, dataSet); needs to implement
                            //megaList.AddRange(excelConnection.Query<TestEntity>(dataQuery).AsList<TestEntity>());
                            dtexcel.Add(dataTable);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
            return dtexcel;
        }
    }
}
