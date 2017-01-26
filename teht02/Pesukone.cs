using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Pesukone
    {
        public bool IsOn { get; set; }
        public string Tyyli { get; set; }
        public int Lampotila { get; set; }
        public string Ohjelma { get; set; }
        public int Kesto { get; set; }


        public Pesukone()
        {

        }

        public Pesukone(string tyyli)
        {
            Tyyli = tyyli;
        }
        public void Loppusoitto()
        {
            Console.WriteLine("Pipipiduduudaa");
        }

    }
}
