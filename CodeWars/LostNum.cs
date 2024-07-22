using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class LostNum
    {

       
        public static int LostNumber(List<int> starting, List<int> mixedList)
        {
            return starting.Sum() - mixedList.Sum();
        }
    }
}
