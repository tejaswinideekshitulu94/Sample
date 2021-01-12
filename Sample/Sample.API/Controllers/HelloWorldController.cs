using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private IHelloWorld _helloWorld;
        public HelloWorldController(IHelloWorld helloWorld)
        {
            _helloWorld = helloWorld;
        }
        [HttpGet("helloworld")]
        public async Task<List<string>> HelloWorldAsync()
        {
            return await _helloWorld.TasksAsync();
        }
    }
}
