using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for IParameterTest and is intended
    ///to contain all IParameterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IParameterTest
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


        internal virtual IParameter CreateIParameter()
        {
            // TODO: Instantiate an appropriate concrete class.
            IParameter target = null;
            return target;
        }

        /// <summary>
        ///A test for SetParameterDirection
        ///</summary>
        [TestMethod()]
        public void SetParameterDirectionTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            ParameterDirection direction = new ParameterDirection(); // TODO: Initialize to an appropriate value
            IParameter expected = null; // TODO: Initialize to an appropriate value
            IParameter actual;
            actual = target.SetParameterDirection(direction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetParameterSize
        ///</summary>
        [TestMethod()]
        public void SetParameterSizeTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            int size = 0; // TODO: Initialize to an appropriate value
            IParameter expected = null; // TODO: Initialize to an appropriate value
            IParameter actual;
            actual = target.SetParameterSize(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetValue
        ///</summary>
        [TestMethod()]
        public void SetValueTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            IParameter expected = null; // TODO: Initialize to an appropriate value
            IParameter actual;
            actual = target.SetValue(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParameterDirection
        ///</summary>
        [TestMethod()]
        public void ParameterDirectionTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            ParameterDirection actual;
            actual = target.ParameterDirection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParameterName
        ///</summary>
        [TestMethod()]
        public void ParameterNameTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ParameterName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParameterSize
        ///</summary>
        [TestMethod()]
        public void ParameterSizeTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            actual = target.ParameterSize;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParameterType
        ///</summary>
        [TestMethod()]
        public void ParameterTypeTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            Type actual;
            actual = target.ParameterType;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParameterValue
        ///</summary>
        [TestMethod()]
        public void ParameterValueTest()
        {
            IParameter target = CreateIParameter(); // TODO: Initialize to an appropriate value
            object actual;
            actual = target.ParameterValue;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
