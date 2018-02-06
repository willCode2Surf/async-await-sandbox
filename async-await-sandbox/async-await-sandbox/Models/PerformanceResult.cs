using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace async_await_sandbox.Models
{
    public class PerformanceResult
    {
        public string URL { get; set; }
        public bool OK { get; set; }
        public string LoadTime { get; set; }
    }
}