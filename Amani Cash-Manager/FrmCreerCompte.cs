using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmCreerCompte : Form
    {
        public FrmCreerCompte()
        {
            InitializeComponent();
        }

        private void BtnCompteEpargne_Click(object sender, EventArgs e)
        {
            TypeDuCompte = Compte.TypeCompte.Epargne;
            new FrmDevise().ShowDialog();
          
        }

        private void BtnCompteCourant_Click(object sender, EventArgs e)
        {
            TypeDuCompte = Compte.TypeCompte.Courant;
            new FrmDevise().ShowDialog();
 
        }

        public static Compte.TypeCompte TypeDuCompte { get; set; }

    }
}
