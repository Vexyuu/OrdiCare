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
    public partial class FormMarque : Form
    {
        private string strConnexion = "Server=.\\SQLEXPRESS;" +
            "Database=OrdiCare;Trusted_Connection=True";

        public FormMarque()
        {
            InitializeComponent();
            loadMarque();
        }

        private void loadMarque()
        {
        SqlConnection cn = new SqlConnection(this.strConnexion);
        cn.Open();

        string strsql = "select nom from MARQUE order by nom";

        SqlCommand sq = new SqlCommand(strsql, cn);

        SqlDataReader drp = sq.ExecuteReader();

        listBoxMarque.Items.Clear();

        while (drp.Read() == true)
        {
            string pro = drp["nom"].ToString();
        listBoxMarque.Items.Add(pro);
        }

        drp.Close();
        cn.Close();
        }
    }
}
