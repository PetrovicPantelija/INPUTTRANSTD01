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

using Microsoft.Reporting.WinForms;

namespace TrackModal.Izvestaji
{
    public partial class frmSelectTransport1 : Form
    {
        public frmSelectTransport1()
        {
            InitializeComponent();
        }

        private void frmSelectTransport1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            TrackModalDataSet22TableAdapters.SelectTransport1TableAdapter ta = new TrackModalDataSet22TableAdapters.SelectTransport1TableAdapter();
            TrackModalDataSet22.SelectTransport1DataTable dt = new TrackModalDataSet22.SelectTransport1DataTable();

            ta.Fill(dt, Convert.ToDateTime(dtpDatumOd.Value), Convert.ToDateTime(dtpDatumDo.Value));
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;

            ReportParameter[] par = new ReportParameter[2];
            par[0] = new ReportParameter("VremeOd", dtpDatumOd.Value.ToString());
            par[1] = new ReportParameter("VremeDo", dtpDatumDo.Value.ToString());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "rptSelectTransport1.rdlc";
            reportViewer1.LocalReport.SetParameters(par);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmSelectTransport1 select1 = new frmSelectTransport1();
            this.Close();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            frmSelectTransport1 select1 = new frmSelectTransport1();
            this.Close();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
