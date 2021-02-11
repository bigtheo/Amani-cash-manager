using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public class CompteEpargne : Compte
    {


        public CompteEpargne()
        {
           
        }

        public CompteEpargne( long numeroDuCompte)
        {
            this.NumeroDuCompte =(int) numeroDuCompte;
        }

        public override decimal CalculerSolde()
        {
            return base.CalculerSolde() + Helper.CalculerTotalGain(this.NumeroDuCompte);
        }
    }
}
