using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public static class Connexion
    {
        public static  string chaineDeConnection;
        public static string NomUtilisateur;
        public static string MotDePasse;
        public static string Server;
        public static MySqlConnection Con;

        public static bool Ouvrir()
        {
            Server = "127.0.0.1";
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
    }
}