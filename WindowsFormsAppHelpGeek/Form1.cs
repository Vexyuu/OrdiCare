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
using System.Net.Sockets;


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
            loadMarque();
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
        // ----------------------------------------------------------------------------
        // Fonction pour vérifier la connexion de l'utilisateur
        // ----------------------------------------------------------------------------
        private bool checkConnexion(string lelogin, string lepwd)
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select count(*) as nb from Login where Nom = @lenom and Password = @lepwd";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@lenom", lelogin);
                    sqlCommand.Parameters.AddWithValue("@lepwd", lepwd);

                    using (SqlDataReader dr = sqlCommand.ExecuteReader())
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
                string sqlQuery = "select nom from PRODUIT order by nom";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
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
            string sqlQuery = "select nom from CLIENT order by nom";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL);
            SqlDataReader drp = sqlCommand.ExecuteReader();
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
        private void loadMarque()
        {
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQuery = "select nom from MARQUE order by nom";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL);
            SqlDataReader drp = sqlCommand.ExecuteReader();
            comboBoxMarque.Items.Clear();
            while (drp.Read() == true)
            {
                string pro = drp["nom"].ToString();
                comboBoxMarque.Items.Add(pro);
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
            int idClient = getClientID(comboBoxClient.SelectedItem.ToString());
            int idMarque = getMarqueID(comboBoxMarque.SelectedItem.ToString());

            AddIntervention(resultatPrix, idMatos, idClient, idMarque);  // Création d'un intervention
            MajDateInstall(idMatos, dateTimePickerDate.Value); //Mise à jour de la date d'installation
        }

        // ----------------------------------------------------------------------------
        // Fonction pour ajouter une intervention
        // ----------------------------------------------------------------------------
        private void AddIntervention(decimal resultatPrix, int idMatos, int idClient, int idMarque)
        {
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQueryAddIntervention = "INSERT INTO INTERVENTION (Objet_Intervention, Date_Intervention, Heure_Intervention, Commentaire, Prix, ID_PROD, ID_CLIENT, ID_MARQUE) " +
                                             "VALUES (@lobjet, @ladate, @lheure, @lecommentaire, @leprix, @lidProd, @lidClient, @lidMarque)";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryAddIntervention, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("@lobjet", textBoxObjetIntervention.Text);
                sqlCommand.Parameters.AddWithValue("@ladate", dateTimePickerDate.Value);
                sqlCommand.Parameters.AddWithValue("@lheure", dateTimePickerHeure.Value);
                sqlCommand.Parameters.AddWithValue("@lecommentaire", textBoxCommentaire.Text);
                sqlCommand.Parameters.AddWithValue("@lidProd", idMatos);
                sqlCommand.Parameters.AddWithValue("@lidClient", idClient);
                sqlCommand.Parameters.AddWithValue("@lidMarque", idMarque);
                sqlCommand.Parameters.AddWithValue("@leprix", resultatPrix);

                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Intervention créée", "Résultat");
        }

        private void MajDateInstall(int idMatos, DateTime dateInstall)
        {
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();

            string sqlQueryUpdateMateriel = "update PRODUIT set Date_Installation = @ladate where ID_PROD = @idProduit";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryUpdateMateriel, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("ladate", dateInstall);
                sqlCommand.Parameters.AddWithValue("idProduit", idMatos);

                sqlCommand.ExecuteNonQuery();
            }
        }

        private int getProduitID(string produit)
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select ID_PROD from PRODUIT where Nom = @nom";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@nom", produit);
                    using (SqlDataReader drp = sqlCommand.ExecuteReader())
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

        private int getClientID(string produit)
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select ID_CLIENT from CLIENT where Nom = @nom";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@nom", produit);
                    using (SqlDataReader drp = sqlCommand.ExecuteReader())
                    {
                        if (drp.Read())
                        {
                            return Convert.ToInt32(drp["ID_CLIENT"]);
                        }
                        else
                        {
                            throw new Exception("Client introuvable");
                        }
                    }
                }
            }
        }

        private int getMarqueID(string produit)
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select ID_MARQUE from MARQUE where Nom = @nom";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@nom", produit);
                    using (SqlDataReader drp = sqlCommand.ExecuteReader())
                    {
                        if (drp.Read())
                        {
                            return Convert.ToInt32(drp["ID_MARQUE"]);
                        }
                        else
                        {
                            throw new Exception("Marque introuvable");
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

        private void listeDesInterventionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormIntervention formIntervention = new FormIntervention();
            formIntervention.ShowDialog();
        }
    }
}
