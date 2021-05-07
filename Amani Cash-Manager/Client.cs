using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
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

        public Client(long numeroClient)
        {
            this.Id = (int)numeroClient;
        }

        public void Enregistrer()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                #region conversion de l'image

                byte[] image;
                if (Photo != null)
                {
                    MemoryStream memory = new MemoryStream();
                    Photo.Save(memory, Photo.RawFormat) ;
                    image = memory.ToArray();
                }
                else
                {
                    image = null;
                }

                #endregion conversion de l'image

                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "Insert into Client(Id,noms,photo,DateDeNaissance,NumeroPiece) values(@Id,@nom,@image,@dateNaissance,@numeropiece)";

                MySqlParameter p_image = new MySqlParameter("@image", MySqlDbType.LongBlob);
                MySqlParameter p_nom = new MySqlParameter("@nom", MySqlDbType.VarChar, 50);
                MySqlParameter p_numeropiece = new MySqlParameter("@numeropiece", MySqlDbType.VarChar, 20);
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64);
                MySqlParameter p_date = new MySqlParameter("@dateNaissance", MySqlDbType.Date);

                p_Id.Value = Id;
                p_image.Value = image;
                p_nom.Value = this.Noms;
                p_numeropiece.Value = this.NumeroPiece;
                p_date.Value = this.DateNaissance;

                cmd.Parameters.Add(p_image);
                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_nom);
                cmd.Parameters.Add(p_numeropiece);
                cmd.Parameters.Add(p_date);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Client enrgistré avec succès ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        internal string GetNumeroPiece()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Ouvrir();
                    cmd.Connection = Connexion.Con;
                    cmd.CommandText = "select NumeroPiece from client where id=@id";
                    MySqlParameter p_id = new MySqlParameter("@Id", MySqlDbType.Int64) { Value = this.Id };
                    cmd.Parameters.Add(p_id);
                    return Convert.ToString( cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return default;
                }
            }
        }

        internal Image GetPhoto()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Ouvrir();
                    cmd.Connection = Connexion.Con;
                    cmd.CommandText = "select photo from client where id=@id";
                    MySqlParameter p_id = new MySqlParameter("@Id", MySqlDbType.Int64) { Value = this.Id };
                    cmd.Parameters.Add(p_id);
                    byte[] byte_image = (byte[])cmd.ExecuteScalar();
                    using (MemoryStream memoryStream = new MemoryStream(byte_image))
                    {
                        return Image.FromStream(memoryStream);
                    }
                }
                catch (Exception)
                {
                    return default;
                }
            }
        }

        internal string GetDateNaissance()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Ouvrir();
                    cmd.Connection = Connexion.Con;
                    cmd.CommandText = "select DateDeNaissance from client where id=@id";
                    MySqlParameter p_id = new MySqlParameter("@Id", MySqlDbType.Int64)
                    {
                        Value = this.Id
                    };
                    cmd.Parameters.Add(p_id);
                    return Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return default;
                }
            }
        }

        internal string GetName()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Ouvrir();
                    cmd.Connection = Connexion.Con;
                    cmd.CommandText = "select noms from client where id=@id";
                    MySqlParameter p_id = new MySqlParameter("@Id", MySqlDbType.VarChar) { Value = this.Id };
                    cmd.Parameters.Add(p_id);
                    return Convert.ToString( cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return default;
                }
            }
        }

        internal void Modifier(long numero_compte)
        {
            using (MySqlCommand cmd = new MySqlCommand())
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

                #endregion conversion de l'image

                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "Update  Client set noms=@nom,photo=@image,DateDeNaissance=@dateNaissance,NumeroPiece=@numeropiece where id=@Id,";

                MySqlParameter p_image = new MySqlParameter("@image", MySqlDbType.LongBlob);
                MySqlParameter p_nom = new MySqlParameter("@nom", MySqlDbType.VarChar, 50);
                MySqlParameter p_numeropiece = new MySqlParameter("@numeropiece", MySqlDbType.VarChar, 20);
                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int64);
                MySqlParameter p_date = new MySqlParameter("@dateNaissance", MySqlDbType.Date);

                p_Id.Value = numero_compte;
                p_image.Value = image;
                p_nom.Value = this.Noms;
                p_numeropiece.Value = this.NumeroPiece;
                p_date.Value = this.DateNaissance;

                cmd.Parameters.Add(p_image);
                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_nom);
                cmd.Parameters.Add(p_numeropiece);
                cmd.Parameters.Add(p_date);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Modification enrgistrée avec succès ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public int DernierID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
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