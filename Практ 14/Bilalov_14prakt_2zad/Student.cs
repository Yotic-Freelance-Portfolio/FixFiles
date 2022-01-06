using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilalov_14prakt_2zad
{
    class Student
    {
       
        private string name;
        private string fio;
        private int n;

        

        public Student(string name, string fio, int n)
        {
            this.name = name;
            this.fio = fio;
            this.n = n;
        }

        public string getName()
        {
            return this.name;
        }
        public string getFio()
        {
            return this.fio;
        }
        public int getN()
        {
            return this.n;
        }
       
        public void setName(string name)
        {
            this.name = name;
        }
        public void setFio(string fio)
        {
            this.fio = fio;
        }
        public void setModel(int n)
        {
            this.n = n;
        }
      

    }
}
