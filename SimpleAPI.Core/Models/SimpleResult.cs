using System;
 
namespace SimpleAPI.Core.Models
{
    public class SimpleResult
    {
        public string Message { get; set; }
        public DateTimeOffset Timestamp { get; set; }

        public override string ToString()
        {
            return $"{Message} {Timestamp}";
        }
    }
}
