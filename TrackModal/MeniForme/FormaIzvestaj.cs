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
    public partial class FormaIzvestaj : Form
    {
        public FormaIzvestaj()
        {
            InitializeComponent();
        }


        private void btniDodatniList_Click(object sender, EventArgs e)
        {
            Izvestaji.frmDodatniList dodlist = new Izvestaji.frmDodatniList();
            dodlist.Show();
        }

        private void btniMERSKPregled_Click(object sender, EventArgs e)
        {
            Izvestaji.frmMersk mersk = new Izvestaji.frmMersk();
            mersk.Show();
        }

        private void btniCMACGAPregled_Click(object sender, EventArgs e)
        {
            Izvestaji.frmCMACGA cma = new Izvestaji.frmCMACGA();
            cma.Show();
        }

        private void btniCIRPregled_Click(object sender, EventArgs e)
        {

            Dokumeta.frmCIRPregled frmCIRPregled = new Dokumeta.frmCIRPregled();
            frmCIRPregled.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Izvestaji.frmCosco cosco = new Izvestaji.frmCosco();
            cosco.Show();
        }

        private void btniMenadzerVozovi_Click(object sender, EventArgs e)
        {
            Izvestaji.frmMenadadzerPoVozu mpv = new Izvestaji.frmMenadadzerPoVozu();
            mpv.Show();
        }

        private void BtniMenadzerKPS_Click(object sender, EventArgs e)
        {
            Izvestaji.frmMenadzerPoKamionuSpediter pmpkm = new Izvestaji.frmMenadzerPoKamionuSpediter();
            pmpkm.Show();
        }

        private void btniMenadzerKamioni_Click(object sender, EventArgs e)
        {
            Izvestaji.frmMenadzerPoKamionima mpk = new Izvestaji.frmMenadzerPoKamionima();
            mpk.Show();
        }

        private void BtniMenadzerManipulacije_Click(object sender, EventArgs e)
        {
            Izvestaji.frmManipulacijeGrupno fmpm = new Izvestaji.frmManipulacijeGrupno();
            fmpm.Show();
        }

        private void btniCOSCO_Click(object sender, EventArgs e)
        {
            Izvestaji.frmMenadzerPretovar mpret = new Izvestaji.frmMenadzerPretovar();
            mpret.Show();
        }

        private void btniMenadzerPunoPrazno_Click(object sender, EventArgs e)
        {
            Izvestaji.frmMenadzerPunoPrazno ppm = new Izvestaji.frmMenadzerPunoPrazno();
            ppm.Show();
        }
    }
}
