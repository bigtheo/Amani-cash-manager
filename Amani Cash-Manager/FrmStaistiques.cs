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
    public partial class FrmStaistiques : Form
    {
        public FrmStaistiques()
        {
            InitializeComponent();
        }

        #region Les fonctions sur les stastiques des clients
        private long NombreTotalClient()
        {
            try
            {

                using (MySqlCommand cmd=new MySqlCommand ())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select count(*) as total from client";
                    cmd.Connection = Connexion.Con;
                    if (long.TryParse(cmd.ExecuteScalar().ToString(), out long nombre_total_client))
                    {
                        return nombre_total_client;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private long NombreTotalCompteCDF()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select count(*) from compte where Devise='cdf'";
                    cmd.Connection = Connexion.Con;
                    if (long.TryParse(cmd.ExecuteScalar().ToString(), out long nombre_total_compteCdf))
                    {
                        return nombre_total_compteCdf;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private long NombreTotalCompteUSD()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select count(*) from compte where Devise='USD'";
                    cmd.Connection = Connexion.Con;
                    if (long.TryParse(cmd.ExecuteScalar().ToString(), out long nombre_total_compteCdf))
                    {
                        return nombre_total_compteCdf;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private long NombreTotalCompteCourant()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select count(*) from compte where TypeCompte='Courant'";
                    cmd.Connection = Connexion.Con;
                    if (long.TryParse(cmd.ExecuteScalar().ToString(), out long nombre_total_compteCdf))
                    {
                        return nombre_total_compteCdf;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private long NombreTotalCompteEpargne()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select count(*) from compte where TypeCompte='Epargne'";
                    cmd.Connection = Connexion.Con;
                    if (long.TryParse(cmd.ExecuteScalar().ToString(), out long nombre_total_compteCdf))
                    {
                        return nombre_total_compteCdf;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private long NombreTotalTransctionCredit()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select count(*) as total from operation where TypeOperation='Credit'";
                    cmd.Connection = Connexion.Con;
                    if (long.TryParse(cmd.ExecuteScalar().ToString(), out long nombre_total_compteCdf))
                    {
                        return nombre_total_compteCdf;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private long NombreTotalTransctionDebit()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select count(*) as total from operation where TypeOperation='Debit'";
                    cmd.Connection = Connexion.Con;
                    if (long.TryParse(cmd.ExecuteScalar().ToString(), out long nombre_total_compteCdf))
                    {
                        return nombre_total_compteCdf;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private Decimal TotalMontantCreditCDF()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select sum(o.montant) as total from operation as o INNER JOIN  compte as c on c.id=o.compteID where o.TypeOperation='Credit'  and c.Devise='CDF'";
                    cmd.Connection = Connexion.Con;
                    if (decimal.TryParse(cmd.ExecuteScalar().ToString(), out decimal montant))
                    {
                        return montant;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private decimal TotalMontantCreditUSD()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select sum(o.montant) as total from operation as o INNER JOIN  compte as c on c.id=o.compteID where o.TypeOperation='Credit'  and c.Devise='USD'";
                    cmd.Connection = Connexion.Con;
                    if (decimal.TryParse(cmd.ExecuteScalar().ToString(), out decimal montant))
                    {
                        return montant;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private decimal TotalMontantDebitUSD()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select sum(o.montant) as total from operation as o INNER JOIN  compte as c on c.id=o.compteID where o.TypeOperation='Debit'  and c.Devise='USD'";
                    cmd.Connection = Connexion.Con;
                    if (decimal.TryParse(cmd.ExecuteScalar().ToString(), out decimal montant))
                    {
                        return montant;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private decimal TotalMontantDebitCDF()
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Ouvrir();
                    cmd.CommandText = "select sum(o.montant) as total from operation as o INNER JOIN  compte as c on c.id=o.compteID where o.TypeOperation='Debit'  and c.Devise='CDF'";
                    cmd.Connection = Connexion.Con;
                    if (decimal.TryParse(cmd.ExecuteScalar().ToString(), out decimal montant))
                    {
                        return montant;
                    }

                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private decimal SoldeTotalCDF()
        {
            return TotalMontantCreditCDF() - TotalMontantDebitCDF();
        }
        private decimal SoldeTotalUSD()
        {
            return TotalMontantCreditUSD() - TotalMontantDebitUSD();
        }
        #endregion

        private void FrmStaistiques_Load(object sender, EventArgs e)
        {
            lbl_total_client.Text = NombreTotalClient().ToString();
            lbl_nombre_total_compteCDF.Text = NombreTotalCompteCDF().ToString();
            lbl_nombre_total_compteUSD.Text = NombreTotalCompteUSD().ToString();
            lbl_nombre_total_compteCourant.Text = NombreTotalCompteCourant().ToString();
            lbl_nombre_total_compteEpagne.Text = NombreTotalCompteEpargne().ToString();
            lbl_total_credit.Text = NombreTotalTransctionCredit().ToString();
            lbl_total_debit.Text = NombreTotalTransctionDebit().ToString();
            lbl_Solde_cdf.Text = SoldeTotalCDF().ToString();
            lbl_Solde_usd.Text = SoldeTotalUSD().ToString();
        }
    }
}
