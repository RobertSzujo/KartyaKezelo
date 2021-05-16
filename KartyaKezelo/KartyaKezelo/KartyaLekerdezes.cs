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
        public KartyaLekerdezes(Kartya kartya)
        {
            InitializeComponent();
            KartyaAdatokFeltoltese(kartya);
        }

        protected void KartyaAdatokFeltoltese(Kartya kartya)
        {
            tbKartyaszam.Text = kartya.Kartyaszam;
            tbLejarat.Text = kartya.Lejarat;
            tbLetiltva.Text = Convert.ToString(kartya.Letiltva);
            tbCvc.Text = kartya.Cvc;

            if (kartya.GetType() == typeof(MasterCardKartya))
            {
                tbKartyatipus.Text = "MasterCard";
            }
            else if (kartya.GetType() == typeof(VisaKartya))
            {
                tbKartyatipus.Text = "VISA";
            }
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
