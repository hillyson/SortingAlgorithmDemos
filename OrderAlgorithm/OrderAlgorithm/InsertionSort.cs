using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm.OrderAlgorithm
{
    public class InsertionSort : OrderAlgorithmBase
    {
        public InsertionSort()
        {
            Name = "(插入-稳定  )直接插入排序";
        }

        public override void Run(int[] list) 
        {
            for (int leadingRole = 1; leadingRole < list.Count(); leadingRole++)
            {
                int nowPos = leadingRole;//每轮一个主角
                while (nowPos > 0 && list[nowPos] < list[nowPos - 1])
                {
                    Swith(ref list[nowPos - 1], ref list[nowPos]);
                    nowPos--;
                }
            }
            SortedList = list;
        }
    }
}
