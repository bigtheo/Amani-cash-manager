namespace Amani_Cash_Manager
{
    partial class FrmDevise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevise));
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeviseUSD = new System.Windows.Forms.Button();
            this.BtnDeviseCDF = new System.Windows.Forms.Button();
            this.panelBarreDeTitre.SuspendLayout();
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
            this.panelBarreDeTitre.Size = new System.Drawing.Size(606, 63);
            this.panelBarreDeTitre.TabIndex = 3;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFermer.FlatAppearance.BorderSize = 0;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(539, 0);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(67, 63);
            this.BtnFermer.TabIndex = 1;
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
            this.label1.Text = "Choix de la devise du compte";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Veuillez Choisir la devise du compte à créer";
            // 
            // BtnDeviseUSD
            // 
            this.BtnDeviseUSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeviseUSD.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeviseUSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnDeviseUSD.Location = new System.Drawing.Point(117, 293);
            this.BtnDeviseUSD.Name = "BtnDeviseUSD";
            this.BtnDeviseUSD.Size = new System.Drawing.Size(365, 70);
            this.BtnDeviseUSD.TabIndex = 7;
            this.BtnDeviseUSD.Text = "Devise USD";
            this.BtnDeviseUSD.UseVisualStyleBackColor = true;
            this.BtnDeviseUSD.Click += new System.EventHandler(this.BtnDeviseUSD_Click);
            // 
            // BtnDeviseCDF
            // 
            this.BtnDeviseCDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeviseCDF.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeviseCDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnDeviseCDF.Location = new System.Drawing.Point(117, 215);
            this.BtnDeviseCDF.Name = "BtnDeviseCDF";
            this.BtnDeviseCDF.Size = new System.Drawing.Size(365, 70);
            this.BtnDeviseCDF.TabIndex = 6;
            this.BtnDeviseCDF.Text = "Devise CDF";
            this.BtnDeviseCDF.UseVisualStyleBackColor = true;
            this.BtnDeviseCDF.Click += new System.EventHandler(this.BtnDeviseCDF_Click);
            // 
            // FrmDevise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDeviseUSD);
            this.Controls.Add(this.BtnDeviseCDF);
            this.Controls.Add(this.panelBarreDeTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDevise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDevise";
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeviseUSD;
        private System.Windows.Forms.Button BtnDeviseCDF;
        private System.Windows.Forms.Button BtnFermer;
    }
}