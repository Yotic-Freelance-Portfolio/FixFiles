using System;
using System.Collections;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = 0;

            try
            {
                while(!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.WriteLine("Ошибка ввода");
                }


                Queue intQ = new Queue();
                for (int i = 1; i <= n; i++)
                    intQ.Enqueue(i);
                Console.WriteLine("Размерность очереди " + intQ.Count);

                Console.WriteLine("Верхний элемент очереди = " + intQ.Count);
                Console.WriteLine("Размерность очереди " + intQ.Count);

                Console.Write("Содержимое очереди = ");
                while (intQ.Count != 0)
                    Console.Write("{0} ", intQ.Dequeue());
                Console.WriteLine("\nНовая размерность очереди " + intQ.Count);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
           
        }
    }

}
