using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmRetrait : Form
    {
        public FrmRetrait()
        {
            InitializeComponent();
        }

        #region barre de titre...

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion barre de titre...
        #region au chargement du formualaire
        private void TrouverInfoClient()
        {
            
            if (long.TryParse(txtNumeroDuCompte.Text, out Int64 numeroDuCompte))
            {
                if (lblTypeDuCompte.Text == Compte.TypeCompte.Epargne.ToString())
                {
                    CompteEpargne compte = new CompteEpargne() { NumeroDuCompte = (int)numeroDuCompte };
                    nupSoldeDuCompte.Value = compte.Solde;
                    lblDevise.Text = compte.GetDeviseCompte();
                    lblTypeDuCompte.Text = compte.GetTypeDuCompte().ToString();
                    txtNoms.Text = compte.GetInfoProprietaire();
                    nupMontantAretirer.Value = 0;
                }
                else
                {
                    
                    CompteCourant compte = new CompteCourant() { NumeroDuCompte = (int)numeroDuCompte };
                    nupSoldeDuCompte.Value = compte.Solde;
                    lblDevise.Text = compte.GetDeviseCompte();
                    lblTypeDuCompte.Text = compte.GetTypeDuCompte().ToString();
                    txtNoms.Text = compte.GetInfoProprietaire();
                    nupMontantAretirer.Value = 0;
                }
               
            
                
            }
            else
            {
                nupSoldeDuCompte.Value = 0;
                lblDevise.Text = "Devise";
                lblTypeDuCompte.Text = "Type du compte";
                txtNoms.Clear();
                nupMontantAretirer.Value = 0;
                NettoyerChamps();
            }


        }
        private void NettoyerChamps()
        {
            txtNoms.Clear();
            txtNumeroDuCompte.Clear();
            nupSoldeDuCompte.Value = 0;
            nupMontantAretirer.Value = 0;
        }
        #endregion

        #region lors du chanegement de la valeur le champs numéro du compte
        private void TxtNumeroDuCompte_TextChanged(object sender, EventArgs e)
        {
            TrouverInfoClient();
        }
        #endregion

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if(int.TryParse(txtNumeroDuCompte.Text,out int numeroDuCompte))
            {
                if (lblTypeDuCompte.Text == TypeCompte.Epargne.ToString())
                {
                    CompteEpargne compte = new CompteEpargne() { NumeroDuCompte = numeroDuCompte };
                    compte.Debiter(nupMontantAretirer.Value);
                }
                else
                {
                    CompteCourant compte = new CompteCourant() { NumeroDuCompte = numeroDuCompte };
                    compte.Debiter(nupMontantAretirer.Value);
                }

                NettoyerChamps();
                
            }
            this.Cursor = Cursors.Default;

        }
    }
}