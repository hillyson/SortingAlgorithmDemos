using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm
{
    public class OrderCounter
    {
        private Stopwatch _stopWatch;

        private int[] _targetList;

        private OrderAlgorithmBase _algorithm;

        public OrderCounter(int listCount, OrderAlgorithmBase algorithm)
        {
            _stopWatch = new Stopwatch();
            _targetList = new int[listCount];
            var ramdom = new Random();
            for (int i = 0; i < _targetList.Count(); i++)
			{
                _targetList[i] = ramdom.Next(10000);
			}
            _algorithm = algorithm;
        }

        public OrderCounter(int[] targetList, OrderAlgorithmBase algorithm)
        {
            _stopWatch = new Stopwatch();
            _targetList = targetList;
            _algorithm = algorithm;
        }

        public void RunSort()
        {
            _stopWatch.Reset();
            _stopWatch.Start();
            _algorithm.Run(_targetList);
            _stopWatch.Stop();
            Console.WriteLine(_algorithm.Name + " 算法耗时:" + _stopWatch.ElapsedMilliseconds + "ms");

            //foreach (var item in _algorithm.SortedList)
            //{
            //    Console.Write(item);
            //    Console.Write(" ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("");
        }
    }
}
