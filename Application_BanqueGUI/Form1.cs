using System.Windows.Forms;
using System.Data.SqlClient;
using Application_Banque;
using System;
using System.Collections.Generic;
namespace Application_BanqueGUI
{
    public partial class Form1 : Form
    {
        public string connect = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        Client client=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, System.EventArgs e)
        {
            //DB connection
            SqlConnection connexion;
            connexion = new SqlConnection(connect);

            connexion.Open();

            SqlCommand command;
            SqlDataReader reader;
            string requeteSql = "select * from client ";

            command = new SqlCommand(requeteSql, connexion);

            reader = command.ExecuteReader();

            bool exist = false;

            while (reader.Read())
            {
                
                string usern = reader["username"].ToString();
                string pass = reader["password"].ToString();
                

                if(usern == username.Text.ToString() && pass == password.Text.ToString())
                {
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string email = reader["email"].ToString();
                    string adresse = reader["adresse"].ToString();
                    string tel = reader["numTel"].ToString();
                    int id = int.Parse(reader["Idclient"].ToString());


                    client = new Client(nom, prenom, email, adresse, tel, usern, pass, id);

                    connexion.Close();
                    connexion.Open();

                    requeteSql = "select * from compte where idclient = " + id + "";

                    command = new SqlCommand(requeteSql, connexion);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int numC = int.Parse(reader["Numerocompte"].ToString());
                        float solde = float.Parse(reader["solde"].ToString());
                        string dateC = reader["DateCreation"].ToString();
                        int typeC = int.Parse(reader["typeCompte"].ToString());
                        string typeDevise = reader["typedevise"].ToString();
                        string date = reader["DateCreation"].ToString();

                        Compte compte = giveCompte(typeC, givDevise(typeDevise, solde), numC,date);

                        client.ajouterCompte(compte);
                        
                    }

                    exist = true;
                    break;
                }
            }
            if(exist==true)
            {
                 new Client_Interface(client).Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong !! Try again");

            connexion.Dispose();
            connexion.Close();

        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void username_Click(object sender, System.EventArgs e)
        {
            username.Clear();
            username.ForeColor = System.Drawing.Color.FromArgb(65, 112, 184);
        }

        private void password_Click(object sender, System.EventArgs e)
        {
            password.Clear();
            password.ForeColor = System.Drawing.Color.FromArgb(65, 112, 184);
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }




        Compte giveCompte(int typeC, Devise dev, int num,string date)
        {
            if (typeC==0)
            {
                MessageBox.Show("compte epargne");
                return new CompteEpargne(client, dev, num,date);
            }
            else if(typeC==1)
            {
                MessageBox.Show("compte payant");
                return new ComptePayant(client, dev, num,date);
            }
            MessageBox.Show("compte error");
            return null;
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

     
    }
}
