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
    public partial class FormaSifrarnici : Form
    {
        public string Korisnik { get; private set; }

        public FormaSifrarnici()
        {
            InitializeComponent();
            CustomizeDesigne();
        }

        private void CustomizeDesigne()
        {
            panelSubZaposlSifr.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void FormaSifrarnici_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsZaposleniSifr_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubZaposlSifr);
        }

        private void btnsOstecenja_Click(object sender, EventArgs e)
        {
            Sifarnici.frmGreske greske = new Sifarnici.frmGreske(Korisnik);
            greske.Show();
        }

        private void btnsDelKontejnera_Click(object sender, EventArgs e)
        {
            Sifarnici.frmDelovi snac = new Sifarnici.frmDelovi(Korisnik);
            snac.Show();
        }

        private void btnsCena_Click(object sender, EventArgs e)
        {
            Sifarnici.frmCene frmcen = new Sifarnici.frmCene(Korisnik);
            frmcen.Show();
        }

        private void btnsTipCenovnika_Click(object sender, EventArgs e)
        {
            Sifarnici.frmTipCenovnika frmTC = new Sifarnici.frmTipCenovnika(Korisnik);
            frmTC.Show();
        }

        private void btnsPartneri_Click(object sender, EventArgs e)
        {
            Sifarnici.frmKomitent komitenti = new Sifarnici.frmKomitent(Korisnik);
            komitenti.Show();
        }

        private void btnsNacinDolOdl_Click(object sender, EventArgs e)
        {
            Sifarnici.frmNacinDolaskaOdlaska nac = new Sifarnici.frmNacinDolaskaOdlaska(Korisnik);
            nac.Show();
        }

        private void btnsStatusKontejnera_Click(object sender, EventArgs e)
        {
            Sifarnici.frmStatusRobe snac = new Sifarnici.frmStatusRobe(Korisnik);
            snac.Show();
        }

        private void btnsZaposleni_Click(object sender, EventArgs e)
        {
            Sifarnici.frmZaposleni zap = new Sifarnici.frmZaposleni(Korisnik);
            zap.Show();
        }

        private void btnszSkolskaSprema_Click(object sender, EventArgs e)
        {
            Sifarnici.frmSkolskaSprema skol = new Sifarnici.frmSkolskaSprema(Korisnik);
            skol.Show();
        }

        private void btnszsLekarskiPregled_Click(object sender, EventArgs e)
        {
            Sifarnici.frmLekarskiPregledi lek = new Sifarnici.frmLekarskiPregledi(Korisnik);
            lek.Show();
        }

        private void btnszsOrganizacioneJedinice_Click(object sender, EventArgs e)
        {
            Sifarnici.frmOrganizacionaJedinica orgJed = new Sifarnici.frmOrganizacionaJedinica(Korisnik);
            orgJed.Show();
        }

        private void btnszsLicenceSertifikati_Click(object sender, EventArgs e)
        {
            Sifarnici.frmLicenceISertifikati lic = new Sifarnici.frmLicenceISertifikati(Korisnik);
            lic.Show();
        }

        private void btnszsZastitnaOdeca_Click(object sender, EventArgs e)
        {
            Sifarnici.frmZastitnaOdeca zast = new Sifarnici.frmZastitnaOdeca(Korisnik);
            zast.Show();
        }

        private void btnszsStrucniIpit_Click(object sender, EventArgs e)
        {
            Sifarnici.frmStrucniIspiti sisp = new Sifarnici.frmStrucniIspiti(Korisnik);
            sisp.Show();
        }

        private void btnsVrstaRobe_Click(object sender, EventArgs e)
        {
            Sifarnici.frmVrstaRobe vr = new Sifarnici.frmVrstaRobe(Korisnik);
            vr.Show();
        }

        private void btnsTipKontenjera_Click(object sender, EventArgs e)
        {
            Sifarnici.frmTipKontejnera tkr = new Sifarnici.frmTipKontejnera(Korisnik);
            tkr.Show();
        }

        private void btnsSredstvaRada_Click(object sender, EventArgs e)
        {
            Dokumeta.frmVozila vozila = new Dokumeta.frmVozila(Korisnik);
            vozila.Show();
        }

        private void btnsStanice_Click(object sender, EventArgs e)
        {
            Sifarnici.frmStanice stanice = new Sifarnici.frmStanice(Korisnik);
            stanice.Show();
        }

        private void btnsPozicije_Click(object sender, EventArgs e)
        {
            Sifarnici.frmPozicija poz = new Sifarnici.frmPozicija(Korisnik);
            poz.Show();
        }

        private void btnsSkladišta_Click(object sender, EventArgs e)
        {
            Sifarnici.frmSkladista sklad = new Sifarnici.frmSkladista(Korisnik);
            sklad.Show();
        }

        private void btnsVrsteManipulacije_Click(object sender, EventArgs e)
        {
            Sifarnici.frmVrstaManipulacije frmvrman = new Sifarnici.frmVrstaManipulacije(Korisnik);
            frmvrman.Show();
        }

        private void btnsPredefinisanePoruke_Click(object sender, EventArgs e)
        {
            Sifarnici.frmPredefinisanePoruke predefinisane = new Sifarnici.frmPredefinisanePoruke();
            predefinisane.Show();
        }
    }
}
