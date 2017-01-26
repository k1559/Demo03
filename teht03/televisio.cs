using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class televisio
    {
        public bool IsOn { get;set; }
        public int Kanava { get; set; }
        public int AanenVoimakkuus { get; set; }
        public string Merkki { get; set; }
        public double Koko { get; set; }


        public void KanavaYlos()
        {
            Kanava = Kanava + 1;
        }
        public void KanavaAlas()
        {
            Kanava++;
        }

        public void SammutaTV()
        {
            IsOn = false;
        }
        public void AaniYlos()
        {
            AanenVoimakkuus++;
        }

        public void AaniAlas()
        {
            AanenVoimakkuus = AanenVoimakkuus - 1;
        }
    }
}
