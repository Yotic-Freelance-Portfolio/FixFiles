using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilalov_PRAKT16_ZAD6
{
    class MyIndex
    {
        public string word;
        public string pages;
        private Dictionary<int, string> index = new Dictionary<int, string>();
        public Dictionary<int, string> Index
        {
            get { return index; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyIndex ex = new MyIndex();
            Console.Write("Введите количество слов, которое вы желаете ввести: ");
            int buf = int.Parse(Console.ReadLine());
            for (int i = 0; i < buf; i++)
            {
                string text = "";
                Console.Write("Введите слово в указатель: ");
                ex.word = Console.ReadLine();
                Console.Write("Введите количество страниц для этого слова: ");
                int buf1 = int.Parse(Console.ReadLine()); int[] pages = new int[buf1];
                ex.pages = "";
                for (int j = 0; j < buf1; j++)
                {

                    Console.Write("Введите страницe" + j + ": ");
                    pages[j] = int.Parse(Console.ReadLine());
                    ex.pages += (pages[j] + ",");
                }
                text += ex.word + " " + ex.pages;
                ex.Index.Add(i, text);
            }
            Console.WriteLine("Заполните указатель: ");
            {
                int[] deletekey = new int[buf];
                for (int i = 0; i < buf; i++)
                {
                    deletekey[i] = -1;
                }
                bool exit = true;
                do
                {
                    Console.WriteLine("Выберете действие:\n1 - Вывод указателя\n2 - Удалить указатель\n3 - Exit");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            string vivod = "";
                            for (int i = 0; i < buf; i++)
                            {
                                if (deletekey[i] == i) continue;
                                else
                                {
                                    vivod = ex.Index[i];
                                    Console.WriteLine(i + ": " + vivod);
                                }

                            }
                            break;
                        case 2:
                            Console.Write("Введите номер слова, которое вы желаете удалить: ");
                            int deletenumber = int.Parse(Console.ReadLine());
                            ex.Index.Remove(deletenumber);
                            for (int i = 0; i < buf; i++)
                            {
                                if (deletekey[i] == -1) { deletekey[i] = deletenumber; break; }

                            }
                            for (int i = 0; i < buf; i++)
                            {
                                Console.Write(deletekey[i] + " ");

                            }
                            break;
                        case 3:
                            exit = false;
                            break;
                    }
                }
                while (exit == true);
            }

        }
    }
}
