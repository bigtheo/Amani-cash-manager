using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmJournal : Form
    {
        internal static TypeJournal typeJournal;

        public FrmJournal()
        {
            InitializeComponent();
        }

        private void BtnJournalDesDepots_Click(object sender, EventArgs e)
        {
            typeJournal = TypeJournal.Depot;
            new FrmJournalGeneral().ShowDialog();
        }

        private void BtnJournalDesRetraits_Click(object sender, EventArgs e)
        {
            typeJournal = TypeJournal.Retrait;
            new FrmJournalGeneral().ShowDialog();
        }

        private void BtnJournalDesPrets_Click(object sender, EventArgs e)
        {
            typeJournal = TypeJournal.Pret;
            new FrmJournalGeneral().ShowDialog();
        }

        private void BtnCompteRemboursement_Click(object sender, EventArgs e)
        {
            typeJournal = TypeJournal.Remboursement;
            new FrmJournalGeneral().ShowDialog();
        }
    }
}
