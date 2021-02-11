using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public class Operation
    {
        public Int64 Id { get; set; }
        public decimal Montant { get; set; }
        public TypeOperation TypeOperation { get; set; }
        public Int64 NumeroDuCompte { get; set; }

        #region le constructeur de la classe

        public Operation( decimal montant, TypeOperation typeOperation, Int64 numeroCompte)
        {
            this.Montant = montant;
            this.TypeOperation = typeOperation;
            this.NumeroDuCompte = numeroCompte;
        }

        #endregion le constructeur de la classe

        public void Enrgistrer()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "INSERT INTO OPERATION(Id,montant,TypeOperation,CompteId) VALUES(@Id,@Montant,@TypeOperation,@NumeroDuCompte)";

                //les parametres MySql 
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.UInt64);
                MySqlParameter p_Montant = new MySqlParameter("@Montant", MySqlDbType.Decimal);
                MySqlParameter p_TypeOperation = new MySqlParameter("@TypeOperation", MySqlDbType.VarChar,15);
                MySqlParameter p_NumeroDuCompte = new MySqlParameter("@NumeroDuCompte", MySqlDbType.UInt64);

                //les valeurs des parametres 
                p_Id.Value = null;
                p_Montant.Value = this.Montant;
                p_NumeroDuCompte.Value = this.NumeroDuCompte;
                p_TypeOperation.Value = this.TypeOperation;

                //assignation des paramtres au cmd

                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_Montant);
                cmd.Parameters.Add(p_TypeOperation);
                cmd.Parameters.Add(p_NumeroDuCompte);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Opération enregitrée avec succès ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}\ncode d'erreur : {ex.Number}");
                }
            }
        }
    }

    public enum TypeOperation
    {
        Debit,
        Credit
    }
}