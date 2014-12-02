using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CECity.Enterprise.Data
{
    public interface IEntityMap
    {
        object Map(IDataRecord record);
    }
}
