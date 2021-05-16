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
            this.Close();
        }

        private void rbMasterCard_CheckedChanged(object sender, EventArgs e)
        {
            btnMentesKilepes.Enabled = true;
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
            btnMentesKilepes.Enabled = true;
        }

        private void btnUjTulajdonos_Click(object sender, EventArgs e)
        {
            TulajdonosLetrehozas tulajdonosLetrehozas = new TulajdonosLetrehozas(tulajdonosLista);
            tulajdonosLetrehozas.ShowDialog();

            lbTulajdonosok.Items.Clear();
            TulajdonosokFeltoltese();
        }

        private void btnMentesKilepes_Click(object sender, EventArgs e)
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

            StreamWriter kartyaStreamWriter = new StreamWriter("Kartyak.txt", true);
            kartyaStreamWriter.WriteLine(kartya.ToString());
            kartyaStreamWriter.Close();

            this.Close();
        }
    }
}
