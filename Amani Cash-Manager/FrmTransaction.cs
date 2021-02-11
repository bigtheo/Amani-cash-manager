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
    public partial class FrmTransaction : Form
    {
        public FrmTransaction()
        {
            InitializeComponent();
        }

        private void BtnDepot_Click(object sender, EventArgs e)
        {
            new FrmDepot().ShowDialog();
        }

        private void BtnRetrait_Click(object sender, EventArgs e)
        {
            new FrmRetrait().ShowDialog();
        }
    }
}
