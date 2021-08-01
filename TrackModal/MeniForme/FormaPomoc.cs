using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackModal.MeniForme
{
    public partial class FormaPomoc : Form
    {
        public FormaPomoc()
        {
            InitializeComponent();
        }

        private void btnpSifrarnici_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo- šifarnici.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnpPrevoz_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo- prevoz.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnpManipulacije_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo - manipulacije.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnpSkladPoslovanje_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo - Skladišno poslovanje.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnpIzvestaji_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\Korisničko upustvo – Izvestaji.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnpTransport_Click(object sender, EventArgs e)
        {
            try
            {
                string Putanja = @"\\192.168.100.2\mta\HELP\KorisnickoUpustvoTransport.pdf";
                string configvalue1 = ConfigurationManager.AppSettings["ip"];
                string configvalue2 = ConfigurationManager.AppSettings["server"];
                configvalue2 = "192.168.100.2";
                Putanja = Putanja.Replace(configvalue1, configvalue2);
                System.Diagnostics.Process.Start(Putanja);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
