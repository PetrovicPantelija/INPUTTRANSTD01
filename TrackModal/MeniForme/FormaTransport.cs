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
    public partial class FormaTransport : Form
    {
        public FormaTransport()
        {
            InitializeComponent();
            CustomizeDesigne();
        }

        private void CustomizeDesigne()
        {
            panel2SubMenu.Visible = false;
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

        private void btntIzvestaji_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel2SubMenu);
        }
    }
}
