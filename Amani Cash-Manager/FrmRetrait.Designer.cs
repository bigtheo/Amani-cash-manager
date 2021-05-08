namespace Amani_Cash_Manager
{
    partial class FrmRetrait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetrait));
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nupSoldeDuCompte = new System.Windows.Forms.NumericUpDown();
            this.lblTypeDuCompte = new System.Windows.Forms.Label();
            this.lblDevise = new System.Windows.Forms.Label();
            this.nupMontantAretirer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroDuCompte = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.txtNoms = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.panelBarreDeTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoldeDuCompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantAretirer)).BeginInit();
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
            this.panelBarreDeTitre.Size = new System.Drawing.Size(608, 68);
            this.panelBarreDeTitre.TabIndex = 5;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(541, 0);
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
            this.label1.Size = new System.Drawing.Size(399, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retrait d\'argent dans un compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(258, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Solde du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(258, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Type de Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(258, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Devise du compte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(37, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // nupSoldeDuCompte
            // 
            this.nupSoldeDuCompte.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSoldeDuCompte.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupSoldeDuCompte.Location = new System.Drawing.Point(421, 259);
            this.nupSoldeDuCompte.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupSoldeDuCompte.Name = "nupSoldeDuCompte";
            this.nupSoldeDuCompte.Size = new System.Drawing.Size(137, 23);
            this.nupSoldeDuCompte.TabIndex = 27;
            this.nupSoldeDuCompte.ThousandsSeparator = true;
            // 
            // lblTypeDuCompte
            // 
            this.lblTypeDuCompte.AutoSize = true;
            this.lblTypeDuCompte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDuCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblTypeDuCompte.Location = new System.Drawing.Point(421, 231);
            this.lblTypeDuCompte.Name = "lblTypeDuCompte";
            this.lblTypeDuCompte.Size = new System.Drawing.Size(129, 19);
            this.lblTypeDuCompte.TabIndex = 26;
            this.lblTypeDuCompte.Text = "Type de compte";
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblDevise.Location = new System.Drawing.Point(421, 201);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(145, 19);
            this.lblDevise.TabIndex = 25;
            this.lblDevise.Text = "Devise du compte";
            // 
            // nupMontantAretirer
            // 
            this.nupMontantAretirer.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMontantAretirer.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupMontantAretirer.Location = new System.Drawing.Point(421, 288);
            this.nupMontantAretirer.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupMontantAretirer.Name = "nupMontantAretirer";
            this.nupMontantAretirer.Size = new System.Drawing.Size(137, 23);
            this.nupMontantAretirer.TabIndex = 29;
            this.nupMontantAretirer.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(259, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Montant à retirer";
            // 
            // txtNumeroDuCompte
            // 
            this.txtNumeroDuCompte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDuCompte.Location = new System.Drawing.Point(258, 125);
            this.txtNumeroDuCompte.Name = "txtNumeroDuCompte";
            this.txtNumeroDuCompte.PlaceholderText = "N° du compte client";
            this.txtNumeroDuCompte.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroDuCompte.Size = new System.Drawing.Size(300, 27);
            this.txtNumeroDuCompte.TabIndex = 24;
            this.txtNumeroDuCompte.TextChanged += new System.EventHandler(this.TxtNumeroDuCompte_TextChanged);
            // 
            // txtNoms
            // 
            this.txtNoms.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoms.Location = new System.Drawing.Point(258, 163);
            this.txtNoms.Name = "txtNoms";
            this.txtNoms.PlaceholderText = "Nom, postnom et prénom";
            this.txtNoms.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoms.Size = new System.Drawing.Size(300, 27);
            this.txtNoms.TabIndex = 15;
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.Location = new System.Drawing.Point(264, 363);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(158, 30);
            this.BtnEnregistrer.TabIndex = 44;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // FrmRetrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 441);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.nupMontantAretirer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupSoldeDuCompte);
            this.Controls.Add(this.lblTypeDuCompte);
            this.Controls.Add(this.lblDevise);
            this.Controls.Add(this.txtNumeroDuCompte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNoms);
            this.Controls.Add(this.panelBarreDeTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRetrait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRetrait";
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoldeDuCompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantAretirer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNoms;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNumeroDuCompte;
        private System.Windows.Forms.NumericUpDown nupSoldeDuCompte;
        private System.Windows.Forms.Label lblTypeDuCompte;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.NumericUpDown nupMontantAretirer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEnregistrer;
    }
}