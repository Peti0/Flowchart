using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_kivalasztasos
{
    using System;

    public class MyProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kérem az elemek számát");
            int n;

            n = (int)inputValue();
            int[] t = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Kérem  " + (i + 1) + ". elemet");
                t[i] = (int)inputValue();
            }
            int maxIndex;
            int tmp;

            for (i = n - 1; i >= 0; i--)
            {
                maxIndex = i;
                int j;

                for (j = 0; j <= i - 1; j++)
                {
                    if (t[j] > t[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                tmp = t[i];
                t[i] = t[maxIndex];
                t[maxIndex] = tmp;
            }
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(t[i].ToString() + ", ");
            }
            Console.ReadKey();
        }


        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }

}
