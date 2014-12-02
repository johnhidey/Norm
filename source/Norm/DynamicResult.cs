using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CECity.Enterprise.Data
{
    public class DynamicResult : IDynamicResult
    {
        private Type _type;
        private string _name;
        private object _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicResult"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="value">The value.</param>
        internal DynamicResult(string name, Type type, object value)
        {
            _type = type;
            _value = value;
            _name = name;
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public Type Type
        {
            get { return _type; }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        internal object Value
        {
            get { return _value; }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="Type">The type of the Type.</typeparam>
        /// <returns></returns>
        public dynamic GetValue()
        {
            dynamic result = Convert.ChangeType(_value, this.Type);

            return result;
        }
    }
}
