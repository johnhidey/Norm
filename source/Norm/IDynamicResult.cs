using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CECity.Enterprise.Data
{
    public interface IDynamicResult
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T">The type of the ype.</typeparam>
        /// <returns></returns>
        dynamic GetValue();
    }
}
