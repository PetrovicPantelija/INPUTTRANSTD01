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

namespace TrackModal.Sifarnici
{
    public partial class frmDelovi : Form
    {
        string KorisnikCene;
        bool status = false;
        public frmDelovi()
        {
            InitializeComponent();
        }

          public frmDelovi(string Korisnik)
        {
            InitializeComponent();
            KorisnikCene = Korisnik;
        }

          private void tsNew_Click(object sender, EventArgs e)
          {
              status = true;
              txtSifra.Enabled = false;
              txtNaziv.Text = "";
          }

          private void tsSave_Click(object sender, EventArgs e)
          {
              if (status == true)
              {
                  InsertDelovi ins = new InsertDelovi();
                  ins.InsDelovi(txtNaziv.Text, Convert.ToDateTime(DateTime.Now), KorisnikCene);
                  status = false;
              }
              else
              {
                  //int TipCenovnika ,int Komitent, double Cena , int VrstaManipulacije ,DateTime  Datum , string Korisnik
                  InsertDelovi upd = new InsertDelovi();
                  upd.UpdDelovi(Convert.ToInt32(txtSifra.Text), txtNaziv.Text, Convert.ToDateTime(DateTime.Now), KorisnikCene);
              }
              RefreshDataGrid();
          }

          private void tsDelete_Click(object sender, EventArgs e)
          {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da brišete?", "Izbor", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                InsertDelovi upd = new InsertDelovi();
                upd.DeleteStatusRobe(Convert.ToInt32(txtSifra.Text));
                RefreshDataGrid();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
          }

          private void RefreshDataGrid()
          {
              var select = " SELECT [ID] ,Naziv,[Datum],[Korisnik] FROM [dbo].[Delovi]";
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
              dataGridView1.Columns[0].Width = 50;

              DataGridViewColumn column2 = dataGridView1.Columns[1];
              dataGridView1.Columns[1].HeaderText = "Naziv";
              dataGridView1.Columns[1].Width = 150;


              DataGridViewColumn column3 = dataGridView1.Columns[2];
              dataGridView1.Columns[2].HeaderText = "Datum";
              dataGridView1.Columns[2].Width = 100;

              DataGridViewColumn column4 = dataGridView1.Columns[3];
              dataGridView1.Columns[3].HeaderText = "Korisnik";
              dataGridView1.Columns[3].Width = 100;
          }

          private void VratiPodatke(string ID)
          {
              var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
              SqlConnection con = new SqlConnection(s_connection);

              con.Open();

              SqlCommand cmd = new SqlCommand("SELECT ID , Naziv from Delovi where ID=" + txtSifra.Text, con);
              SqlDataReader dr = cmd.ExecuteReader();

              while (dr.Read())
              {
                  // Convert.ToInt32(cboTipCenovnika.SelectedValue), Convert.ToInt32(cboKomitent.SelectedValue), Convert.ToDouble(txtCena.Text), Convert.ToInt32(cboVrstaManipulacije.SelectedValue), Convert.ToDateTime(DateTime.Now), KorisnikCene
                  txtNaziv.Text = dr["Naziv"].ToString();
              }

              con.Close();
          }

          private void frmDelovi_Load(object sender, EventArgs e)
          {
              RefreshDataGrid();
            if (KorisnikCene != "Kecman" && KorisnikCene != "M.Jelisavčić" && KorisnikCene != "Dušan Bašanović")
            {
                tsNew.Enabled = false;
                tsSave.Enabled = false;
                tsDelete.Enabled = false;
            }
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
    }
}
