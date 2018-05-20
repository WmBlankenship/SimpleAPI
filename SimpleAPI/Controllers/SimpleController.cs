using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
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

            return result.Output;
        }

        // GET api/values/input
        [HttpGet("{input}")]
        public IActionResult Get(string input)
        {
            var result = _resultService.GetResult(input);
            var output = $"<html><body><strong>{result.Output}</strong></body></html>";
            return Content(output, new MediaTypeHeaderValue("text/html"));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }
    }
}
