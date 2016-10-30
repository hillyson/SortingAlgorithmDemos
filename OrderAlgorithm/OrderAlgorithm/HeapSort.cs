using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm.OrderAlgorithm
{
    public class HeapSort : OrderAlgorithmBase
    {
        public HeapSort()
        {
            Name = "(选择-不稳定)堆排序";
        }

        public override void Run(int[] list) 
        {
            HeapSortMethod(list);
            SortedList = list;
        }

        public void HeapSortMethod(int[] list)
        {
            for (int i = 0; i < list.Count() - 2; i++)
            {
                BuildHeap(list, list.Count() - 1 - i);
                Swith(ref list[0], ref list[list.Count() - 1 - i]);
            }
        }

        /// <summary>
        /// 创建堆
        /// </summary>
        /// <param name="list">目标数组</param>
        /// <param name="size">要创建堆的节点数</param>
        private void BuildHeap(int[] list, int size)
        {
            for (int i = size / 2; i >= 0; i--)    //非叶节点最大序号值为size/2 
            {
                HeapAdjust(list, i, size);
            }
        }

        /// <summary>
        /// 堆调整
        /// </summary>
        /// <param name="list">要排序的数组</param>
        /// <param name="i">要排序的子树根索引</param>
        /// <param name="size">要排序的数组范围</param>
        private void HeapAdjust(int[] list, int i, int size)  //调整堆 
        {
            int lChildIndex = 2 * i;       //i的左孩子节点序号 
            int rChildIndex = 2 * i + 1;   //i的右孩子节点序号 
            int maxIndex = i;              //临时变量 
            if (i <= size / 2)             //如果i是叶节点就不用进行调整 
            {
                if (lChildIndex <= size && list[lChildIndex] > list[maxIndex])
                {
                    maxIndex = lChildIndex;
                }
                if (rChildIndex <= size && list[rChildIndex] > list[maxIndex])
                {
                    maxIndex = rChildIndex;
                }
                if (maxIndex != i)
                {
                    Swith(ref list[i], ref list[maxIndex]);
                    HeapAdjust(list, maxIndex, size);    //递归调整子树
                }
            }
        }
    }
}
