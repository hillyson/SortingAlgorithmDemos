using OrderAlgorithm.OrderAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10000;
            int[] list = new int[count];
            var ramdom = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < count; i++)
            {
                list[i] = ramdom.Next(1000);
            }

            int[] linqList = new int[list.Count()];//Linq排序
            list.CopyTo(linqList, 0);
            var linqCounter = new OrderCounter(linqList, new LinqSort());
            linqCounter.RunSort();

            int[] insertionList = new int[list.Count()];//直接插入排序(插入-稳定)
            list.CopyTo(insertionList, 0);
            var insertionSortCounter = new OrderCounter(insertionList, new InsertionSort());
            insertionSortCounter.RunSort();

            int[] shellList = new int[list.Count()];//希尔排序(插入-不稳定)
            list.CopyTo(shellList, 0);
            var shellSortCounter = new OrderCounter(shellList, new ShellSort());
            shellSortCounter.RunSort();

            int[] selectionList = new int[list.Count()];//直接选择排序(选择-不稳定)
            list.CopyTo(selectionList, 0);
            var selectionSortCounter = new OrderCounter(selectionList, new SelectionSort());
            selectionSortCounter.RunSort();

            int[] heapList = new int[list.Count()];//堆排序(选择-不稳定)
            list.CopyTo(heapList, 0);
            var heapSortCounter = new OrderCounter(heapList, new HeapSort());
            heapSortCounter.RunSort();

            int[] bubbleList = new int[list.Count()];//冒泡排序(交换-稳定)
            list.CopyTo(bubbleList, 0);
            var bubbleSortCounter = new OrderCounter(bubbleList, new BubbleSort());
            bubbleSortCounter.RunSort();

            int[] quickSorList = new int[list.Count()];//快速排序(交换-不稳定)
            list.CopyTo(quickSorList, 0);
            var quickSortCounter = new OrderCounter(quickSorList, new QuickSort());
            quickSortCounter.RunSort();
        }
    }
}
