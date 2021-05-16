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

        List<Tulajdonos> tulajdonosLista;
        Tulajdonos kivalasztottTulajdonos;

        public List<Kartya> ujKartyak = new List<Kartya>();

        public KartyaLetrehozas(List<Tulajdonos> tulajdonosok)
        {
            InitializeComponent();
            this.tulajdonosLista = tulajdonosok;

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
            if (ujKartyak.Count > 0)
            {
                ujKartyak.Clear();
            }
            this.Close();
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

            if (tulajdonosLetrehozas.ujTulajdonos != null)
            {
                StreamWriter tulajdonosStreamWriter = new StreamWriter("Tulajdonosok.txt", true);
                tulajdonosStreamWriter.WriteLine(tulajdonosLetrehozas.ujTulajdonos.ToString());
                tulajdonosStreamWriter.Close();
                tulajdonosLista.Add(tulajdonosLetrehozas.ujTulajdonos);
                lbTulajdonosok.Items.Add(tulajdonosLetrehozas.ujTulajdonos.Id + ": " + tulajdonosLetrehozas.ujTulajdonos.Nev);
            }
        }

        private void btnMentesKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMentesListaba_Click(object sender, EventArgs e)
        {
            //TODO: input checkek elkészítése

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

            ujKartyak.Add(kartya);

            tbBankkartyaSzam.Text = "";
            dtpLejarat.Text = "";
            tbCvc.Text = "";

            lbMentesreVar.Text = "Mentésre vár: "+ ujKartyak.Count +" db kártya";
        }
    }
}
