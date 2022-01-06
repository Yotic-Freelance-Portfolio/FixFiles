using System;
using System.Linq;
using System.IO;

namespace zad2_metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            int chetchik=0;
            string name;
            Console.WriteLine("Введите слово, которое хотитие искать");
            name = Console.ReadLine();
            StreamReader sr = new StreamReader("t.txt");
            

            while (sr.EndOfStream != true)
            {
                var s = sr.ReadLine().Split(' ');
               
                List<string> file = new List<string> { Convert.ToString(s) };


                foreach (string i in file)
                {


                   
                      
                        int count = s.Where(w => w.ToLower().Contains(name.ToLower())).Count();
                    Console.WriteLine(count == 0 ? "Слово не найдено" : $"Слово {name} встречается в тексте {count} раз");


                    

                }
                
            }

            sr.Close();
           
        }
    }
}
