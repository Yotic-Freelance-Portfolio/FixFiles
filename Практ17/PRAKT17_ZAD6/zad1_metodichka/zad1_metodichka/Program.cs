using System;
using System.Linq;
using System.IO;

namespace zad2_metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            int xxx;
            string str1;
            int sum;
            

            try
            {
                Console.WriteLine("Практическая работа 17, под каждой буквой соответсвующее задание");
                Console.WriteLine("Выберите действие:\n1-A\n2-Б\n3-В");
                xxx = Convert.ToInt32(Console.ReadLine());
                if (xxx == 1)
                {
                    Console.WriteLine("Введите строку, содкржащую цифры:");
                    str1 = Console.ReadLine();
                    sum = 0;
                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (char.IsDigit(str1[i]))
                            ++sum;
                    }
                    Console.WriteLine("Количество цифр: " + sum);
                    Console.ReadKey();
                }

                if (xxx == 2)
                {
                    Console.WriteLine("Введите строку, содержащую символ(/):");
                    string str = Console.ReadLine();
                    int poz, t = 0;
                    char s = '/';
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str.Contains(s))
                        {

                            poz = str.IndexOf(s);

                            t = poz;


                        }
                    }
                    for (int it = 0; it < t; it++)
                    {
                        Console.Write(str[it]);
                    }

                }

                if (xxx == 3)
                {
                    string ou;
                    Console.WriteLine("Введите строку, содержащую символ(/):");
                    string str = Console.ReadLine();
                    int poz, t = 0;
                    char s = '/';
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str.Contains(s))
                        {

                            poz = str.IndexOf(s);
                            poz++;
                            t = poz;


                        }
                    }
                    for (int it = t; it < str.Length; it++)
                    {
                        //Console.Write(str[it]);
                        ou = Convert.ToString(str[it]);
                        Console.Write(ou.ToUpper());
                    }

                }
                //else
                //{
                //    Console.WriteLine("ОШИБКА");
                //}
            }
            catch
            {
                Console.WriteLine("ОШИБКА");
            }
            

           

        }

           
        
    }
}
