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
    public partial class FormaSkladistnoPoslovanje : Form
    {
        string Korisnik = "";

        public FormaSkladistnoPoslovanje()
        {
            InitializeComponent();
        }

        public FormaSkladistnoPoslovanje(string Logovan, int Lozinka)
        {
            InitializeComponent();
            Korisnik = Logovan;
        }

        private void btnspPregledPrijemaRaspored_Click(object sender, EventArgs e)
        {
            Promet.frmPregledSkladistePrijem ppr = new Promet.frmPregledSkladistePrijem(Korisnik);
            ppr.Show();
        }

        private void btnspPregMedjuPrijem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmSkladistePrijem spr = new Dokumeta.frmSkladistePrijem(Korisnik);
            spr.Show();
        }

        private void btnspPregPrometa_Click(object sender, EventArgs e)
        {
            Promet.frmPregledMedjuskladisniPrenos pprmp = new Promet.frmPregledMedjuskladisniPrenos(Korisnik);
            pprmp.Show();
        }

        private void btnspPregStanjZaliha_Click(object sender, EventArgs e)
        {
            Promet.frmMedjuskladisniPrenos mpr = new Promet.frmMedjuskladisniPrenos(Korisnik);
            mpr.Show();
        }

        private void btnspPregStanjZalMagacioner_Click(object sender, EventArgs e)
        {
            Promet.frmSkladisteOtprema sklOtp = new Promet.frmSkladisteOtprema(Korisnik);
            sklOtp.Show();
        }

        private void btnspPregPopListi_Click(object sender, EventArgs e)
        {
            Promet.frmPrometKontejnera prometkon = new Promet.frmPrometKontejnera(Korisnik);
            prometkon.Show();
        }

        private void btnspPrijemRaspored_Click(object sender, EventArgs e)
        {
            Promet.frmLager lager = new Promet.frmLager(Korisnik);
            lager.Show();
        }

        private void btnspMedjSklaPrenos_Click(object sender, EventArgs e)
        {
            Promet.frmPopis popis = new Promet.frmPopis(Korisnik);
            popis.Show();
        }

        private void btnspOtprManipulacija_Click(object sender, EventArgs e)
        {
            Promet.frmPopisPregled pl = new Promet.frmPopisPregled();
            pl.Show();
        }

        private void btnspPopisLista_Click(object sender, EventArgs e)
        {
            Promet.frmLagerOperater lager = new Promet.frmLagerOperater();
            lager.Show();
        }
    }
}
