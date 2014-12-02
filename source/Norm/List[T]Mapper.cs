using System.Data;
using System.Collections.Generic;

namespace CECity.Enterprise.Data
{
    public sealed class ListMapper<T> : IEntityCollectionMap<List<T>> where T : class, new()
    {
        IEntityMap<T> _typeMapping;

        public ListMapper(IEntityMap<T> typeMapping)
        {
            _typeMapping = typeMapping;
        }

        public List<T> Map(IDataRecord[] records)
        {
            List<T> list = new List<T>();

            foreach (var record in records)
            {
                list.Add(_typeMapping.Map(record));
            }

            return list;
        }

        object IEntityCollectionMap.Map(IDataRecord[] records)
        {
            return Map(records);
        }
    }
}
