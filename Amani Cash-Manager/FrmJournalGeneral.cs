using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amani_Cash_Manager
{
    public partial class FrmJournalGeneral : Form
    {
        public FrmJournalGeneral()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            string sql =null;
            SetTypeJournal(FrmJournal.typeJournal);
            if (GetTypeJournal() == TypeJournal.Depot)
            {
                //opération pour les dépôts
                lblTititreJournal.Text = "Journal des dépôts";
                sql = "select  " +
                    "time(o.dateOperation) as Heures, o.Id as 'Trans. ID', Cpte.Id as 'N° du compte', cli.noms as 'Noms client', " +
                    "o.typeOperation as 'Opération', concat_ws(' ',o.montant,cpte.devise) 'Montant' " +
                    "from operation as o  inner join compte as cpte " +
                    "ON cpte.id = o.compteID " +
                    "INNER JOIN client as cli " +
                    "ON cli.id = cpte.clientID " +
                    "where date(o.dateOperation)=@date and o.typeOperation = 'Credit'";
            }


            if (GetTypeJournal() == TypeJournal.Retrait)
            {
                //opération pour les retrait
                lblTititreJournal.Text = "Journal des retraits";

                sql = "select  " +
                    "time(o.dateOperation) as Heures, o.Id as 'Trans. ID', Cpte.Id as 'N° du compte', cli.noms as 'Noms client', " +
                    "o.typeOperation as 'Opération', concat_ws(' ',o.montant,cpte.devise) as 'Montant' " +
                    "from operation as o  inner join compte as cpte " +
                    "ON cpte.id = o.compteID " +
                    "INNER JOIN client as cli " +
                    "ON cli.id = cpte.clientID " +
                    "where date(o.dateOperation)=@date and o.typeOperation = 'Debit'";
            }

            if (GetTypeJournal() == TypeJournal.Pret)
            {
                //opération pour les prêt
                lblTititreJournal.Text = "Journal des prêts";
                sql= "select TIME(p.dateDuPret) as Heure,p.Id AS 'Transc Id',cpte.Id as 'N° Compte', " +
                    "cli.noms as 'Nom client','prêt' as 'Opération',concat_ws(' ', p.montant, p.devise) as 'Montant' " +
                    "from pret as p " +
                    "inner join compte as cpte on cpte.id = p.compteId " +
                    "inner join client as cli on cli.id = cpte.clientId where date(p.dateDuPret)= @date";
            }
            if (GetTypeJournal() == TypeJournal.Remboursement)
            {
                //opération pour les remboursement
                lblTititreJournal.Text = "Journal des Remboursements";
                sql= "select TIME(r.dateRemboursement) as Heure,r.Id AS 'Transc Id',cpte.Id as 'N° Compte', " +
                    "cli.noms as 'Nom client','Rembours.' as 'Opération',concat_ws(' ',r.montant,p.Devise) as 'Montant' " +
                    "from remboursement as r " +
                    "inner join pret as p On p.id = r.pretId " +
                    "inner join compte as cpte on cpte.id = p.compteId " +
                    "inner join client as cli on cli.id = cpte.clientId " +
                    "where date(r.dateRemboursement) = @date";
            }

            using (MySqlCommand cmd=new MySqlCommand ())
            {
                Connexion.Ouvrir();
                cmd.Connection = Connexion.Con;
                cmd.CommandText = sql;

                MySqlParameter p_Date = new MySqlParameter("@date", MySqlDbType.Date)
                {
                    Value = dtp_Date.Value
                };
                cmd.Parameters.Add(p_Date);
                using (MySqlDataAdapter adapter=new MySqlDataAdapter (cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvListe.DataSource = table;
                }
            }
            
        }

        private TypeJournal typeJournal;

        public TypeJournal GetTypeJournal()
        {
            return typeJournal;
        }

        public void SetTypeJournal(TypeJournal value)
        {
            typeJournal = value;
        }

        private void Dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            CustomizeDesign();
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Bordereau bordereau = new Bordereau()
            {
                Titre=$"{lblTititreJournal.Text} du {dtp_Date.Text} "
            };
            bordereau.CreerListe(dgvListe);
            this.Cursor = Cursors.Default;
          
        }
    }
    public enum TypeJournal
    {
        Retrait,
        Depot,
        Pret,
        Remboursement
    }

    


}
