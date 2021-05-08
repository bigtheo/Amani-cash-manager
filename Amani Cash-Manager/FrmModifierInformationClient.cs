using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmModifierInformationClient : Form
    {
        #region Les propriétes

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCapture;

        #endregion Les propriétes

        public FrmModifierInformationClient()
        {
            InitializeComponent();
            GetInformationsClient(FrmEspaceClient.ClientId);
            txt_NumeroClient.Text = FrmEspaceClient.ClientId.ToString();
        }

        #region barre de titre

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private extern static void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion barre de titre

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
            txtNom.Text = client.GetName();
            dtpDateNaissance.Text = client.GetDateNaissance();
            txtNumeroCarte.Text = client.GetNumeroPiece();
            pbxPhoto.Image = client.GetPhoto();
            
        }

        private void BtnStartCamera_Click(object sender, EventArgs e)
        {
            try
            {
                videoCapture = new VideoCaptureDevice(filterInfoCollection[cbxWebCam.SelectedIndex].MonikerString);
                videoCapture.NewFrame += VideoCapture_NewFrame;
                videoCapture.Start();

                BtnCapturer.Enabled = true;
                BtnModifier.Enabled = false;
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
            try
            {
                videoCapture.SignalToStop();
                videoCapture.Stop();
                videoCapture.WaitForStop();

                Photo.SaveInFile(pbxPhoto.Image);
                BtnModifier.Enabled = true;
                BtnCapturer.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                videoCapture.Stop();
            }
        }

        private void Txt_NumeroClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (long.TryParse(txt_NumeroClient.Text, out long numerocompte))
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
            if (long.TryParse(txt_NumeroClient.Text, out long numero_compte))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.Connection = Connexion.Con;

                    cmd.CommandText = "update client set photo=@picture,noms=@noms,DateDeNaissance=@datanaissance,NumeroPiece=@NumeroPiece where id=@id";
                    MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int64)
                    {
                        Value = numero_compte
                    };
                    MySqlParameter p_noms = new MySqlParameter("@noms", MySqlDbType.VarChar)
                    {
                        Value = txtNom.Text
                    };
                    MySqlParameter p_image = new MySqlParameter("@picture", MySqlDbType.LongBlob)
                    {
                        Value = Photo.GetConvertedImageFromFiles(pbxPhoto.Image)
                    };
                    MySqlParameter p_date_naissance = new MySqlParameter("@datanaissance", MySqlDbType.Date)
                    {
                        Value = dtpDateNaissance.Value
                    };
                    MySqlParameter p_NumeroPiece = new MySqlParameter("@NumeroPiece", MySqlDbType.VarChar)
                    {
                        Value = txtNumeroCarte.Text
                    };

                    cmd.Parameters.Add(p_id);
                    cmd.Parameters.Add(p_image);
                    cmd.Parameters.Add(p_noms);
                    cmd.Parameters.Add(p_date_naissance);
                    cmd.Parameters.Add(p_NumeroPiece);


                    DialogResult result = MessageBox.Show("Voulez-vous vraiment modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Modification effectuée avec succès !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                }
        }

        private void txt_NumeroClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}