using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CECity.Enterprise.Data
{
    /// <summary>
    /// Provides a set of extension methods for the IDataRecord class adding
    /// support for calling the Get* methods with a column name as well.
    /// </summary>
    public static class IDataRecordExtensions
    {

        /// <summary>
        /// Gets the value of the specified column as a Boolean.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static bool GetBoolean(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetBoolean(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a byte.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static byte GetByte(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetByte(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Reads a stream of bytes from the specified column, starting at location indicated by <paramref name="dataOffset"/>, into the buffer, starting at the location indicated by <paramref name="bufferOffset"/>.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <param name="dataOffset">The index within the row from which to begin the read operation.</param>
        /// <param name="buffer">The buffer into which to copy the data.</param>
        /// <param name="bufferOffset">The index with the buffer to which the data will be copied.</param>
        /// <param name="length">The maximum number of characters to read.</param>
        /// <returns>The actual number of bytes read.</returns>
        public static long GetBytes(this IDataRecord myIDataRecord, string name, long dataOffset, byte[] buffer, int bufferOffset, int length)
        {
            return myIDataRecord.GetBytes(myIDataRecord.GetOrdinal(name), dataOffset, buffer, bufferOffset, length);
        }

        /// <summary>
        /// Gets the value of the specified column as a single character.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static char GetChar(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetChar(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Reads a stream of characters from the specified column, starting at the location indicated by <paramref name="dataOffset"/>, into the buffer, starting at the location indicated by <paramref name="bufferOffset"/>.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <param name="dataOffset">The index within the row from which to begin the read operation.</param>
        /// <param name="buffer">The buffer into which to copy the data.</param>
        /// <param name="bufferOffset">The index with the buffer to which the data will be copied.</param>
        /// <param name="length">The maximum number of characters to read.</param>
        /// <returns>The actual number of characters read.</returns>
        public static long GetChars(this IDataRecord myIDataRecord, string name, long dataOffset, char[] buffer, int bufferOffset, int length)
        {
            return myIDataRecord.GetChars(myIDataRecord.GetOrdinal(name), dataOffset, buffer, bufferOffset, length);
        }

        /// <summary>
        /// Gets name of the data type of the specified column.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>A string representing the name of the data type.</returns>
        public static string GetDataTypeName(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetDataTypeName(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a <see cref="T:System.DateTime"/> object.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static DateTime GetDateTime(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetDateTime(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a <see cref="T:System.Decimal"/> object.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static decimal GetDecimal(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetDecimal(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a double-precision floating point number.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static double GetDouble(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetDouble(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the data type of the specified column.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The data type of the specified column.</returns>
        public static Type GetFieldType(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetFieldType(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a single-precision floating point number.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static float GetFloat(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetFloat(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a globally-unique identifier (GUID).
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static Guid GetGuid(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetGuid(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a 16-bit signed integer.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static short GetInt16(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetInt16(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a 32-bit signed integer.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static int GetInt32(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetInt32(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as a 64-bit signed integer.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static long GetInt64(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetInt64(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of <see cref="T:System.String"/>.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static string GetString(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetString(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>The value of the specified column.</returns>
        public static object GetValue(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.GetValue(myIDataRecord.GetOrdinal(name));
        }

        /// <summary>
        /// Gets a value that indicates whether the column contains nonexistent or missing values.
        /// </summary>
        /// <param name="myIDataRecord">The IDataRecord to extend.</param>
        /// <param name="name">The name of the column in the result set.</param>
        /// <returns>
        /// true if the specified column is equivalent to <see cref="T:System.DBNull"/>; otherwise false.
        /// </returns>
        public static bool IsDBNull(this IDataRecord myIDataRecord, string name)
        {
            return myIDataRecord.IsDBNull(myIDataRecord.GetOrdinal(name));
        }
    }

}
