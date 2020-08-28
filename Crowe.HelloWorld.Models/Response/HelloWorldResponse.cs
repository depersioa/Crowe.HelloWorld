using Crowe.HelloWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Models.Response
{
    public class HelloWorldResponse : BaseResponseModel
    {
        public HelloWorldEntity Data { get; set; }
    }
}
