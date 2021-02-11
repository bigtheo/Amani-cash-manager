using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmDevise : Form
    {
        public FrmDevise()
        {
            InitializeComponent();
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


        private void BtnDeviseCDF_Click(object sender, EventArgs e)
        {
            DeviseDuCompte = Compte.Devise.CDF;
            new FrmNouveauCompte().ShowDialog();
            
        }

        private void BtnDeviseUSD_Click(object sender, EventArgs e)
        {
            DeviseDuCompte = Compte.Devise.USD;
            new FrmNouveauCompte().ShowDialog();
           
        }
        public static Compte.Devise DeviseDuCompte  { get; set; }

    }
}