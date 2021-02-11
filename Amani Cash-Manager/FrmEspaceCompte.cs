using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmEspaceCompte : Form
    {
        public FrmEspaceCompte()
        {
            InitializeComponent();
            nupNumeroCompte.Value = FrmHistotique.NumeroCompte;
            ObtenirInformationCompte();
        }

        #region barre de titre..

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion barre de titre..

        #region fonction de recherche des informations sur le compte client

        private void ObtenirInformationCompte()
        {

            if (int.TryParse(nupNumeroCompte.Text, out int numeroDuCompte))
            {
                Compte compte;
                if (lblTypeDuCompte.Text == Compte.TypeCompte.Epargne.ToString())
                {

                    compte = new CompteEpargne() { NumeroDuCompte = numeroDuCompte };
                }
                else
                {
                    compte=new CompteCourant() { NumeroDuCompte = numeroDuCompte };
                }
                
                nupSoldeDuCompte.Value = compte.Solde;
                lblDevise.Text = compte.GetDeviseCompte();
                lblTypeDuCompte.Text = compte.GetTypeDuCompte().ToString();
                lblProprietaire.Text = compte.GetInfoProprietaire();
                lblDateCreation.Text = compte.GetDateCreation();

                if(lblTypeDuCompte.Text=="Epargne")
                lblDateAterme.Text = GetDateAterme((int)numeroDuCompte).ToString();
                else
                {
                    lblDesignationAterme.Text = "-";
                    lblDateAterme.Text = "-";
                }

            }
            else
            {
                nupSoldeDuCompte.Value = 0;
                lblDevise.Text = "Devise";
                lblTypeDuCompte.Text = "Type du compte";
                lblProprietaire.Text="Propriétaire";
                lblDateCreation.Text = "Date création";

            }
        }

        public DateTime GetDateAterme(Int64 NumeroDuCompte)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select DateCreation from compte where Id=@Id";

                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = NumeroDuCompte
                };
                cmd.Parameters.Add(p_Id);
                return Convert.ToDateTime(cmd.ExecuteScalar()).AddMonths(6);
            }
        }
        #endregion fonction de recherche des informations sur le compte client

        private void TxtNumeroDuCompte_TextChanged(object sender, EventArgs e)
        {
            ObtenirInformationCompte();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}