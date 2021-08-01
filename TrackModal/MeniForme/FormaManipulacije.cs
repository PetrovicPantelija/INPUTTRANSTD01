using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackModal.MeniForme
{
    public partial class FormaManipulacije : Form
    {
        string Korisnik = "";

        public FormaManipulacije()
        {
            InitializeComponent();
        }

        public FormaManipulacije(string Logovan, int Lozinka)
        {
            InitializeComponent();
            Korisnik = Logovan;
        }

        private void btnmRasporedManipulacija_Click(object sender, EventArgs e)
        {
            Dokumeta.frmManipulacije man = new Dokumeta.frmManipulacije(Korisnik);
            man.Show();
        }

        private void btnmPregManPrevoz_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledNarucenihManipulacija pnman = new Dokumeta.frmPregledNarucenihManipulacija(Korisnik);
            pnman.Show();
        }

        private void btnmPregManPartneru_Click(object sender, EventArgs e)
        {
            Izvestaji.frmPregledManipulacijaPoPartneru mpp = new Izvestaji.frmPregledManipulacijaPoPartneru();
            mpp.Show();
        }
    }
}
