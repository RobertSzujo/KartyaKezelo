using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartyaKezelo
{
    public partial class KartyaLetrehozas : Form
    {

        private Dictionary<int, Tulajdonos> tulajdonosLista;

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

        }

        private void lbTulajdonosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTulajdonosok.SelectedItem != null)
            {
                String[] tulajdonosSor = lbTulajdonosok.SelectedItem.ToString().Split(':');
                int tulajdonosId = Convert.ToInt32(tulajdonosSor[0]);
                Tulajdonos tulajdonos = tulajdonosLista[tulajdonosId];

                tbTulajdonosNeve.Text = tulajdonos.Nev;
                tbTulajdonosEmail.Text = tulajdonos.Email;
                tbTulajdonosTel.Text = tulajdonos.Telefonszam;
            }
        }
    }
}
