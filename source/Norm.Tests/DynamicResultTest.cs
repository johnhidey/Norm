using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for DynamicResultTest and is intended
    ///to contain all DynamicResultTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DynamicResultTest
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
        ///A test for DynamicResult Constructor
        ///</summary>
        [TestMethod()]
        public void DynamicResultConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            DynamicResult target = new DynamicResult(name, type, value);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        public void GetValueTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            DynamicResult target = new DynamicResult(name, type, value); // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            DynamicResult target = new DynamicResult(name, type, value); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Type
        ///</summary>
        [TestMethod()]
        public void TypeTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            DynamicResult target = new DynamicResult(name, type, value); // TODO: Initialize to an appropriate value
            Type actual;
            actual = target.Type;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            DynamicResult target = new DynamicResult(name, type, value); // TODO: Initialize to an appropriate value
            object actual;
            actual = target.Value;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
