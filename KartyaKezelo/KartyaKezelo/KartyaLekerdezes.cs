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
    public partial class KartyaLekerdezes : Form
    {
        public KartyaLekerdezes(String kartyaszam, Kartya kartya)
        {
            InitializeComponent();
            tbKartyatipus.Text = Convert.ToString(kartya.Tipus);
            tbKartyaszam.Text = kartyaszam;
            tbLejarat.Text = kartya.Lejarat;
            tbLetiltva.Text = Convert.ToString(kartya.Letiltva);
            tbTulajdonosnev.Text = kartya.Tulajdonos.Nev;
            tbTulajdonosemail.Text = kartya.Tulajdonos.Email;
            tbTulajdonostel.Text = kartya.Tulajdonos.Telefonszam;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
