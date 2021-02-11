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
    public partial class FrmParametre : Form
    {
        public FrmParametre()
        {
            InitializeComponent();
            ChargerInformationDeLentreprise();
        }

        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Enregistrer() == 1)
            {
                Helper.Backup();
            }
            this.Cursor = Cursors.Default;
        }

        private int Enregistrer()
        {
            using (MySqlCommand cmd=new MySqlCommand ())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = $"replace into entite values('1','{txtNom.Text}','{txtAdresse.Text}','{txtRCCM.Text}','{txtCoordonnee.Text}')";
                return cmd.ExecuteNonQuery();
            }
        }
        private void ChargerInformationDeLentreprise()
        {
            using (MySqlCommand cmd=new MySqlCommand ())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "SELECT* from entite limit 1";
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    txtNom.Text = dataReader.GetString(1);
                    txtAdresse.Text = dataReader.GetString(2);
                    txtRCCM.Text = dataReader.GetString(3);
                    txtCoordonnee.Text = dataReader.GetString(4);
                }
            }
        }
    }
}
