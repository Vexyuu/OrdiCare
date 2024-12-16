using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrdiCare
{
    public partial class FormIntervention : Form
    {
        private string StrConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";
        public FormIntervention()
        {
            InitializeComponent();
            LoadIntervention();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Charger les Clients
        // ----------------------------------------------------------------------------
        private void LoadIntervention()
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select ID_INTER, Objet_Intervention from INTERVENTION Objet_Intervention";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    listBoxIntervention.Items.Clear();
                    while (drp.Read())
                    {
                        int id = Convert.ToInt32(drp["ID_INTER"]);
                        string nom = drp["Objet_Intervention"].ToString();
                        var it = new ClassItem(id, nom);
                        listBoxIntervention.Items.Add(it);
                    }
                }
            }
        }

        private void ClearFields()
        {
            textBoxObjectIntervention.Text = textBoxDateIntervention.Text = textBoxHeureIntervention.Text =
            textBoxCommentaireIntervention.Text = textBoxMaterielIntervention.Text =
            textBoxClientIntervention.Text = textBoxMarqueIntervention.Text = textBoxPrixIntervention.Text = string.Empty;
        }

        private void listBoxIntervention_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem it = (ClassItem)listBoxIntervention.SelectedItem;
            int idReferenceClient = it.getId();

            // string leNom = listBoxClient.SelectedItem.ToString();
            SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion);
            connectionBaseSQL.Open();
            string sqlQuery = "select * from INTERVENTION where ID_INTER = @id";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("@id", idReferenceClient);
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    if (drp.Read())
                    {
                        textBoxObjectIntervention.Text = drp["Objet_Intervention"].ToString();
                        textBoxDateIntervention.Text = drp["Date_Intervention"].ToString();
                        textBoxHeureIntervention.Text = drp["Heure_Intervention"].ToString();
                        textBoxCommentaireIntervention.Text = drp["Commentaire"].ToString();
                        textBoxMaterielIntervention.Text = drp["ID_MARQUE"].ToString();
                        textBoxClientIntervention.Text = drp["Prix"].ToString();
                        textBoxMarqueIntervention.Text = drp["ID_CLIENT"].ToString();
                        textBoxPrixIntervention.Text = drp["ID_PROD"].ToString();
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Modifier les Interventions
        // ----------------------------------------------------------------------------
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            int selectIntervention = listBoxIntervention.SelectedIndex;

            // Vérification qu'une intervention est sélectionnée
            if (selectIntervention == -1)
            {
                MessageBox.Show("Choisissez une Intervention.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBoxIntervention.Focus();
                return;
            }

            // Vérification de l'objet de l'intervention
            if (string.IsNullOrWhiteSpace(textBoxObjectIntervention.Text))
            {
                MessageBox.Show("Veuillez indiquer l'Objet de l'Intervention.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxObjectIntervention.Focus();
                return;
            }

            // Récupération de l'ID de l'intervention sélectionnée
            ClassItem it = (ClassItem)listBoxIntervention.SelectedItem;
            int idReferenceIntervention = it.getId();

            try
            {
                // Conversion des valeurs avec validation
                if (!int.TryParse(textBoxMarqueIntervention.Text.Trim(), out int idMarque))
                {
                    MessageBox.Show("ID Marque doit être un entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxMaterielIntervention.Text.Trim(), out int idProd))
                {
                    MessageBox.Show("ID Produit doit être un entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxClientIntervention.Text.Trim(), out int idClient))
                {
                    MessageBox.Show("ID Client doit être un entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxPrixIntervention.Text.Trim(), out decimal prix))
                {
                    MessageBox.Show("Le prix doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Connexion à la base et exécution de la requête SQL
                using (SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion))
                {
                    connectionBaseSQL.Open();
                    string sqlQueryUpdate = "UPDATE INTERVENTION SET Objet_Intervention = @lObject, Date_Intervention = @laDateIntervention, " +
                                            "Heure_Intervention = @lHeureIntervention, Commentaire = @leCommentaire, ID_MARQUE = @lidMarque, " +
                                            "ID_PROD = @lidProduit, ID_CLIENT = @lidClient, Prix = @lePrix WHERE ID_INTER = @idIntervention";

                    using (SqlCommand sqlCommand = new SqlCommand(sqlQueryUpdate, connectionBaseSQL))
                    {
                        sqlCommand.Parameters.AddWithValue("@idIntervention", idReferenceIntervention);
                        sqlCommand.Parameters.AddWithValue("@lObject", textBoxObjectIntervention.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@laDateIntervention", DateTime.Parse(textBoxDateIntervention.Text.Trim()));
                        sqlCommand.Parameters.AddWithValue("@lHeureIntervention", TimeSpan.Parse(textBoxHeureIntervention.Text.Trim()));
                        sqlCommand.Parameters.AddWithValue("@leCommentaire", textBoxCommentaireIntervention.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@lidMarque", idMarque);
                        sqlCommand.Parameters.AddWithValue("@lidProduit", idProd);
                        sqlCommand.Parameters.AddWithValue("@lidClient", idClient);
                        sqlCommand.Parameters.AddWithValue("@lePrix", prix);

                        sqlCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("L'intervention a été modifiée avec succès !", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIntervention();
                ClearFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erreur de format : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Une erreur SQL est survenue : {ex.Message}", "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur inattendue est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ----------------------------------------------------------------------------
        // Fonctions pour Supprimer les Interventions
        // ----------------------------------------------------------------------------
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxObjectIntervention.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Client",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxObjectIntervention.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxIntervention.SelectedItem;
            int idReference = it.getId();

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuerydeleteIntervention = "delete from INTERVENTION where ID_INTER = @idIntervention";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuerydeleteIntervention, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@idIntervention", idReference);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            MessageBox.Show("L'intervention a été supprimé avec succès !", "Résultat");
            LoadIntervention();
            ClearFields();
        }


    }
}
