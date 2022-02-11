using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSorter
{
    class Program
    {
        static void BubbleSorter(int[] idag)
        {
             bool needsSorting = true;
            for (int i = 0; i < idag.Length - 1 && needsSorting; i++)
            {
                needsSorting = false;
                for (int j = 0; j < idag.Length - 1 - i; j++)
                {
                    if (idag[j] > idag[j + 1])
                    {
                        needsSorting = true;
                        int tmp = idag[j +1];
                        idag[j + 1] = idag[j];
                        idag[j] = tmp;
                    }
                }
            }
        }

        static int[] Generateidag(int size)
        {
            Random rnd = new Random();
            int[] idag = new int[size];

            for (int i = 0; i < idag.Length; i++)
                idag[i] = rnd.Next(idag.Length);

            return idag;
        }

        static void Main(string[] args)
        {
            int[] tal = new int[] { 1000, 2000, 4000, 8000 };

            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine("Slumpar talen " + tal[i]);
                int[] idag  = Generateidag(tal[i]);
                
                Console.WriteLine("Sorterar slumpad idag");
                DateTime startTid = DateTime.Now;
                BubbleSorter(idag);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} millisekunder att sortera.\n", deltaTid.TotalMilliseconds);
            }
        }
    }
}
        
    

