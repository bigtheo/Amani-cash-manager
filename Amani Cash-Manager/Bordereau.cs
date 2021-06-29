using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public class Bordereau
    {
        public string Titre { get; set; }
        public string NumeroTransaction { get; set; }
        public string NumeroCompte { get; set; }
        public string IntituleCompte { get; set; }
        public string DeviseCompte { get; set; }
        public string MontantPrete { get; set; }
        public string Solde { get; set; }
        public string TypeCompte { get; set; }
        public string Taux { get; set; }
        public string MontantRembourser { get; set; }
        public string TotalDepose { get; set; }
        public string ResteApayer { get; set; }
        public string Montant { set; get; }
 
        public void CreerBordereau()
        {

            #region Création du document
            
            Rectangle taille = new iTextSharp.text.Rectangle(new Rectangle(297, 720)); // le format(longueur et largueur) du récu
            Document doc = new Document(taille);
            // doc.SetMargins(30, 30, 7, 30);
            try
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bordereau.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);
                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font police_entete = FontFactory.GetFont("TIMES NEW ROMAN", 13);
            police_entete.SetStyle(1);

            #endregion les polices utilisées

            #region tableau principle

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell_libelle = new PdfPCell(new Phrase("Libellé", police_entete));
            PdfPCell cell_valeur = new PdfPCell(new Phrase("Valeur", police_entete));
            Paragraph p_IntituleCompte = new Paragraph(IntituleCompte)
            {
                Alignment = 1
            };
            Paragraph p_Titre = new Paragraph(this.Titre)
            {
                Alignment = 1
            };

            Font font = new Font(Font.FontFamily.HELVETICA, 14, 1);

            table.AddCell(cell_libelle);
            table.AddCell(cell_valeur);

            table.AddCell("N° compte");
            table.AddCell(new Phrase(NumeroCompte, font));

            table.AddCell("N° Trans.");
            table.AddCell(Helper.GetDernerNumeroOperation(Int64.Parse(NumeroCompte)));

            table.AddCell("Devise");
            table.AddCell(DeviseCompte);
            table.AddCell("Type Compte");
            table.AddCell(TypeCompte);

            table.AddCell("Montant");
            table.AddCell(MontantPrete + " " + this.DeviseCompte);

            table.AddCell("Solde");
            table.AddCell(Solde + " " + DeviseCompte);

            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle

        
            Paragraph paragraphs = new Paragraph("Signature\n-----------------------\n", font)
            {
                Alignment = Element.ALIGN_CENTER
            };
            Paragraph p_siganture = paragraphs;

            /*ajaout de l'en-tête du bordereau */
            Helper.AddEntete(doc);
            doc.Add(p_Titre);
            doc.Add(p_IntituleCompte);
            doc.Add(passerLigne);
            doc.Add(table);
            doc.Add(p_siganture);

            //on ferme le document après écriture
            doc.Close();
            new FrmApercuAvantImpression().ShowDialog();
        }

        public void CreerBordereauRemboursement()
        {
            #region Création du document

            Rectangle taille = new iTextSharp.text.Rectangle(new Rectangle(297, 720)); // le format(longueur et largueur) du récu
            Document doc = new Document(taille);
            // doc.SetMargins(30, 30, 7, 30);
            try
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bordereau.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);
                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font police_entete = FontFactory.GetFont("TIMES NEW ROMAN", 13);
            police_entete.SetStyle(1);

            #endregion les polices utilisées

            #region tableau principle

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell_libelle = new PdfPCell(new Phrase("Libellé", police_entete));
            PdfPCell cell_valeur = new PdfPCell(new Phrase("Valeur", police_entete));
            Paragraph p_IntituleCompte = new Paragraph(IntituleCompte)
            {
                Alignment = 1
            };
            Paragraph p_Titre = new Paragraph(this.Titre)
            {
                Alignment = 1
            };

            Font font = new Font(Font.FontFamily.HELVETICA, 14, 1);
            table.AddCell(cell_libelle);
            table.AddCell(cell_valeur);

            table.AddCell("N° compte");
            table.AddCell(new Phrase(NumeroCompte, font));

            table.AddCell("N° Trans.");
            table.AddCell(Helper.GetDernerNumeroRemboursement());


            table.AddCell("Devise");
            table.AddCell(DeviseCompte);

            table.AddCell("Montant prêté");
            table.AddCell(MontantPrete + " " + DeviseCompte);

            table.AddCell("Taux");
            table.AddCell(Taux + "%");

            table.AddCell("Montant à remoubourser");
            table.AddCell(MontantRembourser + " " + DeviseCompte);

            table.AddCell("Total déposé ");
            table.AddCell(TotalDepose + " " + DeviseCompte);

            table.AddCell("Montant ");
            table.AddCell(Montant + " " + DeviseCompte);

            table.AddCell("Reste à payer");
            table.AddCell(ResteApayer + " " + DeviseCompte);

            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle
            Paragraph p_siganture = new Paragraph("Signature\n-----------------------\n", font)
            {
                Alignment = Element.ALIGN_CENTER
            };

            /*ajaout de l'en-tête du bordereau */
            Helper.AddEntete(doc);
            doc.Add(p_Titre);
            doc.Add(p_IntituleCompte);
            doc.Add(passerLigne);
            doc.Add(table);
            doc.Add(p_siganture);

            //on ferme le document après écriture
            doc.Close();
            new FrmApercuAvantImpression().ShowDialog();
        }

        public void CreerBordereauPret()
        {
            #region Création du document

            Rectangle taille = new iTextSharp.text.Rectangle(new Rectangle(297, 720)); // le format(longueur et largueur) du récu
            Document doc = new Document(taille);
            // doc.SetMargins(30, 30, 7, 30);
            try
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bordereau.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);
                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font police_entete = FontFactory.GetFont("TIMES NEW ROMAN", 13);
            police_entete.SetStyle(1);

            #endregion les polices utilisées

            #region tableau principle

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell_libelle = new PdfPCell(new Phrase("Libellé", police_entete));
            PdfPCell cell_valeur = new PdfPCell(new Phrase("Valeur", police_entete));
            Paragraph p_IntituleCompte = new Paragraph(IntituleCompte)
            {
                Alignment = 1
            };
            Paragraph p_Titre = new Paragraph(this.Titre)
            {
                Alignment = 1
            };

            Font font = new Font(Font.FontFamily.HELVETICA, 14, 1);

            table.AddCell(cell_libelle);
            table.AddCell(cell_valeur);

            table.AddCell("N° compte");
            table.AddCell(new Phrase(NumeroCompte, font));

            table.AddCell("N° Trans.");
            table.AddCell(Helper.GetDernerNumeroPret(Int64.Parse(NumeroCompte)));

            table.AddCell("Devise");
            table.AddCell(DeviseCompte);

            table.AddCell("Montant prêté");
            table.AddCell(MontantPrete + " " + DeviseCompte);

            table.AddCell("Taux");
            table.AddCell(Taux + "%");

            table.AddCell("Montant à remoubourser");
            table.AddCell(MontantRembourser + " " + DeviseCompte);

            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle

            #region ajout des valeur aux document
            Paragraph p_siganture = new Paragraph("Signature\n-----------------------\n", font)
            {
                Alignment = Element.ALIGN_CENTER
            };

            /*ajaout de l'en-tête du bordereau */
            Helper.AddEntete(doc);
            doc.Add(p_Titre);
            doc.Add(p_IntituleCompte);
            doc.Add(passerLigne);
            doc.Add(table);
            doc.Add(p_siganture);

            #endregion ajout des valeur aux document

            //on ferme le document après écriture
            doc.Close();
            new FrmApercuAvantImpression().ShowDialog();
        }

        public void CreerListe(DataGridView dataGridView)
        {
            #region Création du document

            Document doc = new Document();

            try
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bordereau.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);
                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font police_entete = FontFactory.GetFont("TIMES NEW ROMAN", 13);
            police_entete.SetStyle(1);

            #endregion les polices utilisées

            Paragraph p_Titre = new Paragraph(this.Titre)
            {
                Alignment = 1
            };

            #region tableau principle

            PdfPTable table = new PdfPTable(6)
            {
                WidthPercentage = 100,
            };
            table.SetWidths(new float[] { 8, 8, 8, 22, 9, 14 });

            PdfPCell cell_transactionId = new PdfPCell(new Phrase("Trans. ID", police_entete));
            PdfPCell cell_heure = new PdfPCell(new Phrase("Heure", police_entete));
            PdfPCell cell_numeroCompte = new PdfPCell(new Phrase("Compte", police_entete));
            PdfPCell cell_nomclient = new PdfPCell(new Phrase("Nom client", police_entete));
            PdfPCell cell_operation = new PdfPCell(new Phrase("Opération", police_entete));
            PdfPCell cell_montant = new PdfPCell(new Phrase("Montant", police_entete));

            table.AddCell(cell_heure);
            table.AddCell(cell_transactionId);
            table.AddCell(cell_numeroCompte);
            table.AddCell(cell_nomclient);
            table.AddCell(cell_operation);
            table.AddCell(cell_montant);

            foreach (DataGridViewRow data in dataGridView.Rows)
            {
                table.AddCell(data.Cells[0].Value.ToString());
                table.AddCell(data.Cells[1].Value.ToString());
                table.AddCell(data.Cells[2].Value.ToString());
                table.AddCell(data.Cells[3].Value.ToString());
                table.AddCell(data.Cells[4].Value.ToString());
                table.AddCell(data.Cells[5].Value.ToString());
            }

            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle

            /*ajaout de l'en-tête du bordereau */
            Helper.AddEntete(doc);
            doc.Add(p_Titre);

            doc.Add(passerLigne);
            doc.Add(table);

            //on ferme le document après écriture
            doc.Close();
            new FrmApercuAvantImpression().ShowDialog();
        }

        public void CreerListeHistorique(DataGridView dataGridView)
        {
            #region Création du document

            Document doc = new Document();

            try
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bordereau.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);
                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font police_entete = FontFactory.GetFont("TIMES NEW ROMAN", 13);
            police_entete.SetStyle(1);

            #endregion les polices utilisées

            Paragraph p_Titre = new Paragraph(this.Titre)
            {
                Alignment = 1
            };

            #region tableau principle

            PdfPTable table = new PdfPTable(4)
            {
                WidthPercentage = 80,
            };
            table.SetWidths(new float[] { 15, 20, 12, 16 });

            PdfPCell cell_transactionId = new PdfPCell(new Phrase("Trans. ID", police_entete));
            PdfPCell cell_heure = new PdfPCell(new Phrase("Date et heure", police_entete));
            PdfPCell cell_operation = new PdfPCell(new Phrase("Opération", police_entete));
            PdfPCell cell_montant = new PdfPCell(new Phrase("Montant", police_entete));

            table.AddCell(cell_transactionId);
            table.AddCell(cell_heure);
            table.AddCell(cell_operation);
            table.AddCell(cell_montant);

            foreach (DataGridViewRow data in dataGridView.Rows)
            {
                table.AddCell(data.Cells[0].Value.ToString());
                table.AddCell(data.Cells[2].Value.ToString());
                table.AddCell(data.Cells[1].Value.ToString());
                table.AddCell(data.Cells[3].Value.ToString());
            }

            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle

            /*ajaout de l'en-tête du bordereau */
            Helper.AddEntete(doc);
            doc.Add(p_Titre);

            doc.Add(passerLigne);
            doc.Add(table);

            //on ferme le document après écriture
            doc.Close();
            new FrmApercuAvantImpression().ShowDialog();
        }

        public void CreerListeHistoriqueRemboursement(DataGridView dataGridView)
        {
            #region Création du document

            Document doc = new Document();

            try
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bordereau.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);
                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font police_entete = FontFactory.GetFont("TIMES NEW ROMAN", 13);
            police_entete.SetStyle(1);

            #endregion les polices utilisées

            Paragraph p_Titre = new Paragraph(this.Titre)
            {
                Alignment = 1
            };

            #region tableau principle

            PdfPTable table = new PdfPTable(4)
            {
                WidthPercentage = 80,
            };
            table.SetWidths(new float[] { 10, 20, 15, 16 });

            PdfPCell cell_transactionId = new PdfPCell(new Phrase("Trans. ID", police_entete));
            PdfPCell cell_heure = new PdfPCell(new Phrase("Date et heure", police_entete));
            PdfPCell cell_montant = new PdfPCell(new Phrase("Montant", police_entete));
            PdfPCell cell_pretId = new PdfPCell(new Phrase("N° du prêt", police_entete));

            table.AddCell(cell_transactionId);
            table.AddCell(cell_heure);
            table.AddCell(cell_montant);
            table.AddCell(cell_pretId);
          

            foreach (DataGridViewRow data in dataGridView.Rows)
            {
                table.AddCell(data.Cells[0].Value.ToString());
                table.AddCell(data.Cells[1].Value.ToString());
                table.AddCell(data.Cells[2].Value.ToString());
                table.AddCell(data.Cells[3].Value.ToString());
            }

            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle

            /*ajaout de l'en-tête du bordereau */
            Helper.AddEntete(doc);
            doc.Add(p_Titre);

            doc.Add(passerLigne);
            doc.Add(table);

            //on ferme le document après écriture
            doc.Close();
            new FrmApercuAvantImpression().ShowDialog();
        }
    }
}