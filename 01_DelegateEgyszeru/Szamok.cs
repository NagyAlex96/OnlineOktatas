using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DelegateEgyszeru
{
    internal class Szamok
    {
        private int[] nums;

        public Szamok(int count)
        {
            nums = new int[count];
        }

        public delegate void CountIncreaseDelegate(int count);
        public delegate void KiiratasDelegate(int num);

        private int index = 0;
        public int[] Nums { get => this.nums; }


        public void Kiiratas(KiiratasDelegate kiiratas)
        {
            foreach (int i in Nums)
            {
                kiiratas?.Invoke(i);
            }
        }

        public void AddNumber(int num)
        {
            nums[index++] = num;
        }
    }
}
