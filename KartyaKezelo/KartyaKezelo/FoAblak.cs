using System;
using System.Collections;
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
    public partial class FoAblak : Form
    {
        List<Tulajdonos> tulajdonosok = new List<Tulajdonos>();
        List<Kartya> kartyak = new List<Kartya>();
        Kartya kivalasztottKartya;

        public FoAblak()
        {
            InitializeComponent();
            AdatokBetoltese();
        }

        private void AdatokBetoltese()
        {

            TulajdonosokBetoltese();
            KartyakBetoltese();
            KartyaListaFeltoltes();
        }

        public void TulajdonosokBetoltese()
        {
            if (File.Exists("Tulajdonosok.txt"))
            {
                StreamReader tulajdonosStreamReader = new StreamReader("Tulajdonosok.txt");
                while (!tulajdonosStreamReader.EndOfStream)
                {
                    string[] sor = tulajdonosStreamReader.ReadLine().Split(',');
                    Tulajdonos tulajdonos = new Tulajdonos();
                    tulajdonos.Id = Convert.ToInt32(sor[0]);
                    tulajdonos.Nev = sor[1];
                    tulajdonos.Email = sor[2];
                    tulajdonos.Telefonszam = sor[3];

                    tulajdonosok.Add(tulajdonos);
                }
                tulajdonosStreamReader.Close();
            }
            
        }

        public void KartyakBetoltese()
        {
            if (File.Exists("Kartyak.txt"))
            {
                StreamReader kartyaStreamReader = new StreamReader("Kartyak.txt");
                while (!kartyaStreamReader.EndOfStream)
                {
                    Kartya kartya = new Kartya();
                    string[] sor = kartyaStreamReader.ReadLine().Split(',');

                    if (sor[1] == "MasterCard")
                    {
                        kartya = new MasterCardKartya();
                    }
                    else if (sor[1] == "VISA")
                    {
                        kartya = new VisaKartya();
                    }

                    kartya.Kartyaszam = sor[0];
                    kartya.Lejarat = sor[2];
                    kartya.Cvc = sor[3];
                    kartya.Letiltva = bool.Parse(sor[4]);
                    kartya.Tulajdonos = tulajdonosok.Find(tulajdonos => tulajdonos.Id == int.Parse(sor[5]));

                    kartyak.Add(kartya);
                }
                kartyaStreamReader.Close();
            }
            
        }

        public void KartyaListaFeltoltes()
        {
            foreach (Kartya kartya in kartyak)
            {
                lbCards.Items.Add(kartya.Kartyaszam);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!kivalasztottKartya.Letiltva)
            {
                String megerositoUzenet = "Biztosan le szeretné tiltani a kártyát? A művelet NEM VONHATÓ VISSZA!";
                String megerositoCim = "Letiltás megerősítése";
                MessageBoxButtons gombok = MessageBoxButtons.OKCancel;

                DialogResult eredmeny = MessageBox.Show(this, megerositoUzenet, megerositoCim, gombok);

                if (eredmeny == DialogResult.OK)
                {
                    kivalasztottKartya.Letiltva = true;
                    KartyaFajlMentes(kartyak);
                    String sikeresUzenet = "A kártya sikeresen letiltva";
                    String sikeresCim = "Sikeres letiltás";
                    MessageBox.Show(sikeresUzenet, sikeresCim);
                }
            }
            else
            {
                String uzenet = "A kártya már le van tiltva!";
                String cim = "Letiltás hiba";
                MessageBox.Show(uzenet, cim);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KartyaLetrehozas kartyaLetrehozas = new KartyaLetrehozas(tulajdonosok, kartyak);
            kartyaLetrehozas.ShowDialog();

            List<Kartya> ujKartyak = kartyaLetrehozas.KartyaListaAtadas();

            if (ujKartyak != null)
            {
                foreach (Kartya ujKartya in ujKartyak)
                {
                    kartyak.Add(ujKartya);
                    lbCards.Items.Add(ujKartya.Kartyaszam);
                }

                KartyaFajlMentes(kartyak);

                TulajdonosokUjratoltese();
            }

        }

        private void KartyaFajlMentes(List<Kartya> kartyak)
        {
            File.Delete("Kartyak.txt");
            StreamWriter kartyaStreamWriter = new StreamWriter("Kartyak.txt", true);
            foreach (Kartya kartya in kartyak)
            {
                kartyaStreamWriter.WriteLine(kartya.ToString());
            }
            kartyaStreamWriter.Close();
        }

        private void TulajdonosokUjratoltese()
        {
            if (tulajdonosok.Count > 0)
            {
                tulajdonosok.Clear();
            }
            TulajdonosokBetoltese();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KartyaEsTulajdonosLekerdezes kartyaEsTulajdonosLekerdezes = new KartyaEsTulajdonosLekerdezes(kivalasztottKartya);
            kartyaEsTulajdonosLekerdezes.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCards.SelectedItem != null)
            {
                kivalasztottKartya = kartyak.Find(kartya => kartya.Kartyaszam == lbCards.SelectedItem.ToString());

                tbKartyaszam.Text = kivalasztottKartya.Kartyaszam;
                tbKartyatulajdonos.Text = kivalasztottKartya.Tulajdonos.Nev;

                btnKartyaAdatok.Enabled = true;
                btnKartyaEsTulajdonosAdatok.Enabled = true;
                btnDisableCard.Enabled = true;
                btnRemoveCard.Enabled = true;
            }
            else
            {
                btnKartyaAdatok.Enabled = false;
                btnKartyaEsTulajdonosAdatok.Enabled = false;
                btnDisableCard.Enabled = false;
                btnRemoveCard.Enabled = false;
                tbKartyaszam.Text = "(nincs kiválasztva bankkártya)";
                tbKartyatulajdonos.Text = "(nincs kiválasztva bankkártya)";
                kivalasztottKartya = null;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKartyaAdatok_Click(object sender, EventArgs e)
        {
            KartyaLekerdezes kartyaLekerdezes = new KartyaLekerdezes(kivalasztottKartya);
            kartyaLekerdezes.ShowDialog();
        }

        private void btnRemoveCard_Click(object sender, EventArgs e)
        {
            String megerositoUzenet = "Biztosan ki szeretné törölni a kártyát? A művelet NEM VONHATÓ VISSZA!";
            String megerositoCim = "Törlés megerősítése";
            MessageBoxButtons gombok = MessageBoxButtons.OKCancel;

            DialogResult eredmeny = MessageBox.Show(this, megerositoUzenet, megerositoCim, gombok);

            if (eredmeny == DialogResult.OK)
            {
                kartyak.Remove(kivalasztottKartya);
                lbCards.Items.Remove(kivalasztottKartya.Kartyaszam);
                KartyaFajlMentes(kartyak);

                String sikeresUzenet = "A kártya sikeresen törlésre került!";
                String sikeresCim = "Sikeres törlés!";

                MessageBox.Show(sikeresUzenet, sikeresCim);
            }
        }

        private void FoAblak_FormClosing(object sender, FormClosingEventArgs e)
        {
            String uzenet = "Biztosan ki szeretne lépni a programból?";
            String cim = "Kilépés megerősítése";
            MessageBoxButtons gombok = MessageBoxButtons.OKCancel;

            DialogResult eredmeny = MessageBox.Show(this, uzenet, cim, gombok);

            if (eredmeny != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
