using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CECity.Enterprise.Data
{
    public interface IParameter
    {
        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        /// <value>
        /// The type of the parameter.
        /// </value>
        Type ParameterType { get; }

        /// <summary>
        /// Gets the size of the parameter.
        /// </summary>
        /// <value>
        /// The size of the parameter.
        /// </value>
        int? ParameterSize { get; }

        /// <summary>
        /// Gets the parameter value.
        /// </summary>
        object ParameterValue { get; }

        /// <summary>
        /// Gets the name of the parameter.
        /// </summary>
        /// <value>
        /// The name of the parameter.
        /// </value>
        string ParameterName { get; }

        /// <summary>
        /// Gets the parameter direction.
        /// </summary>
        ParameterDirection ParameterDirection { get; }

        /// <summary>
        /// Sets the parameter direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        /// <returns></returns>
        IParameter SetParameterDirection(ParameterDirection direction);

        /// <summary>
        /// Sets the size of the parameter.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        IParameter SetParameterSize(int size);

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        IParameter SetValue(object value);
    }
}
