using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public class Client
    {
        public int Id { get; set; }
        public String Noms { get; set; }
        public Image Photo { get; set; }
        public string NumeroPiece { get; set; }
        public DateTime DateNaissance { get; set; }

        public Client()
        {
            this.Id = 0;
            this.Noms = "Inconnu";
            this.Photo = null;
            this.NumeroPiece = "Inconnu";
            this.DateNaissance = DateTime.Now;

        }


        public void Enregistrer()
        {
            using (MySqlCommand cmd=new MySqlCommand ())
            {
                #region conversion de l'image
                byte[] image;
                if (Photo != null)
                {
                    MemoryStream memory = new MemoryStream();
                    Photo.Save(memory, Photo.RawFormat);
                    image = memory.ToArray();
                }
                else
                {
                    image = null;
                }
                #endregion

                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "Insert into Client(Id,noms,photo,DateDeNaissance,NumeroPiece) values(@Id,@nom,@image,@dateNaissance,@numeropiece)";

                MySqlParameter p_image = new MySqlParameter("@image", MySqlDbType.LongBlob);
                MySqlParameter p_nom = new MySqlParameter("@nom", MySqlDbType.VarChar,50);
                MySqlParameter p_numeropiece = new MySqlParameter("@numeropiece", MySqlDbType.VarChar,20);
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int32);
                MySqlParameter p_date = new MySqlParameter("@dateNaissance", MySqlDbType.Date);

                p_Id.Value = Id;
                p_image.Value = image;
                p_nom.Value = this.Noms;
                p_numeropiece.Value = this.NumeroPiece;
                p_date.Value = this.DateNaissance ;


                cmd.Parameters.Add(p_image);
                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_nom);
                cmd.Parameters.Add(p_numeropiece);
                cmd.Parameters.Add(p_date);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Client enrgistré avec succès ", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
                catch(InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        internal void Modifier(int v)
        {
            throw new NotImplementedException();
        }

        public int DernierID()
        {
            using (MySqlCommand cmd=new MySqlCommand ())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "select max(id) from client";
                try
                {
                    if (int.TryParse(cmd.ExecuteScalar().ToString(), out int dernierId))
                    {
                        return dernierId;
                    }
                    return 1;
                     
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }
    }
}
