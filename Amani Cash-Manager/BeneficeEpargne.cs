using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amani_Cash_Manager
{
    class BeneficeEpargne : ICalculateurBenefice
    {
        public double Taux { get; set; }
        public long NumeroDuCompte { get ; set ; }

        public BeneficeEpargne()
        {
        }
        public BeneficeEpargne(double taux,long numeroCompte)
        {
            this.Taux = taux;
            this.NumeroDuCompte = numeroCompte;
        }

        public decimal CalculerBenefice(decimal solde)
        {
            return solde * (decimal)(1 + GetTaux());
        }

        public double GetTaux()
        {
            return Taux;
        }
    }
}
