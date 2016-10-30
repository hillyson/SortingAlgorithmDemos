using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm.OrderAlgorithm
{
    public class LinqSort : OrderAlgorithmBase
    {
        public LinqSort()
        {
            Name = "Linq排序";
        }

        public override void Run(int[] list) 
        {
            SortedList = list.OrderBy(p => p).ToArray();
        }
    }
}
