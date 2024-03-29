﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DelegateEgyszeru
{
    internal class Szamok
    {
        public delegate void KiiratasDelegate(int num);
        public delegate void KiiratasIndexxelDelegate(int num, int index);

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
