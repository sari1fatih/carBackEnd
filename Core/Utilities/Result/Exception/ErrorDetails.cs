using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public class ErrorDetails
    {
        public string message { get; set; }
        public int statusCode { get; set; }
        public bool success { get; } = false;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
