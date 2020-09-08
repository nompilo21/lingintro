using System;
using System.Collections.Generic;
using System.Text;

namespace LinqIntroduction
{
    public static class MyLinq
    {
        //generics(creating reusable methods and classes)
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach(var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
