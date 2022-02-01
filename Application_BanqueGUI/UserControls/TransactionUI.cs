using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Banque;
using System.Windows.Forms;
using System.Data.SqlClient;
using Application_BanqueGUI;
namespace Application_BanqueGUI.UserControls
{
    public partial class TransactionUI : UserControl
    {
        public string connect = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        Client client =null;
        public TransactionUI(Client c)
        {
            this.client = c;
            InitializeComponent();
        }

        Devise givDevise(string typeDevise, float solde)
        {
            Devise dev = null;
            if (typeDevise == "DH")
                dev = new MAD(solde);
            else if (typeDevise == "EU")
                dev = new Euro(solde);
            else if (typeDevise == "DO")
                dev = new Dollar(solde);

            return dev;
        }

        private void TransactionUI_Load(object sender, EventArgs e)
        {
            List<Operation> l = new List<Operation>();
            SqlConnection cnx1 = new SqlConnection(connect);
            SqlCommand command;
            SqlDataReader reader;
            string requeteSql = "select * from Operation where idcompte in ( select Numerocompte from compte where idclient = " + client.idclient.ToString() + " )";
            cnx1.Open();
            command = new SqlCommand(requeteSql, cnx1);
            reader = command.ExecuteReader();


            while (reader.Read())
            {
                int numO = int.Parse(reader["NumOperation"].ToString());
                float montant = float.Parse(reader["Montant"].ToString());
                string dateO = reader["dateOperation"].ToString();
                string typeO = reader["typeOp"].ToString();
                if (typeO == "V")
                {
                    l.Add(new OperationV(null, dateO, givDevise(reader["typeDevise"].ToString(), montant), numO));
                }
                else if (typeO == "R")
                {
                    l.Add(new OperationR(null, dateO, givDevise(reader["typeDevise"].ToString(), montant), numO));
                }

            }

            cnx1.Dispose();
            cnx1.Close();


            dataGridViewtransactions.DataSource = l;
        }
    }

}