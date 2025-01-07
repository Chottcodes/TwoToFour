using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TwoToFour.Services;

namespace TwoToFour.Controllers
{
    [Route("[controller]")]
    public class WhatsYourName : Controller
    {
        private readonly WhatisYourName _whatIsYourName;
        public WhatsYourName(WhatisYourName whatisYourName)
        {
            _whatIsYourName = whatisYourName;
        }

        [HttpGet]
        [Route("Name/{name}/{time}")]
        public string WakeUp(string name, int time){
            return _whatIsYourName.WakeUp(name,time);
        }
    }
}