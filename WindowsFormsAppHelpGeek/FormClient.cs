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

           

            SqlConnection cn = new SqlConnection(this.strConnexion);
            cn.Open();

            string strsql = "select nom from CLIENT order by nom";

            SqlCommand sq = new SqlCommand(strsql, cn);

            SqlDataReader drp = sq.ExecuteReader();

            listBoxClient.Items.Clear();

            while (drp.Read() == true)
            {
                string pro = drp["nom"].ToString();
                listBoxClient.Items.Add(pro);
            }

            drp.Close();
            cn.Close();
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            string leNom = listBoxClient.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection(this.strConnexion);
            connection.Open();
            string strSql = "select * from CLIENT where Nom = '" + leNom + "'";
            SqlCommand sq = new SqlCommand(strSql, connection);
            SqlDataReader drp = sq.ExecuteReader();
            drp.Read();

            textBoxNomClient.Text = drp["Nom"].ToString();
            textBoxMailClient.Text = drp["Mail"].ToString();
            textBoxTelClient.Text = drp["Tel"].ToString();
            textBoxAdresseClient.Text = drp["Adresse"].ToString();

            drp.Close();
            connection.Close();
        }
    }
}
