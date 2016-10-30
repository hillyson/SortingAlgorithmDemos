using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm.OrderAlgorithm
{
    public class QuickSort : OrderAlgorithmBase
    {
        public QuickSort()
        {
            Name = "(交换-不稳定)快速排序";
        }

        public override void Run(int[] list) 
        {
            SortedList = QuickSortMethod(list, 0, list.Length - 1);
        }

        private int[] QuickSortMethod(int[] intArray, int startIndex, int endIndex)//O(nlog2n)-O(n²)
        {
            if (startIndex < endIndex)
            {
                int tag = intArray[startIndex];//比较值
                int preIndex = startIndex;//前游标
                int postIndex = endIndex;//后游标
                bool isPreCompare = false;
                while (preIndex != postIndex)
                {
                    if (isPreCompare)//比较前游标
                    {
                        if (intArray[preIndex] > tag)
                        {
                            intArray[postIndex] = intArray[preIndex];//前游标值赋予后游标位置
                            postIndex--;//后游标前移
                            isPreCompare = false;
                        }
                        else
                        {
                            preIndex++;//前游标后移
                        }
                    }
                    else//比较后游标
                    {
                        if (intArray[postIndex] < tag)//后游标数值比比较值大
                        {
                            intArray[preIndex] = intArray[postIndex];//后游标值赋予前游标位置
                            preIndex++;//前游标后移
                            isPreCompare = true;
                        }
                        else
                        {
                            postIndex--;//后游标前移
                        }
                    }
                }
                int tagIndex = preIndex;//比较值所在位置索引
                intArray[tagIndex] = tag;//比较值赋值在最后的游标位置
                if (tagIndex > startIndex + 1)//存在前子数组
                {
                    intArray = QuickSortMethod(intArray, startIndex, tagIndex - 1);//递归排序前子数组
                }
                if (tagIndex < endIndex - 1)//存在后子数组
                {
                    intArray = QuickSortMethod(intArray, tagIndex + 1, endIndex);//递归排序后子数组
                }
            }
            return intArray;
        }
    }
}
