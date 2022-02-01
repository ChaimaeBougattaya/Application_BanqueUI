using System;
using System.Collections.Generic;

namespace Application_Banque
{
    public class Client
    {

        public string nom, prenom, email, adresse, tel, username, password;
        public int idclient;
        public List<Compte> list { get; set; }

        public Client(string nom, string prenom,
            string email, string adresse, string tel,
            string username, string password, int idclient)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.adresse = adresse;
            this.tel = tel;
            this.username = username;
            this.password = password;
            this.idclient = idclient;
            this.list = new List<Compte>();
        }

        public void ajouterCompte(Compte com)
        {
            this.list.Add(com);
        }
        public override string ToString()
        {
            String res = "Nom = " + nom + "\nPrenom = " + prenom + "\nadresse = " + adresse;

            if (list.Count > 0)
                foreach (Compte c in this.list)
                {
                    res += c.ToString() + "\n";
                }
            return res;
        }

    }
}
