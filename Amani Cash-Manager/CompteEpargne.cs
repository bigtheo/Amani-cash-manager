using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public class CompteEpargne : Compte
    {
        public CompteEpargne()
        {
            this.TypeDuCompte = TypeCompte.Epargne;
        }

        #region le méthode pour créer les comptes

        public void Creer()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "INSERT INTO Compte(id,TypeCompte,Devise,DateCreation,ClientId) values (@id,@TypeCompte,@devise,@DateCreation,@ClientID)";
                MySqlParameter p_Id = new MySqlParameter("@id", MySqlDbType.Int64);
                MySqlParameter p_TypeCompte = new MySqlParameter("@TypeCompte", MySqlDbType.VarChar, 15);
                MySqlParameter p_Devise = new MySqlParameter("@devise", MySqlDbType.VarChar, 15);
                MySqlParameter p_DateCreation = new MySqlParameter("@DateCreation", MySqlDbType.DateTime);
                MySqlParameter p_ClientId = new MySqlParameter("@ClientID", MySqlDbType.Int64);

                //assignation des valeurs aux parametres
                p_Id.Value = null;
                p_TypeCompte.Value = TypeCompte.Epargne;
                p_Devise.Value = this.DeviseCompte;
                p_DateCreation.Value = DateTime.Now;
                p_ClientId.Value = this.IdDuProprietaire;

                //ajout des parametres à la cmd
                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_TypeCompte);
                cmd.Parameters.Add(p_DateCreation);
                cmd.Parameters.Add(p_Devise);
                cmd.Parameters.Add(p_ClientId);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Compte  créeé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion le méthode pour créer les comptes

        public CompteEpargne(long numeroDuCompte)
        {
            this.NumeroDuCompte = (int)numeroDuCompte;
        }

        public override decimal CalculerSolde()
        {
            return base.CalculerSolde() + Helper.CalculerTotalGain(this.NumeroDuCompte);
        }
    }
}