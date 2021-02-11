using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmGainClient : Form
    {
        public FrmGainClient()
        {
            InitializeComponent();
           
        }

        private void AfficherGainClient()
        {
            if (Int64.TryParse(txtNumeroDuCompte.Text, out long numeroCompte))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string sqlQuery = "select op.ID as 'Transac. ID',op.dateOperation as 'Date du Dépôt'," +
                        "concat_ws(' ', op.montant, cpte.Devise) as 'Montant Dépôsé',concat_ws(' ', round(op.montant*10/100,2), cpte.Devise) as Gain" +
                        ",if ( isnull(GCli.id),'NON','OUI') AS 'Validé O/N' " +
                        "from Operation as op " +
                        "INNER JOIN Compte as cpte ON op.compteID = cpte.id " +
                        "left JOIN GainClient as GCli ON GCli.operation_id = op.id" +
                        " where cpte.id=@NumeroCompte and  timestampdiff(month, date(op.dateOperation),curdate())>=6 ";
                    Connexion.Ouvrir();
                    cmd.Connection = Connexion.Con;
                    cmd.CommandText = sqlQuery;
                    MySqlParameter P_numeroCompte = new MySqlParameter("@NumeroCompte", MySqlDbType.Int64)
                    {
                        Value = numeroCompte
                    };
                    cmd.Parameters.Add(P_numeroCompte);
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        dgvListe.DataSource = table;
                    }
                }
                
                if (dgvListe.Rows.Count > 0)
                {
                    //on active les bouton...
                    BtnImprimer.Enabled = true;
                    BtnDetails.Enabled = true;
                    BtnValider.Enabled = true;
                }
                else
                {
                    BtnDetails.Enabled = false;
                    BtnImprimer.Enabled = false;
                    BtnValider.Enabled = false;
                }
            }
            else
            {
                txtNumeroDuCompte.Clear();
                dgvListe.DataSource = null;
                BtnDetails.Enabled = false;
                BtnImprimer.Enabled = false;
                BtnValider.Enabled = false;
            }
        }

        private void txtNumeroDuCompte_TextChanged(object sender, EventArgs e)
        {
            AfficherGainClient();
            if (dgvListe.Columns.Count > 0)
            {
                dgvListe.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvListe.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvListe.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvListe.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;           
            }
   
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            ValiderGain();
        }

        private void ValiderGain()
        {
            using (MySqlCommand cmd=new MySqlCommand ())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "INSERT INTO GainClient(Id,operation_id) values(@Id,@operation_id)";

                //les parametres MySql 
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = null
                };
                MySqlParameter p_Operation_id = new MySqlParameter("@operation_id", MySqlDbType.Int64)
                {
                    Value = dgvListe.CurrentRow.Cells[0].Value
                };

                //assignation des parametres..
                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_Operation_id);
                DialogResult dialogResult = MessageBox.Show("Voulez-vraiment vraiment Valider ce Gain ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show($"Validation effectuée avec succès...\n{rowsAffected} ligne(s) affectée(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                            AfficherGainClient();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062)
                        {
                            MessageBox.Show("Ce gain a déjà été validé...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'exécution de la requete !!!");
                        }
                    }
                  
                }

            }
        }
    }
}