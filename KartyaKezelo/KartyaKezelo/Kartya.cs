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
        String lejarat;
        bool letiltva;
        Tulajdonos tulajdonos;
        Tipus tipus;

        public Kartya(string lejarat, bool letiltva, Tulajdonos tulajdonos, Tipus tipus)
        {
            this.Lejarat = lejarat;
            this.Letiltva = letiltva;
            this.Tulajdonos = tulajdonos;
            this.Tipus = tipus;
        }

        public Kartya()
        { }

        public string Lejarat { get => lejarat; set => lejarat = value; }
        public bool Letiltva { get => letiltva; set => letiltva = value; }
        public Tipus Tipus { get => tipus; set => tipus = value; }
        internal Tulajdonos Tulajdonos { get => tulajdonos; set => tulajdonos = value; }
    }


}
