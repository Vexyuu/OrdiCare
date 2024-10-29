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


namespace WindowsFormsAppHelpGeek
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


    }
}
