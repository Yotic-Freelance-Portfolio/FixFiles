using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilalov_14prakt_2zad
{
    class Computer
    {
       
        private string procesor;
        private string videokarte;
        private string mush;

        private string monitor;
        private string kolider;

        private string OZY;


        public Computer(string procesor, string videokarte, string mush, string monitor, string kolider, string OZY)
        {
            this.procesor = procesor;
            this.videokarte = videokarte;
            this.mush = mush;
            this.monitor = monitor;
            this.kolider = kolider;

            this.   OZY =   OZY;

        }

        public string getName()
        {
            return this.procesor;
        }
        public string getFio()
        {
            return this.videokarte;
        }
        public string getMush()
        {
            return this.mush;
        }
        public string getMon()
        {
            return this.monitor;
        }
        public string getKI()
        {
            return this.kolider;
        }
        public string getOZY()
        {
            return this.OZY;
        }

       
      

    }
}
