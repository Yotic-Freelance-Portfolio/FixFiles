using System;
using System.Collections;
using System.IO;
using System.Text;

namespace PR33_Bilalov_PRAKT15_ZAD5
{
    class Program
    {
        public struct one 
        {
            public string f;
            public string i;
            public string o;
            public int age;
            public int massa;
        }

        public class SortByAge : IComparer
        {
            int IComparer.Compare(object x, object y)  
            {
                one t1 = (one)x;
                one t2 = (one)y;
                if (t1.age > t2.age) return 1;
                if (t1.age < t2.age) return -1;
                return 0;
            }
        }

        static void ArrayPrint(string s, ArrayList a)
        {
            Console.WriteLine(s);
            foreach (one x in a)
                Console.WriteLine("ФИО: " + x.f + " " + x.i + " " + x.o + "\n " + "возраст: " + x.age + "\n " + "вес:" + x.massa);
        }

        static void Main(string[] args)
        {
            StreamReader fileIn = new StreamReader("t.txt");
            string line;
            one a;
            ArrayList people = new ArrayList();
            string[] temp = new string[5];
            while ((line = fileIn.ReadLine()) != null)  
            {
                temp = line.Split(' ');
                a.f = temp[0];
                a.i = temp[1];
                a.o = temp[2];
                a.age = int.Parse(temp[3]);
                a.massa = int.Parse(temp[4]);
                people.Add(a);
            }
            fileIn.Close();

            ArrayPrint("Исходные данные: \n", people);
            Console.WriteLine();
            people.Sort(new Program.SortByAge());  
            
            ArrayPrint("Отсортированные данные: \n", people);
        }
    }
}
