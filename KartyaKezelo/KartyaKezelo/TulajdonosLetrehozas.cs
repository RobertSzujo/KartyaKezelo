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
    public partial class TulajdonosLetrehozas : Form
    {
        List<Tulajdonos> tulajdonosLista;

        private Tulajdonos tulajdonos;
        public Tulajdonos ujTulajdonos;
        public TulajdonosLetrehozas(List<Tulajdonos> tulajdonosok)
        {
            InitializeComponent();
            this.tulajdonosLista = tulajdonosok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMentesKilepes_Click(object sender, EventArgs e)
        {
            tulajdonos = new Tulajdonos();

            if (tulajdonosLista.Count > 0)
            {
                tulajdonos.Id = tulajdonosLista.Last().Id + 1;
            }
            else
            {
                tulajdonos.Id = 1;
            }
            tulajdonos.Nev = tbTulajdonosNeve.Text;
            tulajdonos.Email = tbTulajdonosEmail.Text;
            tulajdonos.Telefonszam = tbTulajdonosTel.Text;

            String ellenorzesEredmeny = tulajdonos.TulajdonosEllenorzes();
            if (ellenorzesEredmeny.Equals("OK"))
            {
                string uzenet = "A tulajdonos sikeresen mentésre került!";
                string cim = "Sikeres mentés";

                MessageBox.Show(uzenet, cim);
                ujTulajdonos = tulajdonos;
                this.Close();
            }
            else
            {
                string cim = "Sikertelen mentés";
                MessageBox.Show(ellenorzesEredmeny, cim);
            }
        }

    }
}
