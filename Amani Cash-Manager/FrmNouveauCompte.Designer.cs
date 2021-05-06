namespace Amani_Cash_Manager
{
    partial class FrmNouveauCompte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNouveauCompte));
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDevise = new System.Windows.Forms.Label();
            this.lblTypeCompte = new System.Windows.Forms.Label();
            this.nupSoldeOuverture = new System.Windows.Forms.NumericUpDown();
            this.cbxWebCam = new System.Windows.Forms.ComboBox();
            this.BtnCapturer = new System.Windows.Forms.Button();
            this.BtnStartCamera = new System.Windows.Forms.Button();
            this.txtNumeroCarte = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.txtAdresseClient = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.txtNom = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.panelBarreDeTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoldeOuverture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarreDeTitre
            // 
            this.panelBarreDeTitre.BackColor = System.Drawing.Color.AliceBlue;
            this.panelBarreDeTitre.Controls.Add(this.BtnFermer);
            this.panelBarreDeTitre.Controls.Add(this.label1);
            this.panelBarreDeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarreDeTitre.Location = new System.Drawing.Point(0, 0);
            this.panelBarreDeTitre.Name = "panelBarreDeTitre";
            this.panelBarreDeTitre.Size = new System.Drawing.Size(626, 68);
            this.panelBarreDeTitre.TabIndex = 4;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(559, 0);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(67, 68);
            this.BtnFermer.TabIndex = 20;
            this.BtnFermer.Text = "x";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création du compte Client";
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhoto.Location = new System.Drawing.Point(32, 118);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(204, 214);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 7;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.Click += new System.EventHandler(this.PbxPhoto_Click);
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.CalendarFont = new System.Drawing.Font("Nova Slim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDateNaissance.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDateNaissance.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateNaissance.Font = new System.Drawing.Font("Nova Slim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateNaissance.Location = new System.Drawing.Point(436, 184);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(138, 26);
            this.dtpDateNaissance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(270, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date de naissance";
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.Location = new System.Drawing.Point(354, 384);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(152, 30);
            this.BtnEnregistrer.TabIndex = 6;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(270, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Devise du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(270, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type de Compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(270, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Solde d\'ouverture";
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblDevise.Location = new System.Drawing.Point(436, 262);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(59, 19);
            this.lblDevise.TabIndex = 15;
            this.lblDevise.Text = "Devise";
            // 
            // lblTypeCompte
            // 
            this.lblTypeCompte.AutoSize = true;
            this.lblTypeCompte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblTypeCompte.Location = new System.Drawing.Point(436, 294);
            this.lblTypeCompte.Name = "lblTypeCompte";
            this.lblTypeCompte.Size = new System.Drawing.Size(101, 19);
            this.lblTypeCompte.TabIndex = 16;
            this.lblTypeCompte.Text = "TypeCompte";
            // 
            // nupSoldeOuverture
            // 
            this.nupSoldeOuverture.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSoldeOuverture.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupSoldeOuverture.Location = new System.Drawing.Point(436, 327);
            this.nupSoldeOuverture.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupSoldeOuverture.Name = "nupSoldeOuverture";
            this.nupSoldeOuverture.Size = new System.Drawing.Size(137, 23);
            this.nupSoldeOuverture.TabIndex = 17;
            this.nupSoldeOuverture.ThousandsSeparator = true;
            // 
            // cbxWebCam
            // 
            this.cbxWebCam.FormattingEnabled = true;
            this.cbxWebCam.Location = new System.Drawing.Point(32, 82);
            this.cbxWebCam.Name = "cbxWebCam";
            this.cbxWebCam.Size = new System.Drawing.Size(204, 22);
            this.cbxWebCam.TabIndex = 18;
            // 
            // BtnCapturer
            // 
            this.BtnCapturer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapturer.Location = new System.Drawing.Point(32, 384);
            this.BtnCapturer.Name = "BtnCapturer";
            this.BtnCapturer.Size = new System.Drawing.Size(204, 30);
            this.BtnCapturer.TabIndex = 19;
            this.BtnCapturer.Text = "Capturer";
            this.BtnCapturer.UseVisualStyleBackColor = true;
            this.BtnCapturer.Click += new System.EventHandler(this.BtnCapturer_Click);
            // 
            // BtnStartCamera
            // 
            this.BtnStartCamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartCamera.Location = new System.Drawing.Point(32, 348);
            this.BtnStartCamera.Name = "BtnStartCamera";
            this.BtnStartCamera.Size = new System.Drawing.Size(204, 30);
            this.BtnStartCamera.TabIndex = 20;
            this.BtnStartCamera.Text = "Démarrer WebCam";
            this.BtnStartCamera.UseVisualStyleBackColor = true;
            this.BtnStartCamera.Click += new System.EventHandler(this.BtnStartCamera_Click);
            // 
            // txtNumeroCarte
            // 
            this.txtNumeroCarte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCarte.Location = new System.Drawing.Point(274, 222);
            this.txtNumeroCarte.Name = "txtNumeroCarte";
            this.txtNumeroCarte.PlaceholderText = "N° carte d\'électeur";
            this.txtNumeroCarte.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroCarte.Size = new System.Drawing.Size(300, 27);
            this.txtNumeroCarte.TabIndex = 4;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresseClient.Location = new System.Drawing.Point(274, 150);
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.PlaceholderText = "Adresse du client";
            this.txtAdresseClient.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdresseClient.Size = new System.Drawing.Size(300, 27);
            this.txtAdresseClient.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(274, 110);
            this.txtNom.Name = "txtNom";
            this.txtNom.PlaceholderText = "Nom, postnom et prénom";
            this.txtNom.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom.Size = new System.Drawing.Size(300, 27);
            this.txtNom.TabIndex = 1;
            // 
            // FrmNouveauCompte
            // 
            this.AcceptButton = this.BtnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 501);
            this.Controls.Add(this.BtnStartCamera);
            this.Controls.Add(this.BtnCapturer);
            this.Controls.Add(this.cbxWebCam);
            this.Controls.Add(this.nupSoldeOuverture);
            this.Controls.Add(this.lblTypeCompte);
            this.Controls.Add(this.lblDevise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.txtNumeroCarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.txtAdresseClient);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.panelBarreDeTitre);
            this.Font = new System.Drawing.Font("Nova Slim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNouveauCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmNouveauCompte";
            this.Load += new System.EventHandler(this.FrmNouveauCompte_Load);
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoldeOuverture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNom;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtAdresseClient;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Label label2;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNumeroCarte;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Label lblTypeCompte;
        private System.Windows.Forms.NumericUpDown nupSoldeOuverture;
        private System.Windows.Forms.ComboBox cbxWebCam;
        private System.Windows.Forms.Button BtnCapturer;
        private System.Windows.Forms.Button BtnStartCamera;
    }
}