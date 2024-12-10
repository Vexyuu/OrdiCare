namespace WindowsFormsAppOrdiCare
{
    partial class FormClient
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
            this.groupBoxProduitText = new System.Windows.Forms.GroupBox();
            this.textBoxAdresseClient = new System.Windows.Forms.TextBox();
            this.labelAdresseClient = new System.Windows.Forms.Label();
            this.labelTelClient = new System.Windows.Forms.Label();
            this.textBoxTelClient = new System.Windows.Forms.TextBox();
            this.textBoxMailClient = new System.Windows.Forms.TextBox();
            this.labelMailClient = new System.Windows.Forms.Label();
            this.labelNomProduit = new System.Windows.Forms.Label();
            this.textBoxNomProduit = new System.Windows.Forms.TextBox();
            this.groupBoxProduit = new System.Windows.Forms.GroupBox();
            this.listBoxProduit = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonCleanClient = new System.Windows.Forms.Button();
            this.groupBoxProduitText.SuspendLayout();
            this.groupBoxProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProduitText
            // 
            this.groupBoxProduitText.Controls.Add(this.textBoxAdresseClient);
            this.groupBoxProduitText.Controls.Add(this.labelAdresseClient);
            this.groupBoxProduitText.Controls.Add(this.labelTelClient);
            this.groupBoxProduitText.Controls.Add(this.textBoxTelClient);
            this.groupBoxProduitText.Controls.Add(this.textBoxMailClient);
            this.groupBoxProduitText.Controls.Add(this.labelMailClient);
            this.groupBoxProduitText.Controls.Add(this.labelNomProduit);
            this.groupBoxProduitText.Controls.Add(this.textBoxNomProduit);
            this.groupBoxProduitText.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduitText.Location = new System.Drawing.Point(254, 37);
            this.groupBoxProduitText.Name = "groupBoxProduitText";
            this.groupBoxProduitText.Size = new System.Drawing.Size(452, 244);
            this.groupBoxProduitText.TabIndex = 15;
            this.groupBoxProduitText.TabStop = false;
            this.groupBoxProduitText.Text = "Plus d\'informations";
            // 
            // textBoxAdresseClient
            // 
            this.textBoxAdresseClient.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxAdresseClient.ForeColor = System.Drawing.Color.Black;
            this.textBoxAdresseClient.Location = new System.Drawing.Point(143, 175);
            this.textBoxAdresseClient.Multiline = true;
            this.textBoxAdresseClient.Name = "textBoxAdresseClient";
            this.textBoxAdresseClient.Size = new System.Drawing.Size(303, 49);
            this.textBoxAdresseClient.TabIndex = 29;
            // 
            // labelAdresseClient
            // 
            this.labelAdresseClient.AutoSize = true;
            this.labelAdresseClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelAdresseClient.ForeColor = System.Drawing.Color.Black;
            this.labelAdresseClient.Location = new System.Drawing.Point(6, 176);
            this.labelAdresseClient.Name = "labelAdresseClient";
            this.labelAdresseClient.Size = new System.Drawing.Size(95, 23);
            this.labelAdresseClient.TabIndex = 28;
            this.labelAdresseClient.Text = "Adresse :";
            // 
            // labelTelClient
            // 
            this.labelTelClient.AutoSize = true;
            this.labelTelClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTelClient.ForeColor = System.Drawing.Color.Black;
            this.labelTelClient.Location = new System.Drawing.Point(6, 132);
            this.labelTelClient.Name = "labelTelClient";
            this.labelTelClient.Size = new System.Drawing.Size(47, 23);
            this.labelTelClient.TabIndex = 27;
            this.labelTelClient.Text = "Tel :";
            // 
            // textBoxTelClient
            // 
            this.textBoxTelClient.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxTelClient.ForeColor = System.Drawing.Color.Black;
            this.textBoxTelClient.Location = new System.Drawing.Point(143, 131);
            this.textBoxTelClient.Name = "textBoxTelClient";
            this.textBoxTelClient.Size = new System.Drawing.Size(303, 29);
            this.textBoxTelClient.TabIndex = 26;
            // 
            // textBoxMailClient
            // 
            this.textBoxMailClient.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMailClient.ForeColor = System.Drawing.Color.Black;
            this.textBoxMailClient.Location = new System.Drawing.Point(143, 81);
            this.textBoxMailClient.Name = "textBoxMailClient";
            this.textBoxMailClient.Size = new System.Drawing.Size(303, 29);
            this.textBoxMailClient.TabIndex = 25;
            // 
            // labelMailClient
            // 
            this.labelMailClient.AutoSize = true;
            this.labelMailClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMailClient.ForeColor = System.Drawing.Color.Black;
            this.labelMailClient.Location = new System.Drawing.Point(6, 82);
            this.labelMailClient.Name = "labelMailClient";
            this.labelMailClient.Size = new System.Drawing.Size(58, 23);
            this.labelMailClient.TabIndex = 24;
            this.labelMailClient.Text = "Mail :";
            // 
            // labelNomProduit
            // 
            this.labelNomProduit.AutoSize = true;
            this.labelNomProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNomProduit.ForeColor = System.Drawing.Color.Black;
            this.labelNomProduit.Location = new System.Drawing.Point(6, 36);
            this.labelNomProduit.Name = "labelNomProduit";
            this.labelNomProduit.Size = new System.Drawing.Size(62, 23);
            this.labelNomProduit.TabIndex = 23;
            this.labelNomProduit.Text = "Nom :";
            // 
            // textBoxNomProduit
            // 
            this.textBoxNomProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxNomProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomProduit.Location = new System.Drawing.Point(143, 35);
            this.textBoxNomProduit.Name = "textBoxNomProduit";
            this.textBoxNomProduit.Size = new System.Drawing.Size(303, 29);
            this.textBoxNomProduit.TabIndex = 22;
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.Controls.Add(this.listBoxProduit);
            this.groupBoxProduit.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduit.Location = new System.Drawing.Point(15, 21);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Size = new System.Drawing.Size(216, 320);
            this.groupBoxProduit.TabIndex = 14;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Liste des clients";
            // 
            // listBoxProduit
            // 
            this.listBoxProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxProduit.FormattingEnabled = true;
            this.listBoxProduit.ItemHeight = 21;
            this.listBoxProduit.Location = new System.Drawing.Point(6, 35);
            this.listBoxProduit.Name = "listBoxProduit";
            this.listBoxProduit.Size = new System.Drawing.Size(203, 277);
            this.listBoxProduit.TabIndex = 8;
            this.listBoxProduit.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(590, 350);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 39);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonOK.Location = new System.Drawing.Point(440, 350);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(129, 39);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAjouter.Location = new System.Drawing.Point(254, 302);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(121, 31);
            this.buttonAjouter.TabIndex = 16;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(417, 302);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(121, 31);
            this.buttonModifier.TabIndex = 17;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSupprimer.Location = new System.Drawing.Point(579, 302);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(121, 31);
            this.buttonSupprimer.TabIndex = 18;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonCleanClient
            // 
            this.buttonCleanClient.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCleanClient.Location = new System.Drawing.Point(39, 355);
            this.buttonCleanClient.Name = "buttonCleanClient";
            this.buttonCleanClient.Size = new System.Drawing.Size(162, 31);
            this.buttonCleanClient.TabIndex = 19;
            this.buttonCleanClient.Text = "Vider les cellules";
            this.buttonCleanClient.UseVisualStyleBackColor = true;
            this.buttonCleanClient.Click += new System.EventHandler(this.buttonCleanClient_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 401);
            this.Controls.Add(this.buttonCleanClient);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBoxProduitText);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormClient";
            this.groupBoxProduitText.ResumeLayout(false);
            this.groupBoxProduitText.PerformLayout();
            this.groupBoxProduit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduitText;
        private System.Windows.Forms.GroupBox groupBoxProduit;
        private System.Windows.Forms.ListBox listBoxProduit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxNomProduit;
        private System.Windows.Forms.Label labelNomProduit;
        private System.Windows.Forms.Label labelTelClient;
        private System.Windows.Forms.TextBox textBoxTelClient;
        private System.Windows.Forms.TextBox textBoxMailClient;
        private System.Windows.Forms.Label labelMailClient;
        private System.Windows.Forms.TextBox textBoxAdresseClient;
        private System.Windows.Forms.Label labelAdresseClient;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonCleanClient;
    }
}