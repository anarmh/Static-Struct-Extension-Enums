using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial.Helpers
{
   public static class Extension
    {
        public static int Factorial(this int mult,int a)
        {
            for (int i = a; i > 1; i--)
            {
                mult *= i;
            }
            return mult;
        }
    }
}
