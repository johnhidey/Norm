using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for DbTypeConvertorTest and is intended
    ///to contain all DbTypeConvertorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DbTypeConvertorTest
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
        ///A test for DbTypeConvertor Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void DbTypeConvertorConstructorTest()
        {
            DbTypeConvertor_Accessor target = new DbTypeConvertor_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Find
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void FindTest()
        {
            SqlDbType sqlDbType = new SqlDbType(); // TODO: Initialize to an appropriate value
            DbTypeConvertor_Accessor.DbTypeMapEntry expected = null; // TODO: Initialize to an appropriate value
            DbTypeConvertor_Accessor.DbTypeMapEntry actual;
            actual = DbTypeConvertor_Accessor.Find(sqlDbType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Find
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void FindTest1()
        {
            Type type = null; // TODO: Initialize to an appropriate value
            DbTypeConvertor_Accessor.DbTypeMapEntry expected = null; // TODO: Initialize to an appropriate value
            DbTypeConvertor_Accessor.DbTypeMapEntry actual;
            actual = DbTypeConvertor_Accessor.Find(type);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Find
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void FindTest2()
        {
            DbType dbType = new DbType(); // TODO: Initialize to an appropriate value
            DbTypeConvertor_Accessor.DbTypeMapEntry expected = null; // TODO: Initialize to an appropriate value
            DbTypeConvertor_Accessor.DbTypeMapEntry actual;
            actual = DbTypeConvertor_Accessor.Find(dbType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDbType
        ///</summary>
        [TestMethod()]
        public void ToDbTypeTest()
        {
            SqlDbType sqlDbType = new SqlDbType(); // TODO: Initialize to an appropriate value
            DbType expected = new DbType(); // TODO: Initialize to an appropriate value
            DbType actual;
            actual = DbTypeConvertor.ToDbType(sqlDbType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDbType
        ///</summary>
        [TestMethod()]
        public void ToDbTypeTest1()
        {
            Type type = null; // TODO: Initialize to an appropriate value
            DbType expected = new DbType(); // TODO: Initialize to an appropriate value
            DbType actual;
            actual = DbTypeConvertor.ToDbType(type);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToNetType
        ///</summary>
        [TestMethod()]
        public void ToNetTypeTest()
        {
            DbType dbType = new DbType(); // TODO: Initialize to an appropriate value
            Type expected = null; // TODO: Initialize to an appropriate value
            Type actual;
            actual = DbTypeConvertor.ToNetType(dbType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToNetType
        ///</summary>
        [TestMethod()]
        public void ToNetTypeTest1()
        {
            SqlDbType sqlDbType = new SqlDbType(); // TODO: Initialize to an appropriate value
            Type expected = null; // TODO: Initialize to an appropriate value
            Type actual;
            actual = DbTypeConvertor.ToNetType(sqlDbType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSqlDbType
        ///</summary>
        [TestMethod()]
        public void ToSqlDbTypeTest()
        {
            DbType dbType = new DbType(); // TODO: Initialize to an appropriate value
            SqlDbType expected = new SqlDbType(); // TODO: Initialize to an appropriate value
            SqlDbType actual;
            actual = DbTypeConvertor.ToSqlDbType(dbType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSqlDbType
        ///</summary>
        [TestMethod()]
        public void ToSqlDbTypeTest1()
        {
            Type type = null; // TODO: Initialize to an appropriate value
            SqlDbType expected = new SqlDbType(); // TODO: Initialize to an appropriate value
            SqlDbType actual;
            actual = DbTypeConvertor.ToSqlDbType(type);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
