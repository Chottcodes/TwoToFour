using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Services
{
    public class AddingServices
    {
        public string Add(int num1, int num2)
        {
            int sum = num1 + num2;
            string result = $"The sum of {num1} plus {num2} is {sum}";
            return result;
        }

    }
}