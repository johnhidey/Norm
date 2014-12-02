using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for IDataRecordExtensionsTest and is intended
    ///to contain all IDataRecordExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IDataRecordExtensionsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetBoolean
        ///</summary>
        [TestMethod()]
        public void GetBooleanTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = IDataRecordExtensions.GetBoolean(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetByte
        ///</summary>
        [TestMethod()]
        public void GetByteTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            byte expected = 0; // TODO: Initialize to an appropriate value
            byte actual;
            actual = IDataRecordExtensions.GetByte(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetBytes
        ///</summary>
        [TestMethod()]
        public void GetBytesTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            long dataOffset = 0; // TODO: Initialize to an appropriate value
            byte[] buffer = null; // TODO: Initialize to an appropriate value
            int bufferOffset = 0; // TODO: Initialize to an appropriate value
            int length = 0; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = IDataRecordExtensions.GetBytes(myIDataRecord, name, dataOffset, buffer, bufferOffset, length);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetChar
        ///</summary>
        [TestMethod()]
        public void GetCharTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            char expected = '\0'; // TODO: Initialize to an appropriate value
            char actual;
            actual = IDataRecordExtensions.GetChar(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetChars
        ///</summary>
        [TestMethod()]
        public void GetCharsTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            long dataOffset = 0; // TODO: Initialize to an appropriate value
            char[] buffer = null; // TODO: Initialize to an appropriate value
            int bufferOffset = 0; // TODO: Initialize to an appropriate value
            int length = 0; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = IDataRecordExtensions.GetChars(myIDataRecord, name, dataOffset, buffer, bufferOffset, length);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDataTypeName
        ///</summary>
        [TestMethod()]
        public void GetDataTypeNameTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = IDataRecordExtensions.GetDataTypeName(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDateTime
        ///</summary>
        [TestMethod()]
        public void GetDateTimeTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = IDataRecordExtensions.GetDateTime(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDecimal
        ///</summary>
        [TestMethod()]
        public void GetDecimalTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = IDataRecordExtensions.GetDecimal(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDouble
        ///</summary>
        [TestMethod()]
        public void GetDoubleTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = IDataRecordExtensions.GetDouble(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFieldType
        ///</summary>
        [TestMethod()]
        public void GetFieldTypeTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Type expected = null; // TODO: Initialize to an appropriate value
            Type actual;
            actual = IDataRecordExtensions.GetFieldType(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFloat
        ///</summary>
        [TestMethod()]
        public void GetFloatTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = IDataRecordExtensions.GetFloat(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetGuid
        ///</summary>
        [TestMethod()]
        public void GetGuidTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            actual = IDataRecordExtensions.GetGuid(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetInt16
        ///</summary>
        [TestMethod()]
        public void GetInt16Test()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            short expected = 0; // TODO: Initialize to an appropriate value
            short actual;
            actual = IDataRecordExtensions.GetInt16(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetInt32
        ///</summary>
        [TestMethod()]
        public void GetInt32Test()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = IDataRecordExtensions.GetInt32(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetInt64
        ///</summary>
        [TestMethod()]
        public void GetInt64Test()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = IDataRecordExtensions.GetInt64(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetString
        ///</summary>
        [TestMethod()]
        public void GetStringTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = IDataRecordExtensions.GetString(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        public void GetValueTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = IDataRecordExtensions.GetValue(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsDBNull
        ///</summary>
        [TestMethod()]
        public void IsDBNullTest()
        {
            IDataRecord myIDataRecord = null; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = IDataRecordExtensions.IsDBNull(myIDataRecord, name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
