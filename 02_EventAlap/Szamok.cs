using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EventAlap
{
    internal class Szamok
    {
        public delegate void ChangeNumberDelegate(int mirol, int mire);
        public delegate void KiiratasDelegate(int num);
        public delegate void KiiratasIndexxelDelegate(int num, int index);

        public event KiiratasDelegate KiiratasEvent;

        public Szamok(int count)
        {
            nums = new int[count];
        }

        private int[] nums;
        private int index = 0;

        public int[] Nums { get => this.nums; }


        public void Kiiratas(KiiratasDelegate kiiratas)
        {
            foreach (int i in Nums)
            {
                kiiratas?.Invoke(i);
                KiiratasEvent?.Invoke(i);
            }
        }

        public void KiiratasIndexxel(KiiratasIndexxelDelegate kiiratas)
        {
            int index = 0;
            foreach (int i in Nums)
            {
                kiiratas?.Invoke(i, index);
                index++;
            }
        }

        public void AddNumber(int num)
        {
            nums[index++] = num;
        }


    }
}
