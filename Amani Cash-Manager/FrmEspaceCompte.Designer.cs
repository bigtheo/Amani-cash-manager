namespace Amani_Cash_Manager
{
    partial class FrmEspaceCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspaceCompte));
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupSoldeDuCompte = new System.Windows.Forms.NumericUpDown();
            this.lblTypeDuCompte = new System.Windows.Forms.Label();
            this.lblDevise = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.nupNumeroCompte = new System.Windows.Forms.NumericUpDown();
            this.lblProprietaire = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDateAterme = new System.Windows.Forms.Label();
            this.lblDesignationAterme = new System.Windows.Forms.Label();
            this.panelBarreDeTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoldeDuCompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.Location = new System.Drawing.Point(270, 385);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(158, 30);
            this.BtnEnregistrer.TabIndex = 56;
            this.BtnEnregistrer.Text = "Imprimer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // panelBarreDeTitre
            // 
            this.panelBarreDeTitre.BackColor = System.Drawing.Color.AliceBlue;
            this.panelBarreDeTitre.Controls.Add(this.BtnFermer);
            this.panelBarreDeTitre.Controls.Add(this.label1);
            this.panelBarreDeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarreDeTitre.Location = new System.Drawing.Point(0, 0);
            this.panelBarreDeTitre.Name = "panelBarreDeTitre";
            this.panelBarreDeTitre.Size = new System.Drawing.Size(691, 68);
            this.panelBarreDeTitre.TabIndex = 44;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(624, 0);
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
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Espace Compte Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(266, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Date de créatin";
            // 
            // nupSoldeDuCompte
            // 
            this.nupSoldeDuCompte.Enabled = false;
            this.nupSoldeDuCompte.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSoldeDuCompte.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupSoldeDuCompte.Location = new System.Drawing.Point(428, 282);
            this.nupSoldeDuCompte.Maximum = new decimal(new int[] {
            -1316487168,
            -1243369706,
            2,
            0});
            this.nupSoldeDuCompte.Name = "nupSoldeDuCompte";
            this.nupSoldeDuCompte.Size = new System.Drawing.Size(203, 23);
            this.nupSoldeDuCompte.TabIndex = 53;
            this.nupSoldeDuCompte.ThousandsSeparator = true;
            // 
            // lblTypeDuCompte
            // 
            this.lblTypeDuCompte.AutoSize = true;
            this.lblTypeDuCompte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDuCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblTypeDuCompte.Location = new System.Drawing.Point(428, 254);
            this.lblTypeDuCompte.Name = "lblTypeDuCompte";
            this.lblTypeDuCompte.Size = new System.Drawing.Size(129, 19);
            this.lblTypeDuCompte.TabIndex = 52;
            this.lblTypeDuCompte.Text = "Type de compte";
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblDevise.Location = new System.Drawing.Point(428, 224);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(145, 19);
            this.lblDevise.TabIndex = 51;
            this.lblDevise.Text = "Devise du compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(266, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Solde du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(266, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Type de Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(266, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Devise du compte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(43, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 304);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblDateCreation.Location = new System.Drawing.Point(428, 313);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(110, 19);
            this.lblDateCreation.TabIndex = 57;
            this.lblDateCreation.Text = "Date création";
            // 
            // nupNumeroCompte
            // 
            this.nupNumeroCompte.Enabled = false;
            this.nupNumeroCompte.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumeroCompte.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupNumeroCompte.Location = new System.Drawing.Point(428, 153);
            this.nupNumeroCompte.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupNumeroCompte.Name = "nupNumeroCompte";
            this.nupNumeroCompte.Size = new System.Drawing.Size(203, 23);
            this.nupNumeroCompte.TabIndex = 58;
            this.nupNumeroCompte.ThousandsSeparator = true;
            // 
            // lblProprietaire
            // 
            this.lblProprietaire.AutoSize = true;
            this.lblProprietaire.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProprietaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblProprietaire.Location = new System.Drawing.Point(428, 191);
            this.lblProprietaire.Name = "lblProprietaire";
            this.lblProprietaire.Size = new System.Drawing.Size(97, 19);
            this.lblProprietaire.TabIndex = 60;
            this.lblProprietaire.Text = "Proprietaire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(266, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 59;
            this.label7.Text = "Propriétaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(266, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "N° du Compte";
            // 
            // lblDateAterme
            // 
            this.lblDateAterme.AutoSize = true;
            this.lblDateAterme.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAterme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblDateAterme.Location = new System.Drawing.Point(428, 342);
            this.lblDateAterme.Name = "lblDateAterme";
            this.lblDateAterme.Size = new System.Drawing.Size(107, 19);
            this.lblDateAterme.TabIndex = 63;
            this.lblDateAterme.Text = "Date à terme";
            // 
            // lblDesignationAterme
            // 
            this.lblDesignationAterme.AutoSize = true;
            this.lblDesignationAterme.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignationAterme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesignationAterme.Location = new System.Drawing.Point(266, 342);
            this.lblDesignationAterme.Name = "lblDesignationAterme";
            this.lblDesignationAterme.Size = new System.Drawing.Size(124, 19);
            this.lblDesignationAterme.TabIndex = 62;
            this.lblDesignationAterme.Text = "sera à terme le";
            // 
            // FrmEspaceCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 461);
            this.Controls.Add(this.lblDateAterme);
            this.Controls.Add(this.lblDesignationAterme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProprietaire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupNumeroCompte);
            this.Controls.Add(this.lblDateCreation);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.panelBarreDeTitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupSoldeDuCompte);
            this.Controls.Add(this.lblTypeDuCompte);
            this.Controls.Add(this.lblDevise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEspaceCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espace Compte client";
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoldeDuCompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupSoldeDuCompte;
        private System.Windows.Forms.Label lblTypeDuCompte;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateCreation;
        private System.Windows.Forms.NumericUpDown nupNumeroCompte;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDateAterme;
        private System.Windows.Forms.Label lblDesignationAterme;
    }
}