namespace Amani_Cash_Manager
{
    partial class FrmPret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPret));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nupTaux = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nupMontantApreter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxDevise = new System.Windows.Forms.ComboBox();
            this.nupMontantArembourser = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.panelInformationDernierPret = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.DgvListe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumerDuCompte = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.txtNoms = new LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantApreter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantArembourser)).BeginInit();
            this.panelInformationDernierPret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListe)).BeginInit();
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
            this.panelLogo.Size = new System.Drawing.Size(636, 63);
            this.panelLogo.TabIndex = 4;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLogo_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(569, 0);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(67, 63);
            this.BtnFermer.TabIndex = 21;
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
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prêt d\'argent au client";
            // 
            // nupTaux
            // 
            this.nupTaux.DecimalPlaces = 2;
            this.nupTaux.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTaux.Location = new System.Drawing.Point(453, 273);
            this.nupTaux.Maximum = new decimal(new int[] {
            1495269376,
            217081053,
            271,
            0});
            this.nupTaux.Name = "nupTaux";
            this.nupTaux.Size = new System.Drawing.Size(171, 23);
            this.nupTaux.TabIndex = 54;
            this.nupTaux.ThousandsSeparator = true;
            this.nupTaux.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(290, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Montant à prêter";
            // 
            // nupMontantApreter
            // 
            this.nupMontantApreter.DecimalPlaces = 2;
            this.nupMontantApreter.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMontantApreter.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupMontantApreter.Location = new System.Drawing.Point(453, 242);
            this.nupMontantApreter.Maximum = new decimal(new int[] {
            1495269376,
            217081053,
            271,
            0});
            this.nupMontantApreter.Name = "nupMontantApreter";
            this.nupMontantApreter.Size = new System.Drawing.Size(171, 23);
            this.nupMontantApreter.TabIndex = 15;
            this.nupMontantApreter.ThousandsSeparator = true;
            this.nupMontantApreter.ValueChanged += new System.EventHandler(this.NupMontantApreter_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(387, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Taux";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(371, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Devise";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 304);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // cbxDevise
            // 
            this.cbxDevise.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDevise.FormattingEnabled = true;
            this.cbxDevise.ItemHeight = 15;
            this.cbxDevise.Items.AddRange(new object[] {
            "CDF",
            "USD"});
            this.cbxDevise.Location = new System.Drawing.Point(453, 213);
            this.cbxDevise.Name = "cbxDevise";
            this.cbxDevise.Size = new System.Drawing.Size(171, 23);
            this.cbxDevise.TabIndex = 10;
            // 
            // nupMontantArembourser
            // 
            this.nupMontantArembourser.DecimalPlaces = 2;
            this.nupMontantArembourser.Enabled = false;
            this.nupMontantArembourser.Font = new System.Drawing.Font("Nova Slim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMontantArembourser.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupMontantArembourser.Location = new System.Drawing.Point(453, 302);
            this.nupMontantArembourser.Maximum = new decimal(new int[] {
            620756992,
            -1962278748,
            271050,
            0});
            this.nupMontantArembourser.Name = "nupMontantArembourser";
            this.nupMontantArembourser.Size = new System.Drawing.Size(171, 23);
            this.nupMontantArembourser.TabIndex = 57;
            this.nupMontantArembourser.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(250, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Montant à rembourser";
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.Location = new System.Drawing.Point(254, 374);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(145, 31);
            this.BtnEnregistrer.TabIndex = 58;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // panelInformationDernierPret
            // 
            this.panelInformationDernierPret.BackColor = System.Drawing.Color.AliceBlue;
            this.panelInformationDernierPret.Controls.Add(this.lblMessage);
            this.panelInformationDernierPret.Controls.Add(this.DgvListe);
            this.panelInformationDernierPret.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInformationDernierPret.Location = new System.Drawing.Point(0, 479);
            this.panelInformationDernierPret.Name = "panelInformationDernierPret";
            this.panelInformationDernierPret.Size = new System.Drawing.Size(636, 73);
            this.panelInformationDernierPret.TabIndex = 59;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblMessage.Image")));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Location = new System.Drawing.Point(189, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(230, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "      Ce client n\'a pas un emprunt en souffrance ";
            this.lblMessage.Visible = false;
            // 
            // DgvListe
            // 
            this.DgvListe.AllowUserToAddRows = false;
            this.DgvListe.AllowUserToDeleteRows = false;
            this.DgvListe.AllowUserToOrderColumns = true;
            this.DgvListe.AllowUserToResizeColumns = false;
            this.DgvListe.AllowUserToResizeRows = false;
            this.DgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvListe.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DgvListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgvListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListe.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListe.GridColor = System.Drawing.Color.AliceBlue;
            this.DgvListe.Location = new System.Drawing.Point(0, 0);
            this.DgvListe.Name = "DgvListe";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListe.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvListe.Size = new System.Drawing.Size(636, 73);
            this.DgvListe.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(3, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 22);
            this.label6.TabIndex = 60;
            this.label6.Text = "Information sur le dernier prêt";
            // 
            // txtNumerDuCompte
            // 
            this.txtNumerDuCompte.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerDuCompte.Location = new System.Drawing.Point(292, 134);
            this.txtNumerDuCompte.Name = "txtNumerDuCompte";
            this.txtNumerDuCompte.PlaceholderText = "N° du compte client";
            this.txtNumerDuCompte.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumerDuCompte.Size = new System.Drawing.Size(334, 27);
            this.txtNumerDuCompte.TabIndex = 1;
            this.txtNumerDuCompte.TextChanged += new System.EventHandler(this.TxtNumerDuCompte_TextChanged);
            // 
            // txtNoms
            // 
            this.txtNoms.Font = new System.Drawing.Font("Nova Slim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoms.Location = new System.Drawing.Point(292, 175);
            this.txtNoms.Name = "txtNoms";
            this.txtNoms.PlaceholderText = "Nom, postnom et prénom";
            this.txtNoms.PlaceholderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoms.Size = new System.Drawing.Size(334, 27);
            this.txtNoms.TabIndex = 43;
            // 
            // FrmPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 552);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelInformationDernierPret);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.nupMontantArembourser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDevise);
            this.Controls.Add(this.nupTaux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupMontantApreter);
            this.Controls.Add(this.txtNumerDuCompte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNoms);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPret";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantApreter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantArembourser)).EndInit();
            this.panelInformationDernierPret.ResumeLayout(false);
            this.panelInformationDernierPret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.NumericUpDown nupTaux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupMontantApreter;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNumerDuCompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LA_CONFIDENCE_CASH_MANAGER.PlaceholderTextBox txtNoms;
        private System.Windows.Forms.ComboBox cbxDevise;
        private System.Windows.Forms.NumericUpDown nupMontantArembourser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEnregistrer;
        private System.Windows.Forms.Panel panelInformationDernierPret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvListe;
        private System.Windows.Forms.Label lblMessage;
    }
}