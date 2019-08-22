using System.Collections.Generic;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly TestService testService;
        public ValuesController()
        {
            this.testService = new TestService();
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody] LoginModel value)
        {
            var shit = value.password;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("ValueFromData")]
        public ActionResult<string> ValueFromData()
        {
            return this.testService.GetTestTextValue();
        }
    }

    public class LoginModel
    {
        public string username { get; set; }
        public string password { get; set; }

    }
}
