using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MsTestProject
{
    [TestClass] // this is use for test class
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext tc)
        {
            Console.WriteLine("This is Before Class");
        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("This is After Class");
        }


        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This is Before Test");
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This is Aafter Test");
        }

        [TestMethod, TestCategory("SmokeTest")] // this is used to declare method asa test method
        public void TestMethod1()
        {
            Console.WriteLine("This is test Method one");
        }

        [Ignore]
        [TestMethod, TestCategory("SmokeTest")]
        public void TestMethod2()
        {
            Console.WriteLine("This is test Method two");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("This is test Method three");
        }
    }
}
