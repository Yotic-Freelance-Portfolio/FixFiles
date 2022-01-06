using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilalov_PRAKT16_ZAD5
{

    struct student
    {
        string _fam;
        string _name;
        string _otch;
        public student(string fam, string name, string otch)
        {
            _fam = fam;
            _name = name;
            _otch = otch;
        }
        public string Famaly
        {
            get { return _fam; }
            set { _fam = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _otch; }
            set { _otch = value; }
        }
    }
    class StudentGroup
    {
        string group_name;
        List<student> students;

        public StudentGroup()
        {
            group_name = "";
            students = new List<student>();
        }
        public StudentGroup(string groupName)
        {
            group_name = groupName;
            students = new List<student>();
        }
        public void AddStudent(student newStudent)
        {
            students.Add(newStudent);
        }
        public void AddStudentRange(List<student> listStudent)
        {
            students.AddRange(listStudent);
        }
        public string GroupName
        {
            get { return group_name; }
            set { group_name = value; }
        }
        public void RemoveStudent(int index)
        {
            if (index >= students.Count)
                throw new Exception("Студента с таким индексом не существует.");
            students.RemoveAt(index);
        }
        public void ShowGroup()
        {
            for (int i = 0; i < students.Count; i++)
                Console.WriteLine("ФИО: " + students[i].Famaly + " " + students[i].Name + " " + students[i].LastName);
        }
        public student FindStudent(string key)
        {
            for (int i = 0; i < students.Count; i++)
                if (students[i].LastName == key || students[i].Famaly == key || students[i].Name == key)
                    return students[i];
            return new student("", "", "");
        }
        public bool RemoveAtFamaly(string famaly)
        {
            for (int i = 0; i < students.Count; i++)
                if (famaly == students[i].Famaly)
                {
                    students.RemoveAt(i);
                    return true;
                }
            return false;
        }
        public bool RemoveAtName(string name)
        {
            for (int i = 0; i < students.Count; i++)
                if (name == students[i].Name)
                {
                    students.RemoveAt(i);
                    return true;
                }
            return false;
        }
        public bool RemoveAtLastname(string lastname)
        {
            for (int i = 0; i < students.Count; i++)
                if (lastname == students[i].LastName)
                {
                    students.RemoveAt(i);
                    return true;
                }
            return false;
        }
        public int StudentCount
        {
            get { return students.Count; }
        }
        public student this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                students[index] = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            StudentGroup group = new StudentGroup("ПР-31");
            student st = new student("Иванов", "Иван", "Иванович");
            for (int i = 0; i < 10; i++) group.AddStudent(st);

            student s = new student("Иванов", "Иван", "Иванович");
            group.AddStudent(s);
            group.ShowGroup();
            student s_find = group.FindStudent("Пива");
            Console.WriteLine("Найденный студент: " + s.Name);
            Console.WriteLine("Название группы:" + group.GroupName);
            Console.ReadKey();
        }
    }
}
