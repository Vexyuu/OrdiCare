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
            loadClient();
        }
        private void loadClient()
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string strsql = "select ID_CLIENT, Nom from CLIENT order by nom";
                using (SqlCommand sq = new SqlCommand(strsql, connectionBaseSQL))
                using (SqlDataReader drp = sq.ExecuteReader())
                {
                    listBoxClient.Items.Clear();
                    while (drp.Read())
                    {
                        int id = Convert.ToInt32(drp["ID_CLIENT"]);
                        string nom = drp["nom"].ToString();
                        var it = new ClassItem(id, nom);
                        listBoxClient.Items.Add(it);
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Séléctionner les Clients
        // ----------------------------------------------------------------------------
        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem it = (ClassItem)listBoxClient.SelectedItem;
            int idReferenceClient = it.getId();

            // string leNom = listBoxClient.SelectedItem.ToString();
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string strSql = "select * from CLIENT where ID_CLIENT = @id";
            using (SqlCommand sq = new SqlCommand(strSql, connectionBaseSQL))
            {
                sq.Parameters.AddWithValue("@id", idReferenceClient);
                using (SqlDataReader drp = sq.ExecuteReader())
                {
                    if (drp.Read())
                    {
                        textBoxNomClient.Text = drp["Nom"].ToString();
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
            if (textBoxNomClient.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Client",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomClient.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Êtes vous sûr de vouloir ajouter ce Client ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            ClassItem it = (ClassItem)listBoxClient.SelectedItem;
            int idReferenceClient = it.getId();


            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string addinter = "insert into CLIENT values (@client, @mail, @telephone, @adresse)";
            SqlCommand sq = new SqlCommand(addinter, connectionBaseSQL);
            sq.Parameters.AddWithValue("client", textBoxNomClient.Text);
            sq.Parameters.AddWithValue("mail", textBoxMailClient.Text);
            sq.Parameters.AddWithValue("telephone", textBoxTelClient.Text);
            sq.Parameters.AddWithValue("adresse", textBoxAdresseClient.Text);

            sq.ExecuteNonQuery();
            connectionBaseSQL.Close();

            MessageBox.Show("Le Client a été ajouté avec succès !", "Résultat");

            loadClient();
            clearFields();
        }

        private void clearFields()
        {
            textBoxNomClient.Text = textBoxMailClient.Text = textBoxTelClient.Text = textBoxAdresseClient.Text = string.Empty;
        }

        private void buttonCleanClient_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Modifier les Clients
        // ----------------------------------------------------------------------------
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            int selectClient = listBoxClient.SelectedIndex;
            if (selectClient == -1)
            {
                MessageBox.Show("Choisissez un Client");
                listBoxClient.Focus();
                return;
            }
            if (textBoxNomClient.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Client",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomClient.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxClient.SelectedItem;
            int idReferenceClient = it.getId();

            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string updateClient = "update CLIENT set Nom = @leClient, Mail = @leMail, Tel = @leTelephone, Adresse = @leAdresse where ID_CLIENT = @idClient";
            using (SqlCommand sq = new SqlCommand(updateClient, connectionBaseSQL))
            {
                sq.Parameters.AddWithValue("idClient", idReferenceClient);
                sq.Parameters.AddWithValue("leClient", textBoxNomClient.Text);
                sq.Parameters.AddWithValue("leMail", textBoxMailClient.Text);
                sq.Parameters.AddWithValue("leTelephone", textBoxTelClient.Text);
                sq.Parameters.AddWithValue("leAdresse", textBoxAdresseClient.Text);

                sq.ExecuteNonQuery();
            }
            MessageBox.Show("Le Client a été modifié avec succès !", "Résultat");
            loadClient();
            clearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Supprimer les Clients
        // ----------------------------------------------------------------------------
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNomClient.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Client",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomClient.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxClient.SelectedItem;
            int idReferenceClient = it.getId();

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string deleteClient = "delete from CLIENT where ID_CLIENT = @idClient";
                using (SqlCommand sq = new SqlCommand(deleteClient, connectionBaseSQL))
                {
                    sq.Parameters.AddWithValue("@idClient", idReferenceClient);
                    sq.Parameters.AddWithValue("leClient", textBoxNomClient.Text);
                    sq.Parameters.AddWithValue("leMail", textBoxMailClient.Text);
                    sq.Parameters.AddWithValue("leTelephone", textBoxTelClient.Text);
                    sq.Parameters.AddWithValue("leAdresse", textBoxAdresseClient.Text);

                    sq.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Le Client a été supprimé avec succès !", "Résultat");
            loadClient();
            clearFields();
        }
    }
}
