using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба1зад3
{
    class Program
    {
        static int MyPow(int number, int power)
        {
            int result;
            if (power == 0) result = 1;
            if (power > 0)
            {
                result = number;
                for (int i = 1; i < power; i++)
                    result *= number;
            }
            else
            {
                result = 1;
                for (int i = 0; i > power; i--)
                    result /= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string s=null; int chislo, p, kolvo, novoechislo=0; 
            chislo = int.Parse(Console.ReadLine());
            kolvo = chislo.ToString().Length;
            p = chislo;
            int[] cifri = new int[kolvo];
            for(int i=kolvo-1;i>=0;i--)
            {
                cifri[i] = p % 10;
                p /= 10;
            }
            for(int i=0; i<kolvo; i++)
            {
                if (i % 2 == 0) cifri[i] = 7;
            }
            for (int i = 0; i <kolvo; i++)
            {
                s += cifri[i].ToString();
            }
            novoechislo = int.Parse(s);
            Console.WriteLine("Новое число равно {0}", novoechislo);
        }
    }
}
