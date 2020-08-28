using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Models.Response
{
    public abstract class BaseResponseModel
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
