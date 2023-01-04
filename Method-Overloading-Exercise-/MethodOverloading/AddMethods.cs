using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class AddMethods
    {

        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Addition(int a, int b, bool isTrue)
        {
            var sum = a + b;

            if (isTrue == true && sum >= 2)
            {
                return $"{sum} dollars.";
            }
            else
            {
                return $" {sum} dollar.";



            }


        }

    }
}

