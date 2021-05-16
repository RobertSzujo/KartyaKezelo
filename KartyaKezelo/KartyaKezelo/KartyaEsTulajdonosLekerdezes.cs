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
    public partial class KartyaEsTulajdonosLekerdezes : KartyaLekerdezes
    {
        public KartyaEsTulajdonosLekerdezes(Kartya kartya) : base(kartya)
        {
            InitializeComponent();
            KartyaAdatokFeltoltese(kartya);
            TulajdonosAdatokFeltoltese(kartya.Tulajdonos);
        }

        private void TulajdonosAdatokFeltoltese(Tulajdonos tulajdonos)
        {
            tbTulajdonosNev.Text = tulajdonos.Nev;
            tbTulajdonosEmail.Text = tulajdonos.Email;
            tbTulajdonosTel.Text = tulajdonos.Telefonszam;
        }
    }
}
