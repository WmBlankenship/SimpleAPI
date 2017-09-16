using SimpleAPI.Core.Interfaces;
using SimpleAPI.Core.Models;
using System;

namespace Infrastructure.Services
{
    public class ReverseResultService : IResultService
    {
        public SimpleResult GetResult(string input)
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            var reverse = chars.ToString();

            var result = new SimpleResult
            {
                Input = input,
                Output = reverse
            };

            return result;
        }
    }
}
