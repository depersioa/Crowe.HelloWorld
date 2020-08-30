using System;
using System.Collections.Generic;
using System.Text;

namespace Crowe.HelloWorld.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
