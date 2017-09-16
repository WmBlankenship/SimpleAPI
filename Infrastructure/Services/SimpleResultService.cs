using SimpleAPI.Core.Interfaces;
using SimpleAPI.Core.Models;

namespace SimpleAPIInfrastructure.Services
{
    public class SimpleResultService : IResultService
    {
        public SimpleResult GetResult(string input)
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
