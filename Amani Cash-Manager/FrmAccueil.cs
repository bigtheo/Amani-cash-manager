using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
            OuvrirFormulaire(new FrmStaistiques());
        }

        #region Menu principal
        private void BtnOuvriUnCompte_Click(object sender, EventArgs e)
        {
            AppliquerCouleurAuPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelClient);
            AppliquerCouleurParDefautPanel(panelGainClient);
            OuvrirFormulaire(new FrmCreerCompte());
            

        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            AppliquerCouleurAuPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelClient);
            AppliquerCouleurParDefautPanel(panelGainClient);
            OuvrirFormulaire(new FrmTransaction());
        }

        private void BtnEmprunt_Click(object sender, EventArgs e)
        {
            AppliquerCouleurAuPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelClient);
            AppliquerCouleurParDefautPanel(panelGainClient);
            OuvrirFormulaire(new FrmEmprunt());
        }

        private void BtnParametre_Click(object sender, EventArgs e)
        {
            AppliquerCouleurAuPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelClient);
            AppliquerCouleurParDefautPanel(panelGainClient);
            OuvrirFormulaire(new FrmJournal());
        }

        private void AppliquerCouleurAuPanel(Panel panel) 
        {
            panel.BackColor = Color.FromArgb(18, 114, 116);
        }

        private void AppliquerCouleurParDefautPanel(Panel panel)
        {
            panel.BackColor = Color.FromArgb(246, 246, 246);
        }
        #endregion

        #region Ouvrir le formulaire

        private Form activeForm = null;

        private void OuvrirFormulaire(Form formulaireEnfant)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formulaireEnfant;
            formulaireEnfant.TopLevel = false;
            formulaireEnfant.FormBorderStyle = FormBorderStyle.None;
            formulaireEnfant.Dock = DockStyle.Fill;
            panelConteneur.Controls.Add(formulaireEnfant);
            panelConteneur.Tag = formulaireEnfant;
            formulaireEnfant.BringToFront();
            formulaireEnfant.Show();

        }
        #endregion

        private void BtnParametre_Click_1(object sender, EventArgs e)
        {

            

            AppliquerCouleurAuPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelClient);
            AppliquerCouleurParDefautPanel(panelGainClient);
            OuvrirFormulaire(new FrmParametre());
        }

        private void BtnHistorique_Click(object sender, EventArgs e)
        {

            AppliquerCouleurAuPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelClient);
            AppliquerCouleurParDefautPanel(panelGainClient);

            OuvrirFormulaire(new FrmHistotique());
        }

        private void FrmAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEspaceClient_Click(object sender, EventArgs e)
        {

            AppliquerCouleurAuPanel(panelClient);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelGainClient);
            OuvrirFormulaire(new FrmEspaceClient());
        }

        private void BtnGainClient_Click(object sender, EventArgs e)
        {
            AppliquerCouleurAuPanel(panelGainClient);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelTransaction);
            AppliquerCouleurParDefautPanel(panelEmprunt);
            AppliquerCouleurParDefautPanel(panelJournal);
            AppliquerCouleurParDefautPanel(panelOuvrirUnCompte);
            AppliquerCouleurParDefautPanel(panelParametre);
            AppliquerCouleurParDefautPanel(panelHistorique);
            AppliquerCouleurParDefautPanel(panelClient);
            OuvrirFormulaire(new FrmGainClient());
        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PanelLogo_MouseClick(object sender, MouseEventArgs e)
        {
            OuvrirFormulaire(new FrmStaistiques());
        }
    }
}
