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

        private Dictionary<int, Tulajdonos> tulajdonosLista;
        int tulajdonosId;
        Kartya kartya;

        public KartyaLetrehozas(Dictionary<int, Tulajdonos> tulajdonosok)
        {
            InitializeComponent();
            this.tulajdonosLista = tulajdonosok;
            
            foreach (KeyValuePair<int, Tulajdonos> tulajdonos in tulajdonosLista)
            {
                lbTulajdonosok.Items.Add(tulajdonos.Key + ": " + tulajdonos.Value.Nev);
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
                tulajdonosId = Convert.ToInt32(tulajdonosSor[0]);
                Tulajdonos tulajdonos = tulajdonosLista[tulajdonosId];

                tbTulajdonosNeve.Text = tulajdonos.Nev;
                tbTulajdonosEmail.Text = tulajdonos.Email;
                tbTulajdonosTel.Text = tulajdonos.Telefonszam;
            }
        }

        private void rbVisa_CheckedChanged(object sender, EventArgs e)
        {
            btnMentesKilepes.Enabled = true;
        }

        private void btnUjTulajdonos_Click(object sender, EventArgs e)
        {
            TulajdonosLetrehozas tulajdonosLetrehozas = new TulajdonosLetrehozas();
            tulajdonosLetrehozas.ShowDialog();
        }

        private void btnMentesKilepes_Click(object sender, EventArgs e)
        {
            //TODO: input checkek elkészítése

            String kartyatipus = "";
            if (rbMasterCard.Checked)
            {
                kartyatipus = "MasterCard";
                kartya = new MasterCardKartya();
            }
            else if (rbVisa.Checked)
            {
                kartyatipus = "VISA";
                kartya = new VisaKartya();
            }

            kartya.Lejarat = dtpLejarat.Text;
            kartya.Cvc = tbCvc.Text;
            kartya.Letiltva = false;

            StreamWriter kartyaStreamWriter = new StreamWriter("Kartyak.txt", true);
            kartyaStreamWriter.WriteLine(tbBankkartyaSzam.Text + "," + kartyatipus + "," + "altípus," + kartya.Lejarat + "," + kartya.Cvc + "," + kartya.Letiltva.ToString() + "," + tulajdonosId);
            kartyaStreamWriter.Close();

            this.Close();
        }
    }
}
