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

namespace TrackModal.Dokumeta
{
    public partial class frmPregledTovarnihListova : Form
    {
        public frmPregledTovarnihListova()
        {
            InitializeComponent();
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

                    }
                }


            }
            catch
            {
                MessageBox.Show("Nije uspela selekcija stavki");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var select = "select TovarniList.ID as ID, Komitenti.Naziv as Posiljalac," +
               " k2.Naziv as Primalac, MestoIspostavljanja, DatumIspostavljanja, CIMBroj " +
                " from TovarniList " +
               " inner Join Komitenti on TovarniList.Posiljalac = Komitenti.ID " +
               " inner Join Komitenti k2 on TovarniList.Primalac = k2.ID " +
               " order by ID desc  ";
            var s_connection = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.NedraConnectionString"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(s_connection);
            var c = new SqlConnection(s_connection);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            frmTovarniList tl = new frmTovarniList(Convert.ToInt32(txtSifra.Text));
            tl.Show();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            frmPregledTovarnihListova pregledtovlist = new frmPregledTovarnihListova();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmPregledTovarnihListova pregledtovlist = new frmPregledTovarnihListova();
            this.Close();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
