using Sample.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.Entities
{
    public class HelloWorldMessage : IHelloWorldMessage
    {
        public string HelloWorld()
        {
            string _helloWorld = "Hello World";
            return _helloWorld;
        }
    }
}
