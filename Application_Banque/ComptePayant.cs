namespace Application_Banque
{
    public class ComptePayant : CompteCourant
    {
        public static double taux = 0.5;
        public ComptePayant(Client client, Devise solde, int num,string date) 
            : base(client, solde, num,date)
        {
        }
        public override string ToString()
        {
            return "\nDétail d'un compte payant " + base.ToString();
        }
        override public void crediter(Devise montant)
        {
            base.crediter(montant);
            this.Mise_A_jour_payant(taux);
        }
        override public bool debiter(Devise montant)
        {
            bool val = base.debiter(montant);
            if (val == true)//si on a debiter
                this.Mise_A_jour_payant(taux);
            return val;
        }
    }
}
