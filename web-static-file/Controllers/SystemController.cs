using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebStaticFile.Controllers
{
    [Route("/api/system")]
    public class SystemController
    {
        private static Dictionary<string, string> _systems = new Dictionary<string, string>()  
        {
            { "Windows", "Windows" },
            { "MacOS", "Darwin" },
            { "Linux", "Linux" }
        };
            
        [HttpGet]
        [Route("version")]
        public IActionResult GetVersion()
        {
            var description = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            var systemBase = _systems.First(x => description.Contains(x.Value)).Key;
            
            var result = new { 
                SystemBase = systemBase,
                Description = description
            };
            
            return new OkObjectResult(result);
        }
    }
}