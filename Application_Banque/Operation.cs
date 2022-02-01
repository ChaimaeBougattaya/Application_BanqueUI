namespace Application_Banque
{
    public abstract class Operation
    {
        //  public static int compteur{get; set;}
        public int Numop { get; set; }
        public string date { get; set; }
        public Devise Montant { get; set; }
        public Compte CompteOp;

    public Operation(Compte compte, string date, Devise montant, int num)//pour database
        {
            // compteur++;
            Numop = num;
            this.CompteOp = compte;
            this.date = date;
            this.Montant = montant;
        }

        public Operation(Compte compte, string date, Devise montant)
        {
            // compteur++;
            //Numop = com;
            this.CompteOp = compte;
            this.date = date;
            this.Montant = montant;
        }
        public override string ToString()
        {
            return "\nDetails : " + date + " || N° : " + Numop + " || " + Montant;
        }

    }
}
