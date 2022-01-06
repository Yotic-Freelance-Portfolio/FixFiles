using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Bilalov_PR33_PRAKT15_ZAD4
{
    class Program
    {
         
      public struct one //структура для хранения данных об одном человеке
            {
                public string f;
                public string i;
                public string o;
                public int age;
                public float massa;
            }

        public static void Main()
        {
            StreamReader fileIn = new StreamReader("t.txt");
            string line;
            Queue people = new Queue();
            one a;
            Console.WriteLine("ВОЗРАСТ МЕНЕЕ 40 ЛЕТ");
            while ((line = fileIn.ReadLine()) != null) //читаем до конца файла 
            {
                string[] temp = line.Split(' '); //разбиваем строку на составные элементы
                                                 //заполняем структуру 
                a.f = temp[0];
                a.i = temp[1];
                a.o = temp[2];
                a.age = int.Parse(temp[3]);
                a.massa = float.Parse(temp[4]);
                // если возраст меньше 40 лет, то выводим данные на экран, иначе помещаем их в 
                //очередь для временного хранения
                if (a.age < 40)
                    Console.WriteLine(a.f + " " + a.i + " " + a.o + " " + a.age + " " + a.massa);
                else people.Enqueue(a);
            }
            fileIn.Close();

            Console.WriteLine("ВОЗРАСТ 40 ЛЕТ И СТАРШЕ");
            while (people.Count != 0) //извлекаем из очереди данные
            {
                a = (one)people.Dequeue();
                Console.WriteLine(a.f + " " + a.i + " " + a.o + " " + a.age + " " + a.massa);
            }

        }
    }
}
    

