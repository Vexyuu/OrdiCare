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
            this.groupBoxProduitText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxProduitText.Controls.Add(this.textBoxAdresseClient);
            this.groupBoxProduitText.Controls.Add(this.labelAdresseClient);
            this.groupBoxProduitText.Controls.Add(this.labelTelClient);
            this.groupBoxProduitText.Controls.Add(this.textBoxTelClient);
            this.groupBoxProduitText.Controls.Add(this.textBoxMailClient);
            this.groupBoxProduitText.Controls.Add(this.labelMailClient);
            this.groupBoxProduitText.Controls.Add(this.labelNomProduit);
            this.groupBoxProduitText.Controls.Add(this.textBoxNomProduit);
            this.groupBoxProduitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduitText.Location = new System.Drawing.Point(190, 30);
            this.groupBoxProduitText.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProduitText.Name = "groupBoxProduitText";
            this.groupBoxProduitText.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProduitText.Size = new System.Drawing.Size(339, 198);
            this.groupBoxProduitText.TabIndex = 15;
            this.groupBoxProduitText.TabStop = false;
            this.groupBoxProduitText.Text = "Plus d\'informations";
            // 
            // textBoxAdresseClient
            // 
            this.textBoxAdresseClient.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxAdresseClient.ForeColor = System.Drawing.Color.Black;
            this.textBoxAdresseClient.Location = new System.Drawing.Point(107, 142);
            this.textBoxAdresseClient.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdresseClient.Multiline = true;
            this.textBoxAdresseClient.Name = "textBoxAdresseClient";
            this.textBoxAdresseClient.Size = new System.Drawing.Size(228, 41);
            this.textBoxAdresseClient.TabIndex = 29;
            // 
            // labelAdresseClient
            // 
            this.labelAdresseClient.AutoSize = true;
            this.labelAdresseClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelAdresseClient.ForeColor = System.Drawing.Color.Black;
            this.labelAdresseClient.Location = new System.Drawing.Point(4, 143);
            this.labelAdresseClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdresseClient.Name = "labelAdresseClient";
            this.labelAdresseClient.Size = new System.Drawing.Size(75, 18);
            this.labelAdresseClient.TabIndex = 28;
            this.labelAdresseClient.Text = "Adresse :";
            // 
            // labelTelClient
            // 
            this.labelTelClient.AutoSize = true;
            this.labelTelClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTelClient.ForeColor = System.Drawing.Color.Black;
            this.labelTelClient.Location = new System.Drawing.Point(4, 107);
            this.labelTelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelClient.Name = "labelTelClient";
            this.labelTelClient.Size = new System.Drawing.Size(35, 18);
            this.labelTelClient.TabIndex = 27;
            this.labelTelClient.Text = "Tel :";
            // 
            // textBoxTelClient
            // 
            this.textBoxTelClient.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxTelClient.ForeColor = System.Drawing.Color.Black;
            this.textBoxTelClient.Location = new System.Drawing.Point(107, 106);
            this.textBoxTelClient.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelClient.Name = "textBoxTelClient";
            this.textBoxTelClient.Size = new System.Drawing.Size(228, 24);
            this.textBoxTelClient.TabIndex = 26;
            // 
            // textBoxMailClient
            // 
            this.textBoxMailClient.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMailClient.ForeColor = System.Drawing.Color.Black;
            this.textBoxMailClient.Location = new System.Drawing.Point(107, 66);
            this.textBoxMailClient.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMailClient.Name = "textBoxMailClient";
            this.textBoxMailClient.Size = new System.Drawing.Size(228, 24);
            this.textBoxMailClient.TabIndex = 25;
            // 
            // labelMailClient
            // 
            this.labelMailClient.AutoSize = true;
            this.labelMailClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMailClient.ForeColor = System.Drawing.Color.Black;
            this.labelMailClient.Location = new System.Drawing.Point(4, 67);
            this.labelMailClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMailClient.Name = "labelMailClient";
            this.labelMailClient.Size = new System.Drawing.Size(45, 18);
            this.labelMailClient.TabIndex = 24;
            this.labelMailClient.Text = "Mail :";
            // 
            // labelNomProduit
            // 
            this.labelNomProduit.AutoSize = true;
            this.labelNomProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNomProduit.ForeColor = System.Drawing.Color.Black;
            this.labelNomProduit.Location = new System.Drawing.Point(4, 29);
            this.labelNomProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomProduit.Name = "labelNomProduit";
            this.labelNomProduit.Size = new System.Drawing.Size(49, 18);
            this.labelNomProduit.TabIndex = 23;
            this.labelNomProduit.Text = "Nom :";
            // 
            // textBoxNomProduit
            // 
            this.textBoxNomProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxNomProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomProduit.Location = new System.Drawing.Point(107, 28);
            this.textBoxNomProduit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomProduit.Name = "textBoxNomProduit";
            this.textBoxNomProduit.Size = new System.Drawing.Size(228, 24);
            this.textBoxNomProduit.TabIndex = 22;
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxProduit.Controls.Add(this.listBoxProduit);
            this.groupBoxProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduit.Location = new System.Drawing.Point(11, 17);
            this.groupBoxProduit.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProduit.Size = new System.Drawing.Size(162, 260);
            this.groupBoxProduit.TabIndex = 14;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Liste des clients";
            // 
            // listBoxProduit
            // 
            this.listBoxProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxProduit.FormattingEnabled = true;
            this.listBoxProduit.ItemHeight = 17;
            this.listBoxProduit.Location = new System.Drawing.Point(4, 28);
            this.listBoxProduit.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProduit.Name = "listBoxProduit";
            this.listBoxProduit.Size = new System.Drawing.Size(153, 225);
            this.listBoxProduit.TabIndex = 8;
            this.listBoxProduit.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(442, 284);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 32);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonOK.Location = new System.Drawing.Point(330, 284);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 32);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAjouter.Location = new System.Drawing.Point(190, 245);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(91, 25);
            this.buttonAjouter.TabIndex = 16;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(313, 245);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 25);
            this.buttonModifier.TabIndex = 17;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSupprimer.Location = new System.Drawing.Point(434, 245);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 25);
            this.buttonSupprimer.TabIndex = 18;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonCleanClient
            // 
            this.buttonCleanClient.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCleanClient.Location = new System.Drawing.Point(29, 288);
            this.buttonCleanClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCleanClient.Name = "buttonCleanClient";
            this.buttonCleanClient.Size = new System.Drawing.Size(122, 25);
            this.buttonCleanClient.TabIndex = 19;
            this.buttonCleanClient.Text = "Vider les cellules";
            this.buttonCleanClient.UseVisualStyleBackColor = true;
            this.buttonCleanClient.Click += new System.EventHandler(this.buttonCleanClient_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 326);
            this.Controls.Add(this.buttonCleanClient);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBoxProduitText);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrdiCare";
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