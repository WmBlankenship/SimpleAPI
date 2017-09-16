using SimpleAPI.Core.Interfaces;
using SimpleAPI.Core.Models;
using System;

namespace Infrastructure.Services
{
    public class ReverseResultService : IResultService
    {
        public SimpleResult GetResult(string input)
        {
            var result = new SimpleResult
            {
                Input = input,
                Output = ReverseString(input)
            };

            return result;
        }

        private string ReverseString(string input)
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
