using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = Convert.ToUInt32(Console.ReadLine());

            int k = 0;

            while (Math.Pow(2, k) <= n)
            {
                k++;
            }
            Console.WriteLine(k);
        }
    }
}
