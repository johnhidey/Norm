using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CECity.Enterprise.Data
{
    public interface IConnection
    {
        /// <summary>
        /// Gets the error callback.
        /// </summary>
        Action<object, Exception> ErrorCallback { get; }

        /// <summary>
        /// Gets the database.
        /// </summary>
        IDatabase Database { get; }

        /// <summary>
        /// Gets the connection string settings.
        /// </summary>
        ConnectionStringSettings ConnectionStringSettings { get; }

        /// <summary>
        /// Sets the error callback.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        IConnection SetErrorCallback(Action<object, Exception> exception);

        /// <summary>
        /// Sets the name of the connection string.
        /// </summary>
        /// <param name="connectionStringName">Name of the connection string.</param>
        /// <returns></returns>
        IConnection SetConnectionStringName(string connectionStringName);

        /// <summary>
        /// Sets the connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        IConnection SetConnectionString(string connectionString);

        /// <summary>
        /// Gets the command.
        /// </summary>
        ICommand Command { get; }
    }
}
