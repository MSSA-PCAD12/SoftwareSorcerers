using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.ArrayDiff
{
    public class Kata
    {

        public static T[] ArrayDiff<T>(T[] a, T[] b)
        {
            // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)
            List<T> result = new List<T>();

            for (int i = 0; i < a.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < b.Length; j++)
                { 
                    if (a[i].Equals(b[j]))
                    {
                        found = true;
                        break;
                    }
                 }
                   if (!found)
                  {
                   result.Add(a[i]);
                  }

            }

            return result.ToArray();
        }
    }
}
