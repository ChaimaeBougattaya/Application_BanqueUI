using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Application_Banque;
namespace Application_BanqueGUI.UserControls
{
    public partial class DepotRetraitUI : UserControl
    {
        Client client=null;
        public DepotRetraitUI(Client c)
        {
            this.client = c;
            InitializeComponent();
        }

        private void DepotRetraitUI_Load(object sender, EventArgs e)
        {
            List<int> l = new List<int>();
            foreach (Compte c in client.list)
                l.Add(c.numCompte);
            comboBox1.DataSource = l;
        }
        bool IsValidInput(string p)
        {
            return ((Regex.Match(p, "^[0-9][0-9]*[.][0-9][0-9]*$").Success) || (Regex.Match(p, "^[0-9][0-9]*$").Success));
           
        }

        private void btnCrediter_Click(object sender, EventArgs e)
        {
            if (montant.Text.Length != 0)
            {
                if (IsValidInput(montant.Text) == true)
                {
                    foreach (Compte c in client.list)
                    {
                        if (c.numCompte == int.Parse(comboBox1.SelectedItem.ToString()))
                        {
                            if (comboBox2.SelectedItem.ToString().Equals("DH"))
                                c.crediter(new MAD(float.Parse(montant.Text.ToString())));
                            else
                                if (comboBox2.SelectedItem.ToString().Equals("Euro"))
                                c.crediter(new Euro(float.Parse(montant.Text.ToString())));
                            else
                                if (comboBox2.SelectedItem.ToString().Equals("Dollar"))
                                c.crediter(new Dollar(float.Parse(montant.Text.ToString())));

                            updateSolde(c.solde.getValeur(), comboBox2.SelectedItem.ToString(),'V');
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Attention montant invalide");
                }
            }
            else
            {
                MessageBox.Show("Attention montant vide");
            }

        }

        void btnDebiter_Click(object sender, EventArgs e)
        {
            if (montant.Text.Length != 0)
            {
                if (IsValidInput(montant.Text) == true)
                {
                    foreach (Compte c in client.list)
                    {
                        if (c.numCompte == int.Parse(comboBox1.SelectedItem.ToString()))
                        {
                            if (comboBox2.SelectedItem.ToString().Equals("DH"))
                                c.debiter(new MAD(float.Parse(montant.Text.ToString())));
                            else
                                if (comboBox2.SelectedItem.ToString().Equals("Euro"))
                                c.debiter(new Euro(float.Parse(montant.Text.ToString())));
                            else
                                if (comboBox2.SelectedItem.ToString().Equals("Dollar"))
                                c.debiter(new Dollar(float.Parse(montant.Text.ToString())));

                            updateSolde(c.solde.getValeur(), comboBox2.SelectedItem.ToString(),'R');
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Attention montant invalide");
                }
            }
            else
            {
                MessageBox.Show("Attention montant vide");
            }
        }


        void updateSolde(float solde,string typed,char typeOp) // solde , type devise (DH , Euro , Dollar) , type opération (V,R)
        {
          
            SqlConnection connexion;
            string connect = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connect);
            connexion.Open();

            SqlCommand com1;
            SqlDataAdapter adapter;

            string requeteSql1 = "update compte set solde=" + solde + " where Numerocompte =" + int.Parse(comboBox1.SelectedItem.ToString()) + "";
            com1 = new SqlCommand(requeteSql1, connexion);
            adapter = new SqlDataAdapter(com1);
            com1.ExecuteNonQuery();

            connexion.Close();
            connexion.Open();

            /*******   Insert operation *********/

            SqlCommand com2;
            SqlDataAdapter adapter2 = new SqlDataAdapter();


            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";


            string requeteSql2 = "INSERT INTO Operation (Montant,typeOp,dateOperation,idcompte,typeDevise) VALUES (" + float.Parse(montant.Text) + ",'"+typeOp+"','" + time.ToString(format) + "'," + int.Parse(comboBox1.SelectedItem.ToString()) +",'"+typed+"' )";
            com2 = new SqlCommand(requeteSql2, connexion);
            adapter.InsertCommand = com2;
            adapter.InsertCommand.ExecuteNonQuery();

            
            connexion.Dispose();
            connexion.Close();
            
        }
    }
}
