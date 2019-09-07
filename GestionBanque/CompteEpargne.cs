using System;

namespace GestionBanque
{
    public class CompteEpargne : Compte
    {
        public double TauxAbonnement { get; set; }

        public override decimal Solde => base.Solde * (decimal)(1 + this.TauxAbonnement);

        public CompteEpargne(string proprietaire, double taux) : base(proprietaire)
        {
            this.TauxAbonnement = taux;
        }

        public override void Resumer()
        {
            Console.WriteLine("Résumé du compte épargne de " + this.Proprietaire);
            Console.WriteLine("########################################################");
            Console.WriteLine("Compte épargne de " + this.Proprietaire);
            Console.WriteLine("\t Solde : " + this.Solde);
            Console.WriteLine("\t Taux : " + this.TauxAbonnement);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Opérations :");

            foreach (OperationBancaire op in this.ListeOperations)
            {
                if (op.TypeMouvement == EnumTypeMouvement.CREDIT)
                    Console.WriteLine("\t +" + op.Montant);
                else
                    Console.WriteLine("\t -" + op.Montant);
            }
            Console.WriteLine("########################################################");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
