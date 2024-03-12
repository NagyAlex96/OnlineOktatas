using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deletaltak
{
    /*
     Delegált feladat: Számláló delegált

      Készíts egy számláló osztályt, amely egy egész számot nyilvántart, és használj delegáltat a számláló
    módosításának eseménykezelésére. Példányosítsd a számlálót, regisztrálj egy eseménykezelőt, majd növeld és
    csökkentsd a számlálót, miközben az események jeleznek.
     
     */
    public class Counter
    {
        private int[] nums;

        public Counter(int count)
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
