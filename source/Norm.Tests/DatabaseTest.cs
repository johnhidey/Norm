using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for DatabaseTest and is intended
    ///to contain all DatabaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DatabaseTest
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
        ///A test for Database Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Norm.dll")]
        public void DatabaseConstructorTest()
        {
            Database_Accessor target = new Database_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SetDbProvider
        ///</summary>
        [TestMethod()]
        public void SetDbProviderTest()
        {
            Database_Accessor target = new Database_Accessor(); // TODO: Initialize to an appropriate value
            string providerName = string.Empty; // TODO: Initialize to an appropriate value
            IDatabase expected = null; // TODO: Initialize to an appropriate value
            IDatabase actual;
            actual = target.SetDbProvider(providerName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Connection
        ///</summary>
        [TestMethod()]
        public void ConnectionTest()
        {
            Database_Accessor target = new Database_Accessor(); // TODO: Initialize to an appropriate value
            IConnection actual;
            actual = target.Connection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProviderName
        ///</summary>
        [TestMethod()]
        public void ProviderNameTest()
        {
            Database_Accessor target = new Database_Accessor(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ProviderName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Using
        ///</summary>
        [TestMethod()]
        public void UsingTest()
        {
            IDatabase actual;
            actual = Database.Using;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
