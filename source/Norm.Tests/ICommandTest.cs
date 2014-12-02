using CECity.Enterprise.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Collections.Generic;

namespace Dorm.Tests
{


    /// <summary>
    ///This is a test class for ICommandTest and is intended
    ///to contain all ICommandTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ICommandTest
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


        internal virtual ICommand CreateICommand()
        {
            // TODO: Instantiate an appropriate concrete class.
            ICommand target = null;
            return target;
        }

        /// <summary>
        ///A test for AddParameter
        ///</summary>
        [TestMethod()]
        public void AddParameterTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IParameter parameter = null; // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.AddParameter(parameter);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddParameter
        ///</summary>
        [TestMethod()]
        public void AddParameterTest1()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.AddParameter(name, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddParameter
        ///</summary>
        [TestMethod()]
        public void AddParameterTest2()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            ParameterDirection direction = new ParameterDirection(); // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.AddParameter(name, value, direction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        public void ExecuteTestHelper<T>()
            where T : class , new()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IComplexEntityMap<T> map = null; // TODO: Initialize to an appropriate value
            bool includeOutputs = false; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.Execute<T>(map, includeOutputs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteTest()
        {
            ExecuteTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest1()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IList<IEntityMap> maps = null; // TODO: Initialize to an appropriate value
            bool includeOutputs = false; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.Execute(maps, includeOutputs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        public void ExecuteTest2Helper<T>()
            where T : class , new()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IEntityCollectionMap<T> map = null; // TODO: Initialize to an appropriate value
            T expected = new T(); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.Execute<T>(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteTest2()
        {
            ExecuteTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        public void ExecuteTest3Helper<T>()
            where T : class , new()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IEntityMap<T> map = null; // TODO: Initialize to an appropriate value
            bool includeOutputs = false; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.Execute<T>(map, includeOutputs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteTest3()
        {
            ExecuteTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        public void ExecuteTest4Helper<T>()
            where T : class , new()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IEntityCollectionMap<T> map = null; // TODO: Initialize to an appropriate value
            bool includeOutputs = false; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.Execute<T>(map, includeOutputs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteTest4()
        {
            ExecuteTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest5()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IList<IEntityCollectionMap> maps = null; // TODO: Initialize to an appropriate value
            bool includeOutputs = false; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.Execute(maps, includeOutputs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest6()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            Action<IDataRecord> action = null; // TODO: Initialize to an appropriate value
            target.Execute(action);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest7()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IList<IComplexEntityMap> maps = null; // TODO: Initialize to an appropriate value
            bool includeOutputs = false; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.Execute(maps, includeOutputs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        public void ExecuteTest8Helper<T>()
            where T : class , new()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IComplexEntityMap<T> map = null; // TODO: Initialize to an appropriate value
            T expected = new T(); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.Execute<T>(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteTest8()
        {
            ExecuteTest8Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        public void ExecuteTest9Helper<T>()
            where T : class , new()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IEntityMap<T> map = null; // TODO: Initialize to an appropriate value
            T expected = new T(); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.Execute<T>(map);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteTest9()
        {
            ExecuteTest9Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest10()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            Action<IDataRecord>[] actions = null; // TODO: Initialize to an appropriate value
            target.Execute(actions);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExecuteNonQuery
        ///</summary>
        [TestMethod()]
        public void ExecuteNonQueryTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteNonQuery();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteScalar
        ///</summary>
        public void ExecuteScalarTestHelper<T>()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            bool includeOutputs = false; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> expected = null; // TODO: Initialize to an appropriate value
            IList<IDynamicResult> actual;
            actual = target.ExecuteScalar<T>(includeOutputs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteScalarTest()
        {
            ExecuteScalarTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExecuteScalar
        ///</summary>
        public void ExecuteScalarTest1Helper<T>()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = target.ExecuteScalar<T>();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExecuteScalarTest1()
        {
            ExecuteScalarTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SetCommandText
        ///</summary>
        [TestMethod()]
        public void SetCommandTextTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            string commandText = string.Empty; // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.SetCommandText(commandText);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetCommandTimeout
        ///</summary>
        [TestMethod()]
        public void SetCommandTimeoutTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            int commandTimeout = 0; // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.SetCommandTimeout(commandTimeout);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetCommandType
        ///</summary>
        [TestMethod()]
        public void SetCommandTypeTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            CommandType commandType = new CommandType(); // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.SetCommandType(commandType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetErrorCallback
        ///</summary>
        [TestMethod()]
        public void SetErrorCallbackTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            Action<object, Exception> exception = null; // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            actual = target.SetErrorCallback(exception);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CommandText
        ///</summary>
        [TestMethod()]
        public void CommandTextTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.CommandText;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CommandTimeout
        ///</summary>
        [TestMethod()]
        public void CommandTimeoutTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            actual = target.CommandTimeout;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CommandType
        ///</summary>
        [TestMethod()]
        public void CommandTypeTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            CommandType actual;
            actual = target.CommandType;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Connection
        ///</summary>
        [TestMethod()]
        public void ConnectionTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IConnection actual;
            actual = target.Connection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ErrorCallback
        ///</summary>
        [TestMethod()]
        public void ErrorCallbackTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            Action<object, Exception> actual;
            actual = target.ErrorCallback;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Parameters
        ///</summary>
        [TestMethod()]
        public void ParametersTest()
        {
            ICommand target = CreateICommand(); // TODO: Initialize to an appropriate value
            IList<IParameter> actual;
            actual = target.Parameters;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
