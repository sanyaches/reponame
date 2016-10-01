using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1zad2
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
            string s=null;
            int dec=0,tr=0,dlina,cifra,chislo;
            Console.WriteLine("введите число в семиричной системе счисления:  ");
            int sem = int.Parse(Console.ReadLine());
            chislo = sem;
            dlina = sem.ToString().Length;
            for(int i = 0;i<=dlina;i++)
            {
                cifra = chislo % 10;
                dec= dec + cifra*(MyPow(7, i));
                chislo = chislo / 10;
            }
            while (dec!=0)
                {
                s = s + ((dec % 3).ToString());
                dec = dec / 3;
                }
            tr = int.Parse(new string(s.Reverse().ToArray()));
            Console.WriteLine("число {0} в троичной равно {1}", sem,tr);
        }
    }
}
