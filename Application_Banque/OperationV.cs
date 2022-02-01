namespace Application_Banque
{
    public class OperationV : Operation
    {
        public OperationV(Compte compte, string date, Devise montant)
            : base(compte, date, montant)
        {
        }
        //pour database
        public OperationV(Compte compte, string date, Devise montant, int num)
            : base(compte, date, montant, num)
        {
        }

        public override string ToString()
        {
            return "\nOperation de Versemment" + base.ToString();
        }
    }
}
