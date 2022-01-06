using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleApp1
{
    class User
    {
        public string Name { get; set; }
        public string group { get; set; }
        public double ball { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            List<User> users = new List<User>
            {
            new User {Name="Иванов Сергей Николаевич", group="ПР-21", ball = 4.2},
            new User {Name="Петров Игорь Юрьевич", group="ПЗ-21", ball = 3.5},
            new User {Name="Семёнов Михаил Алексеевич", group=" ПР-32", ball =  3.8},
            new User {Name="Пиманов Александр Дмитриевич", group=" ПР-32", ball =  4.1},
            new User {Name="Иванов Иван Петрович", group=" ПР-21", ball = 4.7},
            new User {Name="Усольцев Александр Дмитриевич", group=" ПР-32", ball =  4.3}
            };
            try
            {
                Console.WriteLine("Выберите как остортировать список:\n1-По возрастанию\n2-По убыванию");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {

                    StreamWriter sw = new StreamWriter("vozrast.txt");
                    var selectedUsers = from user in users
                                        orderby user.ball
                                        select user;
                    foreach (User user in selectedUsers)
                        sw.WriteLine($" {user.Name}- {user.group} - {user.ball}");
                    sw.Close();
                    StreamReader sr = new StreamReader("vozrast.txt");
                    Console.WriteLine(sr.ReadToEnd());
                    sr.Close();
                }
                if (a == 2)
                {
                    StreamWriter sw = new StreamWriter("ybiv.txt");

                    var selectedUsers = from user in users
                                        orderby user.ball descending
                                        select user;
                    foreach (User user in selectedUsers)
                        sw.WriteLine($" {user.Name}- {user.group} - {user.ball}");
                    sw.Close();
                    StreamReader sr = new StreamReader("ybiv.txt");
                    Console.WriteLine(sr.ReadToEnd());
                    sr.Close();
                }
                if(a>2)
                    Console.WriteLine("ОШИБКА");
            }
            catch
            {
                Console.WriteLine("ОШИБКА");
            }
        }
    }
}