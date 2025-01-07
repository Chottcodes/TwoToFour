using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;

namespace TwoToFour.Services
{
    public class GreaterThanServices
    {
       public string NumbersCompare(int Number1, int Number2)
    {
        if (Number1 < Number2)
        {
            return $"The number {Number1} is Less Than {Number2}, {Number2} is Greater than {Number1}";
        }
        else if (Number1 > Number2)
        {
            return $"The number {Number1} is Greater Than {Number2}, {Number2} is Smaller Than {Number1}";
        }
        else
        {
            return $"The number {Number1} is Equal to {Number2} Both {Number1} and {Number2} are equal";
        }
    }
    }
}