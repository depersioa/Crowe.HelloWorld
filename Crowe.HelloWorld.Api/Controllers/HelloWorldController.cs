using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Crowe.HelloWorld.Models.Entities;
using Crowe.HelloWorld.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crowe.HelloWorld.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        /// <summary>
        /// Gets hello world
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<HelloWorldResponse> Get()
        {
            Console.WriteLine("Doing stuff");
            var results = new HelloWorldResponse();
            try
            {
                results.Success = true;
                results.Message = "Success";
                results.Data = new HelloWorldEntity()
                {
                    Message = "Hello World"
                };

            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
            return Ok(results);
        }
    }
}
