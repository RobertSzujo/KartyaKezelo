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
        private Dictionary<int, Tulajdonos> tulajdonosok;
        private Dictionary<String, Kartya> kartyak;

        public FoAblak()
        {
            InitializeComponent();
            tulajdonosok = TulajdonosokBetoltese();
            kartyak = KartyakBetoltese();
            
            foreach (String kartyaszam in kartyak.Keys)
            {
                lbCards.Items.Add(kartyaszam);
            }
        }

        private Dictionary<int, Tulajdonos> TulajdonosokBetoltese()
        {
            Dictionary <int, Tulajdonos> tulajdonosok = new Dictionary<int, Tulajdonos>();
            StreamReader tulajdonosStreamReader = new StreamReader("Tulajdonosok.txt");
            while (!tulajdonosStreamReader.EndOfStream)
            {
                string[] sor = tulajdonosStreamReader.ReadLine().Split(',');
                Tulajdonos tulajdonos = new Tulajdonos();
                tulajdonos.Nev = sor[1];
                tulajdonos.Email = sor[2];
                tulajdonos.Telefonszam = sor[3];

                tulajdonosok.Add(int.Parse(sor[0]), tulajdonos);
            }
            tulajdonosStreamReader.Close();

            return tulajdonosok;
        }

        private Dictionary<String, Kartya> KartyakBetoltese()
        {
            Dictionary <String, Kartya> kartyak = new Dictionary<String, Kartya>();
            StreamReader kartyaStreamReader = new StreamReader("Kartyak.txt");
            while (!kartyaStreamReader.EndOfStream)
            {
                string[] sor = kartyaStreamReader.ReadLine().Split(',');
                Kartya kartya = new Kartya();
                kartya.Tipus = (Tipus)Enum.Parse(typeof(Tipus), sor[1]);
                kartya.Lejarat = sor[2];
                kartya.Letiltva = bool.Parse(sor[3]);
                kartya.Tulajdonos = tulajdonosok[int.Parse(sor[4])];

                kartyak.Add(sor[0], kartya);
            }
            kartyaStreamReader.Close();

            return kartyak;

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

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KartyaLetrehozas kartyaLetrehozas = new KartyaLetrehozas();
            kartyaLetrehozas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String kartyaszam = lbCards.SelectedItem.ToString();
            KartyaLekerdezes kartyaLekerdezes = new KartyaLekerdezes(kartyaszam, kartyak[kartyaszam]);
            kartyaLekerdezes.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbKartyaszam.Text = lbCards.SelectedItem.ToString();
            tbKartyatulajdonos.Text = kartyak[lbCards.SelectedItem.ToString()].Tulajdonos.Nev;

            btnShowCardDetails.Enabled = true;
            //Ezeket még el kell készíteni!
            btnDisableCard.Enabled = false;
            btnRemoveCard.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
