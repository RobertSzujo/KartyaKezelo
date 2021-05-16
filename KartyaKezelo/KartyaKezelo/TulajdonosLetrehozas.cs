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
            Tulajdonos tulajdonos = new Tulajdonos();
            tulajdonos.Id = tulajdonosLista.Last().Id + 1;
            tulajdonos.Nev = tbTulajdonosNeve.Text;
            tulajdonos.Email = tbTulajdonosEmail.Text;
            tulajdonos.Telefonszam = tbTulajdonosTel.Text;

            StreamWriter tulajdonosStreamWriter = new StreamWriter("Tulajdonosok.txt", true);
            tulajdonosStreamWriter.WriteLine(tulajdonos.ToString());
            tulajdonosStreamWriter.Close();

            this.Close();
        }
    }
}
