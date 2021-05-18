using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public String KartyaEllenorzes()
        {
            String kartyaSzamEredmeny = KartyaSzamEllenorzes(this.kartyaszam);
            if (!kartyaSzamEredmeny.Equals("OK"))
            {
                return kartyaSzamEredmeny;
            }

            String lejaratDatumEredmeny = LejaratDatumEllenorzes(this.lejarat);
            if (!lejaratDatumEredmeny.Equals("OK"))
            {
                return lejaratDatumEredmeny;
            }

            String cvcEredmeny = CvcKodEllenorzes(this.cvc);
            if (!cvcEredmeny.Equals("OK"))
            {
                return cvcEredmeny;
            }

            String tulajdonosEredmeny = TulajdonosEllenorzes(this.tulajdonos);
            if (!tulajdonosEredmeny.Equals("OK"))
            {
                return tulajdonosEredmeny;
            }

            return "OK";
        }

        protected string KartyaSzamEllenorzes(string kartyaszam)
        {
            string regexPattern = @"\d{16}";
            Regex regex = new Regex(regexPattern);
            if (!regex.IsMatch(kartyaszam))
            {
                return "A kártyaszám nem megfelelő formátumú, 16 számjegyből kell állnia, elválasztó karakterek nélkül!";
            }
            if (!LuhnAlgoritmus(kartyaszam))
            {
                return "A kártyaszám nem megfelelő!";
            }

            //a child osztályok elvégzik a típusnak megfelelő plusz ellenőrzéseket
            String gyartoKartyaSzamEredmeny = GyartoKartyaSzamEllenorzes(kartyaszam);
            if (!gyartoKartyaSzamEredmeny.Equals("OK"))
            {
                return gyartoKartyaSzamEredmeny;
            }

            return "OK";
        }

        protected string TulajdonosEllenorzes(Tulajdonos tulajdonos)
        {
            if (tulajdonos == null)
            {
                return "Nincs tulajdonos párosítva a kártyához!";
            }
            return "OK";
        }

        protected string CvcKodEllenorzes(string cvc)
        {
            string regexPattern = @"\d{3}";
            Regex regex = new Regex(regexPattern);
            if (!regex.IsMatch(cvc))
            {
                return "A CVC kód nem megfelelő, 3 számjegyből kell állnia!";
            }

            return "OK";
        }

        protected string LejaratDatumEllenorzes(string lejarat)
        {
            string regexPattern = @"\d{2}\/\d{2}";
            Regex regex = new Regex(regexPattern);
            if (!regex.IsMatch(lejarat))
            {
                return "A lejárati dátum nem megfelelő, MM/YY formátumban kell lennie! (pl. 04/23)";
            }

            int honap = Convert.ToInt32(lejarat.Substring(0, 2));
            int ev = Convert.ToInt32(lejarat.Substring(3, 2)) + 2000;
            int utolsoNap = DateTime.DaysInMonth(ev, honap);

            DateTime lejaratDatum = new DateTime(ev, honap, utolsoNap);
            DateTime jelenlegiDatum = DateTime.Now;
            int osszehasonlitas = DateTime.Compare(lejaratDatum, jelenlegiDatum);

            if (osszehasonlitas < 0)
            {
                return "A lejárati dátumnak a jövőben kell lennie!";
            }

            return "OK";
        }

        protected virtual string GyartoKartyaSzamEllenorzes(string kartyaszam)
        {
            //Ezt a metódust az egyes kártyatípusoknál kell megvalósítani!
            return "OK";
        }

        protected bool LuhnAlgoritmus(String kartyaszam)
        {
            //Kódrészlet forrása: https://www.geeksforgeeks.org/luhn-algorithm/
            int nDigits = kartyaszam.Length;

            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--)
            {

                int d = kartyaszam[i] - '0';

                if (isSecond == true)
                    d = d * 2;

                nSum += d / 10;
                nSum += d % 10;

                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }
    }


}
