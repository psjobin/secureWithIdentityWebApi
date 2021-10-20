using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace daAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class aah : ControllerBase
    {
        public string Get()
        {
            return "invalid yo!"
;        }
    }
}
