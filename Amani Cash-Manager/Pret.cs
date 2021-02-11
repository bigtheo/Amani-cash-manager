using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public class Pret
    {
        public long Id { get; set; }
        public DateTime DateDuJour { get; }
        public decimal Taux { get; set; }
        public decimal MontantApreter { get; set; }
        public long CompteId { get; set; }
        public string Devise { get; set; }

        #region les methodes preter() et rembouser

        public bool Enregistrer()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "Insert Into PRET(Id,DateDuPret,montant,taux,Devise,CompteId) VALUES (@Id,@DateDuPret,@montant,@taux,@Devise,@CompteId)";
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64);
                MySqlParameter p_DateDuPret = new MySqlParameter("@DateDuPret", MySqlDbType.DateTime);
                MySqlParameter p_montant = new MySqlParameter("@montant", MySqlDbType.Decimal);
                MySqlParameter p_CompteId = new MySqlParameter("@CompteId", MySqlDbType.Int64);
                MySqlParameter p_taux = new MySqlParameter("@taux", MySqlDbType.Decimal);
                MySqlParameter p_Devise = new MySqlParameter("@Devise", MySqlDbType.VarChar, 3);

                //les valeurs des parametres...
                p_Id.Value = null;
                p_DateDuPret.Value = DateTime.Now;
                p_montant.Value = this.MontantApreter;
                p_CompteId.Value = this.CompteId;
                p_taux.Value = this.Taux;
                p_Devise.Value = this.Devise;

                //assignation des parametres à la commande ...

                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_DateDuPret);
                cmd.Parameters.Add(p_montant);
                cmd.Parameters.Add(p_CompteId);
                cmd.Parameters.Add(p_taux);
                cmd.Parameters.Add(p_Devise);

                //exécution de la requette

                try
                {
                    CompteEpargne compte = new CompteEpargne();
                    if (compte.DernierUnEmpruntPaye(this.CompteId))
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Prêt enrgistré avec succès !!!");
                            CreerBordereau();
                            return true;
                        }
                    }
                    MessageBox.Show("Ce client à emprunt en souffrance\nVeuillez regulariser la situation pour être éligible !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public decimal CalculerMontantArembourser()
        {
            return this.MontantApreter + ((this.MontantApreter * this.Taux) / (100));
        }

        #endregion les methodes preter() et rembouser

        #region Obtenir les valeurs des proprités

        public void ObtenirInfoPretParCompteId()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "ObtenirInfoPretParCompteId";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //les parametres...
                MySqlParameter p_CompteId = new MySqlParameter("@p_compteId", MySqlDbType.Int64);
                MySqlParameter p_taux = new MySqlParameter("@p_taux", MySqlDbType.Decimal);
                MySqlParameter p_montant = new MySqlParameter("@p_montantPrete", MySqlDbType.Decimal);
                MySqlParameter p_devise = new MySqlParameter("@p_devise", MySqlDbType.VarChar, 10);
                MySqlParameter p_pretId = new MySqlParameter("@p_pretId", MySqlDbType.Int64);

                //la direction des parametres
                p_CompteId.Direction = System.Data.ParameterDirection.Input;
                p_devise.Direction = System.Data.ParameterDirection.Output;
                p_montant.Direction = System.Data.ParameterDirection.Output;
                p_taux.Direction = System.Data.ParameterDirection.Output;
                p_pretId.Direction = System.Data.ParameterDirection.Output;

                //la valeur du parametre d'entrée
                p_CompteId.Value = this.CompteId;

                //assignation des parametres à la cmd
                cmd.Parameters.Add(p_CompteId);
                cmd.Parameters.Add(p_devise);
                cmd.Parameters.Add(p_montant);
                cmd.Parameters.Add(p_taux);
                cmd.Parameters.Add(p_pretId);

                //exécution de la commade puis recupération des valeurs

                try
                {
                    cmd.ExecuteNonQuery();

                    //récuperation des valeurs
                    this.Devise = p_devise.Value.ToString();
                    this.MontantApreter = (decimal)p_montant.Value;
                    this.Taux = (decimal)p_taux.Value;
                    this.Id = (Int64)p_pretId.Value;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public decimal ObtenirTotalRembourse()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "CalculerTotalDejaRembourse";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //les parametres
                MySqlParameter p_PretId = new MySqlParameter("@p_pretId", MySqlDbType.Int64);
                MySqlParameter p_total = new MySqlParameter("@p_totalRembourse", MySqlDbType.Decimal);

                //la direction des paramtres

                p_PretId.Direction = System.Data.ParameterDirection.Input;
                p_total.Direction = System.Data.ParameterDirection.Output;

                //la valeur IN
                p_PretId.Value = this.Id;

                //assignation à la cmd

                cmd.Parameters.Add(p_PretId);
                cmd.Parameters.Add(p_total);

                try
                {
                    cmd.ExecuteNonQuery();
                    return (decimal)p_total.Value;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }

        public decimal ObtenirResteApayer()
        {
            return CalculerMontantArembourser() - ObtenirTotalRembourse();
        }
        #endregion Obtenir les valeurs des proprités

        #region création du Document PDF à Imprimer
        private void CreerBordereau()
        {
            Bordereau bordereau = new Bordereau()
            {
                NumeroTransaction = Helper.GetDernerNumeroPret(this.CompteId),
                DeviseCompte = this.Devise,
                NumeroCompte = this.CompteId.ToString(),
                MontantPrete = this.MontantApreter.ToString(),
                Taux = this.Taux.ToString(),
                MontantRembourser = this.CalculerMontantArembourser().ToString(),
                IntituleCompte=Helper.GetInfoProprietaire(this.CompteId),
                Titre="Bordereau de prêt"
            };
            bordereau.CreerBordereauPret();
        }
        #endregion
    }
}