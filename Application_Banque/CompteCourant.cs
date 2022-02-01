namespace Application_Banque
{
    public abstract class CompteCourant : Compte
    {

        public static Devise decouvert = new MAD(200);
        public CompteCourant(Client client, Devise solde, int num,string date)
            : base(client, solde, num,date)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
        override public bool debiter(Devise montant)
        {
            bool val = false;
            if (decouvert.GetType() == typeof(MAD)) // normalement tjr vérifié car decouvert en MAD
                val = this.comparerSolde(montant.convertToMAD(), decouvert);
            /*
             * if (decouvert.GetType() == typeof(Euro))
                val = this.comparerSolde(montant.convertToEuro(), decouvert);
            if (decouvert.GetType() == typeof(Dollar))
                val = this.comparerSolde(montant.convertToDollar(), decouvert);*/
            if (val == true)
                return base.debiter(montant);
            return false;
        }

    }
}
