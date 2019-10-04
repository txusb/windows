using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static String substring(this String str,int start,int end)
        {
            //return str.Substring(start, end - start);
           if (end > start && str.Length+1 > end) { return str.Substring(start, end - start); } else { return str; }
        }
    }
}