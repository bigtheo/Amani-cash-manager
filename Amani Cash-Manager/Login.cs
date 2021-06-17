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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Barre de titre...
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            Password = txtPassword.Text;
            UserName = txtUserName.Text;

            if (Connexion.Ouvrir())
            {
                new FrmAccueil().ShowDialog();
                this.Hide();

            }
            /*  connexion reseu
            if (Connexion.Ouvrir())
            {
                
                if (Connexion.IsAmanistrator())
                {
                    new FrmAccueil().ShowDialog();
                    this.Hide();
                }
                else
                if (Connexion.IsUser())
                {
                    new FrmDepot();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username/password incorrect","erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
            }
            */

        }

        public static string Password { get; set; }
        public static string UserName { get; set; }
    }
}
