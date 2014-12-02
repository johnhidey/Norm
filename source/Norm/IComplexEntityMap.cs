using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace CECity.Enterprise.Data
{
    public interface IComplexEntityMap
    {
        object Map(DbDataReader reader);
    }
}
