using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public abstract class Compte
    {
        #region Proprietés de la classe

        public long NumeroDuCompte { get; set; }

        public decimal Solde
        {
            get
            {
                decimal total = CalculerSolde();
                return total;
            }
        }

        public DateTime DateDeCreation { get; set; }
        public int IdDuProprietaire { get; set; }
        public Devise DeviseCompte { get; set; }

        private TypeCompte typeDuCompte;
        public TypeCompte TypeDuCompte
        {
            get
            {
                typeDuCompte = GetTypeDuCompte();
                return typeDuCompte;
            }
            set { typeDuCompte = value; }
        }

        #endregion Proprietés de la classe

        #region les constructeurs de la classe

        protected Compte()
        {
            this.NumeroDuCompte = 0;
            this.DateDeCreation = DateTime.Now;
        }

        public virtual decimal CalculerSolde()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select TypeOperation,montant from Operation where compteId=@CompteId";
                MySqlParameter p_CompteId = new MySqlParameter("@CompteId", MySqlDbType.Int64)
                {
                    Value = this.NumeroDuCompte
                };
                cmd.Parameters.Add(p_CompteId);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    decimal total = 0;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        if (row[0].ToString() == "Credit")
                        {
                            total += (decimal)row[1];
                        }
                        else
                        {
                            total -= (decimal)row[1];
                        }
                    }

                    //calcul du total gain pour le client et le solde reel

                    return total;
                }
            }
        }

        #endregion les constructeurs de la classe
        
        #region les méthodes pour debiter et crediter le compte

        public void Crediter(decimal montant)
        {
            if (montant > 0)
            {
                Operation operation = new Operation(montant, TypeOperation.Credit, this.NumeroDuCompte);
                operation.Enrgistrer();

                Bordereau bordereau = new Bordereau()
                {
                    DeviseCompte = this.GetDeviseCompte(),
                    TypeCompte = this.GetTypeDuCompte().ToString(),
                    NumeroCompte = this.NumeroDuCompte.ToString(),
                    NumeroTransaction = operation.Id.ToString(),
                    IntituleCompte = this.GetInfoProprietaire(),
                    MontantPrete = montant.ToString(),
                    Solde = this.Solde.ToString(),
                    Titre = "Bordereau de dépôt"
                };
                bordereau.CreerBordereau();
            }
            else
            {
                MessageBox.Show($"Vous ne pouvez pas enregistrer un  montant négatif ou null : {montant}");
            }
        }

        public void Crediter(decimal montant, Compte compte)
        {
            Debiter(montant);
            compte.Crediter(montant);
        }

        public void Debiter(decimal montant)
        {
            if (GetTypeDuCompte() != TypeCompte.Epargne)
            {
                if (montant > 0 && montant < this.Solde)
                {
                    Operation operation = new Operation(montant, TypeOperation.Debit, this.NumeroDuCompte);
                    operation.Enrgistrer();

                    Bordereau bordereau = new Bordereau()
                    {
                        DeviseCompte = this.GetDeviseCompte(),
                        TypeCompte = GetTypeDuCompte().ToString(),
                        NumeroCompte = this.NumeroDuCompte.ToString(),
                        NumeroTransaction = operation.Id.ToString(),
                        IntituleCompte = this.GetInfoProprietaire(),
                        MontantPrete = montant.ToString(),
                        
                        Solde = this.Solde.ToString(),
                        Titre = "Bordereau de retrait"
                    };
                    bordereau.CreerBordereau();
                }
                else
                {
                    MessageBox.Show($"Vous ne pouvez pas retirer au délà de votre votre solde :\nLe montant : {montant} est superieur ou égal à votre solde du compte :{this.Solde}");
                }
            }
            else
            {
                if (GetNombreDeMoisEntreDateCreationEtDateDuJour() >= 6)
                {
                    if (montant > 0 && montant < this.Solde)
                    {
                        Operation operation = new Operation(montant, TypeOperation.Debit, this.NumeroDuCompte);
                        operation.Enrgistrer();
                    }
                    else
                    {
                        MessageBox.Show($"Vous ne pouvez pas retirer au délà de votre votre solde :\nLe montant : {montant} est superieur ou égal à votre solde du compte :{this.Solde}");
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas retirer dans un compte d'épargne qui n'a pas totalisé le 6 mois ");
                }
            }
        }

        public void Debiter(decimal montant, Compte compte)
        {
            Crediter(montant);
            compte.Debiter(montant);
        }

        #endregion les méthodes pour debiter et crediter le compte

        

        #region les methodes statfiques

        public static Int64 ObtenirDernierID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select max(id) from compte";
                try
                {
                    return Int64.Parse(cmd.ExecuteScalar().ToString());
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return 0;
                }
                catch (InvalidCastException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }

        public string GetDeviseCompte()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select Devise from compte where Id=@Id";

                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = this.NumeroDuCompte
                };
                cmd.Parameters.Add(p_Id);
                if (null != cmd.ExecuteScalar())
                    return cmd.ExecuteScalar().ToString();
                return "";
            }
        }
        public string GetDeviseCompte(long numeroCompte)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select Devise from compte where Id=@Id";

                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = numeroCompte
                };
                cmd.Parameters.Add(p_Id);
                if (null != cmd.ExecuteScalar())
                    return cmd.ExecuteScalar().ToString();
                return "";
            }
        }

        public TypeCompte GetTypeDuCompte()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select TypeCompte from compte where Id=@Id";

                MySqlParameter mySqlParameter = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = this.NumeroDuCompte
                };
                MySqlParameter p_Id = mySqlParameter;
                cmd.Parameters.Add(p_Id);
                if (null != cmd.ExecuteScalar())
                {
                    if (cmd.ExecuteScalar().ToString() == TypeCompte.Epargne.ToString())
                    {
                        return TypeCompte.Epargne;
                    }
                    return TypeCompte.Courant;
                }
                return TypeCompte.Courant;
            }
        }

        public string GetDateCreation()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select DateCreation from compte where Id=@Id";

                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = this.NumeroDuCompte
                };
                cmd.Parameters.Add(p_Id);
                return Convert.ToString(cmd.ExecuteScalar());
            }
        }

        public int GetNombreDeMoisEntreDateCreationEtDateDuJour()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select timestampdiff(month, date(datecreation),curdate())from compte where Id=@Id";

                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = this.NumeroDuCompte
                };
                cmd.Parameters.Add(p_Id);
                try
                {
                    if (null != cmd.ExecuteScalar())
                        return int.Parse(cmd.ExecuteScalar().ToString());
                    return 0;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }

        public string GetClientID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select ClientId from compte where Id=@Id";

                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = this.NumeroDuCompte
                };
                cmd.Parameters.Add(p_Id);
                if (null != cmd.ExecuteScalar())
                    return cmd.ExecuteScalar().ToString();
                return "0";
            }
        }

        public string GetInfoProprietaire()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select noms from client where Id=@Id";
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64)
                {
                    Value = this.GetClientID()
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

        public Int64 GetDernierNumeroDeCompte()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select max(Id) from Compte";

                try
                {
                    if (null != cmd.ExecuteScalar())
                        return Int64.Parse(cmd.ExecuteScalar().ToString());
                    return 0;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }

        public bool DernierUnEmpruntPaye(Int64 CompteId)
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
                    cmd.ExecuteNonQuery();
                    //récuperation des valeurs
                    if (int.TryParse(p_paye.Value.ToString(), out int valeur))
                    {
                        if (valeur == 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Conversion Impossible");
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        #endregion les methodes statfiques

        #region l'enumeration qui prendra la devise du compte

        public enum Devise
        {
            CDF,
            USD
        }

        public enum TypeCompte
        {
            Courant,
            Epargne
        }

        #endregion l'enumeration qui prendra la devise du compte
    }
}