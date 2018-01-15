using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dom
    {
        protected string drzwi;
        protected Kolor kolorElewacji;
        protected string okno;
        public void WstawOkna()
        {

        }
        public void ZamontujDrzwi()
        {
        }
        public void PomalujElewacje()
        {

        }
        public override string ToString()
        {
            return "Okna: " + okno + ", Drzwi: " + drzwi + ", Kolor elewacji: " + kolorElewacji;
        }

    }
}
