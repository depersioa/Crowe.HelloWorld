using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Writers
{
    public interface IWriter
    {
        public void Write(string message) { }
    }
}
