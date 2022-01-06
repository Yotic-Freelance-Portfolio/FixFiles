using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент", "Иван" });

            foreach (object e in list)
            Console.WriteLine(e);

            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[1]);
            for (int i=0; i<list.Count; i++)
            {
            Console.WriteLine(list[i]);
            }

            Console.ReadLine();
            }


            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Иван" });

                ArrayList lst2 = new ArrayList();

                lst2.AddRange(new string[] { "werty", "hello" });

                Console.WriteLine("Vvedite index");
                int n1 = Convert.ToInt32(Console.ReadLine());
                list.InsertRange(n1, lst2);

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }

                Console.WriteLine();
                Console.WriteLine("Vvedite kol-vo");
                int k = Convert.ToInt32(Console.ReadLine());

                int n = n1 / 2;
                list.RemoveRange(n, k);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }

                Console.ReadLine();
            }

        }
    }
}