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
    public partial class FormTechnicien : Form
    {
        private string strConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";
        public FormTechnicien()
        {
            InitializeComponent();
            LoadTechnicien();
        }
        private void LoadTechnicien()
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select ID_TECHNICIEN, Nom from TECHNICIEN order by nom";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    listBoxTechniciens.Items.Clear();
                    while (drp.Read())
                    {
                        int id = Convert.ToInt32(drp["ID_TECHNICIEN"]);
                        string nom = drp["nom"].ToString();
                        var it = new ClassItem(id, nom);
                        listBoxTechniciens.Items.Add(it);
                    }
                }
            }
        }
        private void clearFields()
        {
            textBoxNomTechnicien.Text = textBoxMailTechnicien.Text = textBoxTelTechnicien.Text = textBoxStatutTechnicien.Text = string.Empty;
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Séléctionner les Techniciens
        // ----------------------------------------------------------------------------
        private void listBoxTechniciens_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem it = (ClassItem)listBoxTechniciens.SelectedItem;
            int idReferenceTechnicien = it.getId();

            // string leNom = listBoxTechnicien.SelectedItem.ToString();
            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQuery = "select * from TECHNICIEN where ID_TECHNICIEN = @id";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("@id", idReferenceTechnicien);
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    if (drp.Read())
                    {
                        textBoxNomTechnicien.Text = drp["Nom"].ToString();
                        textBoxMailTechnicien.Text = drp["Mail"].ToString();
                        textBoxTelTechnicien.Text = drp["Telephone"].ToString();
                        textBoxStatutTechnicien.Text = drp["Statut"].ToString();
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Ajouter les Techniciens
        // ----------------------------------------------------------------------------
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNomTechnicien.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Technicien",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomTechnicien.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Êtes vous sûr de vouloir ajouter ce Technicien ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            ClassItem it = (ClassItem)listBoxTechniciens.SelectedItem;
            int idReferenceTechnicien = it.getId();

            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQueryAddIntervention = "insert into TECHNICIEN values (@technicien, @mail, @telephone, @statut)";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryAddIntervention, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("technicien", textBoxNomTechnicien.Text);
                sqlCommand.Parameters.AddWithValue("mail", textBoxMailTechnicien.Text);
                sqlCommand.Parameters.AddWithValue("telephone", textBoxTelTechnicien.Text);
                sqlCommand.Parameters.AddWithValue("Statut", textBoxStatutTechnicien.Text);

                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Le Technicien a été ajouté avec succès !", "Résultat");
            LoadTechnicien();
            clearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Vider les cellules des Techniciens
        // ----------------------------------------------------------------------------
        private void buttonCleanTechnicien_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Modifier les Techniciens
        // ----------------------------------------------------------------------------
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            int selectTechnicien = listBoxTechniciens.SelectedIndex;
            if (selectTechnicien == -1)
            {
                MessageBox.Show("Choisissez un Technicien");
                listBoxTechniciens.Focus();
                return;
            }
            if (textBoxNomTechnicien.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Technicien",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomTechnicien.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxTechniciens.SelectedItem;
            int idReferenceTechnicien = it.getId();

            SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion);
            connectionBaseSQL.Open();
            string sqlQueryUpdateTechnicien = "update TECHNICIEN set Nom = @leTechnicien, Mail = @leMail, Telephone = @leTelephone, Statut = @leStatut where ID_TECHNICIEN = @idTechnicien";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryUpdateTechnicien, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("idTechnicien", idReferenceTechnicien);
                sqlCommand.Parameters.AddWithValue("leTechnicien", textBoxNomTechnicien.Text);
                sqlCommand.Parameters.AddWithValue("leMail", textBoxMailTechnicien.Text);
                sqlCommand.Parameters.AddWithValue("leTelephone", textBoxTelTechnicien.Text);
                sqlCommand.Parameters.AddWithValue("leStatut", textBoxStatutTechnicien.Text);

                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Le Technicien a été modifié avec succès !", "Résultat");
            LoadTechnicien();
            clearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Supprimer les Techniciens
        // ----------------------------------------------------------------------------
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNomTechnicien.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Technicien",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomTechnicien.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxTechniciens.SelectedItem;
            int idReferenceTechnicien = it.getId();

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.strConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuerydeleteTechnicien = "delete from TECHNICIEN where ID_TECHNICIEN = @idTechnicien";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuerydeleteTechnicien, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@idTechnicien", idReferenceTechnicien);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Le Technicien a été supprimé avec succès !", "Résultat");
            LoadTechnicien();
            clearFields();
        }
    }
}
