using Sample.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure.Repositories
{
    public class HelloWorld : IHelloWorld
    {
        public IHelloWorldMessage _helloWorldMessage;

        public HelloWorld(IHelloWorldMessage helloWorldMessage)
        {
            _helloWorldMessage = helloWorldMessage;
        }

        public async Task<List<string>> TasksAsync()
        {
            List<string> helloWorldMessages = new List<string>();
            Task<List<string>> task = Task<List<string>>.Run(() =>
            {
                int i = 0;
                for (i = 1; i <= 10; i++)
                {
                    string helloWorld = _helloWorldMessage.HelloWorld();
                    helloWorldMessages.Add(helloWorld);
                }
                return helloWorldMessages;
            });
            return await task;
        }
    }
}
