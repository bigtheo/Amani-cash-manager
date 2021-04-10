using MySql.Data.MySqlClient;
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
    public partial class FrmEspaceClient : Form
    {
        public FrmEspaceClient()
        {
            InitializeComponent();
        }

        private void AfficherListeClientParNoms()
        {
            if (!txtNomsClient.Text.Contains("'")){
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.Connection = Connexion.Con;
                    cmd.CommandText = "select cl.Id As 'N° de compte',UPPER(cl.noms) as 'Noms',cl.NumeroPiece as 'N° pièce Identité'," +
                        "cpte.TypeCompte as 'Type du Compte',cpte.Devise,cpte.DateCreation 'Date de création' " +
                        "from client as cl " +
                        $"INNER JOIN compte as cpte ON cl.id = cpte.ClientId where cl.noms like '%{txtNomsClient.Text}%'";
                    MySqlParameter p_noms = new MySqlParameter("@p_noms", MySqlDbType.VarChar)
                    {
                        Value = txtNomsClient.Text
                    };
                    //on ajoute le parametre à la cmd..
                    cmd.Parameters.Add(p_noms);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table); //on place les données dans la DataTable
                        dgvListe.DataSource = table; //je place je données de tabla dans mon datagridview

                    }
                }
            }
            else
            {
                txtNomsClient.Clear();
            }
        }

        //appel de la methode affichage
        private void TxtNomsClient_TextChanged(object sender, EventArgs e)
        {
            AfficherListeClientParNoms();
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {

        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new FrmModifierInformationClient().ShowDialog();
        }

        private void DgvListe_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FrmModifierInformationClient().ShowDialog();
        }
    }
}
