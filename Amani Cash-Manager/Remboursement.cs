using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    internal class Remboursement
    {
        public Int64 Id { get; }
        public DateTime DateDuJour { get; }
        public Int64 PretId { get; set; }
        public decimal Montant { get; set; }

        #region les methodes preter() et rembouser

        public bool Enregistrer()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "Insert Into remboursement(Id,dateRemboursement,montant,PretId) VALUES (@Id,@dateRemboursement,@montant,@PretId)";
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64);
                MySqlParameter p_DateRemboursement = new MySqlParameter("@dateRemboursement", MySqlDbType.DateTime);
                MySqlParameter p_montant = new MySqlParameter("@montant", MySqlDbType.Decimal);
                MySqlParameter p_PretId = new MySqlParameter("@PretId", MySqlDbType.Int64);

                //les valeurs des parametres...
                p_Id.Value = null;
                p_DateRemboursement.Value = DateTime.Now;
                p_PretId.Value = this.PretId;
                p_montant.Value = this.Montant;

                //assignation des parametres à la commande ...

                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_DateRemboursement);
                cmd.Parameters.Add(p_montant);
                cmd.Parameters.Add(p_PretId);

                //exécution de la requette

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Remboursement enrgistré avec succès !!!");

                        return true;
                    }
                    return false;
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 3819)
                    {
                        MessageBox.Show("le montant à rembourser ne peut pas être égal à zéro ");
                        return false;
                    }
                    else
                    {
                        MessageBox.Show($"{ ex.Message} numéro de l'erreur : {ex.Number}");
                        return false;
                    }
                }
            }
        }

        #region création du Document PDF à Imprimer

        

        #endregion création du Document PDF à Imprimer

        #endregion les methodes preter() et rembouser
    }
}