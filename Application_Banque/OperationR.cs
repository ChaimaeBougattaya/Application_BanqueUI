namespace Application_Banque
{
    public class OperationR : Operation
    {
        public OperationR(Compte compte, string date, Devise montant, int num)
            : base(compte, date, montant, num)
        {
        }
        //pour database
        public OperationR(Compte compte, string date, Devise montant)
           : base(compte, date, montant)
        {
        }

        public override string ToString()
        {
            return "\nOperation de Retrait" + base.ToString();
        }

    }
}
