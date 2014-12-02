using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Collections.Generic;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for ListMapperTest and is intended
    ///to contain all ListMapperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ListMapperTest
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
        ///A test for ListMapper`1 Constructor
        ///</summary>
        public void ListMapperConstructorTestHelper<T>()
            where T : class , new()
        {
            IEntityMap<T> typeMapping = null; // TODO: Initialize to an appropriate value
            ListMapper<T> target = new ListMapper<T>(typeMapping);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ListMapperConstructorTest()
        {
            ListMapperConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CECity.Enterprise.Data.IEntityCollectionMap.Map
        ///</summary>
        public void MapTestHelper<T>()
            where T : class , new()
        {
            IEntityMap<T> typeMapping = null; // TODO: Initialize to an appropriate value
            IEntityCollectionMap target = new ListMapper<T>(typeMapping); // TODO: Initialize to an appropriate value
            IDataRecord[] records = null; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.Map(records);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void MapTest()
        {
            MapTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Map
        ///</summary>
        public void MapTest1Helper<T>()
            where T : class , new()
        {
            IEntityMap<T> typeMapping = null; // TODO: Initialize to an appropriate value
            ListMapper<T> target = new ListMapper<T>(typeMapping); // TODO: Initialize to an appropriate value
            IDataRecord[] records = null; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.Map(records);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MapTest1()
        {
            MapTest1Helper<GenericParameterHelper>();
        }
    }
}
