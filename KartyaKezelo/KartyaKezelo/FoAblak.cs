﻿using System;
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

                    //TODO: altípus hozzáadása (vagy kitörlése teljesen)

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

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KartyaLetrehozas kartyaLetrehozas = new KartyaLetrehozas(tulajdonosok);
            kartyaLetrehozas.ShowDialog();

            if (kartyaLetrehozas.ujKartyak.Count > 0)
            {
                StreamWriter kartyaStreamWriter = new StreamWriter("Kartyak.txt", true);
                foreach (Kartya ujKartya in kartyaLetrehozas.ujKartyak)
                {
                    kartyaStreamWriter.WriteLine(ujKartya.ToString());
                }
                kartyaStreamWriter.Close();
            }

            AdatokUritese();
            AdatokBetoltese();

        }

        private void AdatokUritese()
        {
            if (kartyak.Count > 0)
            {
                kartyak.Clear();
            }
            if (tulajdonosok.Count > 0)
            {
                tulajdonosok.Clear();
            }
            if (lbCards.Items.Count > 0)
            {
                lbCards.Items.Clear();
            }
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
            KartyaLekerdezes kartyaLekerdezes = new KartyaLekerdezes(kivalasztottKartya);
            kartyaLekerdezes.ShowDialog();
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

                btnShowCardDetails.Enabled = true;
                //Ezeket még el kell készíteni!
                btnDisableCard.Enabled = false;
                btnRemoveCard.Enabled = false;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
