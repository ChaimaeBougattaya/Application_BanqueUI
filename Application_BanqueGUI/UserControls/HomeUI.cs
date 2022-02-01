using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Application_Banque;
namespace Application_BanqueGUI
{
    public partial class HomeUI : UserControl
    {
        Client client;
        public HomeUI(Client c)
        {
            this.client = c;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeUI_Load(object sender, EventArgs e)
        {
            labelNomPrenom.Text = client.nom + " " + client.prenom;
            labelEmail.Text = client.email;
            labeladresse.Text = client.adresse;
            labelTel.Text = client.tel;
        }
    }
}
