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
    public partial class FormMarque : Form
    {
        // Chaîne de connexion à la base de données
        private string strConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";

        public FormMarque()
        {
            InitializeComponent();
            LoadMarque();
        }

        // Méthode pour charger les marques depuis la base de données
        private void LoadMarque()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(this.strConnexion))
                {
                    cn.Open();

                    string strsql = "SELECT ID_MARQUE, nom FROM MARQUE ORDER BY nom";

                    using (SqlCommand sq = new SqlCommand(strsql, cn))
                    using (SqlDataReader drp = sq.ExecuteReader())
                    {
                        listBoxMarque.Items.Clear();
                        // Parcourir les résultats de la requête
                        while (drp.Read())
                        {
                            // Construire une chaîne d'affichage pour chaque marque
                            int idMarque = drp.GetInt32(0); // ID_MARQUE
                            string nomMarque = drp.GetString(1); // nom
                            listBoxMarque.Items.Add($"[{idMarque}] {nomMarque}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des marques : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Séléctionner les Clients
        // ----------------------------------------------------------------------------
        private void listBoxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem it = (ClassItem)listBoxMarque.SelectedItem;
            int idReferenceClient = it.getId();

            // string leNom = listBoxClient.SelectedItem.ToString();
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQuery = "select * from IMG_MARQUE where ID_MARQUE = @id";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("@id", idReferenceClient);
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    if (drp.Read())
                    {
                        textBoxNomMarque.Text = drp["Nom"].ToString();
                        pictureBoxMarque.Text = drp["Image"].ToString();
                    }
                }
            }
        }

        private void InsertImage(int idMarque, string imagePath)
        {
            byte[] imageData = File.ReadAllBytes(imagePath);

            using (SqlConnection connection = new SqlConnection(this.strConnexion))
            {
                connection.Open();

                string sqlQuery = "UPDATE MARQUE SET Image = @image WHERE ID_MARQUE = @id";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@image", imageData);
                    sqlCommand.Parameters.AddWithValue("@id", idMarque);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0
                        ? "Image insérée avec succès !"
                        : "Échec de l'insertion de l'image.");
                }
            }
        }

    }
}

