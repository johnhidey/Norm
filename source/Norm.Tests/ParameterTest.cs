using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for ParameterTest and is intended
    ///to contain all ParameterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ParameterTest
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
        ///A test for Parameter Constructor
        ///</summary>
        [TestMethod()]
        public void ParameterConstructorTest()
        {
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            object parameterValue = null; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName, parameterValue);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Parameter Constructor
        ///</summary>
        [TestMethod()]
        public void ParameterConstructorTest1()
        {
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SetParameterDirection
        ///</summary>
        [TestMethod()]
        public void SetParameterDirectionTest()
        {
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
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
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
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
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
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
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
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
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
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
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
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
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
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
            string parameterName = string.Empty; // TODO: Initialize to an appropriate value
            Parameter target = new Parameter(parameterName); // TODO: Initialize to an appropriate value
            object actual;
            actual = target.ParameterValue;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
