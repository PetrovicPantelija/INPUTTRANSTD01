﻿using System;
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
    public partial class frmNalozi : Form
    {
        DataTable ndt;
        public frmNalozi()
        {
            InitializeComponent();
        }

        public frmNalozi(string broj)
        {
            InitializeComponent();
            txtSifra.Text = broj;
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            TrackModalDataSet7TableAdapters.SelectNalogZaRAdPrometMSPTableAdapter ta = new TrackModalDataSet7TableAdapters.SelectNalogZaRAdPrometMSPTableAdapter();

            TrackModalDataSet7.SelectNalogZaRAdPrometMSPDataTable dt = new TrackModalDataSet7.SelectNalogZaRAdPrometMSPDataTable();
            /*
            TrackModalDataSet1TableAdapters.SelectZadatakPozicijaTableAdapter tal = new TrackModalDataSet1TableAdapters.SelectZadatakPozicijaTableAdapter();
            TrackModalDataSet1.SelectZadatakPozicijaDataTable dtl = new TrackModalDataSet1.SelectZadatakPozicijaDataTable();
            */
            ta.Fill(dt, Convert.ToInt32(txtSifra.Text));
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;


            TrackModalDataSet6TableAdapters.SelectNalogZaRadPrometMTableAdapter taa = new TrackModalDataSet6TableAdapters.SelectNalogZaRadPrometMTableAdapter();

            TrackModalDataSet6.SelectNalogZaRadPrometMDataTable dta = new TrackModalDataSet6.SelectNalogZaRadPrometMDataTable();

            taa.Fill(dta, Convert.ToInt32(txtSifra.Text));
            ReportDataSource rdsa = new ReportDataSource();
            rdsa.Name = "DataSet2";
            rdsa.Value = dta;



            ReportParameter[] par = new ReportParameter[1];
            par[0] = new ReportParameter("Dokument", txtSifra.Text);


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "rptNalogZaRadMSP.rdlc";
            reportViewer1.LocalReport.SetParameters(par);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rdsa);
            /*
            reportViewer1.LocalReport.SubreportProcessing += new
                          SubreportProcessingEventHandler(SetSubDataSource);
             */
            reportViewer1.RefreshReport();

        }

        public void SetSubDataSource(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("DataSet2", ndt));
        }

        private void frmNalozi_Load(object sender, EventArgs e)
        {

        }
    }
}
