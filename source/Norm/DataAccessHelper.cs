using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Collections;

namespace CECity.Enterprise.Data
{
    internal class DataAccessHelper
    {
        private DbCommand _localCommand;
        private ICommand _command;

        public DataAccessHelper(ICommand command)
        {
            _command = command;
            _localCommand = CreateCommand();
        }

        /// <summary>
        /// Executes the command no query.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public IList<IDynamicResult> ExecuteCommandNonQuery()
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            ExecuteNonQuery();
            results = GetOutputParameters();

            return results;
        }

        /// <summary>
        /// Executes the command scalar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public IList<IDynamicResult> ExecuteCommandScalar<T>()
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            object result = ExecuteScalar();
            IDynamicResult scalar = new DynamicResult("Scalar", typeof(T), result);
            results = GetOutputParameters();
            results.Add(scalar);

            return results;
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="actions">The actions.</param>
        public IList<IDynamicResult> ExecuteCommand<T>(IEntityMap<T> map) where T : class, new()
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            using (var reader = ExecuteReader())
            {
                var record = reader.Cast<DbDataRecord>().AsEnumerable().FirstOrDefault();
                var result = new DynamicResult("Entity", typeof(T), map.Map(record));
                results = GetOutputParameters();
                results.Add(result);
            }

            return results;
        }

        public IList<IDynamicResult> ExecuteCommand<T>(IComplexEntityMap<T> map) where T : class, new()
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            using (var reader = ExecuteReader())
            {
                var result = new DynamicResult("Entity", typeof(T), map.Map(reader));
                results = GetOutputParameters();
                results.Add(result);
            }

            return results;
        }

        public IList<IDynamicResult> ExecuteCommand<T>(IEntityCollectionMap<T> map) where T : class, new()
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            using (var reader = ExecuteReader())
            {
                var records = reader.Cast<DbDataRecord>().AsEnumerable().ToArray();
                var result = new DynamicResult("Entity", typeof(T), map.Map(records));
                results = GetOutputParameters();
                results.Add(result);

            }

            return results;
        }

        public IList<IDynamicResult> ExecuteCommand(IEntityMap map)
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            using (var reader = ExecuteReader())
            {
                var record = reader.Cast<DbDataRecord>().AsEnumerable().FirstOrDefault();
                var entity = map.Map(record);
                var result = new DynamicResult("Entity", entity.GetType(), entity);
                results = GetOutputParameters();
                results.Add(result);
            }

            return results;
        }

        public IList<IDynamicResult> ExecuteCommand(IEntityCollectionMap map)
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            using (var reader = ExecuteReader())
            {
                var records = reader.Cast<DbDataRecord>().AsEnumerable().ToArray();
                var entity = map.Map(records);
                var result = new DynamicResult("Entity", entity.GetType(), entity);
                results = GetOutputParameters();
                results.Add(result);

            }

            return results;
        }

        public IList<IDynamicResult> ExecuteCommand(IComplexEntityMap map)
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            using (var reader = ExecuteReader())
            {
                var entity = map.Map(reader);
                var result = new DynamicResult("Entity", entity.GetType(), entity);
                results = GetOutputParameters();
                results.Add(result);
            }

            return results;

        }

        /// <summary>
        /// Opens the command.
        /// </summary>
        private void OpenCommand()
        {
            try { _localCommand.Connection.Open(); }
            catch (Exception e)
            {
                if (_command.Connection.ErrorCallback != null)
                {
                    _command.Connection.ErrorCallback(_command, e);
                }
            }
        }

        /// <summary>
        /// Closes the command.
        /// </summary>
        private void CloseCommand()
        {
            if (_localCommand.Connection.State == ConnectionState.Open)
                _localCommand.Connection.Close();
        }

        /// <summary>
        /// Executes the reader.
        /// </summary>
        /// <returns></returns>
        private DbDataReader ExecuteReader()
        {
            DbDataReader reader = null;

            OpenCommand();
            try
            {
                reader = _localCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                if (_command.ErrorCallback != null)
                {
                    _command.ErrorCallback(_command, e);
                }
            }

            return reader;
        }

        private object ExecuteScalar()
        {
            object returnValue = null;

            OpenCommand();
            try
            {
                returnValue = _localCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                if (_command.ErrorCallback != null)
                {
                    _command.ErrorCallback(_command, e);
                }
            }
            finally { CloseCommand(); }


            return returnValue;
        }

        /// <summary>
        /// Executes the non query.
        /// </summary>
        private void ExecuteNonQuery()
        {
            OpenCommand();
            try
            {
                _localCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (_command.ErrorCallback != null)
                {
                    _command.ErrorCallback(_command, e);
                }
            }
            finally { CloseCommand(); }
        }

        [Obsolete("This method has been deprecated, please use one of the Execute<T> methods.")]
        public IList<IDynamicResult> ExecuteCommand(Action<IDataRecord>[] actions)
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            try { _localCommand.Connection.Open(); }
            catch (Exception e)
            {
                if (_command.Connection.ErrorCallback != null)
                {
                    _command.Connection.ErrorCallback(_command, e);
                }
            }
            try
            {
                var reader = _localCommand.ExecuteReader();

                foreach (var action in actions)
                {
                    var records = reader.Cast<DbDataRecord>().AsEnumerable().ToArray();
                    foreach (var record in records)
                        action(record);

                    reader.NextResult();
                }
            }
            catch (Exception e)
            {
                if (_command.ErrorCallback != null)
                {
                    _command.ErrorCallback(_command, e);
                }
            }
            finally
            {
                if (_localCommand.Connection.State == ConnectionState.Open)
                    _localCommand.Connection.Close();
            }

            return results;
        }

        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        private DbCommand CreateCommand()
        {
            string dbProvider = _command.Connection.Database.ProviderName;
            if (!string.IsNullOrEmpty(_command.Connection.ConnectionStringSettings.ProviderName))
                dbProvider = _command.Connection.ConnectionStringSettings.ProviderName;

            DbProviderFactory factory = DbProviderFactories.GetFactory(dbProvider);
            var localConnection = factory.CreateConnection();

            //if (Connection.Timeout.HasValue)
            //    connection.ConnectionTimeout = Connection.Timeout.Value;
            localConnection.ConnectionString = _command.Connection.ConnectionStringSettings.ConnectionString;

            var localCommand = factory.CreateCommand();

            if (_command.CommandTimeout.HasValue)
                localCommand.CommandTimeout = _command.CommandTimeout.Value;

            localCommand.CommandType = _command.CommandType;
            localCommand.CommandText = _command.CommandText;
            localCommand.Connection = localConnection;

            foreach (var parameter in _command.Parameters)
            {
                var newParameter = factory.CreateParameter();
                newParameter.ParameterName = parameter.ParameterName;
                newParameter.Direction = parameter.ParameterDirection;
                if (parameter.ParameterType != null) newParameter.DbType = DbTypeConvertor.ToDbType(parameter.ParameterType);
                if (parameter.ParameterType != null) newParameter.Value = parameter.ParameterValue == null ? DBNull.Value : parameter.ParameterValue;

                if (parameter.ParameterSize.HasValue)
                    newParameter.Size = parameter.ParameterSize.Value;

                localCommand.Parameters.Add(newParameter);
            }

            return localCommand;

        }

        private IList<IDynamicResult> GetOutputParameters()
        {
            var outputParameters = new List<IDynamicResult>();
            foreach (DbParameter p in _localCommand.Parameters)
            {
                if (p.Direction != ParameterDirection.Input)
                {
                    IDynamicResult op = new DynamicResult(p.ParameterName, DbTypeConvertor.ToNetType(p.DbType), p.Value);
                    outputParameters.Add(op);
                }
            }

            return outputParameters;
        }

    }
}
