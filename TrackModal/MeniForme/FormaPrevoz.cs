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
    public partial class FormaPrevoz : Form
    {
        string Korisnik = "";

        public FormaPrevoz()
        {
            InitializeComponent();
        }

        public FormaPrevoz(string Logovan, int Lozinka)
        {
            InitializeComponent();
            Korisnik = Logovan;
        }

        private void btnprVozovi_Click(object sender, EventArgs e)
        {
            Dokumeta.frmVoz vozovi = new Dokumeta.frmVoz(Korisnik);
            vozovi.Show();
        }

        private void btnprPregledVozovi_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledVozova pvoz = new Dokumeta.frmPregledVozova(Korisnik);
            pvoz.Show();
        }

        private void btnprPrijemKotejnera_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPrijemKontejneraKamionPregled prkamion = new Dokumeta.frmPrijemKontejneraKamionPregled(Korisnik);
            prkamion.Show();
        }

        private void btnprPrijemKotejneraVozom_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPrijemVozomPregled voz = new Dokumeta.frmPrijemVozomPregled(Korisnik);
            voz.Show();
        }

        private void btnprBukingVoza_Click(object sender, EventArgs e)
        {
            Dokumeta.frmBukingVoza buking = new Dokumeta.frmBukingVoza(Korisnik);
            buking.Show();
        }

        private void btnorOtpremaKontejneraVoz_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledOtpreme otprema = new Dokumeta.frmPregledOtpreme(Korisnik);
            otprema.Show();
        }

        private void btnprPtpremaKontejneraKamion_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledOtpremeKamionom pkam = new Dokumeta.frmPregledOtpremeKamionom(Korisnik);
            pkam.Show();
        }

        private void btnprPregledNaloziPrevoz_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledNaloziZaPrevoz preg = new Dokumeta.frmPregledNaloziZaPrevoz();
            preg.Show();
        }

        private void btnprPregledPutniNalozi_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPutniNalog put = new Dokumeta.frmPutniNalog(Korisnik);
            put.Show();
        }

        private void btnprPregledtovarniList_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledTovarnihListova ptl = new Dokumeta.frmPregledTovarnihListova();
            ptl.Show();
        }
    }
}
