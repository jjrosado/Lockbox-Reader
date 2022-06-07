using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LRLogic
{
    public static class DataSetConverter
    {
        public static DataSet ToDataSet(this string[] input)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = dataSet.Tables.Add();
            dataTable.Columns.Add();
            Array.ForEach(input, c => dataTable.Rows.Add()[0] = c);
            return dataSet;
        }
    }
}
