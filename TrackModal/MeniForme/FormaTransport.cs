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
    public partial class FormaTransport : Form
    {
        string Korisnik = "";

        public FormaTransport()
        {
            InitializeComponent();
            CustomizeDesigne();
        }

        public FormaTransport(string Logovan, int Lozinka)
        {
            InitializeComponent();
            Korisnik = Logovan;
        }


        private void CustomizeDesigne()
        {
            panel2SubMenu.Visible = false;
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

        private void btntIzvestaji_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel2SubMenu);
        }

        private void btnpPregNaloziPrevoz_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledNaloziZaPrevoz preg = new Dokumeta.frmPregledNaloziZaPrevoz(Korisnik);
            preg.Show();
        }

        private void btntNaloziPrevoz_Click(object sender, EventArgs e)
        {
            Dokumeta.frmNalogZaPrevoz nzp = new Dokumeta.frmNalogZaPrevoz(Korisnik);
            nzp.Show();
        }

        private void btntpPregPutNalozi_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledPutnihNaloga ppn = new Dokumeta.frmPregledPutnihNaloga();
            ppn.Show();
        }

        private void btntPutniNalozi_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPutniNalog pn = new Dokumeta.frmPutniNalog();
            pn.Show();
        }

        private void btntPregRadniNalTransport_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledRadniNaloziTransport prnt = new Dokumeta.frmPregledRadniNaloziTransport();
            prnt.Show();
        }

        private void btntRadniNalozi_Click(object sender, EventArgs e)
        {
            Dokumeta.frmRadniNalogTransport rnt = new Dokumeta.frmRadniNalogTransport();
            rnt.Show();
        }

        private void btnpAutoprevoynickiList_Click(object sender, EventArgs e)
        {
            Dokumeta.frmAutoprevozniList2 apl = new Dokumeta.frmAutoprevozniList2();
            apl.Show();
        }

        private void btnpPregAutoListova_Click(object sender, EventArgs e)
        {
            Dokumeta.frmPregledAutoPrevozniList pautp = new Dokumeta.frmPregledAutoPrevozniList();
            pautp.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Izvestaji.frmSelectTransport1 trans1 = new Izvestaji.frmSelectTransport1();
            trans1.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Izvestaji.frmSelectTransport6 kvarovi = new Izvestaji.frmSelectTransport6();
            kvarovi.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Izvestaji.frmSelectTransport5 trans = new Izvestaji.frmSelectTransport5();
            trans.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Izvestaji.frmSelectTransport3 trans3 = new Izvestaji.frmSelectTransport3();
            trans3.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Izvestaji.frmSelectTransport4 trans4 = new Izvestaji.frmSelectTransport4();
            trans4.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Izvestaji.frmSelectTransport2 trans2 = new Izvestaji.frmSelectTransport2();
            trans2.Show();
        }
    }
}
