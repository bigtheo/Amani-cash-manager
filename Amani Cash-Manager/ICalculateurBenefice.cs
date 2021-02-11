using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amani_Cash_Manager
{
    public interface ICalculateurBenefice
    {
        decimal CalculerBenefice(decimal solde);
        double GetTaux();
        long NumeroDuCompte { get; set; }
        
    }
}
