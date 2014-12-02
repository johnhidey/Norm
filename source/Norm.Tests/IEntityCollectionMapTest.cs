using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for IEntityCollectionMapTest and is intended
    ///to contain all IEntityCollectionMapTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IEntityCollectionMapTest
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
        ///A test for Map
        ///</summary>
        public void MapTest1Helper<T>()
            where T : class , new()
        {
            IEntityCollectionMap<T> target = CreateIEntityCollectionMap<T>(); // TODO: Initialize to an appropriate value
            IDataRecord[] records = null; // TODO: Initialize to an appropriate value
            T expected = new T(); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.Map(records);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual IEntityCollectionMap<T> CreateIEntityCollectionMap<T>()
            where T : class , new()
        {
            // TODO: Instantiate an appropriate concrete class.
            IEntityCollectionMap<T> target = null;
            return target;
        }

        [TestMethod()]
        public void MapTest1()
        {
            MapTest1Helper<GenericParameterHelper>();
        }

        internal virtual IEntityCollectionMap CreateIEntityCollectionMap()
        {
            // TODO: Instantiate an appropriate concrete class.
            IEntityCollectionMap target = null;
            return target;
        }

        /// <summary>
        ///A test for Map
        ///</summary>
        [TestMethod()]
        public void MapTest()
        {
            IEntityCollectionMap target = CreateIEntityCollectionMap(); // TODO: Initialize to an appropriate value
            IDataRecord[] records = null; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.Map(records);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
