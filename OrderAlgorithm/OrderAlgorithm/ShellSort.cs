using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm.OrderAlgorithm
{
    public class ShellSort : OrderAlgorithmBase
    {
        public ShellSort()
        {
            Name = "(插入-不稳定)希尔排序";
        }

        public override void Run(int[] list) 
        {
            QuickSortMethod(list, 5);
            SortedList = list;
        }

        private void QuickSortMethod(int[] list, int distance)
        {
            if (distance <= 0)
            {
                throw new ArgumentException("距离必须为正整数");
            }

            for (int leadingRole = distance; leadingRole < list.Count(); leadingRole++)
            {
                int nowPos = leadingRole;//每轮一个主角
                while (nowPos - distance >= 0 && list[nowPos] < list[nowPos - distance])
                {
                    int temp = list[nowPos - distance];
                    list[nowPos - distance] = list[nowPos];
                    list[nowPos] = temp;
                    nowPos -= distance;
                }
            }

            if (distance >= 2)
            {
                QuickSortMethod(list, distance / 2);
            }
        }
    }
}
