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

        private void panelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
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
            if (videoCapture != null)
            {

                videoCapture.SignalToStop();
                videoCapture.Stop();
            }
            this.Close();
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
        private void pbxPhoto_Click(object sender, EventArgs e)
        {
            Parcour_photos();
        }

        private void placeholderTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GetInformationsClient(1200);
        }

        private void GetInformationsClient(long numer_compte)
        {
            throw new NotImplementedException();
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
    }
}
