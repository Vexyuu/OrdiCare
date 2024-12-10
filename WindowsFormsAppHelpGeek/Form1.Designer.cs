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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInterventionsToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesTechniciensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInterventionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxInterventions = new System.Windows.Forms.GroupBox();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.labelMarque = new System.Windows.Forms.Label();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLeave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMarque = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMateriel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTechnicien = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInterventions = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearField = new System.Windows.Forms.ToolStripButton();
            this.labelTechnicien = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxInterventions.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.marqueToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.matérielToolStripMenuItem,
            this.listeDesInterventionsToolStripMenuItem,
            this.listeDesTechniciensToolStripMenuItem,
            this.listeDesInterventionsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.fermerToolStripMenuItem});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.ToolStripMenuItem.Text = "Gestion";
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
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.produitToolStripMenuItem.Text = "Produit...";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // matérielToolStripMenuItem
            // 
            this.matérielToolStripMenuItem.Name = "matérielToolStripMenuItem";
            this.matérielToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.matérielToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.matérielToolStripMenuItem.Text = "Matériel...";
            // 
            // listeDesInterventionsToolStripMenuItem
            // 
            this.listeDesInterventionsToolStripMenuItem.Name = "listeDesInterventionsToolStripMenuItem";
            this.listeDesInterventionsToolStripMenuItem.Size = new System.Drawing.Size(273, 6);
            // 
            // listeDesTechniciensToolStripMenuItem
            // 
            this.listeDesTechniciensToolStripMenuItem.Name = "listeDesTechniciensToolStripMenuItem";
            this.listeDesTechniciensToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.listeDesTechniciensToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.listeDesTechniciensToolStripMenuItem.Text = "Liste des techniciens";
            this.listeDesTechniciensToolStripMenuItem.Click += new System.EventHandler(this.listeDesTechniciensToolStripMenuItem_Click);
            // 
            // listeDesInterventionsToolStripMenuItem1
            // 
            this.listeDesInterventionsToolStripMenuItem1.Name = "listeDesInterventionsToolStripMenuItem1";
            this.listeDesInterventionsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.listeDesInterventionsToolStripMenuItem1.Size = new System.Drawing.Size(276, 26);
            this.listeDesInterventionsToolStripMenuItem1.Text = "Liste des interventions";
            this.listeDesInterventionsToolStripMenuItem1.Click += new System.EventHandler(this.listeDesInterventionsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(273, 6);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.fermerToolStripMenuItem.Text = "Fermer ..";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // GroupBoxInterventions
            // 
            this.GroupBoxInterventions.Controls.Add(this.labelTechnicien);
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
            this.GroupBoxInterventions.Location = new System.Drawing.Point(84, 57);
            this.GroupBoxInterventions.Name = "GroupBoxInterventions";
            this.GroupBoxInterventions.Size = new System.Drawing.Size(1147, 531);
            this.GroupBoxInterventions.TabIndex = 4;
            this.GroupBoxInterventions.TabStop = false;
            this.GroupBoxInterventions.Text = "Interventions";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(511, 382);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(214, 29);
            this.comboBoxMarque.TabIndex = 27;
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMarque.ForeColor = System.Drawing.Color.Black;
            this.labelMarque.Location = new System.Drawing.Point(419, 383);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(89, 23);
            this.labelMarque.TabIndex = 26;
            this.labelMarque.Text = "Marque :";
            // 
            // dateTimePickerHeure
            // 
            this.dateTimePickerHeure.CustomFormat = "HH : mm : ss";
            this.dateTimePickerHeure.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHeure.Location = new System.Drawing.Point(806, 116);
            this.dateTimePickerHeure.Name = "dateTimePickerHeure";
            this.dateTimePickerHeure.Size = new System.Drawing.Size(136, 29);
            this.dateTimePickerHeure.TabIndex = 25;
            // 
            // labelHeureIntervention
            // 
            this.labelHeureIntervention.AutoSize = true;
            this.labelHeureIntervention.Font = new System.Drawing.Font("Arial", 12F);
            this.labelHeureIntervention.ForeColor = System.Drawing.Color.Black;
            this.labelHeureIntervention.Location = new System.Drawing.Point(606, 118);
            this.labelHeureIntervention.Name = "labelHeureIntervention";
            this.labelHeureIntervention.Size = new System.Drawing.Size(194, 23);
            this.labelHeureIntervention.TabIndex = 24;
            this.labelHeureIntervention.Text = "Heure d\'intervention :";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(98, 382);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(214, 29);
            this.comboBoxClient.TabIndex = 23;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd / MMMM / yyyy";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(199, 118);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(246, 29);
            this.dateTimePickerDate.TabIndex = 22;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPrix.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrix.Location = new System.Drawing.Point(511, 312);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(163, 29);
            this.textBoxPrix.TabIndex = 21;
            // 
            // labelMateriel
            // 
            this.labelMateriel.AutoSize = true;
            this.labelMateriel.Font = new System.Drawing.Font("Arial", 11F);
            this.labelMateriel.ForeColor = System.Drawing.Color.Black;
            this.labelMateriel.Location = new System.Drawing.Point(6, 319);
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
            this.labelPrix.Location = new System.Drawing.Point(453, 314);
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
            this.labelCommentaire.Location = new System.Drawing.Point(9, 180);
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
            this.labelClient.Location = new System.Drawing.Point(6, 383);
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
            this.labelDate.Location = new System.Drawing.Point(9, 118);
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
            this.buttonCreerIntervention.Location = new System.Drawing.Point(780, 439);
            this.buttonCreerIntervention.Name = "buttonCreerIntervention";
            this.buttonCreerIntervention.Size = new System.Drawing.Size(342, 70);
            this.buttonCreerIntervention.TabIndex = 15;
            this.buttonCreerIntervention.Text = "Créer une intervention";
            this.buttonCreerIntervention.UseVisualStyleBackColor = true;
            this.buttonCreerIntervention.Click += new System.EventHandler(this.buttonCreerIntervention_Click);
            // 
            // comboBoxMateriel
            // 
            this.comboBoxMateriel.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxMateriel.FormattingEnabled = true;
            this.comboBoxMateriel.Location = new System.Drawing.Point(98, 316);
            this.comboBoxMateriel.Name = "comboBoxMateriel";
            this.comboBoxMateriel.Size = new System.Drawing.Size(326, 29);
            this.comboBoxMateriel.TabIndex = 14;
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxCommentaire.ForeColor = System.Drawing.Color.Black;
            this.textBoxCommentaire.Location = new System.Drawing.Point(6, 207);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(1135, 99);
            this.textBoxCommentaire.TabIndex = 9;
            // 
            // textBoxObjetIntervention
            // 
            this.textBoxObjetIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxObjetIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxObjetIntervention.Location = new System.Drawing.Point(197, 43);
            this.textBoxObjetIntervention.Name = "textBoxObjetIntervention";
            this.textBoxObjetIntervention.Size = new System.Drawing.Size(944, 29);
            this.textBoxObjetIntervention.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLeave,
            this.toolStripButtonClient,
            this.toolStripButtonMarque,
            this.toolStripButtonMateriel,
            this.toolStripButtonTechnicien,
            this.toolStripButtonInterventions,
            this.toolStripButtonClearField});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(50, 595);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLeave
            // 
            this.toolStripButtonLeave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLeave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLeave.Image")));
            this.toolStripButtonLeave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLeave.Name = "toolStripButtonLeave";
            this.toolStripButtonLeave.Size = new System.Drawing.Size(47, 49);
            this.toolStripButtonLeave.Text = "Fermer le Logiciel";
            this.toolStripButtonLeave.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // toolStripButtonClient
            // 
            this.toolStripButtonClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClient.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClient.Image")));
            this.toolStripButtonClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClient.Name = "toolStripButtonClient";
            this.toolStripButtonClient.Size = new System.Drawing.Size(37, 39);
            this.toolStripButtonClient.Text = "Afficher les Clients";
            this.toolStripButtonClient.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // toolStripButtonMarque
            // 
            this.toolStripButtonMarque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMarque.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMarque.Image")));
            this.toolStripButtonMarque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMarque.Name = "toolStripButtonMarque";
            this.toolStripButtonMarque.Size = new System.Drawing.Size(37, 39);
            this.toolStripButtonMarque.Text = "Afficher les Marques";
            this.toolStripButtonMarque.Click += new System.EventHandler(this.marqueToolStripMenuItem_Click);
            // 
            // toolStripButtonMateriel
            // 
            this.toolStripButtonMateriel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMateriel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMateriel.Image")));
            this.toolStripButtonMateriel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMateriel.Name = "toolStripButtonMateriel";
            this.toolStripButtonMateriel.Size = new System.Drawing.Size(37, 39);
            this.toolStripButtonMateriel.Text = "Afficher le Matériel";
            // 
            // toolStripButtonTechnicien
            // 
            this.toolStripButtonTechnicien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTechnicien.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTechnicien.Image")));
            this.toolStripButtonTechnicien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTechnicien.Name = "toolStripButtonTechnicien";
            this.toolStripButtonTechnicien.Size = new System.Drawing.Size(37, 39);
            this.toolStripButtonTechnicien.Text = "Afficher les Techniciens";
            this.toolStripButtonTechnicien.Click += new System.EventHandler(this.listeDesTechniciensToolStripMenuItem_Click);
            // 
            // toolStripButtonInterventions
            // 
            this.toolStripButtonInterventions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInterventions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInterventions.Image")));
            this.toolStripButtonInterventions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInterventions.Name = "toolStripButtonInterventions";
            this.toolStripButtonInterventions.Size = new System.Drawing.Size(37, 39);
            this.toolStripButtonInterventions.Text = "Afficher les Interventions";
            this.toolStripButtonInterventions.Click += new System.EventHandler(this.listeDesInterventionsToolStripMenuItem1_Click);
            // 
            // toolStripButtonClearField
            // 
            this.toolStripButtonClearField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearField.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearField.Image")));
            this.toolStripButtonClearField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearField.Name = "toolStripButtonClearField";
            this.toolStripButtonClearField.Size = new System.Drawing.Size(37, 39);
            this.toolStripButtonClearField.Text = "Vider les champs";
            this.toolStripButtonClearField.Click += new System.EventHandler(this.toolStripButtonClearField_Click);
            // 
            // labelTechnicien
            // 
            this.labelTechnicien.AutoSize = true;
            this.labelTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.labelTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelTechnicien.Location = new System.Drawing.Point(760, 315);
            this.labelTechnicien.Name = "labelTechnicien";
            this.labelTechnicien.Size = new System.Drawing.Size(132, 22);
            this.labelTechnicien.TabIndex = 28;
            this.labelTechnicien.Text = "Technicien(s) :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 620);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem listeDesTechniciensToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClient;
        private System.Windows.Forms.ToolStripButton toolStripButtonMarque;
        private System.Windows.Forms.ToolStripButton toolStripButtonMateriel;
        private System.Windows.Forms.ToolStripButton toolStripButtonTechnicien;
        private System.Windows.Forms.ToolStripButton toolStripButtonInterventions;
        private System.Windows.Forms.ToolStripButton toolStripButtonLeave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearField;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Label labelTechnicien;
    }
}

