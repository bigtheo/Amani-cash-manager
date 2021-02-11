using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmRemboursement : Form
    {
        public FrmRemboursement()
        {
            InitializeComponent();
        }

        public static Int64 PretId { get; set; }

        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion barre de titre

        #region au changement du numero du compte

        private void Custumize()
        {
            if (int.TryParse(txtNumeroDuCompte.Text, out int numeroDuCompte))
            {
                CompteEpargne compte = new CompteEpargne() { NumeroDuCompte = numeroDuCompte };
                txtNoms.Text = compte.GetInfoProprietaire();

                Pret pret = new Pret { CompteId = numeroDuCompte };
                pret.ObtenirInfoPretParCompteId();

                //récuperation des informations du pret...
                nupTaux.Value = pret.Taux;
                nupMontantPrete.Value = pret.MontantApreter;
                lblDevise.Text = pret.Devise;
                nupTotalARembourse.Value = pret.CalculerMontantArembourser();
                PretId = pret.Id;
                nupTotalRembourse.Value = pret.ObtenirTotalRembourse();

                //on calcule le reste à rembourser
                nupResteArembourser.Value = nupTotalARembourse.Value - nupTotalRembourse.Value;
            }
            else
            {
                txtNoms.Clear();
                nupTaux.Value = 0;
                nupMontantPrete.Value = 0;
                lblDevise.Text = "Devise";
                nupTotalARembourse.Value = 0;
                nupTotalRembourse.Value = 0;
                nupResteArembourser.Value = 0;
            }
        }

        #endregion au changement du numero du compte

        #region autres méthodes
        private void TxtNumeroDuCompte_TextChanged(object sender, EventArgs e)
        {
            Custumize();
            nupMontant.Maximum = nupResteArembourser.Value;
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; 
            if (MontantArembourserEstSuperieurUN_Trantieme())
            {
               
                Remboursement remboursement = new Remboursement { Montant = nupMontant.Value, PretId = PretId };
                remboursement.Enregistrer();
                CreerBordereau();
                NetoyerChamps();
            }
            else
            {
                MessageBox.Show("Le montant à rembourser ne répresente pas le 1/30 du montant prêté + Interêt ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }

            this.Cursor = Cursors.Default;
        }

        private void NetoyerChamps()
        {
            txtNoms.Clear();
            txtNumeroDuCompte.Clear();
            nupMontant.Value = 0;
            nupMontantPrete.Value = 0;
            nupResteArembourser.Value = 0;
            nupTaux.Value = 0;
            nupTotalARembourse.Value = 0;
            nupTotalRembourse.Value = 0;
        }

        private void CreerBordereau()
        {
            this.Cursor = Cursors.WaitCursor;
            if (long.TryParse(txtNumeroDuCompte.Text, out long numeroCompte))
            {
                Bordereau bordereau = new Bordereau()
                {
                    DeviseCompte = lblDevise.Text,
                    NumeroCompte = numeroCompte.ToString(),
                    MontantPrete = nupMontantPrete.Value.ToString(),
                    Taux = nupTaux.Value.ToString(),
                    MontantRembourser = nupTotalARembourse.Value.ToString(),
                    IntituleCompte = txtNoms.Text,
                    Titre = "Bordereau de remboursement",
                    TotalDepose = (nupTotalRembourse.Value + nupMontant.Value).ToString(),
                    ResteApayer = (nupResteArembourser.Value - nupMontant.Value).ToString(),
                    Montant = nupMontant.Value.ToString()
                };
                bordereau.CreerBordereauRemboursement();
            }
            else
            {
                MessageBox.Show("Impossible de créer le bordereau");
            }
            this.Cursor = Cursors.Default;
        }

        private bool MontantArembourserEstSuperieurUN_Trantieme()
        {
            return (nupMontant.Value >= (nupTotalARembourse.Value) / 30) || (nupResteArembourser.Value < (nupTotalARembourse.Value) / 30);
        }
        #endregion


    }
}