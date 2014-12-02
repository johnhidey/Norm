using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace CECity.Enterprise.Data
{
    public sealed class DataTableMapper : IEntityMap<DataTable>
    {
        public DataTable Map(DbDataReader reader)
        {
            DataTable table = new DataTable();
            for (int index = 0; index < reader.FieldCount; index++)
            {
                DataColumn column = new DataColumn(reader.GetName(index), reader.GetFieldType(index));
                if (table.Columns.Contains(reader.GetName(index)))
                    continue;

                table.Columns.Add(column);
            }

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int index = 0; index < reader.FieldCount; index++)
                {
                    row[reader.GetName(index)] = reader[reader.GetName(index)];
                }

                table.Rows.Add(row);
            }

            return table;
        }

    }
}
