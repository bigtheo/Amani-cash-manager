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
            this.BtnModifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroCarte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txt_NumeroClient = new System.Windows.Forms.TextBox();
            this.txtAdresseClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.panelBarreDeTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStartCamera
            // 
            this.BtnStartCamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartCamera.Location = new System.Drawing.Point(32, 290);
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
            this.BtnCapturer.Location = new System.Drawing.Point(32, 326);
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
            // BtnModifier
            // 
            this.BtnModifier.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(346, 254);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(98, 30);
            this.BtnModifier.TabIndex = 26;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(245, 192);
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
            this.dtpDateNaissance.Location = new System.Drawing.Point(403, 187);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(161, 26);
            this.dtpDateNaissance.TabIndex = 23;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhoto.Location = new System.Drawing.Point(32, 98);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(204, 186);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 27;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.Click += new System.EventHandler(this.PbxPhoto_Click);
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
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
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
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
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
            // txtNumeroCarte
            // 
            this.txtNumeroCarte.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCarte.Location = new System.Drawing.Point(350, 219);
            this.txtNumeroCarte.Name = "txtNumeroCarte";
            this.txtNumeroCarte.Size = new System.Drawing.Size(218, 23);
            this.txtNumeroCarte.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(245, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "N° Carte";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(346, 127);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(222, 23);
            this.txtNom.TabIndex = 40;
            // 
            // txt_NumeroClient
            // 
            this.txt_NumeroClient.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroClient.Location = new System.Drawing.Point(346, 98);
            this.txt_NumeroClient.Name = "txt_NumeroClient";
            this.txt_NumeroClient.Size = new System.Drawing.Size(222, 23);
            this.txt_NumeroClient.TabIndex = 41;
            this.txt_NumeroClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NumeroClient_KeyUp);
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresseClient.Location = new System.Drawing.Point(346, 156);
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.Size = new System.Drawing.Size(222, 23);
            this.txtAdresseClient.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(245, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "N° client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(245, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Noms client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(245, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Adresse";
            // 
            // FrmModifierInformationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 395);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresseClient);
            this.Controls.Add(this.txt_NumeroClient);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroCarte);
            this.Controls.Add(this.BtnStartCamera);
            this.Controls.Add(this.BtnCapturer);
            this.Controls.Add(this.cbxWebCam);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.panelBarreDeTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModifierInformationClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCarte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txt_NumeroClient;
        private System.Windows.Forms.TextBox txtAdresseClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}