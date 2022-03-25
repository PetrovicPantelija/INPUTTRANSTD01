using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

using Microsoft.Reporting.WinForms;

namespace TrackModal.Dokumeta
{
    public partial class frmAutoprevozniList2 : Form
    {
        string KorisnikCene = "";
        bool status = false;
        int VoziloS = 0;
        int PriklucjucnoVoziloS = 0;
        int transportnidispecerS = 0;
        string mestoizdavanjaS = "";
        public frmAutoprevozniList2()
        {
            InitializeComponent();
        }


        public frmAutoprevozniList2(string Korisnik)
        {
            InitializeComponent();
            KorisnikCene = Korisnik;
        }

        

        public frmAutoprevozniList2(int sifra, string Korisnik)
        {
            InitializeComponent();
            txtSifra.Text = sifra.ToString();
            KorisnikCene = Korisnik;
            VratiPodatke(sifra);

        }


        public frmAutoprevozniList2(string NalogZaPrevozID, string PutniNalogID, string RAdniNalogID,  int VoziloP, string mestoizdavanjaP, int prikljucnovoziloP, int transportnidispecerP)
        {
            InitializeComponent();

            txtPutniNalogID.Text = NalogZaPrevozID;
            txtPutniNalogID.Text = PutniNalogID;
            txtRadniNalogID.Text = RAdniNalogID;

            VoziloS = Convert.ToInt32(VoziloP);
            PriklucjucnoVoziloS = Convert.ToInt32(prikljucnovoziloP);
            transportnidispecerS = Convert.ToInt32(transportnidispecerP);
            mestoizdavanjaS = mestoizdavanjaP;

            dtpDatumPrevoza.Value = DateTime.Now;
            VratiPodatkeNalogZaPrevoz(Convert.ToInt32(NalogZaPrevozID));
            VratiPodatkePutniNalog(Convert.ToInt32(PutniNalogID));
            if (txtSifra.Text != "")
            {
                VratiPodatke(Convert.ToInt32(txtSifra.Text));
            }

        }

        private void VratiPodatke(int ID)
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(s_connection);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT [ID] " + 
     " ,[IDPutniNalog]  ,[IDNalogZaPrevoz] ,[IDRadniNalog],[Platilac] " +
     " ,[Kontakt],[Vozilo]      ,[Dana] ,[UtovarnoMesto] " +
     " ,[IstovarnoMesto],[Primalac]      ,[Ugovor] ,[Ponuda] " +
     " ,[MestoIzdavanja]  ,[Datum] " +
  " FROM [dbo].[Autoprevoznilist] " +
             "   where ID = " + ID, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               // dtpDatum.Value = Convert.ToDateTime(dr["Datum"].ToString());
                txtUgovor.Text = dr["Ugovor"].ToString();
                txtPonuda.Text = dr["Ponuda"].ToString();
                txtPutniNalogID.Text = dr["IDPutniNalog"].ToString();
                txtPutniNalogID.Text = dr["IDNalogZaPrevoz"].ToString();
                txtRadniNalogID.Text = dr["IDRadniNalog"].ToString();
                cboPlatilac.SelectedValue = Convert.ToInt32(dr["Platilac"].ToString());
                cboVozilo.SelectedValue = Convert.ToInt32(dr["Vozilo"].ToString());
                dtpDatumPrevoza.Value = Convert.ToDateTime(dr["Dana"].ToString());
                txtKontaktOsoba.Text = dr["Kontakt"].ToString();
                txtPonuda.Text = dr["MestoIzdavanja"].ToString();
               // dtpDatumPrevoza.Value = Convert.ToDateTime(dr["DatumPrevoza"].ToString());
                txtUtovarnoMesto.Text = dr["UtovarnoMesto"].ToString();
                txtIstovarnoMesto.Text = dr["IstovarnoMesto"].ToString();
                cboPrimalac.SelectedValue = Convert.ToInt32(dr["Primalac"].ToString());
              
            }
            con.Close();
            VratiPodatkePutniNalog(Convert.ToInt32(txtPutniNalogID.Text));
         
            //VratiPodatkeRadniNalog();
        }

        private void VratiPodatkeNalogZaPrevoz(int ID)
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(s_connection);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT [ID] " +
          " ,[Relacija1] ,[Relacija2] ,[Platilac] ,[Primalac] " +
          " FROM [dbo].[NajavaPrevoza] " +
             "   where ID = " + ID, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // dtpDatum.Value = Convert.ToDateTime(dr["Datum"].ToString());
                txtRelacijaOd.Text = dr["Relacija1"].ToString();
                txtRelacijaDo.Text = dr["Relacija2"].ToString();
                cboPlatilac.SelectedValue = Convert.ToInt32(dr["Platilac"].ToString());
                cboPrimalac.SelectedValue = Convert.ToInt32(dr["Primalac"].ToString());

            }
            con.Close();
        }

        private void VratiPodatkePutniNalog(int ID)
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(s_connection);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT PutniNalog.[ID] , Vozilo,[PrikljucnoVoziloID], (Zaposleni.Ime + ' ' +Zaposleni.Prezime) as Vozac " +
          " FROM [dbo].[PutniNalog] " +
" inner join Zaposleni on Vozac = Zaposleni.ID " +
             "   where PutniNalog.ID = " + ID, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // dtpDatum.Value = Convert.ToDateTime(dr["Datum"].ToString());
                cboVozilo.SelectedValue = Convert.ToInt32(dr["Vozilo"].ToString());
                cboPlatilac.SelectedValue = Convert.ToInt32(dr["PrikljucnoVoziloID"].ToString());
                txtKontaktOsoba.Text = dr["Vozac"].ToString();
            }
            con.Close();
        }

        private void VratiPodatkeRadniNalog(int ID)
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(s_connection);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT [ID]       ,[MestoIzdavanja]   FROM [dbo].[RadniNalogTransport]" +
             "   where ID = " + ID, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // dtpDatum.Value = Convert.ToDateTime(dr["Datum"].ToString());
                txtPonuda.Text = dr["MestoIzdavanja"].ToString();
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtKontaktOsoba_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAutoprevozniList2_Load(object sender, EventArgs e)
        {
            var select9 = " Select Distinct ID, Naziv From Komitenti where Platilac = 1 order by Naziv";
            var s_connection9 = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection9 = new SqlConnection(s_connection9);
            var c9 = new SqlConnection(s_connection9);
            var dataAdapter9 = new SqlDataAdapter(select9, c9);

            var commandBuilder9 = new SqlCommandBuilder(dataAdapter9);
            var ds9 = new DataSet();
            dataAdapter9.Fill(ds9);
            cboPlatilac.DataSource = ds9.Tables[0];
            cboPlatilac.DisplayMember = "Naziv";
            cboPlatilac.ValueMember = "ID";

            var select10 = " Select Distinct ID, Naziv From Komitenti where Platilac = 1 order by Naziv";
            var s_connection10 = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection10 = new SqlConnection(s_connection9);
            var c10 = new SqlConnection(s_connection10);
            var dataAdapter10 = new SqlDataAdapter(select10, c10);

            var commandBuilder10 = new SqlCommandBuilder(dataAdapter10);
            var ds10 = new DataSet();
            dataAdapter10.Fill(ds10);
            cboPrimalac.DataSource = ds10.Tables[0];
            cboPrimalac.DisplayMember = "Naziv";
            cboPrimalac.ValueMember = "ID";


            var select1 = "select ID, RegistarskaOznaka from Vozila where RegistarskaOznaka is not null";

            var s_connection1 = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection1 = new SqlConnection(s_connection1);
            var c1 = new SqlConnection(s_connection1);
            var dataAdapter1 = new SqlDataAdapter(select1, c1);

            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            cboVozilo.DataSource = ds1.Tables[0];
            cboVozilo.DisplayMember = "RegistarskaOznaka";
            cboVozilo.ValueMember = "ID";


            var select2 = "select ID, RegistarskaOznaka from Vozila where RegistarskaOznaka is not null";

            var s_connection2 = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection2 = new SqlConnection(s_connection2);
            var c2 = new SqlConnection(s_connection2);
            var dataAdapter2 = new SqlDataAdapter(select2, c2);

            var commandBuilder2 = new SqlCommandBuilder(dataAdapter2);
            var ds2 = new DataSet();
            dataAdapter2.Fill(ds2);
            cboPlatilac.DataSource = ds2.Tables[0];
            cboPlatilac.DisplayMember = "RegistarskaOznaka";
            cboPlatilac.ValueMember = "ID";

            if (txtSifra.Text != "")
            {
                VratiPodatke(Convert.ToInt32(txtSifra.Text));

            }
            else
            {
                cboVozilo.SelectedValue = Convert.ToInt32(VoziloS);
                cboPlatilac.SelectedValue = Convert.ToInt32(PriklucjucnoVoziloS);
               // cboTransportniDispicer.SelectedValue = Convert.ToInt32(transportnidispecerS);
                txtPonuda.Text = mestoizdavanjaS;
            }

            this.reportViewer1.RefreshReport();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            status = true;
            txtSifra.Enabled = false;
        }
        private void VratiPodatkeMax()
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(s_connection);

            con.Open();

            SqlCommand cmd = new SqlCommand("select Max([ID]) as ID from AutoPrevozniList", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtSifra.Text = dr["ID"].ToString();
            }

            con.Close();
        }
        private void tsSave_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                Dokumeta.InsertAutoprevozniList ins = new InsertAutoprevozniList();
                ins.InsAutoprevozniList(Convert.ToInt32(txtPutniNalogID.Text), Convert.ToInt32(txtPutniNalogID.Text), Convert.ToInt32(txtRadniNalogID.Text), Convert.ToInt32(cboPlatilac.SelectedValue), txtKontaktOsoba.Text, Convert.ToInt32(cboVozilo.SelectedValue), Convert.ToDateTime(dtpDatumPrevoza.Value), txtUtovarnoMesto.Text, txtIstovarnoMesto.Text, Convert.ToInt32(cboPrimalac.SelectedValue), txtUgovor.Text, txtPonuda.Text, txtPonuda.Text, DateTime.Now);
                status = false;
                 VratiPodatkeMax();
            }
            else
            {

                if (status == true)
                {
                    Dokumeta.InsertAutoprevozniList upd = new InsertAutoprevozniList();
                    upd.UpdAutoprevozniList(Convert.ToInt32(txtSifra.Text), Convert.ToInt32(txtPutniNalogID.Text), Convert.ToInt32(txtPutniNalogID.Text), Convert.ToInt32(txtRadniNalogID.Text), Convert.ToInt32(cboPlatilac.SelectedValue), txtKontaktOsoba.Text, Convert.ToInt32(cboVozilo.SelectedValue), Convert.ToDateTime(dtpDatumPrevoza.Value), txtUtovarnoMesto.Text, txtIstovarnoMesto.Text, Convert.ToInt32(cboPrimalac.SelectedValue), txtUgovor.Text, txtPonuda.Text, txtPonuda.Text, DateTime.Now);
                    status = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TrackModalDataSet15TableAdapters.SelectAutoPrevozniListTableAdapter ta = new TrackModalDataSet15TableAdapters.SelectAutoPrevozniListTableAdapter();
            TrackModalDataSet15.SelectAutoPrevozniListDataTable dt = new TrackModalDataSet15.SelectAutoPrevozniListDataTable();


            ta.Fill(dt, Convert.ToInt32(txtSifra.Text));
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;

            ReportParameter[] par = new ReportParameter[1];
            par[0] = new ReportParameter("ID", txtSifra.Text);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "rptAutoprevozniList.rdlc";
            reportViewer1.LocalReport.SetParameters(par);
            reportViewer1.LocalReport.DataSources.Add(rds);
          
            reportViewer1.RefreshReport();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dokumeta.InsertAutoprevozniList ins = new InsertAutoprevozniList();
            ins.DelAutoprevozniListGeneralni(Convert.ToInt32(txtStavkaKameni.Text));
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            frmAutoprevozniList2 al2 = new frmAutoprevozniList2();
            this.Close();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAutoprevozniList2 al2 = new frmAutoprevozniList2();
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            frmAutoprevozniList2 al2 = new frmAutoprevozniList2();
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
