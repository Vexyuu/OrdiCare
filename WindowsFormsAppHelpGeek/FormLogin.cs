using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrdiCare
{
    public partial class FormLogin : Form
    {
        private string lelogin, lepwd;

        public FormLogin()
        {
            InitializeComponent();
        }

        public string getLogin()
        {
            return this.lelogin;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.lelogin = textBoxLogin.Text;
            this.lepwd = textBoxPwd.Text;
        }

        public string getPwd()
        {
            return this.lepwd;
        }
    }
}
