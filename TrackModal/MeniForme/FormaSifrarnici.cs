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
    public partial class FormaSifrarnici : Form
    {
        public string Korisnik { get; private set; }

        public FormaSifrarnici()
        {
            InitializeComponent();
            CustomizeDesigne();
        }

        private void CustomizeDesigne()
        {
            panelSubZaposlSifr.Visible = false;
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

        private void FormaSifrarnici_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsZaposleniSifr_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubZaposlSifr);
        }
    }
}
