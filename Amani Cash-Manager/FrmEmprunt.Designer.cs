namespace Amani_Cash_Manager
{
    partial class FrmEmprunt
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
            this.BtnRemboursement = new System.Windows.Forms.Button();
            this.BtnPret = new System.Windows.Forms.Button();
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
            this.panelLogo.Size = new System.Drawing.Size(606, 63);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les emprunts des clients";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nova Slim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Veuillez Choisir le type d\'opération à faire";
            // 
            // BtnRemboursement
            // 
            this.BtnRemboursement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemboursement.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemboursement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnRemboursement.Location = new System.Drawing.Point(121, 253);
            this.BtnRemboursement.Name = "BtnRemboursement";
            this.BtnRemboursement.Size = new System.Drawing.Size(365, 70);
            this.BtnRemboursement.TabIndex = 10;
            this.BtnRemboursement.Text = "Remboursement d\'argent";
            this.BtnRemboursement.UseVisualStyleBackColor = true;
            this.BtnRemboursement.Click += new System.EventHandler(this.BtnRemboursement_Click);
            // 
            // BtnPret
            // 
            this.BtnPret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPret.Font = new System.Drawing.Font("Nova Slim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.BtnPret.Location = new System.Drawing.Point(121, 177);
            this.BtnPret.Name = "BtnPret";
            this.BtnPret.Size = new System.Drawing.Size(365, 70);
            this.BtnPret.TabIndex = 9;
            this.BtnPret.Text = "Prêt d\'argent au client";
            this.BtnPret.UseVisualStyleBackColor = true;
            this.BtnPret.Click += new System.EventHandler(this.BtnPret_Click);
            // 
            // FrmEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemboursement);
            this.Controls.Add(this.BtnPret);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmprunt";
            this.Text = "FrmEmprunt";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRemboursement;
        private System.Windows.Forms.Button BtnPret;
    }
}