using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm.OrderAlgorithm
{
    public class SelectionSort : OrderAlgorithmBase
    {
        public SelectionSort()
        {
            Name = "(选择-不稳定)直接选择排序";
        }

        public override void Run(int[] list)//O(n²)
        {
            for (int room = 0; room < list.Count(); room++)
            {
                int smallerGuy = list[room];//类似换房子
                for (int compareRoom = room + 1; compareRoom < list.Count(); compareRoom++)
                {
                    if (list[compareRoom] < smallerGuy)
                    {
                        Swith(ref list[compareRoom], ref smallerGuy);
                    }
                }
                list[room] = smallerGuy;
            }
            SortedList = list;
        }
    }
}
