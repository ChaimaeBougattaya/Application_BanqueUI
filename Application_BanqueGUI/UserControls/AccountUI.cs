using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Application_Banque;
using System.Data.SqlClient;


namespace Application_BanqueGUI.UserControls
{
    public partial class AccountUI : UserControl
    {
        Client client;
        public AccountUI(Client c)
        {
            this.client = c;
            InitializeComponent();
        }

        private void AccountUI_Load(object sender, EventArgs e)
        {        
            dataGridViewAccounts.DataSource = client.list;
        }
    }
}
