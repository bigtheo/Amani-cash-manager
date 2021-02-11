namespace Amani_Cash_Manager
{
    partial class FrmRemboursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemboursement));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nupTotalARembourse = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nupTaux = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nupMontantPrete = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nupTotalRembourse = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nupResteArembourser = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nupMontant = new System.Windows.Forms.NumericUpDown();
            this.lblDevise = new System.Windows.Forms.Label();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.txtNumeroDuCompte = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.txtNoms = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalARembourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantPrete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalRembourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupResteArembourser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.panelLogo.Controls.Add(this.BtnFermer);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(654, 63);
            this.panelLogo.TabIndex = 3;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLogo_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(587, 0);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(67, 63);
            this.BtnFermer.TabIndex = 50;
            this.BtnFermer.Text = "x";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remboursement d\'un emprunt";
            // 
            // nupTotalARembourse
            // 
            this.nupTotalARembourse.DecimalPlaces = 2;
            this.nupTotalARembourse.Enabled = false;
            this.nupTotalARembourse.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTotalARembourse.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupTotalARembourse.Location = new System.Drawing.Point(462, 268);
            this.nupTotalARembourse.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupTotalARembourse.Name = "nupTotalARembourse";
            this.nupTotalARembourse.Size = new System.Drawing.Size(137, 23);
            this.nupTotalARembourse.TabIndex = 69;
            this.nupTotalARembourse.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(289, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Total à rembourser";
            // 
            // nupTaux
            // 
            this.nupTaux.DecimalPlaces = 2;
            this.nupTaux.Enabled = false;
            this.nupTaux.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTaux.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupTaux.Location = new System.Drawing.Point(462, 239);
            this.nupTaux.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupTaux.Name = "nupTaux";
            this.nupTaux.Size = new System.Drawing.Size(137, 23);
            this.nupTaux.TabIndex = 66;
            this.nupTaux.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(320, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Montant prêté";
            // 
            // nupMontantPrete
            // 
            this.nupMontantPrete.DecimalPlaces = 2;
            this.nupMontantPrete.Enabled = false;
            this.nupMontantPrete.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMontantPrete.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupMontantPrete.Location = new System.Drawing.Point(462, 208);
            this.nupMontantPrete.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupMontantPrete.Name = "nupMontantPrete";
            this.nupMontantPrete.Size = new System.Drawing.Size(137, 23);
            this.nupMontantPrete.TabIndex = 64;
            this.nupMontantPrete.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(397, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Taux";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(379, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Devise";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(50, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 304);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // nupTotalRembourse
            // 
            this.nupTotalRembourse.DecimalPlaces = 2;
            this.nupTotalRembourse.Enabled = false;
            this.nupTotalRembourse.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTotalRembourse.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupTotalRembourse.Location = new System.Drawing.Point(462, 297);
            this.nupTotalRembourse.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupTotalRembourse.Name = "nupTotalRembourse";
            this.nupTotalRembourse.Size = new System.Drawing.Size(137, 23);
            this.nupTotalRembourse.TabIndex = 71;
            this.nupTotalRembourse.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(309, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 70;
            this.label6.Text = "Total remboursé";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(281, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 19);
            this.label7.TabIndex = 73;
            this.label7.Text = "Reste à rembourser";
            // 
            // nupResteArembourser
            // 
            this.nupResteArembourser.DecimalPlaces = 2;
            this.nupResteArembourser.Enabled = false;
            this.nupResteArembourser.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupResteArembourser.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupResteArembourser.Location = new System.Drawing.Point(462, 326);
            this.nupResteArembourser.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupResteArembourser.Name = "nupResteArembourser";
            this.nupResteArembourser.Size = new System.Drawing.Size(137, 23);
            this.nupResteArembourser.TabIndex = 72;
            this.nupResteArembourser.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(359, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 75;
            this.label8.Text = "Montant ";
            // 
            // nupMontant
            // 
            this.nupMontant.DecimalPlaces = 2;
            this.nupMontant.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMontant.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupMontant.Location = new System.Drawing.Point(462, 355);
            this.nupMontant.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupMontant.Name = "nupMontant";
            this.nupMontant.Size = new System.Drawing.Size(137, 23);
            this.nupMontant.TabIndex = 2;
            this.nupMontant.ThousandsSeparator = true;
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Nova Slim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.lblDevise.Location = new System.Drawing.Point(462, 183);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(54, 18);
            this.lblDevise.TabIndex = 76;
            this.lblDevise.Text = "Devise";
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.Location = new System.Drawing.Point(363, 393);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(128, 35);
            this.BtnEnregistrer.TabIndex = 0;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // txtNumeroDuCompte
            // 
            this.txtNumeroDuCompte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDuCompte.Location = new System.Drawing.Point(304, 100);
            this.txtNumeroDuCompte.Name = "txtNumeroDuCompte";
            this.txtNumeroDuCompte.PlaceholderText = "N° du compte client";
            this.txtNumeroDuCompte.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroDuCompte.Size = new System.Drawing.Size(300, 27);
            this.txtNumeroDuCompte.TabIndex = 1;
            this.txtNumeroDuCompte.TextChanged += new System.EventHandler(this.TxtNumeroDuCompte_TextChanged);
            // 
            // txtNoms
            // 
            this.txtNoms.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoms.Location = new System.Drawing.Point(304, 141);
            this.txtNoms.Name = "txtNoms";
            this.txtNoms.PlaceholderText = "Nom, postnom et prénom";
            this.txtNoms.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoms.Size = new System.Drawing.Size(300, 27);
            this.txtNoms.TabIndex = 58;
            // 
            // FrmRemboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 471);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.lblDevise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nupMontant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupResteArembourser);
            this.Controls.Add(this.nupTotalRembourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nupTotalARembourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nupTaux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupMontantPrete);
            this.Controls.Add(this.txtNumeroDuCompte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNoms);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRemboursement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRemboursement";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalARembourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantPrete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalRembourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupResteArembourser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.NumericUpDown nupTotalARembourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupTaux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupMontantPrete;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNumeroDuCompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNoms;
        private System.Windows.Forms.NumericUpDown nupTotalRembourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupResteArembourser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupMontant;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Button BtnEnregistrer;
    }
}