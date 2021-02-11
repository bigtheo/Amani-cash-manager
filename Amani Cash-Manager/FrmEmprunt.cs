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
    public partial class FrmEmprunt : Form
    {
        public FrmEmprunt()
        {
            InitializeComponent();
        }

        private void BtnPret_Click(object sender, EventArgs e)
        {
            new FrmPret().ShowDialog();
        }

        private void BtnRemboursement_Click(object sender, EventArgs e)
        {
            new FrmRemboursement().ShowDialog();
        }
    }
}
