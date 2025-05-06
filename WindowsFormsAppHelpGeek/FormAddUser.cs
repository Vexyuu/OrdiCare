using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrdiCare
{
    public partial class FormAddUser : Form
    {
        private string strConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPwd.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Générer un sel unique pour chaque utilisateur
            string salt = PasswordHelper.GenerateSalt();

            // Hasher le mot de passe avec le sel
            string motDePasseHashe = PasswordHelper.HashPasswordWithSalt(password, salt);

            using (SqlConnection connection = new SqlConnection(strConnexion))
            {
                connection.Open();

                string query = "INSERT INTO LOGIN (nom, password, salt) VALUES (@nom, @password, @salt)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", login);
                    command.Parameters.AddWithValue("@password", motDePasseHashe);
                    command.Parameters.AddWithValue("@salt", salt); // Stocker le sel également

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Utilisateur créé avec succès !");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
        }

    }
}