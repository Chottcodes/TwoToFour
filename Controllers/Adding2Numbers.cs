using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TwoToFour.Services;

namespace TwoToFour.Controllers
{
    [Route("[controller]")]
    public class AddingBothNumbers : Controller
    {
        private readonly AddingServices _addingServices;
        public AddingBothNumbers(AddingServices addingServices){
            _addingServices = addingServices;
        }
        [HttpGet]
        [Route("Adding/{num1}/{num2}")]
        public string Add(int num1,int num2){
            string result = _addingServices.Add(num1,num2);
            return result;
        }


    }
}