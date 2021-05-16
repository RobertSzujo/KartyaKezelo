using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyaKezelo
{
    public class Kartya
    {
        String kartyaszam, lejarat, cvc;
        bool letiltva;
        Tulajdonos tulajdonos;

        public Kartya(string kartyaszam, string lejarat, bool letiltva, Tulajdonos tulajdonos)
        {
            this.kartyaszam = kartyaszam;
            this.Lejarat = lejarat;
            this.Cvc = cvc;
            this.Letiltva = letiltva;
            this.Tulajdonos = tulajdonos;
        }

        public Kartya()
        { }

        public string Kartyaszam { get => kartyaszam; set => kartyaszam = value; }
        public string Lejarat { get => lejarat; set => lejarat = value; }
        public String Cvc { get => cvc; set => cvc = value; }
        public bool Letiltva { get => letiltva; set => letiltva = value; }
        internal Tulajdonos Tulajdonos { get => tulajdonos; set => tulajdonos = value; }

    }


}
