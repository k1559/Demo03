using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            televisio telkkari = new televisio();
            telkkari.IsOn = true;
            telkkari.Merkki = "Samsung";
            telkkari.Kanava = 1;
            telkkari.AanenVoimakkuus = 10;
            telkkari.Koko = 42;
            Console.WriteLine("Merkki on " + telkkari.Merkki);
            Console.WriteLine("Kanava on " + telkkari.Kanava);
            Console.WriteLine("Äänenvoimakkuus on " + telkkari.AanenVoimakkuus);
            Console.WriteLine("Koko on " + telkkari.Koko);
            telkkari.KanavaYlos();
            telkkari.AaniAlas();
            telkkari.SammutaTV();
            Console.WriteLine("TV on päällä " + telkkari.IsOn);
            Console.WriteLine("Merkki on " + telkkari.Merkki);
            Console.WriteLine("Kanava on " + telkkari.Kanava);
            Console.WriteLine("Äänenvoimakkuus on " + telkkari.AanenVoimakkuus);
            Console.WriteLine("Koko on " + telkkari.Koko);

        }
    }
}
