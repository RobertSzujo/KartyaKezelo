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
            ujTulajdonos = new Tulajdonos();

            if (tulajdonosLista.Count > 0)
            {
                ujTulajdonos.Id = tulajdonosLista.Last().Id + 1;
            }
            else
            {
                ujTulajdonos.Id = 1;
            }
            ujTulajdonos.Nev = tbTulajdonosNeve.Text;
            ujTulajdonos.Email = tbTulajdonosEmail.Text;
            ujTulajdonos.Telefonszam = tbTulajdonosTel.Text;

            this.Close();
        }

    }
}
