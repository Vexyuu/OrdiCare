namespace WindowsFormsAppOrdiCare
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.GroupBoxConnect = new System.Windows.Forms.GroupBox();
            this.buttonShHiPassword = new System.Windows.Forms.Button();
            this.GroupBoxConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxLogin.Location = new System.Drawing.Point(206, 56);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(98, 24);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPwd.Location = new System.Drawing.Point(206, 106);
            this.textBoxPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(98, 24);
            this.textBoxPwd.TabIndex = 3;
            this.textBoxPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(67, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonOK.Location = new System.Drawing.Point(70, 167);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 32);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(206, 167);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 32);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // GroupBoxConnect
            // 
            this.GroupBoxConnect.Controls.Add(this.buttonShHiPassword);
            this.GroupBoxConnect.Controls.Add(this.label2);
            this.GroupBoxConnect.Controls.Add(this.buttonCancel);
            this.GroupBoxConnect.Controls.Add(this.label1);
            this.GroupBoxConnect.Controls.Add(this.buttonOK);
            this.GroupBoxConnect.Controls.Add(this.textBoxLogin);
            this.GroupBoxConnect.Controls.Add(this.textBoxPwd);
            this.GroupBoxConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxConnect.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxConnect.Location = new System.Drawing.Point(19, 34);
            this.GroupBoxConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxConnect.Name = "GroupBoxConnect";
            this.GroupBoxConnect.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxConnect.Size = new System.Drawing.Size(425, 245);
            this.GroupBoxConnect.TabIndex = 6;
            this.GroupBoxConnect.TabStop = false;
            this.GroupBoxConnect.Text = "Connection à votre compte OrdiCare";
            // 
            // buttonShHiPassword
            // 
            this.buttonShHiPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShHiPassword.Location = new System.Drawing.Point(327, 102);
            this.buttonShHiPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShHiPassword.Name = "buttonShHiPassword";
            this.buttonShHiPassword.Size = new System.Drawing.Size(86, 32);
            this.buttonShHiPassword.TabIndex = 6;
            this.buttonShHiPassword.Text = "Afficher";
            this.buttonShHiPassword.UseVisualStyleBackColor = true;
            this.buttonShHiPassword.Click += new System.EventHandler(this.buttonShHiPassword_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.GroupBoxConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connexion";
            this.GroupBoxConnect.ResumeLayout(false);
            this.GroupBoxConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox GroupBoxConnect;
        private System.Windows.Forms.Button buttonShHiPassword;
    }
}