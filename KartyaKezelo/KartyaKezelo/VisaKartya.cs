using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyaKezelo
{
    public class VisaKartya:Kartya
    {
        public override string ToString()
        {
            return this.Kartyaszam + "," + "VISA" + "," + this.Lejarat + "," + this.Cvc + "," + this.Letiltva.ToString() + "," + this.Tulajdonos.Id;
        }

        protected override string GyartoKartyaSzamEllenorzes(String kartyaszam)
        {
            if (!kartyaszam.StartsWith("4"))
            {
                return "VISA kártyák esetén a kártyaszámnak 4-essel kell kezdődnie!";
            }
            return "OK";
        }
    }
}
