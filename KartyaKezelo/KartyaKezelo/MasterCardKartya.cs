using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyaKezelo
{
    public class MasterCardKartya:Kartya
    {
        public override string ToString()
        {
            return this.Kartyaszam + "," + "MasterCard" + "," + this.Lejarat + "," + this.Cvc + "," + this.Letiltva.ToString() + "," + this.Tulajdonos.Id;
        }
    }
}
