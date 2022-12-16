using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    // Adding static keyword to the class Helper enables it to become custom extension method, must be paid with 'this' keyword in the nested method to enable this extension
    // method can be accessed without passing any arguements. Can be accessed by appending it to any string
    public static class Helper
    {
        // Adding this keyword into the method args before type enables this method can be accessesd without args, only applicable for first parameter
        public static string ChangeFirstCharToLowerOrUpper(this string inputStr)
        {
            if (inputStr.Length > 0)
            {
                char[] charArray = inputStr.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                var result = new string(charArray);
                return result;
            }

            return inputStr;
        }

        public static List<int> EvenNumbers(this List<int> inputInts)
        {
            if (inputInts.Count > 0)
            {
                List<int> result = inputInts.Where(x => x % 2 == 0).ToList();
                return result;
            }

            return inputInts;
        }
    }
}
