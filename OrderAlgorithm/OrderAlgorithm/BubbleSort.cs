using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm.OrderAlgorithm
{
    public class BubbleSort : OrderAlgorithmBase
    {
        public BubbleSort()
        {
            Name = "(交换-稳定  )冒泡排序";
        }

        public override void Run(int[] list) 
        {
            for (int bigLoop = 0; bigLoop < list.Count(); bigLoop++)
            {
                for (int smallLoop = 0; smallLoop < list.Count() - bigLoop - 1; smallLoop++)
                {
                    if (list[smallLoop] > list[smallLoop + 1])
                    {
                        Swith(ref list[smallLoop + 1], ref list[smallLoop]);
                    }
                }
            }
            SortedList = list;
        }
    }
}
