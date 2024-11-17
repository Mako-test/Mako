using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counterr
{
    public class Counter
    {
        public static int count=0;

        public Counter() {

            count++;
        }
        public static int GetCount()
        {
            return Counter.count;
        }


        public static void ResetCount()
        {
            if (count >= 0)
                count--;

            else throw new ArgumentException("Count is negative number");

        }
    }
}
