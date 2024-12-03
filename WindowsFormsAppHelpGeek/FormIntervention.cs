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
    public partial class FormIntervention : Form
    {
        private string strConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";
        public FormIntervention()
        {
            InitializeComponent();
            loadIntervention();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Charger les Clients
        // ----------------------------------------------------------------------------
        private void loadIntervention()
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
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

        private void clearFields()
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
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
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

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
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
            loadIntervention();
            clearFields();
        }
    }
}
