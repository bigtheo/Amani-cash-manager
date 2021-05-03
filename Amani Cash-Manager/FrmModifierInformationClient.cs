using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
           dtpDateNaissance.Value= client.GetDateNaissance();
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
            if(long.TryParse(txt_NumeroClient.ToString(),out long numero_client))
            {
                Client client = new Client();
                client.Modifier(numero_client);
            }
            else
            {
                MessageBox.Show("Le format de la chaine entrée est incorrect ","Information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
