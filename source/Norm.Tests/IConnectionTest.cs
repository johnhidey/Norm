using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for IConnectionTest and is intended
    ///to contain all IConnectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IConnectionTest
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


        internal virtual IConnection CreateIConnection()
        {
            // TODO: Instantiate an appropriate concrete class.
            IConnection target = null;
            return target;
        }

        /// <summary>
        ///A test for SetConnectionString
        ///</summary>
        [TestMethod()]
        public void SetConnectionStringTest()
        {
            IConnection target = CreateIConnection(); // TODO: Initialize to an appropriate value
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            IConnection expected = null; // TODO: Initialize to an appropriate value
            IConnection actual;
            actual = target.SetConnectionString(connectionString);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetConnectionStringName
        ///</summary>
        [TestMethod()]
        public void SetConnectionStringNameTest()
        {
            IConnection target = CreateIConnection(); // TODO: Initialize to an appropriate value
            string connectionStringName = string.Empty; // TODO: Initialize to an appropriate value
            IConnection expected = null; // TODO: Initialize to an appropriate value
            IConnection actual;
            actual = target.SetConnectionStringName(connectionStringName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetErrorCallback
        ///</summary>
        [TestMethod()]
        public void SetErrorCallbackTest()
        {
            IConnection target = CreateIConnection(); // TODO: Initialize to an appropriate value
            Action<object, Exception> exception = null; // TODO: Initialize to an appropriate value
            IConnection expected = null; // TODO: Initialize to an appropriate value
            IConnection actual;
            actual = target.SetErrorCallback(exception);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Command
        ///</summary>
        [TestMethod()]
        public void CommandTest()
        {
            IConnection target = CreateIConnection(); // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.Command;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConnectionStringSettings
        ///</summary>
        [TestMethod()]
        public void ConnectionStringSettingsTest()
        {
            IConnection target = CreateIConnection(); // TODO: Initialize to an appropriate value
            ConnectionStringSettings actual;
            actual = target.ConnectionStringSettings;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Database
        ///</summary>
        [TestMethod()]
        public void DatabaseTest()
        {
            IConnection target = CreateIConnection(); // TODO: Initialize to an appropriate value
            IDatabase actual;
            actual = target.Database;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ErrorCallback
        ///</summary>
        [TestMethod()]
        public void ErrorCallbackTest()
        {
            IConnection target = CreateIConnection(); // TODO: Initialize to an appropriate value
            Action<object, Exception> actual;
            actual = target.ErrorCallback;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
