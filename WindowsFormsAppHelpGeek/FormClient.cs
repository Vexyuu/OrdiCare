using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrdiCare
{
    public partial class FormClient : Form
    {
        private string strConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";
        public FormClient()
        {
            InitializeComponent();
            LoadClient();
        }
        private void LoadClient()
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select ID_CLIENT, Nom from CLIENT order by nom";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    listBoxProduit.Items.Clear();
                    while (drp.Read())
                    {
                        int id = Convert.ToInt32(drp["ID_CLIENT"]);
                        string nom = drp["nom"].ToString();
                        var it = new ClassItem(id, nom);
                        listBoxProduit.Items.Add(it);
                    }
                }
            }
        }
        private void ClearFields()
        {
            textBoxNomProduit.Text = textBoxMailClient.Text = textBoxTelClient.Text = textBoxAdresseClient.Text = string.Empty;
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Séléctionner les Clients
        // ----------------------------------------------------------------------------
        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceClient = it.getId();

            // string leNom = listBoxClient.SelectedItem.ToString();
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQuery = "select * from CLIENT where ID_CLIENT = @id";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("@id", idReferenceClient);
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    if (drp.Read())
                    {
                        textBoxNomProduit.Text = drp["Nom"].ToString();
                        textBoxMailClient.Text = drp["Mail"].ToString();
                        textBoxTelClient.Text = drp["Tel"].ToString();
                        textBoxAdresseClient.Text = drp["Adresse"].ToString();
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Ajouter les Clients
        // ----------------------------------------------------------------------------
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Client",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomProduit.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Êtes vous sûr de vouloir ajouter ce Client ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceClient = it.getId();


            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQueryAddIntervention = "insert into CLIENT values (@client, @mail, @telephone, @adresse)";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryAddIntervention, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("client", textBoxNomProduit.Text);
                sqlCommand.Parameters.AddWithValue("mail", textBoxMailClient.Text);
                sqlCommand.Parameters.AddWithValue("telephone", textBoxTelClient.Text);
                sqlCommand.Parameters.AddWithValue("adresse", textBoxAdresseClient.Text);

                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Le Client a été ajouté avec succès !", "Résultat");
            LoadClient();
            ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Vider les cellules des Clients
        // ----------------------------------------------------------------------------
        private void buttonCleanClient_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Modifier les Clients
        // ----------------------------------------------------------------------------
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            int selectClient = listBoxProduit.SelectedIndex;
            if (selectClient == -1)
            {
                MessageBox.Show("Choisissez un Client");
                listBoxProduit.Focus();
                return;
            }
            if (textBoxNomProduit.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Client",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomProduit.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceClient = it.getId();

            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQueryUpdateClient = "update CLIENT set Nom = @leClient, Mail = @leMail, Tel = @leTelephone, Adresse = @leAdresse where ID_CLIENT = @idClient";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryUpdateClient, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("idClient", idReferenceClient);
                sqlCommand.Parameters.AddWithValue("leClient", textBoxNomProduit.Text);
                sqlCommand.Parameters.AddWithValue("leMail", textBoxMailClient.Text);
                sqlCommand.Parameters.AddWithValue("leTelephone", textBoxTelClient.Text);
                sqlCommand.Parameters.AddWithValue("leAdresse", textBoxAdresseClient.Text);

                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Le Client a été modifié avec succès !", "Résultat");
            LoadClient();
            ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Supprimer les Clients
        // ----------------------------------------------------------------------------
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Client",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomProduit.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceClient = it.getId();

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuerydeleteClient = "delete from CLIENT where ID_CLIENT = @idClient";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuerydeleteClient, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@idClient", idReferenceClient);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Le Client a été supprimé avec succès !", "Résultat");
            LoadClient();
            ClearFields();
        }
    }
}
