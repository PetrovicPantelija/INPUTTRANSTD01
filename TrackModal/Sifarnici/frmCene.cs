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
//PANTA
namespace TrackModal.Sifarnici
{
    public partial class frmCene : Form
    {
        string KorisnikCene;
        public frmCene()
        {
            InitializeComponent();
        }
        bool status = false;
         public frmCene(string Korisnik)
        {
            InitializeComponent();
            KorisnikCene = Korisnik;
        }

         private void tsNew_Click(object sender, EventArgs e)
         {
             status = true;
         }

         private void RefreshDataGrid()
         {
             var select = " SELECT Cene.[ID] as ID ,[TipCenovnika].Naziv as TipCenovnika,[Komitenti].Naziv as Partner,[Cena],Cena2,[VrstaManipulacije].Naziv as VrstaManipulacije,Cene.[Datum],Cene.[Korisnik] FROM [dbo].[Cene] " +
             " inner join TipCenovnika on TipCenovnika.ID = Cene.TipCenovnika " +
             " inner join Komitenti on Komitenti.ID = Cene.Komitent " +
             " inner join VrstaManipulacije on VrstaManipulacije.Id = Cene.VrstaManipulacije order by ID desc";
             var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection myConnection = new SqlConnection(s_connection);
             var c = new SqlConnection(s_connection);
             var dataAdapter = new SqlDataAdapter(select, c);

             var commandBuilder = new SqlCommandBuilder(dataAdapter);
             var ds = new DataSet();
             dataAdapter.Fill(ds);
             dataGridView1.ReadOnly = true;
             dataGridView1.DataSource = ds.Tables[0];

             //string value = dataGridView3.Rows[0].Cells[0].Value.ToString();
             DataGridViewColumn column = dataGridView1.Columns[0];
             dataGridView1.Columns[0].HeaderText = "ID";
             dataGridView1.Columns[0].Width = 40;

             DataGridViewColumn column2 = dataGridView1.Columns[1];
             dataGridView1.Columns[1].HeaderText = "Tip Cenovnika";
             dataGridView1.Columns[1].Width = 130;

             DataGridViewColumn column3 = dataGridView1.Columns[2];
             dataGridView1.Columns[2].HeaderText = "Komitent";
             dataGridView1.Columns[2].Width = 250;

             DataGridViewColumn column4 = dataGridView1.Columns[3];
             dataGridView1.Columns[3].HeaderText = "Cena JM/EUR";
             dataGridView1.Columns[3].Width = 80;


            DataGridViewColumn column5 = dataGridView1.Columns[4];
            dataGridView1.Columns[4].HeaderText = "Cena JM2/EUR";
            dataGridView1.Columns[4].Width = 80;

            DataGridViewColumn column6 = dataGridView1.Columns[5];
             dataGridView1.Columns[5].HeaderText = "Vrsta manipulacije";
             dataGridView1.Columns[5].Width = 300;

             DataGridViewColumn column7 = dataGridView1.Columns[6];
             dataGridView1.Columns[6].HeaderText = "Datum";
             dataGridView1.Columns[6].Width = 80;

             DataGridViewColumn column8 = dataGridView1.Columns[7];
             dataGridView1.Columns[7].HeaderText = "Korisnik";
             dataGridView1.Columns[7].Width = 80;
         }

        private void RefreshDataGridPoCenovniku()
        {
            var select = " SELECT Cene.[ID] as ID ,[TipCenovnika].Naziv as TipCenovnika,[Komitenti].Naziv as Partner,[Cena],Cena2,[VrstaManipulacije].Naziv as VrstaManipulacije,Cene.[Datum],Cene.[Korisnik] FROM [dbo].[Cene] " +
            " inner join TipCenovnika on TipCenovnika.ID = Cene.TipCenovnika " +
            " inner join Komitenti on Komitenti.ID = Cene.Komitent " +
            " inner join VrstaManipulacije on VrstaManipulacije.Id = Cene.VrstaManipulacije " +
            " where Cene.TipCenovnika = " + cboTipCenovnika.SelectedValue + 
            " order by ID desc";
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(s_connection);
            var c = new SqlConnection(s_connection);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            //string value = dataGridView3.Rows[0].Cells[0].Value.ToString();
            DataGridViewColumn column = dataGridView1.Columns[0];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 40;

            DataGridViewColumn column2 = dataGridView1.Columns[1];
            dataGridView1.Columns[1].HeaderText = "Tip Cenovnika";
            dataGridView1.Columns[1].Width = 130;

            DataGridViewColumn column3 = dataGridView1.Columns[2];
            dataGridView1.Columns[2].HeaderText = "Komitent";
            dataGridView1.Columns[2].Width = 250;

            DataGridViewColumn column4 = dataGridView1.Columns[3];
            dataGridView1.Columns[3].HeaderText = "Cena JM/EUR";
            dataGridView1.Columns[3].Width = 80;


            DataGridViewColumn column5 = dataGridView1.Columns[4];
            dataGridView1.Columns[4].HeaderText = "Cena JM2/EUR";
            dataGridView1.Columns[4].Width = 80;

            DataGridViewColumn column6 = dataGridView1.Columns[5];
            dataGridView1.Columns[5].HeaderText = "Vrsta manipulacije";
            dataGridView1.Columns[5].Width = 300;

            DataGridViewColumn column7 = dataGridView1.Columns[6];
            dataGridView1.Columns[6].HeaderText = "Datum";
            dataGridView1.Columns[6].Width = 80;

            DataGridViewColumn column8 = dataGridView1.Columns[7];
            dataGridView1.Columns[7].HeaderText = "Korisnik";
            dataGridView1.Columns[7].Width = 80;
        }

        private void RefreshDataGridPoPartneru()
        {
            var select = " SELECT Cene.[ID] as ID ,[TipCenovnika].Naziv as TipCenovnika,[Komitenti].Naziv as Partner,[Cena],Cena2,[VrstaManipulacije].Naziv as VrstaManipulacije,Cene.[Datum],Cene.[Korisnik] FROM [dbo].[Cene] " +
            " inner join TipCenovnika on TipCenovnika.ID = Cene.TipCenovnika " +
            " inner join Komitenti on Komitenti.ID = Cene.Komitent " +
            " inner join VrstaManipulacije on VrstaManipulacije.Id = Cene.VrstaManipulacije where Komitenti.ID = " + Convert.ToInt32(cboKomitent.SelectedValue) +
            "order by Cene.ID desc";
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(s_connection);
            var c = new SqlConnection(s_connection);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            //string value = dataGridView3.Rows[0].Cells[0].Value.ToString();
            DataGridViewColumn column = dataGridView1.Columns[0];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 40;

            DataGridViewColumn column2 = dataGridView1.Columns[1];
            dataGridView1.Columns[1].HeaderText = "Tip Cenovnika";
            dataGridView1.Columns[1].Width = 130;

            DataGridViewColumn column3 = dataGridView1.Columns[2];
            dataGridView1.Columns[2].HeaderText = "Komitent";
            dataGridView1.Columns[2].Width = 250;

            DataGridViewColumn column4 = dataGridView1.Columns[3];
            dataGridView1.Columns[3].HeaderText = "Cena JM/EUR";
            dataGridView1.Columns[3].Width = 80;


            DataGridViewColumn column5 = dataGridView1.Columns[4];
            dataGridView1.Columns[4].HeaderText = "Cena JM2/EUR";
            dataGridView1.Columns[4].Width = 80;

            DataGridViewColumn column6 = dataGridView1.Columns[5];
            dataGridView1.Columns[5].HeaderText = "Vrsta manipulacije";
            dataGridView1.Columns[5].Width = 300;

            DataGridViewColumn column7 = dataGridView1.Columns[6];
            dataGridView1.Columns[6].HeaderText = "Datum";
            dataGridView1.Columns[6].Width = 80;

            DataGridViewColumn column8 = dataGridView1.Columns[7];
            dataGridView1.Columns[7].HeaderText = "Korisnik";
            dataGridView1.Columns[7].Width = 80;
        }

        private void tsSave_Click(object sender, EventArgs e)
         {
             if (status == true)
             {
                 InsertCene ins = new InsertCene();
                 ins.InsCene(Convert.ToInt32(cboTipCenovnika.SelectedValue), Convert.ToInt32(cboKomitent.SelectedValue), Convert.ToDouble(txtCena.Text), Convert.ToInt32(cboVrstaManipulacije.SelectedValue), Convert.ToDateTime(DateTime.Now), KorisnikCene, Convert.ToDouble(txtCena2.Text));
                 status = false;
             }
             else
             {
                 //int TipCenovnika ,int Komitent, double Cena , int VrstaManipulacije ,DateTime  Datum , string Korisnik
                 InsertCene upd = new InsertCene();
                 upd.UpdCene(Convert.ToInt32(txtSifra.Text), Convert.ToInt32(cboTipCenovnika.SelectedValue), Convert.ToInt32(cboKomitent.SelectedValue), Convert.ToDouble(txtCena.Text), Convert.ToInt32(cboVrstaManipulacije.SelectedValue), Convert.ToDateTime(DateTime.Now), KorisnikCene, Convert.ToDouble(txtCena2.Text));
             }
             RefreshDataGrid();
         }

         private void tsDelete_Click(object sender, EventArgs e)
         {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da brišete?", "Izbor", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                InsertCene upd = new InsertCene();
                upd.DeleteCene(Convert.ToInt32(txtSifra.Text));
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
         }

        private void VratiPodatke(string ID)
        {
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(s_connection);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT ID , TipCenovnika , Komitent, Cena, VrstaManipulacije, Cena2 from Cene where ID=" + txtSifra.Text, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboTipCenovnika.SelectedValue = Convert.ToInt32(dr["TipCenovnika"].ToString());
                cboKomitent.SelectedValue = Convert.ToInt32(dr["Komitent"].ToString());
                cboVrstaManipulacije.SelectedValue = Convert.ToInt32(dr["VrstaManipulacije"].ToString());
                txtCena.Text = Convert.ToDecimal(dr["Cena"].ToString()).ToString();
                txtCena2.Text = Convert.ToDecimal(dr["Cena2"].ToString()).ToString();
            }

            con.Close();
        }

         private void dataGridView1_SelectionChanged(object sender, EventArgs e)
         {
             try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected)
                    {
                        txtSifra.Text = row.Cells[0].Value.ToString();
                        VratiPodatke(txtSifra.Text);
                        // txtOpis.Text = row.Cells[1].Value.ToString();
                    }
                }


            }
            catch
            {
                MessageBox.Show("Nije uspela selekcija stavki");
            }
        }

         private void txtSifra_TextChanged(object sender, EventArgs e)
         {

         }

         private void frmCene_Load(object sender, EventArgs e)
         {
             var select = " Select Distinct ID, Naziv  From Komitenti";
             var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection myConnection = new SqlConnection(s_connection);
             var c = new SqlConnection(s_connection);
             var dataAdapter = new SqlDataAdapter(select, c);

             var commandBuilder = new SqlCommandBuilder(dataAdapter);
             var ds = new DataSet();
             dataAdapter.Fill(ds);
             cboKomitent.DataSource = ds.Tables[0];
             cboKomitent.DisplayMember = "Naziv";
             cboKomitent.ValueMember = "ID";
            //
             var select3 = " select ID, Naziv from TipCenovnika";
             var s_connection3 = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection myConnection3 = new SqlConnection(s_connection3);
             var c3 = new SqlConnection(s_connection3);
             var dataAdapter3 = new SqlDataAdapter(select3, c3);

             var commandBuilder3 = new SqlCommandBuilder(dataAdapter3);
             var ds3 = new DataSet();
             dataAdapter3.Fill(ds3);
             cboTipCenovnika.DataSource = ds3.Tables[0];
             cboTipCenovnika.DisplayMember = "Naziv";
             cboTipCenovnika.ValueMember = "ID";

             var select4 = " select ID, Naziv from VrstaManipulacije";
             var s_connection4 = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection myConnection4 = new SqlConnection(s_connection4);
             var c4 = new SqlConnection(s_connection4);
             var dataAdapter4 = new SqlDataAdapter(select4, c4);

             var commandBuilder4 = new SqlCommandBuilder(dataAdapter4);
             var ds4 = new DataSet();
             dataAdapter4.Fill(ds4);
             cboVrstaManipulacije.DataSource = ds4.Tables[0];
             cboVrstaManipulacije.DisplayMember = "Naziv";
             cboVrstaManipulacije.ValueMember = "ID";

             RefreshDataGrid();
            if (KorisnikCene != "Kecman" && KorisnikCene != "M.Jelisavčić" && KorisnikCene != "Dušan Bašanović")
            {
                //Dušan Bašanović
                tsNew.Enabled = false;
                tsSave.Enabled = false;
                tsDelete.Enabled = false;
            }
         }

         private void tsPrvi_Click(object sender, EventArgs e)
         {

             var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection con = new SqlConnection(s_connection);

             con.Open();

             SqlCommand cmd = new SqlCommand("select Min([ID]) as ID from Cene", con);
             SqlDataReader dr = cmd.ExecuteReader();

             while (dr.Read())
             {
                 txtSifra.Text = dr["ID"].ToString();
             }
             VratiPodatke(txtSifra.Text);
             con.Close();

         }

         private void tsPoslednja_Click(object sender, EventArgs e)
         {


             var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection con = new SqlConnection(s_connection);

             con.Open();

             SqlCommand cmd = new SqlCommand("select Max([ID]) as ID from Cene", con);
             SqlDataReader dr = cmd.ExecuteReader();

             while (dr.Read())
             {
                 txtSifra.Text = dr["ID"].ToString();
             }
             VratiPodatke(txtSifra.Text);
             con.Close();



         }

         private void tsNazad_Click(object sender, EventArgs e)
         {
             var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection con = new SqlConnection(s_connection);
             int prvi = 0;
             con.Open();

             SqlCommand cmd = new SqlCommand("select top 1 ID as ID from Cene where ID <" + Convert.ToInt32(txtSifra.Text) + " Order by ID desc", con);
             SqlDataReader dr = cmd.ExecuteReader();

             while (dr.Read())
             {
                 prvi = Convert.ToInt32(dr["ID"].ToString());
                 txtSifra.Text = prvi.ToString();
             }

             con.Close();
             if ((Convert.ToInt32(txtSifra.Text) - 1) > prvi)
                 VratiPodatke((Convert.ToInt32(txtSifra.Text) - 1).ToString());
             else
                 VratiPodatke((Convert.ToInt32(prvi)).ToString());
         }

         private void VratiPodatkeMax()
         {
             var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection con = new SqlConnection(s_connection);

             con.Open();

             SqlCommand cmd = new SqlCommand("select Max([ID]) as ID from Cene", con);
             SqlDataReader dr = cmd.ExecuteReader();

             while (dr.Read())
             {
                 txtSifra.Text = dr["ID"].ToString();
             }

             con.Close();
         }

         private void tsNapred_Click(object sender, EventArgs e)
         {
             var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
             SqlConnection con = new SqlConnection(s_connection);
             int zadnji = 0;
             con.Open();

             SqlCommand cmd = new SqlCommand("select top 1 ID as ID from Cene where ID >" + Convert.ToInt32(txtSifra.Text) + " Order by ID", con);
             SqlDataReader dr = cmd.ExecuteReader();

             while (dr.Read())
             {
                 zadnji = Convert.ToInt32(dr["ID"].ToString());
                 txtSifra.Text = zadnji.ToString();
             }

             con.Close();

             if ((Convert.ToInt32(txtSifra.Text) + 1) == zadnji)
                 VratiPodatke((Convert.ToInt32(zadnji).ToString()));
             else
                 VratiPodatke((Convert.ToInt32(txtSifra.Text) + 1).ToString());

         }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGridPoCenovniku();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    InsertCene ins = new InsertCene();
                    ins.KopirajCene(Convert.ToInt32(row.Cells[0].Value.ToString()), Convert.ToInt32(cboKomitent.SelectedValue));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridPoPartneru();
        }
    }
    }

