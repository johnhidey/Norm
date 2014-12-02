using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Data;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for DataAccessHelperTest and is intended
    ///to contain all DataAccessHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataAccessHelperTest
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
        ///A test for DataAccessHelper Constructor
        ///</summary>
        [TestMethod()]
        public void DataAccessHelperConstructorTest()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CloseCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void CloseCommandTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataAccessHelper_Accessor target = new DataAccessHelper_Accessor(param0); // TODO: Initialize to an appropriate value
            target.CloseCommand();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void CreateCommandTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataAccessHelper_Accessor target = new DataAccessHelper_Accessor(param0); // TODO: Initialize to an appropriate value
            DbCommand expected = null; // TODO: Initialize to an appropriate value
            DbCommand actual;
            actual = target.CreateCommand();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        [TestMethod()]
        public void ExecuteCommandTest()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IEntityCollectionMap map = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommand(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        [TestMethod()]
        public void ExecuteCommandTest1()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IComplexEntityMap map = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommand(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        [TestMethod()]
        public void ExecuteCommandTest2()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            Action<IDataRecord>[] actions = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommand(actions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        [TestMethod()]
        public void ExecuteCommandTest3()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IEntityMap map = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommand(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        public void ExecuteCommandTest4Helper<T>()
            where T : class , new()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IEntityMap<T> map = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommand<T>(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteCommandTest4()
        {
            ExecuteCommandTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        public void ExecuteCommandTest5Helper<T>()
            where T : class , new()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IComplexEntityMap<T> map = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommand<T>(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteCommandTest5()
        {
            ExecuteCommandTest5Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExecuteCommand
        ///</summary>
        public void ExecuteCommandTest6Helper<T>()
            where T : class , new()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IEntityCollectionMap<T> map = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommand<T>(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteCommandTest6()
        {
            ExecuteCommandTest6Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExecuteCommandNonQuery
        ///</summary>
        [TestMethod()]
        public void ExecuteCommandNonQueryTest()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommandNonQuery();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteCommandScalar
        ///</summary>
        public void ExecuteCommandScalarTestHelper<T>()
        {
            ICommand command = null; // TODO: Initialize to an appropriate value
            DataAccessHelper target = new DataAccessHelper(command); // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteCommandScalar<T>();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteCommandScalarTest()
        {
            ExecuteCommandScalarTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExecuteNonQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void ExecuteNonQueryTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataAccessHelper_Accessor target = new DataAccessHelper_Accessor(param0); // TODO: Initialize to an appropriate value
            target.ExecuteNonQuery();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExecuteReader
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void ExecuteReaderTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataAccessHelper_Accessor target = new DataAccessHelper_Accessor(param0); // TODO: Initialize to an appropriate value
            DbDataReader expected = null; // TODO: Initialize to an appropriate value
            DbDataReader actual;
            actual = target.ExecuteReader();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteScalar
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void ExecuteScalarTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataAccessHelper_Accessor target = new DataAccessHelper_Accessor(param0); // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.ExecuteScalar();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetOutputParameters
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void GetOutputParametersTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataAccessHelper_Accessor target = new DataAccessHelper_Accessor(param0); // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.GetOutputParameters();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OpenCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Dorm.dll")]
        public void OpenCommandTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DataAccessHelper_Accessor target = new DataAccessHelper_Accessor(param0); // TODO: Initialize to an appropriate value
            target.OpenCommand();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
