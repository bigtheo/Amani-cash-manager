using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{

    public static class Helper
    {
        private static string nomEntite;

        public static string GetNomEntite()
        {
            return nomEntite;
        }

        private static void SetNomEntite(string value)
        {
            nomEntite = value;
        }

        public static string AdresseEntite { get; private set; }
        public static string RccmEntite { get; private set; }
        public static string Cordonnees { get; private set; }

        #region la sauvergarde de la base des données
        public static void Backup()
        {
            string nom_du_fichier = DateTime.Now.Date.ToString("AMANI_DB_backup dd MMM yyyy HH mm") + ".sql";
            string file = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + nom_du_fichier;

            using (MySqlConnection conn = Connexion.Con)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        Connexion.Ouvrir();
                        cmd.Connection = Connexion.Con;
                        mb.ExportToFile(file);
                        MessageBox.Show("Sauvegarde éffectuée avec succès !!!", "Infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion la sauvergarde de la base des données

        #region autres methodes statiques
        public static void ChargerDernierPret(DataGridView dataGridView, Int64 CompteId)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "DernierEmpruntPaye";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_CompteId = new MySqlParameter("@p_CompteId", MySqlDbType.Int64);
                MySqlParameter p_paye = new MySqlParameter("@p_paye", MySqlDbType.UInt16);
                p_CompteId.Direction = ParameterDirection.Input;
                p_paye.Direction = ParameterDirection.Output;
                p_CompteId.Value = CompteId;
                cmd.Parameters.Add(p_CompteId);
                cmd.Parameters.Add(p_paye);

                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            dataGridView.DataSource = table;
                        }
                        else
                        {
                            dataGridView.DataSource = null;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

 

        public static DataTable AfficherHistoriqueCompte(long numeroDuCompte)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "AfficherHistoriqueCompte";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_CompteId = new MySqlParameter("@p_compteId", MySqlDbType.Int64)
                {
                    Direction = ParameterDirection.Input,
                    Value = numeroDuCompte
                };
                cmd.Parameters.Add(p_CompteId);
                CompteCourant compte = new CompteCourant
                {
                    NumeroDuCompte = (int)numeroDuCompte
                };

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if(compte.TypeDuCompte==Compte.TypeCompte.Courant)
                    table.Rows.Add(new object[] { null, "Solde", null, compte.Solde });
                    else
                        table.Rows.Add(new object[] { null, "Solde + Gain", null, compte.Solde });

                    return table;
                }
            }
        }

        public static string GetDernerNumeroOperation(long numeroCompte)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select max(id) as nombre from operation where compteId=@CompteId";
                MySqlParameter p_CompteId = new MySqlParameter("@CompteId", MySqlDbType.Int64)
                {
                    Value = numeroCompte
                };
                cmd.Parameters.Add(p_CompteId);
                if (Int64.TryParse(cmd.ExecuteScalar().ToString(), out Int64 NumeroOperation))
                {
                    return NumeroOperation.ToString();
                }
                return "null";
            }
        }

        public static void AddEntete(Document document)
        {
            #region la police

            iTextSharp.text.Font police = FontFactory.GetFont("TIMES NEW ROMAN", 16, 1, new BaseColor(31, 50, 64));
            police.SetStyle(iTextSharp.text.Font.BOLD);

            #endregion la police
            ChargerInformationDeLentreprise();

            string entite = $"CAISSE D'EPARGNE\n{GetNomEntite()}";
            string Adresse = AdresseEntite;
            string dateJour = $"Date d'impression :{DateTime.Now}";
            Paragraph p_entete = new Paragraph(entite, police)
            {
                Alignment = Element.ALIGN_CENTER
            };

            police = FontFactory.GetFont("TIMES NEW ROMAN", 10, 1, new BaseColor(31, 50, 64));
            Chunk c_adresse = new Chunk(Adresse, police);
            c_adresse.SetUnderline(0.2f, -2f);

            Paragraph p_adresse = new Paragraph(c_adresse)
            {
                Alignment = Element.ALIGN_CENTER
            };
<<<<<<< Updated upstream
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 12,0,BaseColor.MAGENTA);
=======
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 1,0,BaseColor.MAGENTA);
>>>>>>> Stashed changes

            Paragraph P_date_jour = new Paragraph(dateJour, font)
            {
                Alignment = Element.ALIGN_CENTER
            };

            document.Add(p_entete);
            document.Add(p_adresse);
            document.Add(P_date_jour);
        }

        private  static void ChargerInformationDeLentreprise()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "SELECT* from entite limit 1";
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    SetNomEntite(dataReader.GetString(1));
                    AdresseEntite = dataReader.GetString(2);
                    RccmEntite = dataReader.GetString(3);
                    Cordonnees = dataReader.GetString(4);
                }
            }
        }
        internal static string GetDernerNumeroPret(long numeroCompte)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select max(id) as nombre from pret where compteId=@CompteId";
                MySqlParameter p_CompteId = new MySqlParameter("@CompteId", MySqlDbType.Int64)
                {
                    Value = numeroCompte
                };
                cmd.Parameters.Add(p_CompteId);
                if (Int64.TryParse(cmd.ExecuteScalar().ToString(), out Int64 NumeroOperation))
                {
                    return NumeroOperation.ToString();
                }
                return "null";
            }
        }
        internal static string GetDernerNumeroRemboursement()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select id as nombre from remboursement order by(id) desc limit 1";
                return Convert.ToString( cmd.ExecuteScalar());
  
            }
        }
        internal static string GetInfoProprietaire(long compteId)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select noms from client where Id=@Id";
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = compteId
                };
                cmd.Parameters.Add(p_Id);
                try
                {
                    if (null != cmd.ExecuteScalar())
                        return cmd.ExecuteScalar().ToString();
                    return "";
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }
            }
        }
        public static decimal CalculerTotalGain(long NumeroDuCompte)
        {

            using (MySqlCommand cmd = new MySqlCommand())
            {

                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select sum(o.montant)*0.01 from operation as o " +
                    "inner join compte as cpte on cpte.id = o.compteId " +
                    "inner join GainClient as g on g.operation_id = o.id " +
                    "where cpte.TypeCompte = 'Epargne' and cpte.Id = @CompteId";

                MySqlParameter p_CompteId = new MySqlParameter("@CompteId", MySqlDbType.Int64)
                {
                    Value = NumeroDuCompte
                };
                cmd.Parameters.Add(p_CompteId);

                if (decimal.TryParse(cmd.ExecuteScalar().ToString(), out decimal totalGain))
                {
                    return totalGain;
                }
                else
                {
                    return 0;
                }
            }


        }
        #endregion
    }

   
}