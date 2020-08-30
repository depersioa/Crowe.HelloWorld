using System;
using Crowe.HelloWorld.Writers;
using Microsoft.AspNetCore.Mvc;

namespace Crowe.HelloWorld.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly IWriter _writer;

        public HelloWorldController(IWriter writer)
        {
            _writer = writer;
        }

        /// <summary>
        /// POST: /api/helloworld
        /// Writes hello world to the configured writer
        /// </summary>
        /// <returns>Either an HTTP 200 or 500</returns>
        [HttpPost]
        public ActionResult Write()
        {
            try
            {
                _writer.Write("Hello World");
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
            return Ok();
        }
    }
}
