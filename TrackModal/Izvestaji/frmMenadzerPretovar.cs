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

namespace TrackModal.Izvestaji
{
    public partial class frmMenadzerPretovar : Form
    {
        public frmMenadzerPretovar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            InsertMen ins = new InsertMen();
            ins.InsMen4(Convert.ToDateTime(dtpDatumOd.Value), Convert.ToDateTime(dtpDatumDo.Value));



            var select = "SELECT *  FROM [dbo].Men4 ";
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmMenadzerPretovar mp = new frmMenadzerPretovar();
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            frmMenadzerPretovar mp = new frmMenadzerPretovar();
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
