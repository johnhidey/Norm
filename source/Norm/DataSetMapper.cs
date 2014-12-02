using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace CECity.Enterprise.Data
{
    public sealed class DataSetMapper : IComplexEntityMap<DataSet>
    {
        IEntityMap<DataTable> _tableMapping;

        public DataSetMapper(IEntityMap<DataTable> tableMapping)
        {
            _tableMapping = tableMapping;
        }

        public DataSet Map(DbDataReader reader)
        {
            DataSet set = new DataSet();

            while(reader.Read())
            {
                set.Tables.Add(_tableMapping.Map(reader));
            }
            do
            {
            } while (reader.NextResult());

            return set;
        }

    }
}
