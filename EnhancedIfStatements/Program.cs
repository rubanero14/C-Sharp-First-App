using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnhancedIfStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // condition ? first-expression : second_expression;
            // condition has to be either true or false
            // The ternary operator is right - associative
            // The expression a ? b : c ? d : e;
            // Is evaluated as a ? b : (c ? d : e);
            // not as (a ? b ; c) ? d : e;
            // The ternary operator cannot be overloaded

            // CHALLENGE: add gas state of water

            // temp in celcius
            int temp = 80;
            string stateOfWater;

            if (temp <= 0)
            {
                stateOfWater = "solid";
            }
            else if (temp >= 100)
            {
                stateOfWater = "gas";
            }
            else
            {
                stateOfWater = "liquid";
            }
            Console.WriteLine("State of water is {0}", stateOfWater);

            // Convert if statement above to nested ternary operator
            temp += 30;
            stateOfWater = temp < 0 ? "solid" : ( temp > 100 ? "gas" : "liquid" );
            Console.WriteLine("State of water is {0}", stateOfWater);

            Console.ReadKey();
        }
    }
}
