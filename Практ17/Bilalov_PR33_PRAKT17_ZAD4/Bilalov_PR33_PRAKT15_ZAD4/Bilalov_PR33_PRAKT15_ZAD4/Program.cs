using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Bilalov_PR33_PRAKT15_ZAD4
{
    class Program
    {
         
      public struct one //структура для хранения данных об одном человеке
            {
                public string f;
                public string i;
                public string o;
                public string group;
                public double ball;
            }
        class User
        {
            public string Name { get; set; }
            public string group { get; set; }
            public double ball { get; set; }

            //public string group { get; set; }
            //public float ball { get; set; }
        }

        public static void Main()
        {
            StreamReader fileIn = new StreamReader("t.txt");
            string line;
            Queue people = new Queue();
            one a;
            Console.WriteLine("Средний бал больше 4");
            while ((line = fileIn.ReadLine()) != null) //читаем до конца файла 
            {
                string[] temp = line.Split(' '); 
                a.f = temp[0];
                a.i = temp[1];
                a.o = temp[2];
                a.group = temp[3];
                a.ball = Convert.ToDouble(temp[4]);

                List<User> users = new List<User>
                {
                new User {Name=a.f + " " + a.i + " " + a.o, group=a.group, ball = a.ball}
                };

                var selectedUsers = from user in users
                                    where user.ball > 4 
                                    select user;
                foreach (User user in selectedUsers)
                    Console.WriteLine($"{user.Name} - {user.group} - {user.ball}");
            }
            fileIn.Close();

        }
    }
}
    

