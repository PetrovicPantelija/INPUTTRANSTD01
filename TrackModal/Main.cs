using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Configuration;

using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using TrackModal.Dokumeta;
using TrackModal.Izvestaji;
using FontAwesome.Sharp;
using TrackModal.MeniForme;

namespace TrackModal
{
    public partial class Main : Form
    {
        //Polja
        private IconButton curentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        string Korisnik = "";

        //Konstruktor za dizajn
        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            PanelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Struktura za boje
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(2, 140, 243);
            public static Color color2 = Color.FromArgb(8, 153, 232);
            public static Color color3 = Color.FromArgb(15, 167, 222);
            public static Color color4 = Color.FromArgb(21, 180, 211);
            public static Color color5 = Color.FromArgb(28, 194, 200);
            public static Color color6 = Color.FromArgb(34, 207, 189);
            public static Color color7 = Color.FromArgb(41, 221, 179);
            public static Color color8 = Color.FromArgb(47, 234, 168);
        }

        //metoda
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                curentBtn = (IconButton)senderBtn;
                curentBtn.BackColor = Color.FromArgb(82, 108, 120);
                curentBtn.ForeColor = color;
                curentBtn.TextAlign = ContentAlignment.MiddleCenter;
                curentBtn.IconColor = color;
                curentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                curentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //left border btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, curentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon curent child form
                iconCurentChildForm.IconChar = curentBtn.IconChar;
                iconCurentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (curentBtn != null)
            {
                curentBtn.BackColor = Color.FromArgb(69, 90, 100);
                curentBtn.ForeColor = Color.White;
                curentBtn.TextAlign = ContentAlignment.MiddleLeft;
                curentBtn.IconColor = Color.White;
                curentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                curentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //otvaranje samo jedne forme
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitlechildForm.Text = childForm.Text;
        }
 
        public Main(string Logovan, int Lozinka)
        {
            InitializeComponent();
            Korisnik = Logovan;
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void kOMITENTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmTipCenovnika frmTC = new Sifarnici.frmTipCenovnika(Korisnik);
            frmTC.Show();
        }

        private void ceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmCene frmcen = new Sifarnici.frmCene(Korisnik);
            frmcen.Show();
        }

        private void nHMToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //panta
        }

        private void komitentiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sifarnici.frmKomitent komitenti = new Sifarnici.frmKomitent(Korisnik);
            komitenti.Show();
        }

        private void načinDolaskaOdlaskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmNacinDolaskaOdlaska nac = new Sifarnici.frmNacinDolaskaOdlaska(Korisnik);
            nac.Show();
        }

        private void statusRobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmStatusRobe snac = new Sifarnici.frmStatusRobe(Korisnik);
            snac.Show();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmZaposleni zap = new Sifarnici.frmZaposleni(Korisnik);
            zap.Show();
        }

        private void vrstaRobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmVrstaRobe vr = new Sifarnici.frmVrstaRobe(Korisnik);
            vr.Show();
        }

        private void kontejneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmTipKontejnera tkr = new Sifarnici.frmTipKontejnera(Korisnik);
            tkr.Show();
        }

        private void skladištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmSkladista sklad = new Sifarnici.frmSkladista(Korisnik);
            sklad.Show();
        }

        private void pozicijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmPozicija poz = new Sifarnici.frmPozicija(Korisnik);
            poz.Show();
        }

        private void vozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmVozila vozila = new Dokumeta.frmVozila(Korisnik);
            vozila.Show();
        }

        private void vozoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmVoz vozovi = new Dokumeta.frmVoz(Korisnik);
            vozovi.Show();
        }

        private void bukingVozaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmBukingVoza buking = new Dokumeta.frmBukingVoza(Korisnik);
            buking.Show();
        }

        private void formeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmForme forme = new Sifarnici.frmForme(Korisnik);
            forme.Show();
        }

        private void prijemVozaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPrijemVozomPregled voz = new Dokumeta.frmPrijemVozomPregled(Korisnik);
            voz.Show();
        }

        private void prijemKamionomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPrijemKontejneraKamionom kamion = new Dokumeta.frmPrijemKontejneraKamionom(Korisnik);
            kamion.Show();
        }
 
        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dodeljivanjePravaPristupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmPravoPristupaFormi ppf = new Sifarnici.frmPravoPristupaFormi(Korisnik);
            ppf.Show();
        }

        private void pristupFormiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rasporedManipulacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmManipulacije man = new Dokumeta.frmManipulacije(Korisnik);
            man.Show();
        }

        private void vrsteManipulacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void otpremaVozomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledOtpreme otprema = new Dokumeta.frmPregledOtpreme(Korisnik);
            otprema.Show();
        }

        private void prijemRasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmSkladistePrijem spr = new Dokumeta.frmSkladistePrijem(Korisnik);
            spr.Show();
        }

        private void međuskladišniPrenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmMedjuskladisniPrenos mpr = new Promet.frmMedjuskladisniPrenos(Korisnik);
            mpr.Show();
        }

        private void pregledStanjaZalihaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmLager lager = new Promet.frmLager(Korisnik);
            lager.Show();
        }

        private void pregledPrometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmPrometKontejnera prometkon = new Promet.frmPrometKontejnera(Korisnik);
            prometkon.Show();
        }

        private void dodatniListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaji.frmDodatniList dodlist = new Izvestaji.frmDodatniList();
            dodlist.Show();
        }

        private void školskaSpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmSkolskaSprema skol = new Sifarnici.frmSkolskaSprema(Korisnik);
            skol.Show();
        }

        private void lekarskiPreglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmLekarskiPregledi lek = new Sifarnici.frmLekarskiPregledi(Korisnik);
            lek.Show();
        }

        private void organizacioneJediniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmOrganizacionaJedinica orgJed = new Sifarnici.frmOrganizacionaJedinica(Korisnik);
            orgJed.Show();
        }

        private void licenceISertifikatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmLicenceISertifikati lic = new Sifarnici.frmLicenceISertifikati(Korisnik);
            lic.Show();
        }

        private void opremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmZastitnaOdeca zast = new Sifarnici.frmZastitnaOdeca(Korisnik);
            zast.Show();
        }

        private void stručniIspitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmStrucniIspiti sisp = new Sifarnici.frmStrucniIspiti(Korisnik);
            sisp.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPrijemKontejneraKamionPregled prkamion = new Dokumeta.frmPrijemKontejneraKamionPregled(Korisnik);
            prkamion.Show();
        }

        private void staniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmStanice stanice = new Sifarnici.frmStanice(Korisnik);
            stanice.Show();
        }

        private void vrsteManipulacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sifarnici.frmVrstaManipulacije frmvrman = new Sifarnici.frmVrstaManipulacije(Korisnik);
            frmvrman.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledVozova pvoz = new Dokumeta.frmPregledVozova(Korisnik);
            pvoz.Show();
        }

        private void otpremaKontejneraKamionomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledOtpremeKamionom pkam = new Dokumeta.frmPregledOtpremeKamionom(Korisnik);
            pkam.Show();
        }

        private void pregledManipulacijaPoPrevozuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledNarucenihManipulacija pnman = new Dokumeta.frmPregledNarucenihManipulacija(Korisnik);
            pnman.Show();
        }

        private void pregledPrijemaRasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmPregledSkladistePrijem ppr = new Promet.frmPregledSkladistePrijem(Korisnik);
            ppr.Show();
        }

        private void pregledMeđuskladišniPoPrijemuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmPregledMedjuskladisniPrenos pprmp = new Promet.frmPregledMedjuskladisniPrenos(Korisnik);
            pprmp.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo- šifarnici.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void prevozToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo- prevoz.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void skladištaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sifarnici.frmSkladista sklad = new Sifarnici.frmSkladista(Korisnik);
            sklad.Show();
        }

        private void pozicijeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sifarnici.frmPozicija poz = new Sifarnici.frmPozicija(Korisnik);
            poz.Show();
        }

        private void popisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmPopis popis = new Promet.frmPopis(Korisnik);
            popis.Show();
        }

        private void manipulacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo - manipulacije.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Sifarnici.frmDelovi snac = new Sifarnici.frmDelovi(Korisnik);
            snac.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Sifarnici.frmGreske greske = new Sifarnici.frmGreske(Korisnik);
            greske.Show();
        }

        private void skladišnoPoslovanjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo - Skladišno poslovanje.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pregledNaloziZaPrevozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledNaloziZaPrevoz preg = new frmPregledNaloziZaPrevoz();
            preg.Show();
        }

        private void pregledPutniNaloziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPutniNalog put = new frmPutniNalog(Korisnik);
            put.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmPregledNaloziZaPrevoz preg = new frmPregledNaloziZaPrevoz(Korisnik);
            preg.Show();
        }

        private void merskPregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMersk mersk = new frmMersk();
            mersk.Show();
        }

        private void cMACGAPregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCMACGA cma= new frmCMACGA();
            cma.Show();
        }

        private void pregledManipulacijaPoPartneruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledManipulacijaPoPartneru mpp = new frmPregledManipulacijaPoPartneru();
            mpp.Show();
        }

        private void izveštajiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo – Izvestaji.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cOSCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCosco cosco = new frmCosco();
            cosco.Show();
        }

        private void pregledCIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCIRPregled frmCIRPregled = new frmCIRPregled();
            frmCIRPregled.Show();
        }

        private void menadžerVozoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenadadzerPoVozu mpv = new frmMenadadzerPoVozu();
            mpv.Show();
        }

        private void menadžerKamioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenadzerPoKamionima mpk = new frmMenadzerPoKamionima();
            mpk.Show();
        }

        private void menadžerSaManipulacijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManipulacijeGrupno fmpm = new frmManipulacijeGrupno();
            fmpm.Show();
        }

        private void metadžerPretovarenoPoOrganizatoruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenadzerPretovar mpret = new frmMenadzerPretovar();
            mpret.Show();
        }

        private void otpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmSkladisteOtprema sklOtp = new Promet.frmSkladisteOtprema(Korisnik);
            sklOtp.Show();
        }

        private void punoPraznoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenadzerPunoPrazno ppm = new frmMenadzerPunoPrazno();
            ppm.Show();
        }

        private void pregledPopisnihListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmPopisPregled pl = new Promet.frmPopisPregled();
            pl.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmPutniNalog pn = new frmPutniNalog();
            pn.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmRadniNalogTransport rnt = new frmRadniNalogTransport();
            rnt.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmNalogZaPrevoz nzp = new frmNalogZaPrevoz(Korisnik);
            nzp.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmPregledPutnihNaloga ppn = new frmPregledPutnihNaloga();
            ppn.Show();
        }

        private void menadžerKamioniPoŠpediteruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenadzerPoKamionuSpediter pmpkm = new frmMenadzerPoKamionuSpediter();
            pmpkm.Show();
        }

        private void autoprevozničkiListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutoprevozniList2 apl = new frmAutoprevozniList2();
            apl.Show();
        }

        private void pregledRadniNaloziTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledRadniNaloziTransport prnt = new frmPregledRadniNaloziTransport();
            prnt.Show();
        }

        private void pregledAutoprevoznihListovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledAutoPrevozniList pautp = new frmPregledAutoPrevozniList();
            pautp.Show();
        }

        private void tovarniListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void kvaroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectTransport6 kvarovi = new frmSelectTransport6();
            kvarovi.Show();
        }

        private void vozačiPoRutama5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectTransport5 trans = new frmSelectTransport5();
            trans.Show();
        }

        private void vozilaPoPN4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectTransport4 trans4 = new frmSelectTransport4();
            trans4.Show();
        }

        private void turePoRelaciji3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectTransport3 trans3 = new frmSelectTransport3();
            trans3.Show();
        }

        private void poTipuKontejnera2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectTransport2 trans2 = new frmSelectTransport2();
            trans2.Show();
        }

        private void kameniAgregat1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectTransport1 trans1 = new frmSelectTransport1();
            trans1.Show();
        }

        private void pregledTovarnihListovaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tovarniListoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTovarniList tovl = new frmTovarniList();
            tovl.Show();
        }

        private void pregledTovarniListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledTovarnihListova ptl = new frmPregledTovarnihListova();
            ptl.Show();
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\KorisnickoUpustvoTransport.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pregledStanjaZalihaMagacionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promet.frmLagerOperater lager = new Promet.frmLagerOperater();
            lager.Show();
        }

        private void predefinisanePorukeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnici.frmPredefinisanePoruke predefinisane = new Sifarnici.frmPredefinisanePoruke();
            predefinisane.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSifrarnici_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormaSifrarnici());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormaPrevoz());

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormaManipulacije());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormaSkladistnoPoslovanje());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormaTransport());

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormaAdministracija());

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new FormaIzvestaj());

        }


        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormaPomoc());
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurentChildForm.IconChar = IconChar.Home;
            iconCurentChildForm.IconColor = Color.FromArgb(180, 193, 204);
            lblTitlechildForm.Text = "Početna";
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
