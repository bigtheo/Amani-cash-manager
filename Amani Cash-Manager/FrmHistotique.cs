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
    public partial class FrmHistotique : Form
    {
        public FrmHistotique()
        {
            InitializeComponent();
            
        }

        private void TxtNumeroDuCompte_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtNumeroDuCompte.Text,out int numeroDuCompte))
            {

                dgvListe.DataSource= Helper.AfficherHistoriqueCompte(numeroDuCompte);
                BtnDetails.Enabled = true;
                BtnImprimer.Enabled = true;
                NumeroCompte = numeroDuCompte;
               
            }
            else
            {
                dgvListe.DataSource = null;
                BtnDetails.Enabled = false;
                BtnImprimer.Enabled = false;
                NumeroCompte = 0;
            }
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            new FrmEspaceCompte().ShowDialog();
            new FrmEspaceCompte().ShowInTaskbar = false;
        }
        public static long NumeroCompte { get; set; }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (int.TryParse(txtNumeroDuCompte.Text, out int valeur))
            {          
                Compte compte = new CompteEpargne();

                if (compte.TypeDuCompte == Compte.TypeCompte.Epargne)
                {
                   compte = new CompteEpargne(NumeroCompte)
                    {
                        NumeroDuCompte = valeur
                    };
                }
                else
                {
                    compte = new CompteCourant() { NumeroDuCompte = valeur };
                }
                    
                //création du rapport...
                Bordereau bordereau = new Bordereau()
                {
                    Titre = $"{lblTitre.Text}  {compte.GetInfoProprietaire()} "
                };
                bordereau.CreerListeHistorique(dgvListe);
            }
            else
            {
                MessageBox.Show("Le format du numero de compte n'est pas valide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            this.Cursor = Cursors.Default;
        }
    }
}
