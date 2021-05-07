using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmNouveauCompte : Form
    {
        #region Les propriétes

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCapture;

        #endregion Les propriétes

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

        #endregion Chargement des cameras

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
                videoCapture.Stop();
                videoCapture.WaitForStop();
            }
            this.Close();
        }

        #endregion barre de titre


        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if(nupSoldeOuverture.Value<=0)
            {
                MessageBox.Show("le solde ne peut pas être 0");
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            Client client = new Client
            {
                Id = 0,
                DateNaissance = dtpDateNaissance.Value,
                Noms = txtNom.Text,
                NumeroPiece = txtNumeroCarte.Text
            };


            if (pbxPhoto.Image != null)
            {
                client.Photo = Photo.GetImageDataFromFolder();
            }
            client.Enregistrer();


            //
            if (lblTypeCompte.Text == TypeCompte.Courant.ToString())
            {
                CompteCourant compte = new CompteCourant()
                {
                    IdDuProprietaire = client.DernierID(),
                    DeviseCompte = FrmDevise.DeviseDuCompte,
                    TypeDuCompte = Compte.TypeCompte.Courant
                };
                compte.Creer();
                //on crédite le compte   
                compte.NumeroDuCompte = int.Parse(compte.GetDernierNumeroDeCompte().ToString());
                compte.Crediter(nupSoldeOuverture.Value);
            }
            else
            {

                CompteEpargne compte = new CompteEpargne()
                {
                    IdDuProprietaire = client.DernierID(),
                    DeviseCompte = FrmDevise.DeviseDuCompte,
                    TypeDuCompte = Compte.TypeCompte.Epargne
                };
                compte.Creer();
                //on crédite le compte   
                compte.NumeroDuCompte = int.Parse(compte.GetDernierNumeroDeCompte().ToString());
                compte.Crediter(nupSoldeOuverture.Value);
            }




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
                pbxPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                pbxPhoto.Text = openFileDialog1.FileName;
            }
        }

        #region au region du formualaire

        private void CustomizerInformation()
        {
            lblDevise.Text = FrmDevise.DeviseDuCompte.ToString();
            lblTypeCompte.Text = FrmCreerCompte.TypeDuCompte.ToString();
        }

        #endregion au region du formualaire

        private void FrmNouveauCompte_Load(object sender, EventArgs e)
        {
            ChargerCameras();
        }

        private void BtnCapturer_Click(object sender, EventArgs e)
        {
            try
            {
                
                videoCapture.SignalToStop();
                videoCapture.Stop();
                videoCapture.WaitForStop();

                Photo.SaveInFile(pbxPhoto.Image);
                BtnEnregistrer.Enabled = true;
                BtnCapturer.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                videoCapture.Stop();
            }
        }

        private void VideoCapture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
         pbxPhoto.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnStartCamera_Click(object sender, EventArgs e)
        {
            try
            {
                videoCapture = new VideoCaptureDevice(filterInfoCollection[cbxWebCam.SelectedIndex].MonikerString);
                videoCapture.NewFrame += VideoCapture_NewFrame;
                videoCapture.Start();

                BtnCapturer.Enabled = true;
                BtnEnregistrer.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion capture Photo
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