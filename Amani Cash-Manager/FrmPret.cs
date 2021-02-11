using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmPret : Form
    {
        public FrmPret()
        {
            InitializeComponent();
        }

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
            if (int.TryParse(txtNumerDuCompte.Text, out int numeroDuCompte))
            {
                CompteEpargne compte = new CompteEpargne() { NumeroDuCompte = numeroDuCompte };
                txtNoms.Text = compte.GetInfoProprietaire();
                Helper.ChargerDernierPret(DgvListe, numeroDuCompte);
                if (DgvListe.Rows.Count == 1)
                {
                    lblMessage.Visible = false;
                }
                else
                {
                    if (txtNoms.Text.Length > 0)
                        lblMessage.Visible = true;
                    else
                    {
                        lblMessage.Visible = false;
                    }
                }
            }
            else
            {
                txtNoms.Clear();
                DgvListe.DataSource = null;
                lblMessage.Visible = false;
            }
        }

        #endregion au changement du numero du compte

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Pret pret = new Pret
            {
                MontantApreter = nupMontantApreter.Value,
                Taux = nupTaux.Value,
                CompteId = Int64.Parse(txtNumerDuCompte.Text),
                Devise = cbxDevise.Text
            };
            pret.Enregistrer();
            NetoyerChamps();
            this.Cursor = Cursors.Default;
        }

        private void NetoyerChamps()
        {
            txtNoms.Clear();
            txtNumerDuCompte.Text="0";
            nupMontantApreter.Value = 0;
            nupMontantArembourser.Value = 0;
            nupTaux.Value = 0;
            cbxDevise.Text = "";
        }

        private void TxtNumerDuCompte_TextChanged(object sender, EventArgs e)
        {
            Custumize();
        }

        private void NupMontantApreter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Pret pret = new Pret
                {
                    MontantApreter = nupMontantApreter.Value,
                    Taux = nupTaux.Value,
                    CompteId = Int64.Parse(txtNumerDuCompte.Text),
                    Devise = cbxDevise.Text
                };
                nupMontantArembourser.Value = pret.CalculerMontantArembourser();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}