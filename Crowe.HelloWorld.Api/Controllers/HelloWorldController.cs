using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Crowe.HelloWorld.Writers;
using Microsoft.AspNetCore.Http;
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
        /// Writes hello world to the configured writer
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Write()
        {
            try
            {
                _writer.Write("Hello World");
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
            return Ok();
        }
    }
}
