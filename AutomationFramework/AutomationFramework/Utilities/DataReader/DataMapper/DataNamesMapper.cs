using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utilities.DataReader
{
    class DataNamesMapper<T> where T : class, new()
    {
        public T Map(DataRow row)
        {
            //Step 1 - Get the Column Names
            var columnNames = row.Table.Columns
                                       .Cast<DataColumn>()
                                       .Select(x => x.ColumnName)
                                       .ToList();
            //Step 2 - Get the Property Data Names
            var properties = (typeof(T)).GetProperties()
                                              .Where(x => x.GetCustomAttributes(typeof(DataNamesAttribute), true).Any())
                                              .ToList();
            //Step 3 - Map the data
            T entity = new T();
            foreach (var prop in properties)
            {
                PropertyMapHelper.Map(typeof(T), row, prop, entity);
            }
            return entity;
        }

        public static List<T> Map(DataTable table)
        {
            //Step 1 - Get the Column Names
            var columnNames = table.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();

            //Step 2 - Get the Property Data Names
            var properties = (typeof(T)).GetProperties()
                                                .Where(x => x.GetCustomAttributes(typeof(DataNamesAttribute), true).Any())
                                                .ToList();

            //Step 3 - Map the data
            List<T> entities = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                T entity = new T();
                foreach (var prop in properties)
                {
                    PropertyMapHelper.Map(typeof(T), row, prop, entity);
                }
                entities.Add(entity);
            }
            return entities;
        }
    }
}
