using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m;
            Console.Write("Введите n = ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(new string(n.ToString().Reverse().ToArray()));
            Console.WriteLine("Наше число n в обратном порядке = {0}", m);
            if (n==m) Console.WriteLine("число n палиндром");
            else Console.WriteLine("Число n не палиндром"); 
        }
    }
}
