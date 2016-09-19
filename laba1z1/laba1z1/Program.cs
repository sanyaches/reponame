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
            int n,j,m;
           string s;
            Console.Write("Enter n = ");
            n = int.Parse(Console.ReadLine());
           Console.Write("Our m = ");
            j = n;
            char [] array= j.ToString().Reverse();
            Console.WriteLine(s);
            //m = int.Parse(s);
            //Console.Write(m);
            //if(n==m)
           //     Console.WriteLine("Число палиндром");
            //else Console.WriteLine("Число не палиндром");
            /*for(int i=0;i<j/2;i++)
            {
                if (array[i] == array[j - i])
                {
                    Console.WriteLine("Число палиндром");
                    continue;
                }
                else
                {
                    Console.WriteLine("Число не палиндром");
                    break;
                }
                
            }*/
            /* Console.Write(n % 10);
             while ((n /= 10) != 0)
                 Console.Write(n % 10);*/

        }
    }
}
