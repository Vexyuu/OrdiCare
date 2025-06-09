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
            this.listeDesInterventionsToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesTechniciensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInterventionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxInterventions = new System.Windows.Forms.GroupBox();
            this.comboBoxTechnicien = new System.Windows.Forms.ComboBox();
            this.labelTechnicien = new System.Windows.Forms.Label();
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
            this.toolStripButtonProduit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTechnicien = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInterventions = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearField = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxInterventions.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.marqueToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.listeDesInterventionsToolStripMenuItem,
            this.listeDesTechniciensToolStripMenuItem,
            this.listeDesInterventionsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.fermerToolStripMenuItem});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ToolStripMenuItem.Text = "Gestion";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.clientToolStripMenuItem.Text = "Client...";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.marqueToolStripMenuItem.Text = "Marque...";
            this.marqueToolStripMenuItem.Click += new System.EventHandler(this.marqueToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.produitToolStripMenuItem.Text = "Produit...";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // listeDesInterventionsToolStripMenuItem
            // 
            this.listeDesInterventionsToolStripMenuItem.Name = "listeDesInterventionsToolStripMenuItem";
            this.listeDesInterventionsToolStripMenuItem.Size = new System.Drawing.Size(229, 6);
            // 
            // listeDesTechniciensToolStripMenuItem
            // 
            this.listeDesTechniciensToolStripMenuItem.Name = "listeDesTechniciensToolStripMenuItem";
            this.listeDesTechniciensToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.listeDesTechniciensToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listeDesTechniciensToolStripMenuItem.Text = "Liste des techniciens";
            this.listeDesTechniciensToolStripMenuItem.Click += new System.EventHandler(this.listeDesTechniciensToolStripMenuItem_Click);
            // 
            // listeDesInterventionsToolStripMenuItem1
            // 
            this.listeDesInterventionsToolStripMenuItem1.Name = "listeDesInterventionsToolStripMenuItem1";
            this.listeDesInterventionsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.listeDesInterventionsToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.listeDesInterventionsToolStripMenuItem1.Text = "Liste des interventions";
            this.listeDesInterventionsToolStripMenuItem1.Click += new System.EventHandler(this.listeDesInterventionsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.fermerToolStripMenuItem.Text = "Fermer ..";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUtilisateurToolStripMenuItem});
            this.administrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // créerUtilisateurToolStripMenuItem
            // 
            this.créerUtilisateurToolStripMenuItem.Name = "créerUtilisateurToolStripMenuItem";
            this.créerUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.créerUtilisateurToolStripMenuItem.Text = "Créer Utilisateur";
            this.créerUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.créerUtilisateurToolStripMenuItem_Click);
            // 
            // GroupBoxInterventions
            // 
            this.GroupBoxInterventions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GroupBoxInterventions.Controls.Add(this.comboBoxTechnicien);
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
            this.GroupBoxInterventions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.GroupBoxInterventions.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxInterventions.Location = new System.Drawing.Point(84, 56);
            this.GroupBoxInterventions.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxInterventions.Name = "GroupBoxInterventions";
            this.GroupBoxInterventions.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxInterventions.Size = new System.Drawing.Size(1025, 527);
            this.GroupBoxInterventions.TabIndex = 4;
            this.GroupBoxInterventions.TabStop = false;
            this.GroupBoxInterventions.Text = "Interventions";
            // 
            // comboBoxTechnicien
            // 
            this.comboBoxTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxTechnicien.FormattingEnabled = true;
            this.comboBoxTechnicien.Location = new System.Drawing.Point(788, 372);
            this.comboBoxTechnicien.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTechnicien.Name = "comboBoxTechnicien";
            this.comboBoxTechnicien.Size = new System.Drawing.Size(162, 25);
            this.comboBoxTechnicien.TabIndex = 29;
            // 
            // labelTechnicien
            // 
            this.labelTechnicien.AutoSize = true;
            this.labelTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.labelTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelTechnicien.Location = new System.Drawing.Point(681, 376);
            this.labelTechnicien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTechnicien.Name = "labelTechnicien";
            this.labelTechnicien.Size = new System.Drawing.Size(103, 17);
            this.labelTechnicien.TabIndex = 28;
            this.labelTechnicien.Text = "Technicien(s) :";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(469, 375);
            this.comboBoxMarque.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(162, 25);
            this.comboBoxMarque.TabIndex = 27;
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMarque.ForeColor = System.Drawing.Color.Black;
            this.labelMarque.Location = new System.Drawing.Point(400, 376);
            this.labelMarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(69, 18);
            this.labelMarque.TabIndex = 26;
            this.labelMarque.Text = "Marque :";
            // 
            // dateTimePickerHeure
            // 
            this.dateTimePickerHeure.CustomFormat = "HH : mm : ss";
            this.dateTimePickerHeure.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHeure.Location = new System.Drawing.Point(657, 101);
            this.dateTimePickerHeure.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerHeure.Name = "dateTimePickerHeure";
            this.dateTimePickerHeure.Size = new System.Drawing.Size(103, 24);
            this.dateTimePickerHeure.TabIndex = 25;
            // 
            // labelHeureIntervention
            // 
            this.labelHeureIntervention.AutoSize = true;
            this.labelHeureIntervention.Font = new System.Drawing.Font("Arial", 12F);
            this.labelHeureIntervention.ForeColor = System.Drawing.Color.Black;
            this.labelHeureIntervention.Location = new System.Drawing.Point(507, 103);
            this.labelHeureIntervention.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeureIntervention.Name = "labelHeureIntervention";
            this.labelHeureIntervention.Size = new System.Drawing.Size(153, 18);
            this.labelHeureIntervention.TabIndex = 24;
            this.labelHeureIntervention.Text = "Heure d\'intervention :";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(108, 443);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(162, 25);
            this.comboBoxClient.TabIndex = 23;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd / MMMM / yyyy";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(149, 103);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(186, 24);
            this.dateTimePickerDate.TabIndex = 22;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPrix.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrix.Location = new System.Drawing.Point(377, 445);
            this.textBoxPrix.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(123, 24);
            this.textBoxPrix.TabIndex = 21;
            // 
            // labelMateriel
            // 
            this.labelMateriel.AutoSize = true;
            this.labelMateriel.Font = new System.Drawing.Font("Arial", 11F);
            this.labelMateriel.ForeColor = System.Drawing.Color.Black;
            this.labelMateriel.Location = new System.Drawing.Point(38, 375);
            this.labelMateriel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMateriel.Name = "labelMateriel";
            this.labelMateriel.Size = new System.Drawing.Size(66, 17);
            this.labelMateriel.TabIndex = 20;
            this.labelMateriel.Text = "Matériel :";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Arial", 11F);
            this.labelPrix.ForeColor = System.Drawing.Color.Black;
            this.labelPrix.Location = new System.Drawing.Point(334, 446);
            this.labelPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(41, 17);
            this.labelPrix.TabIndex = 19;
            this.labelPrix.Text = "Prix :";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Font = new System.Drawing.Font("Arial", 12F);
            this.labelCommentaire.ForeColor = System.Drawing.Color.Black;
            this.labelCommentaire.Location = new System.Drawing.Point(7, 146);
            this.labelCommentaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(111, 18);
            this.labelCommentaire.TabIndex = 18;
            this.labelCommentaire.Text = "Commentaire :";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelClient.ForeColor = System.Drawing.Color.Black;
            this.labelClient.Location = new System.Drawing.Point(38, 444);
            this.labelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(56, 18);
            this.labelClient.TabIndex = 17;
            this.labelClient.Text = "Client :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(7, 103);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(145, 18);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date d\'intervention :";
            // 
            // labelObjet
            // 
            this.labelObjet.AutoSize = true;
            this.labelObjet.Font = new System.Drawing.Font("Arial", 12F);
            this.labelObjet.ForeColor = System.Drawing.Color.Black;
            this.labelObjet.Location = new System.Drawing.Point(4, 52);
            this.labelObjet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelObjet.Name = "labelObjet";
            this.labelObjet.Size = new System.Drawing.Size(144, 18);
            this.labelObjet.TabIndex = 5;
            this.labelObjet.Text = "Objet du problème :";
            // 
            // buttonCreerIntervention
            // 
            this.buttonCreerIntervention.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreerIntervention.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCreerIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCreerIntervention.Location = new System.Drawing.Point(742, 443);
            this.buttonCreerIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreerIntervention.Name = "buttonCreerIntervention";
            this.buttonCreerIntervention.Size = new System.Drawing.Size(256, 57);
            this.buttonCreerIntervention.TabIndex = 15;
            this.buttonCreerIntervention.Text = "Créer une intervention";
            this.buttonCreerIntervention.UseVisualStyleBackColor = false;
            this.buttonCreerIntervention.Click += new System.EventHandler(this.buttonCreerIntervention_Click);
            // 
            // comboBoxMateriel
            // 
            this.comboBoxMateriel.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxMateriel.FormattingEnabled = true;
            this.comboBoxMateriel.Location = new System.Drawing.Point(108, 373);
            this.comboBoxMateriel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMateriel.Name = "comboBoxMateriel";
            this.comboBoxMateriel.Size = new System.Drawing.Size(246, 25);
            this.comboBoxMateriel.TabIndex = 14;
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxCommentaire.ForeColor = System.Drawing.Color.Black;
            this.textBoxCommentaire.Location = new System.Drawing.Point(7, 178);
            this.textBoxCommentaire.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(1011, 166);
            this.textBoxCommentaire.TabIndex = 9;
            // 
            // textBoxObjetIntervention
            // 
            this.textBoxObjetIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxObjetIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxObjetIntervention.Location = new System.Drawing.Point(148, 49);
            this.textBoxObjetIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObjetIntervention.Name = "textBoxObjetIntervention";
            this.textBoxObjetIntervention.Size = new System.Drawing.Size(709, 24);
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
            this.toolStripButtonProduit,
            this.toolStripButtonTechnicien,
            this.toolStripButtonInterventions,
            this.toolStripButtonClearField});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(50, 590);
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
            this.toolStripButtonClient.Size = new System.Drawing.Size(47, 49);
            this.toolStripButtonClient.Text = "Afficher les Clients";
            this.toolStripButtonClient.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // toolStripButtonMarque
            // 
            this.toolStripButtonMarque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMarque.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMarque.Image")));
            this.toolStripButtonMarque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMarque.Name = "toolStripButtonMarque";
            this.toolStripButtonMarque.Size = new System.Drawing.Size(47, 49);
            this.toolStripButtonMarque.Text = "Afficher les Marques";
            this.toolStripButtonMarque.Click += new System.EventHandler(this.marqueToolStripMenuItem_Click);
            // 
            // toolStripButtonProduit
            // 
            this.toolStripButtonProduit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProduit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProduit.Image")));
            this.toolStripButtonProduit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProduit.Name = "toolStripButtonProduit";
            this.toolStripButtonProduit.Size = new System.Drawing.Size(47, 49);
            this.toolStripButtonProduit.Text = "Afficher le Matériel";
            this.toolStripButtonProduit.Click += new System.EventHandler(this.toolStripButtonProduit_Click);
            // 
            // toolStripButtonTechnicien
            // 
            this.toolStripButtonTechnicien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTechnicien.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTechnicien.Image")));
            this.toolStripButtonTechnicien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTechnicien.Name = "toolStripButtonTechnicien";
            this.toolStripButtonTechnicien.Size = new System.Drawing.Size(47, 49);
            this.toolStripButtonTechnicien.Text = "Afficher les Techniciens";
            this.toolStripButtonTechnicien.Click += new System.EventHandler(this.listeDesTechniciensToolStripMenuItem_Click);
            // 
            // toolStripButtonInterventions
            // 
            this.toolStripButtonInterventions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInterventions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInterventions.Image")));
            this.toolStripButtonInterventions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInterventions.Name = "toolStripButtonInterventions";
            this.toolStripButtonInterventions.Size = new System.Drawing.Size(47, 49);
            this.toolStripButtonInterventions.Text = "Afficher les Interventions";
            this.toolStripButtonInterventions.Click += new System.EventHandler(this.listeDesInterventionsToolStripMenuItem1_Click);
            // 
            // toolStripButtonClearField
            // 
            this.toolStripButtonClearField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearField.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearField.Image")));
            this.toolStripButtonClearField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearField.Name = "toolStripButtonClearField";
            this.toolStripButtonClearField.Size = new System.Drawing.Size(47, 49);
            this.toolStripButtonClearField.Text = "Vider les champs";
            this.toolStripButtonClearField.Click += new System.EventHandler(this.toolStripButtonClearField_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 614);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GroupBoxInterventions);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " OrdiCare";
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
        private System.Windows.Forms.ToolStripButton toolStripButtonProduit;
        private System.Windows.Forms.ToolStripButton toolStripButtonTechnicien;
        private System.Windows.Forms.ToolStripButton toolStripButtonInterventions;
        private System.Windows.Forms.ToolStripButton toolStripButtonLeave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearField;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Label labelTechnicien;
        private System.Windows.Forms.ComboBox comboBoxTechnicien;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUtilisateurToolStripMenuItem;
    }
}

