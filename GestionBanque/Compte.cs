using System;
using System.Collections.Generic;

namespace GestionBanque
{   
    public abstract class Compte
    {
        public virtual decimal Solde
        {
            get
            {
                decimal total = 0;
                foreach(OperationBancaire op in this.ListeOperations)
                {
                    total = (op.TypeMouvement == EnumTypeMouvement.CREDIT) ? total + op.Montant : total - op.Montant;
                }
                return total;
            }
        }

        public string Proprietaire { get; set; }
        protected List<OperationBancaire> ListeOperations;

        public abstract void Resumer();

        protected Compte(string proprio)
        {
            this.ListeOperations = new List<OperationBancaire>();
            this.Proprietaire = proprio;
        }

        public void Crediter(decimal somme)
        {
            this.ListeOperations.Add(new OperationBancaire(somme, EnumTypeMouvement.CREDIT));
        }

        public void Crediter(Compte compte, decimal somme)
        {
            compte.Crediter(somme);
            this.Debiter(somme);
        }

        public void Debiter(decimal somme)
        {
            this.ListeOperations.Add(new OperationBancaire(somme, EnumTypeMouvement.DEBIT));
        }

        public void Debiter(Compte compte, decimal somme)
        {
            compte.Debiter(somme);
            this.Crediter(somme);
        }
    }
}
