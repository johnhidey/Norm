using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for DbTypeConvertor_DbTypeMapEntryTest and is intended
    ///to contain all DbTypeConvertor_DbTypeMapEntryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DbTypeConvertor_DbTypeMapEntryTest
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
        ///A test for DbTypeMapEntry Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void DbTypeConvertor_DbTypeMapEntryConstructorTest()
        {
            Type type = null; // TODO: Initialize to an appropriate value
            DbType dbType = new DbType(); // TODO: Initialize to an appropriate value
            SqlDbType sqlDbType = new SqlDbType(); // TODO: Initialize to an appropriate value
            DbTypeConvertor_Accessor.DbTypeMapEntry target = new DbTypeConvertor_Accessor.DbTypeMapEntry(type, dbType, sqlDbType);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
