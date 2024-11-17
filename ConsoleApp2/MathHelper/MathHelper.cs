using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public static class MathHelper
    {
       
        public static int Add(int a, int b)
        {
           return a+b;
        }

       public static int Subtract(int a, int b) {
            return a-b;
        }

        public static int Multiply(int a, int b) {
            return a*b;
        }
        public static int Divide(int a, int b) {
            if (a != 0)
                return a / b;
            else throw new ArgumentException("number can not be devided by zero");
        }
    }
}
