using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CECity.Enterprise.Data
{
    public interface IEntityCollectionMap
    {
        object Map(IDataRecord[] records);
    }
}
