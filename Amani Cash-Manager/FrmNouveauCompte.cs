using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace Amani_Cash_Manager
{
    public partial class FrmNouveauCompte : Form
    {
        #region Les propriétes
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCapture;
        #endregion

        #region Chargement des cameras
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
        #endregion
        public FrmNouveauCompte()
        {
            InitializeComponent();
            CustomizerInformation();
        }

        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            if (videoCapture!=null)
            {

                videoCapture.SignalToStop();
                videoCapture.Stop();
            }
            this.Close();
        }

        #endregion barre de titre

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Client client = new Client
            {
                Id = 0,
                DateNaissance = dtpDateNaissance.Value,
                Noms = txtNom.Text,
                Photo = pbxPhoto.Image,
                NumeroPiece = txtNumeroCarte.Text
                
            };

            client.Modifier(10000000);
           
           
            NettoyerChamps();
            this.Cursor = Cursors.Default;
        }

        private void NettoyerChamps()
        {
            txtNom.Clear();
            txtNumeroCarte.Clear();
            txtAdresseClient.Clear();
            nupSoldeOuverture.Value = 0;
        }

        #region capture Photo
        private void PbxPhoto_Click(object sender, EventArgs e)
        {
            Parcour_photos();
        }

        private void Parcour_photos()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "choisir l'image (*.jpg *.png ) |*.jpg; *.png"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pbxPhoto.Text = openFileDialog1.FileName;
            }
        }

        #region au region du formualaire
        private void CustomizerInformation()
        {
            lblDevise.Text = FrmDevise.DeviseDuCompte.ToString();
            lblTypeCompte.Text = FrmCreerCompte.TypeDuCompte.ToString();
        }
        #endregion

        
        private void FrmNouveauCompte_Load(object sender, EventArgs e)
        {
            ChargerCameras();
        }

        private void BtnCapturer_Click(object sender, EventArgs e)
        {

            videoCapture.SignalToStop();
            videoCapture.Stop();
            
        }

        private void VideoCapture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbxPhoto.Image = (Bitmap)eventArgs.Frame.Clone();
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
        #endregion
    }


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
}