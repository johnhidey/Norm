using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CECity.Enterprise.Data
{
    public class Parameter : IParameter
    {
        private string _parameterName;
        private object _parameterValue;
        private Type _parameterType;
        private int? _parameterSize;
        private ParameterDirection _direction = ParameterDirection.Input;


        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        public Parameter(string parameterName) : this(parameterName, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="parameterValue">The parameter value.</param>
        public Parameter(string parameterName, object parameterValue)
        {
            if (!parameterName.StartsWith("@"))
                parameterName = "@" + parameterName;

            _parameterName = parameterName;
            _parameterValue = parameterValue;
            _parameterType = parameterValue.GetType();
        }

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        /// <value>
        /// The type of the parameter.
        /// </value>
        public Type ParameterType
        {
            get { return _parameterType; }
        }

        /// <summary>
        /// Gets the size of the parameter.
        /// </summary>
        /// <value>
        /// The size of the parameter.
        /// </value>
        public int? ParameterSize
        {
            get { return _parameterSize; }
        }

        /// <summary>
        /// Gets the parameter value.
        /// </summary>
        public object ParameterValue
        {
            get { return _parameterValue; }
        }

        /// <summary>
        /// Gets the name of the parameter.
        /// </summary>
        /// <value>
        /// The name of the parameter.
        /// </value>
        public string ParameterName
        {
            get { return _parameterName; }
        }

        /// <summary>
        /// Gets the parameter direction.
        /// </summary>
        public ParameterDirection ParameterDirection
        {
            get { return _direction; }
        }

        /// <summary>
        /// Sets the parameter direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        /// <returns></returns>
        public IParameter SetParameterDirection(ParameterDirection direction)
        {
            _direction = direction;
            return this;
        }

        /// <summary>
        /// Sets the size of the parameter.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public IParameter SetParameterSize(int size)
        {
            _parameterSize = size;
            return this;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public IParameter SetValue(object value)
        {
            _parameterValue = value;
            return this;
        }
    }
}
