using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CECity.Enterprise.Data
{
    public interface IEntityCollectionMap<T> : IEntityCollectionMap where T : class, new()
    {
        new T Map(IDataRecord[] records);
    }
}
