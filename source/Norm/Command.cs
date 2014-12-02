using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace CECity.Enterprise.Data
{
    public class Command : ICommand
    {
        private IConnection _connection;
        private string _commandText;
        private int? _commandTimeout;
        private CommandType _commandType = System.Data.CommandType.StoredProcedure;
        private IList<IParameter> _parameters = new List<IParameter>();
        private Action<object, Exception> _exceptionCall;
        private DataAccessHelper _dbHelper = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        public Command(IConnection connection)
        {
            _connection = connection;
        }

        private DataAccessHelper GetHelper(ICommand command)
        {
            if (_dbHelper != null) return _dbHelper;

            _dbHelper = new DataAccessHelper(this);

            return _dbHelper;
        }

        /// <summary>
        /// Gets the exception logger.
        /// </summary>
        public Action<object, Exception> ErrorCallback
        {
            get { return _exceptionCall; }
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        public string CommandText
        {
            get { return _commandText; }
        }

        /// <summary>
        /// Gets the command timeout.
        /// </summary>
        public int? CommandTimeout
        {
            get { return _commandTimeout; }
        }

        /// <summary>
        /// Gets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public CommandType CommandType
        {
            get { return _commandType; }
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        public IConnection Connection
        {
            get { return _connection; }
        }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        public IList<IParameter> Parameters
        {
            get { return _parameters; }
        }

        /// <summary>
        /// Sets the error logging.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        public ICommand SetErrorCallback(Action<object, Exception> exception)
        {
            _exceptionCall = exception;
            return this;
        }

        /// <summary>
        /// Sets the command timeout.
        /// </summary>
        /// <param name="commandTimeout">The command timeout.</param>
        /// <returns></returns>
        public ICommand SetCommandTimeout(int commandTimeout)
        {
            _commandTimeout = commandTimeout;
            return this;
        }

        /// <summary>
        /// Sets the command text.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <returns></returns>
        public ICommand SetCommandText(string commandText)
        {
            _commandText = commandText;
            return this;
        }

        /// <summary>
        /// Sets the type of the command.
        /// </summary>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public ICommand SetCommandType(CommandType commandType)
        {
            _commandType = commandType;
            return this;
        }

        /// <summary>
        /// Adds the parameter.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public ICommand AddParameter(string name, object value)
        {
            return AddParameter(name, value, ParameterDirection.Input);
        }

        /// <summary>
        /// Adds the parameter.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="type">The type.</param>
        /// <param name="direction">The direction.</param>
        /// <returns></returns>
        public ICommand AddParameter(string name, object value, ParameterDirection direction)
        {
            _parameters.Add(new Parameter(name, value).SetParameterDirection(direction));
            return this;
        }

        /// <summary>
        /// Adds the parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        public ICommand AddParameter(IParameter parameter)
        {
            _parameters.Add(parameter);
            return this;
        }

        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <returns></returns>
        public IList<IDynamicResult> ExecuteNonQuery()
        {
            return GetHelper(this).ExecuteCommandNonQuery();
        }

        /// <summary>
        /// Executes the scalar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T ExecuteScalar<T>()
        {
            return ExecuteScalar<T>(false).Where(dr => dr.Name == "Scalar").FirstOrDefault().GetValue();
        }

        /// <summary>
        /// Executes the scalar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        public IList<IDynamicResult> ExecuteScalar<T>(bool includeOutputs)
        {
            return GetHelper(this).ExecuteCommandScalar<T>().Where(dr => dr.Name == "Scalar" || includeOutputs).ToList();
        }

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public T Execute<T>(IEntityMap<T> map) where T : class, new()
        {
            return Execute<T>(map, false).Where(dr => dr.Name == "Entity").FirstOrDefault().GetValue();
        }

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public T Execute<T>(IComplexEntityMap<T> map) where T : class, new()
        {
            return Execute<T>(map, false).Where(dr => dr.Name == "Entity").FirstOrDefault().GetValue();
        }

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public T Execute<T>(IEntityCollectionMap<T> map) where T : class, new()
        {
            return Execute<T>(map, false).Where(dr => dr.Name == "Entity").FirstOrDefault().GetValue();
        }

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        public IList<IDynamicResult> Execute<T>(IEntityMap<T> map, bool includeOutputs) where T : class, new()
        {
            return GetHelper(this).ExecuteCommand<T>(map).Where(dr => dr.Name == "Entity" || includeOutputs).ToList();
        }

        /// <summary>
        /// Executes the specified maps.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="maps">The maps.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        public IList<IDynamicResult> Execute(IList<IEntityMap> maps, bool includeOutputs)
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            for (var i = 0; i < maps.Count; i++)
            {
                IList<IDynamicResult> innerResults = GetHelper(this).ExecuteCommand(maps[i]).Where(dr => dr.Name == "Entity" || includeOutputs).ToList();
                IList<IDynamicResult> renamedResults = innerResults.Where(dr => dr.Name == "Entity").Select(e => new DynamicResult(e.Name + i, e.Type, e.GetValue())).ToList<IDynamicResult>();
                foreach (var result in renamedResults)
                {
                    if (!results.Contains(result))
                        results.Add(result);
                }
            }

            return results;
        }

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        public IList<IDynamicResult> Execute<T>(IComplexEntityMap<T> map, bool includeOutputs) where T : class, new()
        {
            return GetHelper(this).ExecuteCommand<T>(map).Where(dr => dr.Name == "Entity" || includeOutputs).ToList();
        }

        /// <summary>
        /// Executes the specified maps.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="maps">The maps.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        public IList<IDynamicResult> Execute(IList<IComplexEntityMap> maps, bool includeOutputs)
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            for (var i = 0; i < maps.Count; i++)
            {
                IList<IDynamicResult> innerResults = GetHelper(this).ExecuteCommand(maps[i]).Where(dr => dr.Name == "Entity" || includeOutputs).ToList();
                IList<IDynamicResult> renamedResults = innerResults.Where(dr => dr.Name == "Entity").Select(e => new DynamicResult(e.Name + i, e.Type, e.GetValue())).ToList<IDynamicResult>();
                foreach (var result in renamedResults)
                {
                    if (!results.Contains(result))
                        results.Add(result);
                }
            }

            return results;
        }

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        public IList<IDynamicResult> Execute<T>(IEntityCollectionMap<T> map, bool includeOutputs) where T : class, new()
        {
            return GetHelper(this).ExecuteCommand<T>(map).Where(dr => dr.Name == "Entity" || includeOutputs).ToList();
        }

        /// <summary>
        /// Executes the specified maps.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="maps">The maps.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        public IList<IDynamicResult> Execute(IList<IEntityCollectionMap> maps, bool includeOutputs)
        {
            IList<IDynamicResult> results = new List<IDynamicResult>();

            for (var i = 0; i < maps.Count; i++)
            {
                IList<IDynamicResult> innerResults = GetHelper(this).ExecuteCommand(maps[i]).Where(dr => dr.Name == "Entity" || includeOutputs).ToList();
                IList<IDynamicResult> renamedResults = innerResults.Where(dr => dr.Name == "Entity").Select(e => new DynamicResult(e.Name + i, e.Type, e.GetValue())).ToList<IDynamicResult>();
                foreach (var result in renamedResults)
                {
                    if (!results.Contains(result))
                        results.Add(result);
                }
            }

            return results;
        }

        [Obsolete("This method has been deprecated, please use one of the Execute<T> methods.")]
        public void Execute(Action<IDataRecord> action)
        {
            Execute(new Action<IDataRecord>[] { action });
        }

        [Obsolete("This method has been deprecated, please use one of the Execute<T> methods.")]
        public void Execute(Action<IDataRecord>[] actions)
        {
            GetHelper(this).ExecuteCommand(actions);
        }

    }
}
