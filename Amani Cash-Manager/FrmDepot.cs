using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmDepot : Form
    {
        public FrmDepot()
        {
            InitializeComponent();
        }

        #region Barre de Titre

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr ptr, int v1, int v2, int v3);

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion Barre de Titre

        #region au chargement du formualaire

        private void Custumize()
        {
            if (int.TryParse(txtNumeroDuCompte.Text, out int numeroDuCompte))
            {
                if (lblTypeDuCompte.Text == Compte.TypeCompte.Epargne.ToString())
                {

                    CompteEpargne compte = new CompteEpargne(numeroDuCompte);
                    nupSoldeDuCompte.Value = compte.Solde;
                    lblDevise.Text = compte.GetDeviseCompte();
                    lblTypeDuCompte.Text = compte.GetTypeDuCompte().ToString();
                    txtNoms.Text = compte.GetInfoProprietaire();
                    nupMontantAdeposer.Value = 0;
                }
                else
                {
                    CompteCourant compte = new CompteCourant { NumeroDuCompte = numeroDuCompte };
                    nupSoldeDuCompte.Value = compte.Solde;
                    lblDevise.Text = compte.GetDeviseCompte();
                    lblTypeDuCompte.Text = compte.GetTypeDuCompte().ToString();
                    txtNoms.Text = compte.GetInfoProprietaire();
                    nupMontantAdeposer.Value = 0;
                }
            }
            else
            {
                nupSoldeDuCompte.Value = 0;
                lblDevise.Text = "Devise";
                lblTypeDuCompte.Text = "Type du compte";
                txtNoms.Clear();
                nupMontantAdeposer.Value = 0;
            }
        }

        #endregion au chargement du formualaire

        private void TxtNumeroDuCompte_TextChanged(object sender, EventArgs e)
        {
            Custumize();
            Getphoto();
        }

        private void Getphoto()
        {
            if(long.TryParse(txtNumeroDuCompte.Text,out long numero_compte))
            {
                Client client = new Client();
                pictureBox1.Image = client.GetPhotoByNumeroCompte(numero_compte);
            }

        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (int.TryParse(txtNumeroDuCompte.Text, out int numeroDuCompte))
            {
                if (lblTypeDuCompte.Text == TypeCompte.Epargne.ToString())
                {
                    
                    CompteEpargne compte = new CompteEpargne() { NumeroDuCompte = numeroDuCompte };

                    compte.Crediter(nupMontantAdeposer.Value);
                    _ = new Bordereau();

                }
                else
                {
                    CompteCourant compte = new CompteCourant() { NumeroDuCompte = numeroDuCompte };
                    compte.Crediter(nupMontantAdeposer.Value);
                }

                NettoyerChamps();
            }
            this.Cursor = Cursors.Default;
        }

        private void NettoyerChamps()
        {
            txtNoms.Clear();
            txtNumeroDuCompte.Clear();
            nupMontantAdeposer.Value = 0;
            nupSoldeDuCompte.Value = 0;
        }
    }
}