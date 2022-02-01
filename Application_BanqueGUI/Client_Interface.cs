using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_BanqueGUI.UserControls;
using Application_Banque;
namespace Application_BanqueGUI
{
    public partial class Client_Interface : Form
    {
        Client client=null;
        public Client_Interface(Client c)
        {
            this.client = c;
            InitializeComponent();

            HomeUI home = new HomeUI(client);
            AddControl(home);
        }

        void AddControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(client1.ToString());
            HomeUI home = new HomeUI(client);
            AddControl(home);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            AccountUI account = new AccountUI(client);
            AddControl(account);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransactionUI trans = new TransactionUI(client);
            AddControl(trans);

        }

        private void Client_Interface_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDepotretrait_Click(object sender, EventArgs e)
        {
            DepotRetraitUI dr = new DepotRetraitUI(client);
            AddControl(dr);
        }
    }
}
