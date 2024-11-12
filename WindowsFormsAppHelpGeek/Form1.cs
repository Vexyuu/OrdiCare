using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Drawing.Text;


namespace WindowsFormsAppOrdiCare
{
    public partial class FormMain : Form
    {
        private string strConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";

        public FormMain()
        {
            InitializeComponent();
            loadMateriel();
            loadClient();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            bool res = false; 

            do
            {
                FormLogin dlg = new FormLogin();
                DialogResult dr = dlg.ShowDialog();

                if (dr ==DialogResult.Cancel)
                {
                    Application.Exit();
                    Application.DoEvents();
                    res = true;
                }

                if (dr == DialogResult.OK)
                {
                    string login = dlg.getLogin();
                    string pwd = dlg.getPwd();

                    res = this.checkConnexion(login, pwd);

                    if (res == false)
                    {
                        MessageBox.Show("Identifiants incorrects",
                            "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            while (res == false);
        }

        // Fonction pour vérifier la connexion de l'utilisateur
        private bool checkConnexion(string lelogin, string lepwd)
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string strsql = "select count(*) as nb from Login where Nom = @lenom and Password = @lepwd";
                using (SqlCommand sq = new SqlCommand(strsql, connectionBaseSQL))
                {
                    sq.Parameters.AddWithValue("@lenom", lelogin);
                    sq.Parameters.AddWithValue("@lepwd", lepwd);

                    using (SqlDataReader dr = sq.ExecuteReader())
                    {
                        if (dr.Read() && Convert.ToInt32(dr["nb"]) > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        // ----------------------------------------------------------------------------
        // Fonctions pour charger les Matériels
        // ----------------------------------------------------------------------------
        private void loadMateriel()
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string strsql = "select nom from PRODUIT order by nom";
                using (SqlCommand sq = new SqlCommand(strsql, connectionBaseSQL))
                using (SqlDataReader drp = sq.ExecuteReader())
                {
                    comboBoxMateriel.Items.Clear();
                    while (drp.Read())
                    {
                        string pro = drp["nom"].ToString();
                        comboBoxMateriel.Items.Add(pro);
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour charger les Clients
        // ----------------------------------------------------------------------------
        private void loadClient()
        {
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();

            string strsql = "select nom from CLIENT order by nom";

            SqlCommand sq = new SqlCommand(strsql, connectionBaseSQL);

            SqlDataReader drp = sq.ExecuteReader();

            comboBoxClient.Items.Clear();

            while (drp.Read() == true)
            {
                string pro = drp["nom"].ToString();
                comboBoxClient.Items.Add(pro);
            }
            drp.Close();
            connectionBaseSQL.Close();
        }
        // ----------------------------------------------------------------------------
        // Fonction pour valider la Création de l'intervention
        // ----------------------------------------------------------------------------
        private void buttonCreerIntervention_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes vous sûr de vouloir valider l'intervention ?",
                "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }

            string prix = textBoxPrix.Text;
            decimal resultatPrix;

            bool b = Decimal.TryParse(prix, out resultatPrix);

            if (b == false)
            {
                MessageBox.Show("Prix incorrect !");
                    return;
            }

            //Check du produit
            int posprod = comboBoxMateriel.SelectedIndex;
            if (posprod == -1)
            {
                MessageBox.Show("Choisissez un prix", "erreur");
                comboBoxMateriel.Focus();
                return;
            }

            int idMatos = getProduitID(comboBoxMateriel.SelectedItem.ToString());

            AddIntervention(resultatPrix, idMatos);  // Création d'un intervention
            MajDateInstall(idMatos, dateTimePickerDate.Value); //Mise à jour de la date d'installation
        }

        // ----------------------------------------------------------------------------
        // Fonction pour ajouter une intervention
        // ----------------------------------------------------------------------------
        private void AddIntervention(decimal resultatPrix, int idMatos)
        {
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string addinter = "insert into INTERVENTION values (@lobjet, @ladate, @lecommentaire, @leprix, @lid)";
            SqlCommand sq = new SqlCommand(addinter, connectionBaseSQL);
            sq.Parameters.AddWithValue("lobjet", textBoxObjetIntervention.Text);
            sq.Parameters.AddWithValue("ladate", dateTimePickerDate.Value);
            sq.Parameters.AddWithValue("lecommentaire", textBoxCommentaire.Text);
            sq.Parameters.AddWithValue("leprix", resultatPrix);
            sq.Parameters.AddWithValue("lid", idMatos);

            sq.ExecuteNonQuery();
            connectionBaseSQL.Close();

            MessageBox.Show("Intervention créée", "Résultat");
        }

        private void MajDateInstall(int  idMatos, DateTime dateInstall)
        {
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();

            string majSql = "update PRODUIT set Date_Installation = @ladate where ID_PROD = @idProduit";
            SqlCommand sq = new SqlCommand(majSql, connectionBaseSQL);
            sq.Parameters.AddWithValue("ladate", dateInstall);
            sq.Parameters.AddWithValue("idProduit", idMatos);

            sq.ExecuteNonQuery();

            connectionBaseSQL.Close();
        }

        private int getProduitID(string produit)
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string strsql = "select ID_PROD from PRODUIT where Nom = @nom";
                using (SqlCommand sq = new SqlCommand(strsql, connectionBaseSQL))
                {
                    sq.Parameters.AddWithValue("@nom", produit);
                    using (SqlDataReader drp = sq.ExecuteReader())
                    {
                        if (drp.Read())
                        {
                            return Convert.ToInt32(drp["ID_PROD"]);
                        }
                        else
                        {
                            throw new Exception("Produit introuvable");
                        }
                    }
                }
            }
        }

        private void marqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarque formMarque = new FormMarque();
            formMarque.ShowDialog();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.ShowDialog();
        }
    }
}
