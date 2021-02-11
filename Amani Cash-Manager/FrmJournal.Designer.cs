namespace Amani_Cash_Manager
{
    partial class FrmJournal
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCompteRemboursement = new System.Windows.Forms.Button();
            this.BtnJournalDesDepots = new System.Windows.Forms.Button();
            this.BtnJournalDesPrets = new System.Windows.Forms.Button();
            this.BtnJournalDesRetraits = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(590, 63);
            this.panelLogo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Journal des opérations ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Veuillez Choisir le type du journal à afficher";
            // 
            // BtnCompteRemboursement
            // 
            this.BtnCompteRemboursement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCompteRemboursement.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompteRemboursement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnCompteRemboursement.Location = new System.Drawing.Point(112, 327);
            this.BtnCompteRemboursement.Name = "BtnCompteRemboursement";
            this.BtnCompteRemboursement.Size = new System.Drawing.Size(365, 60);
            this.BtnCompteRemboursement.TabIndex = 7;
            this.BtnCompteRemboursement.Text = "Journal des remboursements";
            this.BtnCompteRemboursement.UseVisualStyleBackColor = true;
            this.BtnCompteRemboursement.Click += new System.EventHandler(this.BtnCompteRemboursement_Click);
            // 
            // BtnJournalDesDepots
            // 
            this.BtnJournalDesDepots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnJournalDesDepots.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJournalDesDepots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnJournalDesDepots.Location = new System.Drawing.Point(112, 129);
            this.BtnJournalDesDepots.Name = "BtnJournalDesDepots";
            this.BtnJournalDesDepots.Size = new System.Drawing.Size(365, 60);
            this.BtnJournalDesDepots.TabIndex = 6;
            this.BtnJournalDesDepots.Text = "Journal  des dépôts";
            this.BtnJournalDesDepots.UseVisualStyleBackColor = true;
            this.BtnJournalDesDepots.Click += new System.EventHandler(this.BtnJournalDesDepots_Click);
            // 
            // BtnJournalDesPrets
            // 
            this.BtnJournalDesPrets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnJournalDesPrets.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJournalDesPrets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnJournalDesPrets.Location = new System.Drawing.Point(112, 261);
            this.BtnJournalDesPrets.Name = "BtnJournalDesPrets";
            this.BtnJournalDesPrets.Size = new System.Drawing.Size(365, 60);
            this.BtnJournalDesPrets.TabIndex = 9;
            this.BtnJournalDesPrets.Text = "Journal des prêts";
            this.BtnJournalDesPrets.UseVisualStyleBackColor = true;
            this.BtnJournalDesPrets.Click += new System.EventHandler(this.BtnJournalDesPrets_Click);
            // 
            // BtnJournalDesRetraits
            // 
            this.BtnJournalDesRetraits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnJournalDesRetraits.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJournalDesRetraits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnJournalDesRetraits.Location = new System.Drawing.Point(112, 195);
            this.BtnJournalDesRetraits.Name = "BtnJournalDesRetraits";
            this.BtnJournalDesRetraits.Size = new System.Drawing.Size(365, 60);
            this.BtnJournalDesRetraits.TabIndex = 10;
            this.BtnJournalDesRetraits.Text = "Journal des retraits";
            this.BtnJournalDesRetraits.UseVisualStyleBackColor = true;
            this.BtnJournalDesRetraits.Click += new System.EventHandler(this.BtnJournalDesRetraits_Click);
            // 
            // FrmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 464);
            this.Controls.Add(this.BtnJournalDesRetraits);
            this.Controls.Add(this.BtnJournalDesPrets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCompteRemboursement);
            this.Controls.Add(this.BtnJournalDesDepots);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJournal";
            this.Text = "FrmJournal";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCompteRemboursement;
        private System.Windows.Forms.Button BtnJournalDesDepots;
        private System.Windows.Forms.Button BtnJournalDesPrets;
        private System.Windows.Forms.Button BtnJournalDesRetraits;
    }
}