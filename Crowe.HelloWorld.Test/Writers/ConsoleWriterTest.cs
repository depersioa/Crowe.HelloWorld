using System;
using System.Collections.Generic;
using System.Text;
using Crowe.HelloWorld.Writers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crowe.HelloWorld.Test.Writers
{
    [TestClass]
    public class ConsoleWriterTest
    {
        [TestMethod]
        public void WriteTest()
        {
            //Just make sure we don't throw any exceptions
            try
            {
                var consoleWriter = new ConsoleWriter();
                consoleWriter.Write("Hello World");
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Exception Occurred: {ex.Message}");
            }
        }
    }
}
