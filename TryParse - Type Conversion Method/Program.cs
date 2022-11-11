using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryParse___Type_Conversion_Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numAsStr = "128";
            int parsedValue;
            bool success = int.TryParse(numAsStr, out parsedValue);

            if (success)
            {
                Console.WriteLine("Parsing successful - number is : {0}", parsedValue);
                Console.WriteLine("parsedValue type is : {0}", parsedValue.GetType());
            } else
            {
                Console.WriteLine("Parsing failed!");
            }

            float parsedValue1;
            bool success1 = float.TryParse(numAsStr, out parsedValue1);

            if (success1)
            {
                Console.WriteLine("Parsing successful - number is : {0}", parsedValue1);
                Console.WriteLine("parsedValue1 type is : {0}", parsedValue1.GetType());
            }
            else
            {
                Console.WriteLine("Parsing failed!");
            }

            double parsedValue2;
            bool success2 = double.TryParse(numAsStr, out parsedValue2);

            if (success)
            {
                Console.WriteLine("Parsing successful - number is : {0}", parsedValue2);
                Console.WriteLine("parsedValue2 type is : {0}", parsedValue2.GetType());
            }
            else
            {
                Console.WriteLine("Parsing failed!");
            }
        }
    }
}
