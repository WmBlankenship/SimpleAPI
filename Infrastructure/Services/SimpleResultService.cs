using SimpleAPI.Core.Interfaces;
using SimpleAPI.Core.Models;
using System;

namespace Infrastructure.Services
{
    public class SimpleResultService : IResultService
    {
        public SimpleResult GetResult(string input = "no input provided")
        {
            var result = new SimpleResult
            {
                Input = input,
                Output = input
            };

            return result;
        }
    }
}
