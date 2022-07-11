using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_Exercise
{
    internal class Methods
    {
        //Create a method named Add, that accepts two integers and returns the sum of those two integers
        public static int Add(int x, int y)
        { 
          return x + y; 
        }

        //Now create an overload of the Add method to account for being able to add two decimals together
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        //For example:

        //“5 dollars”

        //"1 dollar”

        //“16 dollars”
        public static string Add(decimal x, decimal y, bool checkThis)
        {
            var sum = x + y;

            if (checkThis == true && sum > 1)
            {
                return $"${sum} dollars";
            }
            else if (checkThis == true && sum ==1)
            {
                return $"${sum} dollar";
            }
            else if (checkThis == true && sum < 1)
            {
                return $"${sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }

}
