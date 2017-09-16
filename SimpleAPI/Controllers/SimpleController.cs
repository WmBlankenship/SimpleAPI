using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Core.Interfaces;
using System;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    public class SimpleController : Controller
    {
        private readonly IResultService _resultService;

        public SimpleController(IResultService resultService)
        {
            _resultService = resultService;
        }
        
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var result = _resultService.GetResult();

            return result.ToString();
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
