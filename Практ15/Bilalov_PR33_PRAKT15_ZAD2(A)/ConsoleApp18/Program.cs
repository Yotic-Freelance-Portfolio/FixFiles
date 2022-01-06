using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1=0, c2=0,i;
            char z;
            string a;
            char a2 = '(';
            char a3 = ')';
            Console.WriteLine("Введите функцию = " );
            
            a = Console.ReadLine();
            for (i = 0; i < a.Length; i++)
            {
                if(a[i] == a2)
                {
                    c1++;
                    z = a[i];
                    
                }
                if (a[i] == a3)
                {
                    c2++;
                    z = a[i];
                }
            }
            if (c1 != c2)
            {
                if (c1 > c2)
                {
                    int c3 = c1 - c2;
                    
                    Console.WriteLine("Количество скобок не одинаковое\n Вот ваша новая строка с соблюдением баланса");
                    //a.Remove(a2,c3);
                    //Console.WriteLine(a);
                }
                if(c1<c2)
                {
                    int c3 = c2 - c1;
                    Console.WriteLine("Количество скобок не одинаковое\n Вот ваша новая строка с соблюдением баланса");
                    //a.Remove(a3,c3);
                    //Console.WriteLine(a);
                }
                    
               
            }
            else Console.WriteLine("Количество скобок одинаковое");
            StreamWriter sr = new StreamWriter("1.txt");
            sr.Write(a);
            sr.Close();
            Console.ReadKey();
        }
    }
}
