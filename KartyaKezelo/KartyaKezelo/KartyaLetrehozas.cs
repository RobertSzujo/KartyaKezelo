using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartyaKezelo
{
    public partial class KartyaLetrehozas : Form
    {
        List<Kartya> kartyaLista;
        List<Tulajdonos> tulajdonosLista;
        Tulajdonos kivalasztottTulajdonos;
        List<Kartya> ujKartyak = new List<Kartya>();
        bool menteniKell = false;

        public KartyaLetrehozas(List<Tulajdonos> tulajdonosok, List<Kartya> kartyak)
        {
            InitializeComponent();
            this.tulajdonosLista = tulajdonosok;
            this.kartyaLista = kartyak;

            TulajdonosokFeltoltese();
        }

        private void TulajdonosokFeltoltese()
        {
            foreach (Tulajdonos tulajdonos in tulajdonosLista)
            {
                lbTulajdonosok.Items.Add(tulajdonos.Id + ": " + tulajdonos.Nev);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KilepesMentesNelkul();
        }

        private void KilepesMentesNelkul()
        {
            if (ujKartyak.Count > 0)
            {
                String uzenet = "Biztosan ki szeretne lépni a kártyák mentése nélkül?";
                String cim = "Kilépés megerősítése";
                MessageBoxButtons gombok = MessageBoxButtons.OKCancel;

                DialogResult eredmeny = MessageBox.Show(this, uzenet, cim, gombok);

                if (eredmeny == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void rbMasterCard_CheckedChanged(object sender, EventArgs e)
        {
            btnMentesListaba.Enabled = true;
        }

        private void lbTulajdonosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTulajdonosok.SelectedItem != null)
            {
                String[] tulajdonosSor = lbTulajdonosok.SelectedItem.ToString().Split(':');
                int tulajdonosId = Convert.ToInt32(tulajdonosSor[0]);
                kivalasztottTulajdonos = tulajdonosLista.Find(tulajdonos => tulajdonos.Id == tulajdonosId);

                tbTulajdonosNeve.Text = kivalasztottTulajdonos.Nev;
                tbTulajdonosEmail.Text = kivalasztottTulajdonos.Email;
                tbTulajdonosTel.Text = kivalasztottTulajdonos.Telefonszam;
            }
        }

        private void rbVisa_CheckedChanged(object sender, EventArgs e)
        {
            btnMentesListaba.Enabled = true;
        }

        private void btnUjTulajdonos_Click(object sender, EventArgs e)
        {
            TulajdonosLetrehozas tulajdonosLetrehozas = new TulajdonosLetrehozas(tulajdonosLista);
            tulajdonosLetrehozas.ShowDialog();

            Tulajdonos ujTulajdonos = tulajdonosLetrehozas.TulajdonosAtadas();

            if (ujTulajdonos != null)
            {
                StreamWriter tulajdonosStreamWriter = new StreamWriter("Tulajdonosok.txt", true);
                tulajdonosStreamWriter.WriteLine(ujTulajdonos.ToString());
                tulajdonosStreamWriter.Close();
                tulajdonosLista.Add(ujTulajdonos);
                lbTulajdonosok.Items.Add(ujTulajdonos.Id + ": " + ujTulajdonos.Nev);
            }
        }

        private void btnMentesKilepes_Click(object sender, EventArgs e)
        {
            menteniKell = true;
            String uzenet = "A kártyák mentése sikeresen megtörtént!";
            String cim = "Sikeres mentés!";
            MessageBox.Show(uzenet, cim);
            this.Close();
        }

        private void btnMentesListaba_Click(object sender, EventArgs e)
        {
            Kartya kartya = new Kartya();
            if (rbMasterCard.Checked)
            {
                kartya = new MasterCardKartya();
            }
            else if (rbVisa.Checked)
            {
                kartya = new VisaKartya();
            }

            kartya.Kartyaszam = tbBankkartyaSzam.Text;
            kartya.Lejarat = dtpLejarat.Text;
            kartya.Cvc = tbCvc.Text;
            kartya.Letiltva = false;
            kartya.Tulajdonos = kivalasztottTulajdonos;

            bool letezikMarIlyenKartya = false;
            foreach (Kartya letezoKartya in kartyaLista)
            {
                if (letezoKartya.Kartyaszam.Equals(kartya.Kartyaszam))
                {
                    letezikMarIlyenKartya = true;
                    break;
                }
            }

            if (letezikMarIlyenKartya)
            {
                String uzenet = "A megadott kártyaszámmal már létezik kártya a listában!";
                String cim = "Létrehozás hiba";
                MessageBox.Show(uzenet, cim);
            }
            else
            {
                String kartyaEllenorzesEredmeny = kartya.KartyaEllenorzes();
                if (kartyaEllenorzesEredmeny.Equals("OK"))
                {
                    ujKartyak.Add(kartya);
                    lbMentesreVar.Text = "Mentésre vár: " + ujKartyak.Count + " db kártya";

                    String cim = "Sikeres mentés";
                    String uzenet = "A kártya sikeresen mentésre került az új kártyák közé!";
                    MessageBox.Show(uzenet, cim);

                    if (btnMentesKilepes.Enabled == false)
                    {
                        btnMentesKilepes.Enabled = true;
                    }

                    MezokUritese();
                }
                else
                {
                    String cim = "Létrehozás hiba";
                    MessageBox.Show(kartyaEllenorzesEredmeny, cim);
                }
            }
        }

        private void MezokUritese()
        {
            tbBankkartyaSzam.Text = "";
            dtpLejarat.Text = "";
            tbCvc.Text = "";
        }

        public List<Kartya> KartyaListaAtadas()
        {
            if (menteniKell == true)
            {
                return ujKartyak;
            }
            else
            {
                return null;
            }
        }

        private void KartyaLetrehozas_Load(object sender, EventArgs e)
        {

        }
    }
}
