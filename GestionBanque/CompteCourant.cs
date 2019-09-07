using System;

namespace GestionBanque
{
    public class CompteCourant : Compte
    {
        private readonly decimal DecouvertAutorise;

        public CompteCourant(string proprietaire, decimal decouvert) : base(proprietaire)
        {
            this.DecouvertAutorise = decouvert;
        }

        public override void Resumer()
        {
            Console.WriteLine("Résumé du compte courant de " + this.Proprietaire);
            Console.WriteLine("*******************************************");
            Console.WriteLine("Compte courant de " + this.Proprietaire);
            Console.WriteLine("\t Solde : " + this.Solde);
            Console.WriteLine("\t Découvert autorisé : " + this.DecouvertAutorise);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Opérations :");

            foreach(OperationBancaire op in this.ListeOperations)
            {
                if (op.TypeMouvement == EnumTypeMouvement.CREDIT)
                    Console.WriteLine("\t +" + op.Montant);
                else
                    Console.WriteLine("\t -" + op.Montant);
            }
            Console.WriteLine("*******************************************");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
