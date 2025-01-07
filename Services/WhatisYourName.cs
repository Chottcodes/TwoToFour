using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Services
{
    public class WhatisYourName
    {
       public string WakeUp(string name, int time){
         return $"Your name is {name} you woke up at {time}";
       }
    }
}