using SimpleAPI.Core.Interfaces;
using SimpleAPI.Core.Models;
using System;

namespace Infrastructure.Services
{
    public class SimpleResultService : IResultService
    {
        public SimpleResult GetResult()
        {
            var result = new SimpleResult
            {
                Message = "This result was accessed at ",
                Timestamp = DateTimeOffset.UtcNow
            };

            return result;
        }
    }
}
