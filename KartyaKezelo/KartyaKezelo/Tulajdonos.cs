namespace KartyaKezelo
{
    internal class Tulajdonos
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
    }
}