using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Models.Response
{
    /// <summary>
    /// Contains properties that we want to include on all API response objects
    /// </summary>
    public abstract class BaseResponseModel
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
