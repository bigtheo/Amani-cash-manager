using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmNouveauCompte : Form
    {
        public FrmNouveauCompte()
        {
            InitializeComponent();
            CustomizerInformation();
        }

        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion barre de titre

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Client client = new Client
            {
                Id = 0,
                DateNaissance = dtpDateNaissance.Value,
                Noms = txtNom.Text,
                Photo = pbxPhoto.Image,
                NumeroPiece = txtNumeroCarte.Text
                
            };

            client.Enregistrer();
           
            //
            if (lblTypeCompte.Text == TypeCompte.Courant.ToString())
            {
                CompteCourant compte = new CompteCourant()
                {
                    IdDuProprietaire = client.DernierID(),
                    DeviseCompte = FrmDevise.DeviseDuCompte,
                    TypeDuCompte = Compte.TypeCompte.Courant
                };
                compte.Creer();
                //on crédite le compte   
                compte.NumeroDuCompte = int.Parse(compte.GetDernierNumeroDeCompte().ToString());
                compte.Crediter(nupSoldeOuverture.Value);
            }
            else
            {

                CompteEpargne compte = new CompteEpargne()
                {
                    IdDuProprietaire = client.DernierID(),
                    DeviseCompte = FrmDevise.DeviseDuCompte,
                    TypeDuCompte = Compte.TypeCompte.Epargne
                };
                compte.Creer();
                //on crédite le compte   
                compte.NumeroDuCompte = int.Parse(compte.GetDernierNumeroDeCompte().ToString());
                compte.Crediter(nupSoldeOuverture.Value);
            }
           
            NettoyerChamps();
            this.Cursor = Cursors.Default;
        }

        private void NettoyerChamps()
        {
            txtNom.Clear();
            txtNumeroCarte.Clear();
            txtAdresseClient.Clear();
            nupSoldeOuverture.Value = 0;
        }

        private void PbxPhoto_Click(object sender, EventArgs e)
        {
            Parcour_photos();
        }

        private void Parcour_photos()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "choisir l'image (*.jpg *.png ) |*.jpg; *.png"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pbxPhoto.Text = openFileDialog1.FileName;
            }
        }

        #region au region du formualaire
        private void CustomizerInformation()
        {
            lblDevise.Text = FrmDevise.DeviseDuCompte.ToString();
            lblTypeCompte.Text = FrmCreerCompte.TypeDuCompte.ToString();
        }
        #endregion
    }


    public enum Devise
    {
        CDF,
        USD
    }

    public enum TypeCompte
    {
        Courant,
        Epargne
    }
}