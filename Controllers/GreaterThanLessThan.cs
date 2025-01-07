
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
        public string NumbersCompare(int number1, int number2)
        {
            string result = _greaterThanServices.NumbersCompare(number1, number2);
            return result;
        }
    }
}