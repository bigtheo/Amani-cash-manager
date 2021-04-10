using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmModifierInformationClient : Form
    {
        #region Les propriétes
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCapture;
        #endregion

        public FrmModifierInformationClient()
        {
            InitializeComponent();
        }
        #region barre de titre
        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll")]
        private extern static void SendMessage(IntPtr intPtr,int v1,int v2,int v3);

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void ChargerCameras()
        {

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cbxWebCam.Items.Add(filter.Name);
                cbxWebCam.SelectedIndex = 0;
                videoCapture = new VideoCaptureDevice();
            }

            if (cbxWebCam.Items.Count == 0)
            {
                cbxWebCam.Items.Add("Aucune Camera");
                cbxWebCam.SelectedIndex = 0;
                cbxWebCam.Enabled = false;
                BtnCapturer.Enabled = false;
                BtnStartCamera.Enabled = false;
            }
        }

        private void FrmModifierInformationClient_Load(object sender, EventArgs e)
        {
            ChargerCameras();
        }
        private void Parcour_photos()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "choisir l'image (*.jpg *.png ) |*.jpg; *.png"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                pbxPhoto.Text = openFileDialog1.FileName;
            }
        }
        private void PbxPhoto_Click(object sender, EventArgs e)
        {
            Parcour_photos();
        }

        private void PlaceholderTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void GetInformationsClient(long numero_client)
        {
           Client client = new Client(numero_client);
           txtNom.Text= client.GetName();

           dtpDateNaissance.Text= client.GetDateNaissance();
           txtNumeroCarte.Text = client.GetNumeroPiece();
           pbxPhoto.Image= client.GetPhoto();
        }

        private void BtnStartCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture == null)
                {
                    videoCapture = new VideoCaptureDevice(filterInfoCollection[cbxWebCam.SelectedIndex].MonikerString);
                    videoCapture.NewFrame += VideoCapture_NewFrame;
                    videoCapture.Start();

                    Photo.SaveInFile(pbxPhoto); //save Image in file

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VideoCapture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbxPhoto.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnCapturer_Click(object sender, EventArgs e)
        {
            if (pbxPhoto.Image != null)
            {
                videoCapture.SignalToStop();
                videoCapture.Stop();
                pbxPhoto.Image.Save("photomofication.jpeg", ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("Aucune camera coonnectée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Txt_NumeroClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               if(long.TryParse(txt_NumeroClient.Text,out long numerocompte))
                {
                    GetInformationsClient(numerocompte);
                }
                else
                {
                    MessageBox.Show("Format de la chaine entrée est incorrect");
                }
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {

                videoCapture.SignalToStop();
                videoCapture.Stop();
            }
            this.Close();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
           
            using(MySqlCommand cmd=new MySqlCommand())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = "update client set noms=@noms,numeroPiece=@piece,DateDeNaissance=@date,photo=@photo where id=@id";
                pbxPhoto.Image= Image.FromFile("photo.jpeg");

              
                #region les parametres
                MySqlParameter p_noms = new MySqlParameter("@noms", MySqlDbType.VarChar) 
                { 
                    Value=txtNom.Text
                };
                MySqlParameter p_piece = new MySqlParameter("@piece", MySqlDbType.VarChar)
                {
                    Value = txtNumeroCarte.Text
                };
                MySqlParameter p_DateDeNaissance = new MySqlParameter("@date", MySqlDbType.Date)
                {
                    Value = dtpDateNaissance.Value
                };
                MySqlParameter p_photo = new MySqlParameter("@photo", MySqlDbType.LongBlob)
                {
                    Value = Photo.GetImageDataFromFolder()
                };
                MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int64)
                {
                    Value = Photo.GetImageDataFromFolder()
                };
                #endregion

                cmd.Parameters.Add(p_noms);
                cmd.Parameters.Add(p_id);
                cmd.Parameters.Add(p_piece);
                cmd.Parameters.Add(p_photo);
                cmd.Parameters.Add(p_DateDeNaissance);

                DialogResult result = MessageBox.Show("Voulez vous modifier les informations du client ?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Information mise à jour avec succès !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                

            }

           
        }
     




        
    }
}
