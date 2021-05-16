using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyaKezelo
{
    public enum Tipus { MasterCard, Visa };
    class Kartya
    {
        String kartyaszam, lejarat, cvcHash;
        bool letiltva;
        Tulajdonos tulajdonos;
        Tipus tipus;

        public Kartya(string kartyaszam, string lejarat, string cvcHash, bool letiltva, Tulajdonos tulajdonos, Tipus tipus)
        {
            this.Kartyaszam = kartyaszam;
            this.Lejarat = lejarat;
            this.CvcHash = cvcHash;
            this.Letiltva = letiltva;
            this.Tulajdonos = tulajdonos;
            this.Tipus = tipus;
        }

        public Kartya()
        { }

        public string Kartyaszam { get => kartyaszam; set => kartyaszam = value; }
        public string Lejarat { get => lejarat; set => lejarat = value; }
        public string CvcHash { get => cvcHash; set => cvcHash = value; }
        public bool Letiltva { get => letiltva; set => letiltva = value; }
        public Tipus Tipus { get => tipus; set => tipus = value; }
        internal Tulajdonos Tulajdonos { get => tulajdonos; set => tulajdonos = value; }
    }


}
