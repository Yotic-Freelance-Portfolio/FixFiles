using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilalov_PR33_PRAKT15_ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Stack ts = new Stack();
            for (int i = 1; i <= n; i++)
            {
                ts.Push(i);
                Console.WriteLine("Размерность стека =" + ts.Count);
                Console.WriteLine("Верхний элемент стека = " + ts.Peek());
                Console.Write("Содержание стека= ");
                while (ts.Count !=0)
                    Console.WriteLine("{0}", ts.Pop());
                Console.WriteLine("\nНовая размерность стека = " + ts.Count);
                Console.ReadKey();
            }
        }
    }
}
