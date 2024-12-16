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
    public partial class FormProduit : Form                                         
    {
        private string StrConnexion = "Server=.\\SQLEXPRESS;" + "Database=OrdiCare;Trusted_Connection=True";
        public FormProduit()                                                        
        {                                                                           
            InitializeComponent();
            LoadProduit();
        }
        private void LoadProduit()
        {
            using (SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuery = "select ID_PRODUIT, Nom from PRODUIT order by nom";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    listBoxProduit.Items.Clear();
                    while (drp.Read())
                    {
                        int id = Convert.ToInt32(drp["ID_PRODUIT"]);
                        string nom = drp["nom"].ToString();
                        var it = new ClassItem(id, nom);
                        listBoxProduit.Items.Add(it);
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Vider les cellules des Produits
        // ----------------------------------------------------------------------------
        private void ClearFields()
        {
            textBoxNomProduit.Text = textBoxDescriptionProduit.Text = dateTimePickerDate.Text = textBoxCodeProduit.Text = textBoxMBTFProduit.Text = textBoxMarqueProduit.Text = textBoxClientProduit.Text = string.Empty;
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Séléctionner les Produits
        // ----------------------------------------------------------------------------
        private void listBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceProduit = it.getId();

            SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion);
            connectionBaseSQL.Open();
            string sqlQuery = "select * from PRODUIT where ID_PRODUIT = @id";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("@id", idReferenceProduit);
                using (SqlDataReader drp = sqlCommand.ExecuteReader())
                {
                    if (drp.Read())
                    {
                        textBoxNomProduit.Text = drp["Nom"].ToString();
                        textBoxDescriptionProduit.Text = drp["Description"].ToString();
                        dateTimePickerDate.Text = drp["Date_Installation"].ToString();
                        textBoxCodeProduit.Text = drp["Code"].ToString();
                        textBoxMBTFProduit.Text = drp["MTBF"].ToString();
                        textBoxMarqueProduit.Text = drp["ID_MARQUE"].ToString();
                        textBoxClientProduit.Text = drp["ID_CLIENT"].ToString();
                    }
                }
            }
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Ajouter les Produits
        // ----------------------------------------------------------------------------
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Produit",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomProduit.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Êtes vous sûr de vouloir ajouter ce Produit ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceProduit = it.getId();


            SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion);
            connectionBaseSQL.Open();
            string sqlQueryAddProduit = "insert into PRODUIT values (@nom, @description, @dateInstall, " + " @code, @mbtf, @idMarque, @idClient)";

            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryAddProduit, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("nom", textBoxNomProduit.Text);
                sqlCommand.Parameters.AddWithValue("description", textBoxDescriptionProduit.Text);
                sqlCommand.Parameters.AddWithValue("dateInstall", dateTimePickerDate.Text);
                sqlCommand.Parameters.AddWithValue("code", textBoxCodeProduit.Text);
                sqlCommand.Parameters.AddWithValue("mbtf", textBoxMBTFProduit.Text);
                sqlCommand.Parameters.AddWithValue("idMarque", textBoxMarqueProduit.Text);
                sqlCommand.Parameters.AddWithValue("idClient", textBoxClientProduit.Text);

                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Le Produit a été ajouté avec succès !", "Résultat");
            LoadProduit();
            ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Modifier les Clients
        // ----------------------------------------------------------------------------
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            int selectProduit = listBoxProduit.SelectedIndex;
            if (selectProduit == -1)
            {
                MessageBox.Show("Choisissez un Produit");
                listBoxProduit.Focus();
                return;
            }
            if (textBoxNomProduit.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Produit",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomProduit.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceProduit = it.getId();

            SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion);
            connectionBaseSQL.Open();
            string sqlQueryUpdateProduit = "update PRODUIT set Nom = @lenom, description = @laDescription, Date_Installation = @laDateInstall, code = @lecode," +
                "mtbf = @lmtbf, id_Marque = @lidMarque, id_Client = @lidClient where ID_PRODUIT = @idProduit";
            using (SqlCommand sqlCommand = new SqlCommand(sqlQueryUpdateProduit, connectionBaseSQL))
            {
                sqlCommand.Parameters.AddWithValue("idProduit", idReferenceProduit);
                sqlCommand.Parameters.AddWithValue("lenom", textBoxNomProduit.Text);
                sqlCommand.Parameters.AddWithValue("laDescription", textBoxDescriptionProduit.Text);
                sqlCommand.Parameters.AddWithValue("laDateInstall", dateTimePickerDate.Text);
                sqlCommand.Parameters.AddWithValue("lecode", textBoxCodeProduit.Text);
                sqlCommand.Parameters.AddWithValue("lmtbf", textBoxMBTFProduit.Text);
                sqlCommand.Parameters.AddWithValue("lidMarque", textBoxMarqueProduit.Text);
                sqlCommand.Parameters.AddWithValue("lidClient", textBoxClientProduit.Text);

                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Le Produit a été modifié avec succès !", "Résultat");
            LoadProduit();
            ClearFields();
        }

        // ----------------------------------------------------------------------------
        // Fonctions pour Supprimer les Clients
        // ----------------------------------------------------------------------------
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNomProduit.Text == "")
            {
                MessageBox.Show("Veuillez indiquer le Nom du Produit",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxNomProduit.Focus();
                return;
            }

            ClassItem it = (ClassItem)listBoxProduit.SelectedItem;
            int idReferenceProduit = it.getId();

            using (SqlConnection connectionBaseSQL = new SqlConnection(this.StrConnexion))
            {
                connectionBaseSQL.Open();
                string sqlQuerydeleteClient = "delete from PRODUIT where ID_PRODUIT = @idProduit";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuerydeleteClient, connectionBaseSQL))
                {
                    sqlCommand.Parameters.AddWithValue("@idProduit", idReferenceProduit);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Le Produit a été supprimé avec succès !", "Résultat");
            LoadProduit();
            ClearFields();
        }

        private void buttonCleanClient_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }
    }
}
