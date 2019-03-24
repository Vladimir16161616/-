using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project001
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int c = (a * 100)*2;
            int d = (b * 2);
            int e = (c + d);
            int resultMod = (e % 1100);
            Console.WriteLine((e/100) + "" + resultMod);
        }
    }
}
