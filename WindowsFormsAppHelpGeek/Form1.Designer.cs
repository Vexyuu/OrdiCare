namespace WindowsFormsAppOrdiCare
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fzadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInterventionsToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesInterventionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxInterventions = new System.Windows.Forms.GroupBox();
            this.dateTimePickerHeure = new System.Windows.Forms.DateTimePicker();
            this.labelHeureIntervention = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.labelMateriel = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelObjet = new System.Windows.Forms.Label();
            this.buttonCreerIntervention = new System.Windows.Forms.Button();
            this.comboBoxMateriel = new System.Windows.Forms.ComboBox();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.textBoxObjetIntervention = new System.Windows.Forms.TextBox();
            this.labelMarque = new System.Windows.Forms.Label();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxInterventions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fzadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fzadToolStripMenuItem
            // 
            this.fzadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.marqueToolStripMenuItem,
            this.matérielToolStripMenuItem,
            this.listeDesInterventionsToolStripMenuItem,
            this.listeDesInterventionsToolStripMenuItem1});
            this.fzadToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.fzadToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.fzadToolStripMenuItem.Name = "fzadToolStripMenuItem";
            this.fzadToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.fzadToolStripMenuItem.Text = "Gestion";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.clientToolStripMenuItem.Text = "Client...";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.marqueToolStripMenuItem.Text = "Marque...";
            this.marqueToolStripMenuItem.Click += new System.EventHandler(this.marqueToolStripMenuItem_Click);
            // 
            // matérielToolStripMenuItem
            // 
            this.matérielToolStripMenuItem.Name = "matérielToolStripMenuItem";
            this.matérielToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.matérielToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.matérielToolStripMenuItem.Text = "Matériel";
            // 
            // listeDesInterventionsToolStripMenuItem
            // 
            this.listeDesInterventionsToolStripMenuItem.Name = "listeDesInterventionsToolStripMenuItem";
            this.listeDesInterventionsToolStripMenuItem.Size = new System.Drawing.Size(273, 6);
            // 
            // listeDesInterventionsToolStripMenuItem1
            // 
            this.listeDesInterventionsToolStripMenuItem1.Name = "listeDesInterventionsToolStripMenuItem1";
            this.listeDesInterventionsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.listeDesInterventionsToolStripMenuItem1.Size = new System.Drawing.Size(276, 26);
            this.listeDesInterventionsToolStripMenuItem1.Text = "Liste des interventions";
            this.listeDesInterventionsToolStripMenuItem1.Click += new System.EventHandler(this.listeDesInterventionsToolStripMenuItem1_Click);
            // 
            // GroupBoxInterventions
            // 
            this.GroupBoxInterventions.Controls.Add(this.comboBoxMarque);
            this.GroupBoxInterventions.Controls.Add(this.labelMarque);
            this.GroupBoxInterventions.Controls.Add(this.dateTimePickerHeure);
            this.GroupBoxInterventions.Controls.Add(this.labelHeureIntervention);
            this.GroupBoxInterventions.Controls.Add(this.comboBoxClient);
            this.GroupBoxInterventions.Controls.Add(this.dateTimePickerDate);
            this.GroupBoxInterventions.Controls.Add(this.textBoxPrix);
            this.GroupBoxInterventions.Controls.Add(this.labelMateriel);
            this.GroupBoxInterventions.Controls.Add(this.labelPrix);
            this.GroupBoxInterventions.Controls.Add(this.labelCommentaire);
            this.GroupBoxInterventions.Controls.Add(this.labelClient);
            this.GroupBoxInterventions.Controls.Add(this.labelDate);
            this.GroupBoxInterventions.Controls.Add(this.labelObjet);
            this.GroupBoxInterventions.Controls.Add(this.buttonCreerIntervention);
            this.GroupBoxInterventions.Controls.Add(this.comboBoxMateriel);
            this.GroupBoxInterventions.Controls.Add(this.textBoxCommentaire);
            this.GroupBoxInterventions.Controls.Add(this.textBoxObjetIntervention);
            this.GroupBoxInterventions.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.GroupBoxInterventions.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxInterventions.Location = new System.Drawing.Point(12, 69);
            this.GroupBoxInterventions.Name = "GroupBoxInterventions";
            this.GroupBoxInterventions.Size = new System.Drawing.Size(1045, 409);
            this.GroupBoxInterventions.TabIndex = 4;
            this.GroupBoxInterventions.TabStop = false;
            this.GroupBoxInterventions.Text = "Interventions";
            // 
            // dateTimePickerHeure
            // 
            this.dateTimePickerHeure.CustomFormat = "HH : mm : ss";
            this.dateTimePickerHeure.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHeure.Location = new System.Drawing.Point(691, 94);
            this.dateTimePickerHeure.Name = "dateTimePickerHeure";
            this.dateTimePickerHeure.Size = new System.Drawing.Size(136, 29);
            this.dateTimePickerHeure.TabIndex = 25;
            // 
            // labelHeureIntervention
            // 
            this.labelHeureIntervention.AutoSize = true;
            this.labelHeureIntervention.Font = new System.Drawing.Font("Arial", 12F);
            this.labelHeureIntervention.ForeColor = System.Drawing.Color.Black;
            this.labelHeureIntervention.Location = new System.Drawing.Point(491, 96);
            this.labelHeureIntervention.Name = "labelHeureIntervention";
            this.labelHeureIntervention.Size = new System.Drawing.Size(194, 23);
            this.labelHeureIntervention.TabIndex = 24;
            this.labelHeureIntervention.Text = "Heure d\'intervention :";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(96, 322);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(214, 29);
            this.comboBoxClient.TabIndex = 23;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd / MMMM / yyyy";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(199, 92);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(246, 29);
            this.dateTimePickerDate.TabIndex = 22;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPrix.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrix.Location = new System.Drawing.Point(511, 275);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(134, 29);
            this.textBoxPrix.TabIndex = 21;
            // 
            // labelMateriel
            // 
            this.labelMateriel.AutoSize = true;
            this.labelMateriel.Font = new System.Drawing.Font("Arial", 11F);
            this.labelMateriel.ForeColor = System.Drawing.Color.Black;
            this.labelMateriel.Location = new System.Drawing.Point(4, 277);
            this.labelMateriel.Name = "labelMateriel";
            this.labelMateriel.Size = new System.Drawing.Size(86, 22);
            this.labelMateriel.TabIndex = 20;
            this.labelMateriel.Text = "Matériel :";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Arial", 11F);
            this.labelPrix.ForeColor = System.Drawing.Color.Black;
            this.labelPrix.Location = new System.Drawing.Point(453, 277);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(52, 22);
            this.labelPrix.TabIndex = 19;
            this.labelPrix.Text = "Prix :";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Font = new System.Drawing.Font("Arial", 12F);
            this.labelCommentaire.ForeColor = System.Drawing.Color.Black;
            this.labelCommentaire.Location = new System.Drawing.Point(9, 133);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(139, 23);
            this.labelCommentaire.TabIndex = 18;
            this.labelCommentaire.Text = "Commentaire :";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelClient.ForeColor = System.Drawing.Color.Black;
            this.labelClient.Location = new System.Drawing.Point(4, 323);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(71, 23);
            this.labelClient.TabIndex = 17;
            this.labelClient.Text = "Client :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(9, 92);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(184, 23);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date d\'intervention :";
            // 
            // labelObjet
            // 
            this.labelObjet.AutoSize = true;
            this.labelObjet.Font = new System.Drawing.Font("Arial", 12F);
            this.labelObjet.ForeColor = System.Drawing.Color.Black;
            this.labelObjet.Location = new System.Drawing.Point(6, 47);
            this.labelObjet.Name = "labelObjet";
            this.labelObjet.Size = new System.Drawing.Size(185, 23);
            this.labelObjet.TabIndex = 5;
            this.labelObjet.Text = "Objet du problème :";
            // 
            // buttonCreerIntervention
            // 
            this.buttonCreerIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCreerIntervention.Location = new System.Drawing.Point(715, 324);
            this.buttonCreerIntervention.Name = "buttonCreerIntervention";
            this.buttonCreerIntervention.Size = new System.Drawing.Size(291, 42);
            this.buttonCreerIntervention.TabIndex = 15;
            this.buttonCreerIntervention.Text = "Créer une intervention";
            this.buttonCreerIntervention.UseVisualStyleBackColor = true;
            this.buttonCreerIntervention.Click += new System.EventHandler(this.buttonCreerIntervention_Click);
            // 
            // comboBoxMateriel
            // 
            this.comboBoxMateriel.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxMateriel.FormattingEnabled = true;
            this.comboBoxMateriel.Location = new System.Drawing.Point(96, 274);
            this.comboBoxMateriel.Name = "comboBoxMateriel";
            this.comboBoxMateriel.Size = new System.Drawing.Size(326, 29);
            this.comboBoxMateriel.TabIndex = 14;
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxCommentaire.ForeColor = System.Drawing.Color.Black;
            this.textBoxCommentaire.Location = new System.Drawing.Point(6, 160);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(1033, 99);
            this.textBoxCommentaire.TabIndex = 9;
            // 
            // textBoxObjetIntervention
            // 
            this.textBoxObjetIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxObjetIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxObjetIntervention.Location = new System.Drawing.Point(197, 43);
            this.textBoxObjetIntervention.Name = "textBoxObjetIntervention";
            this.textBoxObjetIntervention.Size = new System.Drawing.Size(842, 29);
            this.textBoxObjetIntervention.TabIndex = 5;
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMarque.ForeColor = System.Drawing.Color.Black;
            this.labelMarque.Location = new System.Drawing.Point(351, 324);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(89, 23);
            this.labelMarque.TabIndex = 26;
            this.labelMarque.Text = "Marque :";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(443, 323);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(214, 29);
            this.comboBoxMarque.TabIndex = 27;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 526);
            this.Controls.Add(this.GroupBoxInterventions);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxInterventions.ResumeLayout(false);
            this.GroupBoxInterventions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fzadToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBoxInterventions;
        private System.Windows.Forms.TextBox textBoxObjetIntervention;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.ComboBox comboBoxMateriel;
        private System.Windows.Forms.Button buttonCreerIntervention;
        private System.Windows.Forms.Label labelObjet;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMateriel;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator listeDesInterventionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesInterventionsToolStripMenuItem1;
        private System.Windows.Forms.Label labelHeureIntervention;
        private System.Windows.Forms.DateTimePicker dateTimePickerHeure;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.Label labelMarque;
    }
}

