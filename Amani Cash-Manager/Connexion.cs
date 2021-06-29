using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public static class Connexion
    {
        //les propriétés
        #region les propriétées
        public static  string chaineDeConnection;
        public static string NomUtilisateur;
        public static string MotDePasse;
        public static string Server;
        public static MySqlConnection Con;
        #endregion

        #region les méthodes de la classes
        //ouvre la connexion au seveur des données
        public static bool Ouvrir()
        {
            Server = "localhost";
            MotDePasse = Login.Password;
            NomUtilisateur = Login.UserName;
            chaineDeConnection = $" persistsecurityinfo=True;server={Server};username={NomUtilisateur};password={MotDePasse};database=AmaniDB";
            Con = new MySqlConnection(chaineDeConnection);  
                try
                {
                    Con.Open();
                    if (Con.State == ConnectionState.Open)
                        return true;
                    else
                        return false;
                }catch(MySqlException ex)
                {
                    MessageBox.Show($"Erreur :{ex.Message}\n\nCode d'erreur : {ex.Number}","Information");
                    return false;
                }

            
        }

       //vérifie si l'utilisateur est un administrateur
       public  static bool IsAmanistrator()
        {
            MotDePasse = Login.Password;
            NomUtilisateur = Login.UserName;
            using (var cmd=new MySqlCommand ())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select count(id) from users where pass_word=sha1(@password) and nom=@username and role=1";

                MySqlParameter p_username = new MySqlParameter("@username", MySqlDbType.VarChar);
                MySqlParameter p_password = new MySqlParameter("@password", MySqlDbType.VarChar);

                p_password.Value = MotDePasse;
                p_username.Value = NomUtilisateur;

                cmd.Parameters.Add(p_username);
                cmd.Parameters.Add(p_password);

                try
                {
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (rowCount == 1)
                    {
                        return true;
                    }
                    return false;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            
        }

        //vérifie si l'utilisateur est n'est pas admin
        public static bool IsUser()
        {
            MotDePasse = Login.Password;
            NomUtilisateur = Login.UserName;
            using (var cmd = new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select count(id) from users where pass_word=sha1(@password) and nom=@username and role=2";

                MySqlParameter p_username = new MySqlParameter("@username", MySqlDbType.VarChar);
                MySqlParameter p_password = new MySqlParameter("@password", MySqlDbType.VarChar);

                p_password.Value = MotDePasse;
                p_username.Value = NomUtilisateur;

                cmd.Parameters.Add(p_username);
                cmd.Parameters.Add(p_password);

                try
                {
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (rowCount == 1)
                    {
                        return true;
                    }
                    return false;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($" Is user{ex.Message}");
                    return false;
                }
            }

        }

        #endregion
    }
}