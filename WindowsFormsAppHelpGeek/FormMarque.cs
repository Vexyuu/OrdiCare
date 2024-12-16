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
                using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
                {
                    connectionBaseSQL.Open();

                    string strsql = "SELECT ID_MARQUE, nom FROM MARQUE ORDER BY nom";

                    using (SqlCommand sq = new SqlCommand(strsql, connectionBaseSQL))
                    using (SqlDataReader drp = sq.ExecuteReader())
                    {
                        listBoxMarque.Items.Clear();
                        // Parcourir les résultats de la requête
                        while (drp.Read())
                        {
                            // Construire une chaîne d'affichage pour chaque marque
                            int idMarque = drp.GetInt32(0); // ID_MARQUE
                            string nomMarque = drp.GetString(1); // nom
                            listBoxMarque.Items.Add(new ClassItem(idMarque, nomMarque));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des marques : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textBoxNomMarque.Text = pictureBoxMarque.Text = string.Empty;
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Séléctionner les Marques
        // ----------------------------------------------------------------------------
        private void listBoxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMarque.SelectedItem is ClassItem it)
            {
                int idMarque = it.getId();

                using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
                {
                    connectionBaseSQL.Open();
                    string sqlQuery = "SELECT Nom, Image FROM MARQUE WHERE ID_MARQUE = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", idMarque);
                        using (SqlDataReader drp = sqlCommand.ExecuteReader())
                        {
                            if (drp.Read())
                            {
                                textBoxNomMarque.Text = drp["Nom"].ToString();

                                // Afficher l'image si elle existe
                                if (drp["Image"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])drp["Image"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pictureBoxMarque.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBoxMarque.Image = null; // Aucune image disponible
                                }
                            }
                        }
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Ajouter les Marques
        // ----------------------------------------------------------------------------
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNomMarque.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom de la Marque",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomMarque.Focus();
                return;
            }

            byte[] imageData = null;

            // Vérifiez si une image est sélectionnée dans le PictureBox
            if (pictureBoxMarque.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxMarque.Image.Save(ms, pictureBoxMarque.Image.RawFormat);
                    imageData = ms.ToArray(); // Convertir l'image en tableau de bytes
                }
            }

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQueryAddMarque = "INSERT INTO MARQUE (Nom, Image) VALUES (@marque, @image)";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQueryAddMarque, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@marque", textBoxNomMarque.Text);

                    // Ajoutez l'image ou null si elle n'existe pas
                    sqlCommand.Parameters.Add("@image", SqlDbType.VarBinary).Value = (object)imageData ?? DBNull.Value;

                    sqlCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("La Marque a été ajoutée avec succès !", "Résultat");
            LoadMarque();
            ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Modifier les Marques
        // ----------------------------------------------------------------------------
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            int selectMarque = listBoxMarque.SelectedIndex;
            if (selectMarque == -1)
            {
                MessageBox.Show("Choisissez une Marque");
                listBoxMarque.Focus();
                return;
            }
            if (textBoxNomMarque.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom de la Marque",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomMarque.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxMarque.SelectedItem;
            int idReferenceMarque = it.getId();

            byte[] imageData = null;

            // Vérifiez si une image est sélectionnée dans le PictureBox
            if (pictureBoxMarque.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxMarque.Image.Save(ms, pictureBoxMarque.Image.RawFormat);
                    imageData = ms.ToArray(); // Convertir l'image en tableau de bytes
                }
            }

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQueryUpdateMarque = "UPDATE MARQUE SET Nom = @laMarque, Image = @limage WHERE ID_MARQUE = @idMarque";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQueryUpdateMarque, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@idMarque", idReferenceMarque);
                    sqlCommand.Parameters.AddWithValue("@laMarque", textBoxNomMarque.Text);

                    // Ajoutez l'image ou null si elle n'existe pas
                    sqlCommand.Parameters.Add("@limage", SqlDbType.VarBinary).Value = (object)imageData ?? DBNull.Value;

                    sqlCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("La Marque a été modifiée avec succès !", "Résultat");
            LoadMarque();
            ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Supprimer les Marques
        // ----------------------------------------------------------------------------
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNomMarque.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom de la Marque",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomMarque.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxMarque.SelectedItem;
            int idReferenceMarque = it.getId();

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();

                // Supprimer d'abord les produits liés
                string sqlQueryDeleteProduits = "DELETE FROM PRODUIT WHERE ID_MARQUE = @idMarque";
                using (SqlCommand sqlCommandDeleteProduits = new SqlCommand(sqlQueryDeleteProduits, connectionBaseSQL))
                {
                    sqlCommandDeleteProduits.Parameters.AddWithValue("@idMarque", idReferenceMarque);
                    sqlCommandDeleteProduits.ExecuteNonQuery();
                }

                // Ensuite, supprimer la marque
                string sqlQueryDeleteMarque = "DELETE FROM MARQUE WHERE ID_MARQUE = @idMarque";
                using (SqlCommand sqlCommandDeleteMarque = new SqlCommand(sqlQueryDeleteMarque, connectionBaseSQL))
                {
                    sqlCommandDeleteMarque.Parameters.AddWithValue("@idMarque", idReferenceMarque);
                    sqlCommandDeleteMarque.ExecuteNonQuery();
                }
            }

            MessageBox.Show("La Marque a été supprimée avec succès !", "Résultat");
            LoadMarque();
            ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Vider les cellules des Marques
        // ----------------------------------------------------------------------------
        private void buttonCleanClient_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Insérer les Images
        // ----------------------------------------------------------------------------
        private void InsertImage(int idMarque, string imagePath)
        {
            try
            {
                byte[] imageData = File.ReadAllBytes(imagePath);

                using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
                {
                    connectionBaseSQL.Open();

                    string sqlQuery = "UPDATE MARQUE SET Image = @image WHERE ID_MARQUE = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'insertion de l'image : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjouterImage_Click(object sender, EventArgs e)
        {
            if (listBoxMarque.SelectedItem is ClassItem it)
            {
                int idMarque = it.getId();

                // Ouvrir une boîte de dialogue pour sélectionner une image
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.bmp";
                    ofd.Title = "Sélectionner une image";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = ofd.FileName;

                        // Appeler la méthode pour insérer l'image dans la base de données
                        InsertImage(idMarque, imagePath);

                        // Rafraîchir l'affichage pour montrer la nouvelle image
                        AfficherImage(idMarque);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une marque dans la liste.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AfficherImage(int idMarque)
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "SELECT Image FROM MARQUE WHERE ID_MARQUE = @id";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@id", idMarque);

                    using (SqlDataReader drp = sqlCommand.ExecuteReader())
                    {
                        if (drp.Read() && drp["Image"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])drp["Image"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBoxMarque.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBoxMarque.Image = null; // Aucune image disponible
                        }
                    }
                }
            }
        }


    }
}

