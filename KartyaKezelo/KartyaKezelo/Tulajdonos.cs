using System;
using System.Text.RegularExpressions;

namespace KartyaKezelo
{
    public class Tulajdonos
    {
        int id;
        string nev, email, telefonszam;

        public Tulajdonos(int id, string nev, string email, string telefonszam)
        {
            this.Id = id;
            this.Nev = nev;
            this.Email = email;
            this.Telefonszam = telefonszam;
        }

        public Tulajdonos()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Email { get => email; set => email = value; }
        public string Telefonszam { get => telefonszam; set => telefonszam = value; }

        public override string ToString()
        {
            return this.Id + "," + this.Nev + "," + this.Email + "," + this.Telefonszam;
        }

        public string TulajdonosEllenorzes()
        {
            string nevEredmeny = NevEllenorzes(nev);
            if (!nevEredmeny.Equals("OK"))
            {
                return nevEredmeny;
            }

            string emailEredmeny = EmailEllenorzes(email);
            if (!emailEredmeny.Equals("OK"))
            {
                return emailEredmeny;
            }

            string telefonEredmeny = TelefonEllenorzes(telefonszam);
            if (!telefonEredmeny.Equals("OK"))
            {
                return telefonEredmeny;
            }

            return "OK";
        }

        private string TelefonEllenorzes(string telefonszam)
        {
            string regexPattern = @"\+{1}\d{7,15}";
            Regex regex = new Regex(regexPattern);
            if (!regex.IsMatch(telefonszam))
            {
                return "A telefonszám nem megfelelő, nemzetközi formátumban kell lennie, és 7-15 karakternyi számból kell állnia! pl. +36301234567";
            }

            return "OK";
        }

        private string EmailEllenorzes(string email)
        {
            try
            {
                var emailCim = new System.Net.Mail.MailAddress(email);
                if (emailCim.Address == email)
                {
                    return "OK";
                }
                else
                {
                    return "Az e-mail cím nem megfelelő. Példa helyes formtáumra: example@example.com";
                }
            }
            catch
            {
                return "Az e-mail cím nem megfelelő. Példa helyes formtáumra: example@example.com";
            }
        }

        private string NevEllenorzes(string nev)
        {
            if (nev.Equals(""))
            {
                return "Kötelező nevet megadni!";
            }
            if (nev.Contains(","))
            {
                return "A név nem tartalmazhat vessző karaktert!";
            }

            return "OK";
        }
    }
}