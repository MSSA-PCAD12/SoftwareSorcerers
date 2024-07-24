using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{   
    public class birthdayCandles
    {
        //helper function
        static List<int> ConvertStringToIntList(string numbers)
        {
            List<int> intList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                char c = numbers[i];
                int number = int.Parse(c.ToString());
                intList.Add(number);
            }

            return intList;
        }

        //Main
        public static int BlowCandles(string str)
        {
            int count = 0;
            // convert string nums into List<int>
            List<int> intList = ConvertStringToIntList(str);

            while (intList.Count > 0)
            {
                if (intList[0] > 0)
                {
                    for (int i = 0; i <= Math.Min(2, intList.Count - 1); i++) // iterate at most through the first 3 indexes.. if intList.Count < 3 use that count -1 as indexes
                    {
                        if (intList[i] > 0)
                        {
                            intList[i]--;
                        }
                    }

                    count++;
                }
                else
                {
                    intList.RemoveAt(0); // remove head of list
                }
            }

            return count; // Let's see how we gonna blow these candles...
        }

    }
}
