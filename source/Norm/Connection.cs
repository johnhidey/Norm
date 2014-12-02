using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CECity.Enterprise.Data
{
    public class Connection : IConnection
    {
        private ConnectionStringSettings _connectionStringSetting;
        private IDatabase _database;
        private Action<object, Exception> _exceptionCall;

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection"/> class.
        /// </summary>
        /// <param name="database">The database.</param>
        internal Connection(IDatabase database)
        {
            _database = database;
        }

        /// <summary>
        /// Gets the exception logger.
        /// </summary>
        public Action<object, Exception> ErrorCallback
        {
            get { return _exceptionCall; }
        }

        /// <summary>
        /// Gets the database.
        /// </summary>
        public IDatabase Database
        {
            get { return _database; }
        }

        /// <summary>
        /// Gets the connection string settings.
        /// </summary>
        public ConnectionStringSettings ConnectionStringSettings
        {
            get { return _connectionStringSetting; }
        }

        /// <summary>
        /// Sets the error logging.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        public IConnection SetErrorCallback(Action<object, Exception> exception)
        {
            _exceptionCall = exception;
            return this;
        }

        /// <summary>
        /// Sets the name of the connection string.
        /// </summary>
        /// <param name="connectionStringName">Name of the connection string.</param>
        /// <returns></returns>
        public IConnection SetConnectionStringName(string connectionStringName)
        {
            _connectionStringSetting = ConfigurationManager.ConnectionStrings[connectionStringName];
            if (_connectionStringSetting == null)
            {
                var cs = ConfigurationManager.AppSettings[connectionStringName];
                _connectionStringSetting = new ConnectionStringSettings(connectionStringName, cs);
            }
            return this;
        }

        /// <summary>
        /// Sets the connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        public IConnection SetConnectionString(string connectionString)
        {
            _connectionStringSetting = new ConnectionStringSettings(connectionString, Database.ProviderName);
            return this;
        }

        /// <summary>
        /// Gets the command.
        /// </summary>
        public ICommand Command
        {
            get { return new Command(this); }
        }
    }
}
