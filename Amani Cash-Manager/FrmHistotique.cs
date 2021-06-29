using System;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmHistotique : Form
    {
        public FrmHistotique()
        {
            InitializeComponent();
            
        }


        #region Listage des historiques.
        //liste l'historique des transactions dépôt-retrait.
        private void AfficherHistoriqueTransaction()
        {
            if (Ck_remboursement.Checked)
            {
                ListerHistoriqueRemboursement();
            }
            else
            {
                ListerHistoriqueDesDepotRetrait();
            }

        }
        private void ListerHistoriqueDesDepotRetrait()
        {
            if (int.TryParse(txtNumeroDuCompte.Text, out int numeroDuCompte))
            {

                dgvListe.DataSource = Helper.AfficherHistoriqueCompte(numeroDuCompte);
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
        //Liste l'historique des remboursements
        private void ListerHistoriqueRemboursement()
        {
            if (int.TryParse(txtNumeroDuCompte.Text, out int numeroDuCompte))
            {

                dgvListe.DataSource = Helper.AfficherHistoriqueRemboursement(numeroDuCompte);
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
        private void txtNumeroDuCompte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AfficherHistoriqueTransaction();
            }
        }
        #endregion 

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            new FrmEspaceCompte().ShowDialog();
            new FrmEspaceCompte().ShowInTaskbar = false;
        }
        public static long NumeroCompte { get; set; }
        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            if (dgvListe.Rows.Count > 0)
            {
                if (Ck_remboursement.Checked)
                {
                    ImprimerHistoriqueRemboursement();
                }
                else
                {
                    ImprimerHistoriqueCompte();
                }
            }
            else
            {
                MessageBox.Show("La grille ne contient aucune ligne","information",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            
        }
        private void ImprimerHistoriqueCompte()
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
        private void ImprimerHistoriqueRemboursement()
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
                    Titre = $"{lblTitre.Text}-Remoursement-{compte.GetInfoProprietaire()} "
                };
                bordereau.CreerListeHistoriqueRemboursement(dgvListe);
            }
            else
            {
                MessageBox.Show("Le format du numero de compte n'est pas valide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            this.Cursor = Cursors.Default;
        }


        private void Ck_remboursement_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvListe.Rows.Count > 0)
            {
                dgvListe.DataSource = null;
                
            }

            if (Ck_remboursement.Checked)
            {
                ListerHistoriqueRemboursement();
            }
            else
            {
                ListerHistoriqueDesDepotRetrait();
            }

        }
    }
}
