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

        private void buttonShHiPassword_Click(object sender, EventArgs e)
        {
            // Inverser l'état d'affichage du mot de passe
            textBoxPwd.UseSystemPasswordChar = !textBoxPwd.UseSystemPasswordChar;

            // Modifier le texte du bouton pour refléter l'action possible
            buttonShHiPassword.Text = textBoxPwd.UseSystemPasswordChar ? "Afficher" : "Masquer";
        }


        public string getPwd()
        {
            return this.lepwd;
        }
    }
}
