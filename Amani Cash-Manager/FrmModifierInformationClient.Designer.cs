namespace Amani_Cash_Manager
{
    partial class FrmModifierInformationClient
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
            this.BtnStartCamera = new System.Windows.Forms.Button();
            this.BtnCapturer = new System.Windows.Forms.Button();
            this.cbxWebCam = new System.Windows.Forms.ComboBox();
            this.lblTypeCompte = new System.Windows.Forms.Label();
            this.lblDevise = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.txtNumeroCarte = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.txtAdresseClient = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.txtNom = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.placeholderTextBox1 = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.panelBarreDeTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStartCamera
            // 
            this.BtnStartCamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartCamera.Location = new System.Drawing.Point(32, 408);
            this.BtnStartCamera.Name = "BtnStartCamera";
            this.BtnStartCamera.Size = new System.Drawing.Size(204, 30);
            this.BtnStartCamera.TabIndex = 37;
            this.BtnStartCamera.Text = "Démarrer WebCam";
            this.BtnStartCamera.UseVisualStyleBackColor = true;
            this.BtnStartCamera.Click += new System.EventHandler(this.BtnStartCamera_Click);
            // 
            // BtnCapturer
            // 
            this.BtnCapturer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapturer.Location = new System.Drawing.Point(32, 444);
            this.BtnCapturer.Name = "BtnCapturer";
            this.BtnCapturer.Size = new System.Drawing.Size(204, 30);
            this.BtnCapturer.TabIndex = 36;
            this.BtnCapturer.Text = "Capturer";
            this.BtnCapturer.UseVisualStyleBackColor = true;
            this.BtnCapturer.Click += new System.EventHandler(this.BtnCapturer_Click);
            // 
            // cbxWebCam
            // 
            this.cbxWebCam.FormattingEnabled = true;
            this.cbxWebCam.Location = new System.Drawing.Point(32, 70);
            this.cbxWebCam.Name = "cbxWebCam";
            this.cbxWebCam.Size = new System.Drawing.Size(204, 21);
            this.cbxWebCam.TabIndex = 35;
            // 
            // lblTypeCompte
            // 
            this.lblTypeCompte.AutoSize = true;
            this.lblTypeCompte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblTypeCompte.Location = new System.Drawing.Point(427, 311);
            this.lblTypeCompte.Name = "lblTypeCompte";
            this.lblTypeCompte.Size = new System.Drawing.Size(101, 19);
            this.lblTypeCompte.TabIndex = 33;
            this.lblTypeCompte.Text = "TypeCompte";
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblDevise.Location = new System.Drawing.Point(427, 279);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(59, 19);
            this.lblDevise.TabIndex = 32;
            this.lblDevise.Text = "Devise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(261, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Type de Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(261, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Devise du compte";
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.Location = new System.Drawing.Point(354, 372);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(152, 30);
            this.BtnEnregistrer.TabIndex = 26;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // txtNumeroCarte
            // 
            this.txtNumeroCarte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCarte.Location = new System.Drawing.Point(261, 239);
            this.txtNumeroCarte.Name = "txtNumeroCarte";
            this.txtNumeroCarte.PlaceholderText = "N° carte d\'électeur";
            this.txtNumeroCarte.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroCarte.Size = new System.Drawing.Size(300, 27);
            this.txtNumeroCarte.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(261, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date de naissance";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.CalendarFont = new System.Drawing.Font("Nova Slim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDateNaissance.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDateNaissance.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateNaissance.Font = new System.Drawing.Font("Nova Slim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateNaissance.Location = new System.Drawing.Point(427, 201);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(138, 26);
            this.dtpDateNaissance.TabIndex = 23;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhoto.Location = new System.Drawing.Point(32, 98);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(204, 304);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 27;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.Click += new System.EventHandler(this.pbxPhoto_Click);
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresseClient.Location = new System.Drawing.Point(261, 167);
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.PlaceholderText = "Adresse du client";
            this.txtAdresseClient.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdresseClient.Size = new System.Drawing.Size(300, 27);
            this.txtAdresseClient.TabIndex = 22;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(261, 127);
            this.txtNom.Name = "txtNom";
            this.txtNom.PlaceholderText = "Nom, postnom et prénom";
            this.txtNom.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom.Size = new System.Drawing.Size(300, 27);
            this.txtNom.TabIndex = 21;
            // 
            // panelBarreDeTitre
            // 
            this.panelBarreDeTitre.BackColor = System.Drawing.Color.AliceBlue;
            this.panelBarreDeTitre.Controls.Add(this.BtnFermer);
            this.panelBarreDeTitre.Controls.Add(this.label1);
            this.panelBarreDeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarreDeTitre.Location = new System.Drawing.Point(0, 0);
            this.panelBarreDeTitre.Name = "panelBarreDeTitre";
            this.panelBarreDeTitre.Size = new System.Drawing.Size(610, 55);
            this.panelBarreDeTitre.TabIndex = 24;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarreDeTitre_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(543, 0);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(67, 55);
            this.BtnFermer.TabIndex = 20;
            this.BtnFermer.Text = "x";
            this.BtnFermer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifcation des Informations du compte";
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.Location = new System.Drawing.Point(261, 94);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Veuillez saisir le n° du compte";
            this.placeholderTextBox1.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.placeholderTextBox1.Size = new System.Drawing.Size(300, 27);
            this.placeholderTextBox1.TabIndex = 38;
            this.placeholderTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.placeholderTextBox1_KeyDown);
            // 
            // FrmModifierInformationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 491);
            this.Controls.Add(this.placeholderTextBox1);
            this.Controls.Add(this.BtnStartCamera);
            this.Controls.Add(this.BtnCapturer);
            this.Controls.Add(this.cbxWebCam);
            this.Controls.Add(this.lblTypeCompte);
            this.Controls.Add(this.lblDevise);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModifierInformationClient";
            this.Text = "FrmModifierInformationClient";
            this.Load += new System.EventHandler(this.FrmModifierInformationClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartCamera;
        private System.Windows.Forms.Button BtnCapturer;
        private System.Windows.Forms.ComboBox cbxWebCam;
        private System.Windows.Forms.Label lblTypeCompte;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEnregistrer;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNumeroCarte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtAdresseClient;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNom;
        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox placeholderTextBox1;
    }
}