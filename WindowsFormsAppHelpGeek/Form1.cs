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


namespace WindowsFormsAppOrdiCare
{
    public partial class FormMain : Form
    {
        private string strcon = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadMateriel();

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


        private void loadMateriel()
        {
            SqlConnection cn = new SqlConnection(this.strcon);
            cn.Open();

            string strsql = "select nom from Produit order by nom";

            SqlCommand sq = new SqlCommand(strsql, cn);

            SqlDataReader drp = sq.ExecuteReader();

            comboBoxMateriel.Items.Clear();

            while (drp.Read() == true)
            {
                string pro = drp["nom"].ToString();
                comboBoxMateriel.Items.Add(pro);
            }
            drp.Close();
            cn.Close();
        }


        // Fonction pour vérifier la connexion de l'utilisateur
        private bool checkConnexion(string lelogin, string lepwd)
        {
            SqlConnection cn = new SqlConnection(this.strcon);
            cn.Open();

            string strsql = "select count(*) as nb from Login where " +
                "Nom = @lenom and Password = @lepwd";           

            SqlCommand sq = new SqlCommand(strsql, cn);
            sq.Parameters.AddWithValue("lenom", lelogin);
            sq.Parameters.AddWithValue("lepwd", lepwd);

            SqlDataReader dr = sq.ExecuteReader();

            dr.Read();
            int nb = Convert.ToInt32(dr["nb"]);

            if (nb > 0)
                return true;
            else
                return false;
        }

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

            int posprod = comboBoxMateriel.SelectedIndex;
            if (posprod == -1)
            {
                MessageBox.Show("Choisissez un prix", "erreur");
                comboBoxMateriel.Focus();
                return;
            }

            int idMatos = getProduitID(comboBoxMateriel.SelectedItem.ToString());

            AddIntervention(resultatPrix, idMatos);  // Création d'un intervention
            MajDateInstall(idMatos, dateTimePickerDate.Value); //Mise à jour de la date d'installation
        }

        private void AddIntervention(decimal resultatPrix, int idMatos)
        {
            SqlConnection cn = new SqlConnection(this.strcon);
            cn.Open();
            string addinter = "insert into INTERVENTION values (@lobjet, @ladate, @lecommentaire, @leprix, @lid";
            SqlCommand sq = new SqlCommand(addinter, cn);
            sq.Parameters.AddWithValue("lobjet", textBoxObjetIntervention.Text);
            sq.Parameters.AddWithValue("ladate", dateTimePickerDate.Value);
            sq.Parameters.AddWithValue("lecommentaire", textBoxCommentaire.Text);
            sq.Parameters.AddWithValue("leprix", resultatPrix);
            sq.Parameters.AddWithValue("lid", idMatos);

            sq.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Intervention créée", "Résultat");
        }

        private void MajDateInstall(int  idMatos, DateTime dateInstall)
        {
            SqlConnection cn = new SqlConnection(this.strcon);
            cn.Open();
            string majSql = "update PRODUIT set Date_Installation = @ladate where ID_PROD = @idpr";
            SqlCommand sq = new SqlCommand(majSql, cn);
            sq.Parameters.AddWithValue("ladate", dateInstall);
            sq.Parameters.AddWithValue(majSql, dateTimePickerDate.Value);

            cn.Close();
        }

        private int getProduitID(string produit)
        {
            {
                SqlConnection cn = new SqlConnection(this.strcon);
                cn.Open();

                string strsql = "select ID_PROD from PRODUIT where Nom = '" + produit + "'";

                SqlCommand sq = new SqlCommand(strsql, cn);

                SqlDataReader drp = sq.ExecuteReader();

                drp.Read();

                int id = Convert.ToInt32(drp["ID_PROD"]);

                drp.Close();
                cn.Close();

                return id;
            }
        }

    }
}
