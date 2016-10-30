using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAlgorithm
{
    public abstract class OrderAlgorithmBase
    {
        public string Name { get; protected set; }

        public int[] SortedList { get; protected set; }
        public abstract void Run(int[] list);

        protected void Swith(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
