using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();
            pesukone.IsOn = true;
            pesukone.Lampotila = 30;
            pesukone.Ohjelma = "Valkopesu";
            pesukone.Kesto = 20;
            Console.WriteLine("Veden lämpötila on " + pesukone.Lampotila);
            Console.WriteLine("Ohjelma on " + pesukone.Ohjelma);
            Console.WriteLine("Ohjelman kesto on " + pesukone.Kesto);
            pesukone.Loppusoitto();

            string tyyli = ("nopsakone");
            Pesukone nopea = new Pesukone(tyyli);
            pesukone.IsOn = true;
            pesukone.Lampotila = 40;
            pesukone.Ohjelma = "Väripesu";
            pesukone.Kesto = 15;
            Console.WriteLine("Veden lämpötila on " + pesukone.Lampotila);
            Console.WriteLine("Ohjelma on " + pesukone.Ohjelma);
            Console.WriteLine("Ohjelman kesto on " + pesukone.Kesto);
            pesukone.Loppusoitto();
        }
    }
}
