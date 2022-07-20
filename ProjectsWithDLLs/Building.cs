using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    public  class Building
    {
        private static int _LastNumber=100;
        private int Number { get; set; }

        public int Height { get; set; }
        public int Flors { get; set; }
        public int Flats { get; set; }
        public int Sections { get; set; }


        public  Building()
        {
            _LastNumber++;
            Number = _LastNumber;
        }

        public int GetNumber()
        {
            return Number;
        }

        public float GetFlorH()
        {
            return Height / Flors;
        }

        public int GetFlatsInSection()
        {
            return Flats / Sections;
        }

        public int GetFlatsAtFlor()
        {
            return Flats / Flors;
        }
    }
}
