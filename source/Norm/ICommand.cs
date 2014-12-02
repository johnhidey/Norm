using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace CECity.Enterprise.Data
{
    public interface ICommand
    {
        /// <summary>
        /// Gets the error callback.
        /// </summary>
        Action<object, Exception> ErrorCallback { get; }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        string CommandText { get; }

        /// <summary>
        /// Gets the command timeout.
        /// </summary>
        int? CommandTimeout { get; }

        /// <summary>
        /// Gets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        CommandType CommandType { get; }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        IConnection Connection { get; }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        IList<IParameter> Parameters { get; }

        /// <summary>
        /// Sets the error callback.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        ICommand SetErrorCallback(Action<object, Exception> exception);

        /// <summary>
        /// Sets the command timeout.
        /// </summary>
        /// <param name="commandTimeout">The command timeout.</param>
        /// <returns></returns>
        ICommand SetCommandTimeout(int commandTimeout);

        /// <summary>
        /// Sets the command text.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <returns></returns>
        ICommand SetCommandText(string commandText);

        /// <summary>
        /// Sets the type of the command.
        /// </summary>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        ICommand SetCommandType(CommandType commandType);

        /// <summary>
        /// Adds the parameter.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        ICommand AddParameter(string name, object value);

        /// <summary>
        /// Adds the parameter.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="type">The type.</param>
        /// <param name="direction">The direction.</param>
        /// <returns></returns>
        ICommand AddParameter(string name, object value, ParameterDirection direction);

        /// <summary>
        /// Adds the parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        ICommand AddParameter(IParameter parameter);

        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <returns></returns>
        IList<IDynamicResult> ExecuteNonQuery();

        /// <summary>
        /// Executes the scalar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T ExecuteScalar<T>();

        /// <summary>
        /// Executes the scalar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        IList<IDynamicResult> ExecuteScalar<T>(bool includeOutputs);

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        T Execute<T>(IEntityMap<T> map) where T : class, new();

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        T Execute<T>(IComplexEntityMap<T> map) where T : class, new();

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        T Execute<T>(IEntityCollectionMap<T> map) where T : class, new();

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        IList<IDynamicResult> Execute<T>(IEntityMap<T> map, bool includeOutputs) where T : class, new();

        IList<IDynamicResult> Execute(IList<IEntityMap> maps, bool includeOutputs);

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        IList<IDynamicResult> Execute<T>(IComplexEntityMap<T> map, bool includeOutputs) where T : class, new();

        IList<IDynamicResult> Execute(IList<IComplexEntityMap> maps, bool includeOutputs);

        /// <summary>
        /// Executes the specified map.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="map">The map.</param>
        /// <param name="includeOutputs">if set to <c>true</c> [include outputs].</param>
        /// <returns></returns>
        IList<IDynamicResult> Execute<T>(IEntityCollectionMap<T> map, bool includeOutputs) where T : class, new();

        IList<IDynamicResult> Execute(IList<IEntityCollectionMap> maps, bool includeOutputs);

        /// <summary>
        /// Executes the specified action.
        /// </summary>
        /// <param name="action">The action.</param>
        [Obsolete("This method has been deprecated, please use one of the Execute<T> methods.")]
        void Execute(Action<IDataRecord> action);

        /// <summary>
        /// Executes the specified actions.
        /// </summary>
        /// <param name="actions">The actions.</param>
        [Obsolete("This method has been deprecated, please use one of the Execute<T> methods.")]
        void Execute(Action<IDataRecord>[] actions);
    }
}
