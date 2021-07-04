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

namespace TrackModal.Promet
{
    public partial class frmPopisStampa : Form
    {
        public frmPopisStampa()
        {
            InitializeComponent();
        }

        public frmPopisStampa(string broj)
        {
            InitializeComponent();
            txtSifra.Text = broj;
        }

        private void frmPopisStampa_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrackModalDataSet10TableAdapters.SelectPopisStavkeTableAdapter ta = new TrackModalDataSet10TableAdapters.SelectPopisStavkeTableAdapter();
            TrackModalDataSet10.SelectPopisStavkeDataTable dt = new TrackModalDataSet10.SelectPopisStavkeDataTable();
          
            ta.Fill(dt, Convert.ToInt32(txtSifra.Text));
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet2";
            rds.Value = dt;


            TrackModalDataSet9TableAdapters.SelectPopisTableAdapter taa = new TrackModalDataSet9TableAdapters.SelectPopisTableAdapter();

            TrackModalDataSet9.SelectPopisDataTable dta = new TrackModalDataSet9.SelectPopisDataTable();

            taa.Fill(dta, Convert.ToInt32(txtSifra.Text));
            ReportDataSource rdsa = new ReportDataSource();
            rdsa.Name = "DataSet1";
            rdsa.Value = dta;



            ReportParameter[] par = new ReportParameter[1];
            par[0] = new ReportParameter("Dokument", txtSifra.Text);


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "rptPopisnLista.rdlc";
            reportViewer1.LocalReport.SetParameters(par);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rdsa);
            /*
            reportViewer1.LocalReport.SubreportProcessing += new
                          SubreportProcessingEventHandler(SetSubDataSource);
             */
            reportViewer1.RefreshReport();
        }
    }
}
