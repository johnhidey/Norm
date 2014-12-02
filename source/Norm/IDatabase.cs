using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CECity.Enterprise.Data
{
    public interface IDatabase
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        IConnection Connection { get; }

        /// <summary>
        /// Sets the db provider.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        /// <returns></returns>
        IDatabase SetDbProvider(string providerName);

        /// <summary>
        /// Gets the name of the provider.
        /// </summary>
        /// <value>
        /// The name of the provider.
        /// </value>
        string ProviderName { get; }

    }
}
