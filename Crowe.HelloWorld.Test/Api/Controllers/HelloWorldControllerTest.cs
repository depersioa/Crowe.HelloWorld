using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Crowe.HelloWorld.Api.Controllers;
using Crowe.HelloWorld.Writers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crowe.HelloWorld.Test.Api.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        private IWriter _writer;

        [TestInitialize]
        public void Initialize()
        {
            _writer = new ConsoleWriter();
        }

        [TestMethod]
        public void WriteTest()
        {
            var helloWorldController = new HelloWorldController(_writer);
            var response = helloWorldController.Write();
            var statusCode = ((StatusCodeResult) response).StatusCode;

            Assert.IsTrue(statusCode == 200);
        }
    }
}
