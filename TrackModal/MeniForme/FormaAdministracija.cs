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
    public partial class FormaAdministracija : Form
    {
        string Korisnik = "";

        public FormaAdministracija()
        {
            InitializeComponent();
        }

        public FormaAdministracija(string Logovan, int Lozinka)
        {
            InitializeComponent();
            Korisnik = Logovan;
        }

        private void btnaKorisnici_Click(object sender, EventArgs e)
        {
            if (Korisnik != "M.Jelisavčić" && Korisnik != "Kecman")
            {

            }
            else
            {
                Sifarnici.frmKorisnici kor = new Sifarnici.frmKorisnici(Korisnik);
                kor.Show();
            }
        }

        private void btnaDodavanjePristupa_Click(object sender, EventArgs e)
        {
            Sifarnici.frmPravoPristupaFormi ppf = new Sifarnici.frmPravoPristupaFormi(Korisnik);
            ppf.Show();
        }

        private void BtnaForme_Click(object sender, EventArgs e)
        {
            Sifarnici.frmForme forme = new Sifarnici.frmForme(Korisnik);
            forme.Show();
        }

        private void BtnaDodavanjeKorisnika_Click(object sender, EventArgs e)
        {

        }
    }
}
