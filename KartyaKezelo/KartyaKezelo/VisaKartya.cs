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
            return this.Kartyaszam + "," + "VISA" + "," + "altípus," + this.Lejarat + "," + this.Cvc + "," + this.Letiltva.ToString() + "," + this.Tulajdonos.Id;
        }
    }
}
