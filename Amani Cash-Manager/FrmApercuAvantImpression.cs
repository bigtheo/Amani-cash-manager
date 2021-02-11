using System;
using System.IO;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmApercuAvantImpression : Form
    {
        public FrmApercuAvantImpression()
        {
            InitializeComponent();
            ChargerFichier();
        }

        private void ChargerFichier()
        {
            axFoxitCtl1.OpenFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bordereau.pdf"));
        }

        private void Imprimer()
        {
            axFoxitCtl1.PrintFile();

        }
    }
}