using Microsoft.AspNetCore.Mvc;
using System;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    public class SimpleController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var timestamp = DateTimeOffset.UtcNow;

            return $"This API was accessed at {timestamp}";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }
    }
}
