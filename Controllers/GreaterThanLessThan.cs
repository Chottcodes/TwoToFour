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
    public class GreaterThanLessThan : Controller
    {
      private readonly GreaterThanServices _greaterThanServices;

        
        public GreaterThanLessThan(GreaterThanServices greaterThanServices)
        {
            _greaterThanServices = greaterThanServices;
        }

       
        [HttpGet]
        [Route("Comparing/{number1}/{number2}")]
        public IActionResult NumbersCompare(int number1, int number2)
        {
           
            string result = _greaterThanServices.NumbersCompare(number1, number2);

           
            return Ok(result);
        }
    }
}