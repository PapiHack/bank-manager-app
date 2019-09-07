using System;

namespace GestionBanque
{
    public class OperationBancaire
    {
        public decimal Montant { get; set; }
        public EnumTypeMouvement TypeMouvement { get; set; }

        public OperationBancaire(decimal somme, EnumTypeMouvement mouvement)
        {
            this.Montant = somme;
            this.TypeMouvement = mouvement;
        }
    }
}
