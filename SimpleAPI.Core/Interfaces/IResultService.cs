using SimpleAPI.Core.Models;

namespace SimpleAPI.Core.Interfaces
{
    public interface IResultService
    {
        SimpleResult GetResult(string input = "no input provided");
    }
}
