using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBox
{
    public static class Utility
    {
        public static int GetListCount<T>(List<T> list)
        {
            return list.Count;
        }
    }
}
