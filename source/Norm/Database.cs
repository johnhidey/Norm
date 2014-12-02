using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace CECity.Enterprise.Data
{
    public class Database : IDatabase
    {
        private string _providerName;

        /// <summary>
        /// Prevents a default instance of the <see cref="Database"/> class from being created.
        /// </summary>
        private Database() { }

        /// <summary>
        /// Gets the using.
        /// </summary>
        public static IDatabase Using
        {
            get { return new Database(); }
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        public IConnection Connection
        {
            get { return new Connection(this); }
        }

        /// <summary>
        /// Sets the db provider.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        /// <returns></returns>
        public IDatabase SetDbProvider(string providerName)
        {
            _providerName = providerName;
            return this;
        }

        /// <summary>
        /// Gets the name of the provider.
        /// </summary>
        /// <value>
        /// The name of the provider.
        /// </value>
        public string ProviderName
        {
            get { return _providerName; }
        }

    }
}
