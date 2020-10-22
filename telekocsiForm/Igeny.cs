using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekocsiForm
{
    class Igeny
    {
        public string Azonosito { get; private set; }
        public string IndulasI { get; private set; }
        public string CelI { get; private set; }
        public int Szemelyek { get; private set; }
        public string Utvonal { get; private set; }

        public Igeny(string sor)
        {
            string[] a = sor.Split(';');
            Azonosito = a[0];
            IndulasI = a[1];
            CelI = a[2];
            Szemelyek = Convert.ToInt32(a[3]);
            Utvonal = IndulasI + "-" + CelI;
        }
    }
}
