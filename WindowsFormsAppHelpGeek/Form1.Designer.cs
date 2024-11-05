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
            this.GroupBoxInterventions = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.labelMateriel = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelObjet = new System.Windows.Forms.Label();
            this.buttonCreerIntervention = new System.Windows.Forms.Button();
            this.comboBoxMateriel = new System.Windows.Forms.ComboBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.maskedTextBoxHeure = new System.Windows.Forms.MaskedTextBox();
            this.textBoxObjetIntervention = new System.Windows.Forms.TextBox();
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
            this.fzadToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.fzadToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.fzadToolStripMenuItem.Name = "fzadToolStripMenuItem";
            this.fzadToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.fzadToolStripMenuItem.Text = "Gestion";
            // 
            // GroupBoxInterventions
            // 
            this.GroupBoxInterventions.Controls.Add(this.dateTimePickerDate);
            this.GroupBoxInterventions.Controls.Add(this.textBoxPrix);
            this.GroupBoxInterventions.Controls.Add(this.labelMateriel);
            this.GroupBoxInterventions.Controls.Add(this.labelPrix);
            this.GroupBoxInterventions.Controls.Add(this.labelCommentaire);
            this.GroupBoxInterventions.Controls.Add(this.labelHeure);
            this.GroupBoxInterventions.Controls.Add(this.labelDate);
            this.GroupBoxInterventions.Controls.Add(this.labelObjet);
            this.GroupBoxInterventions.Controls.Add(this.buttonCreerIntervention);
            this.GroupBoxInterventions.Controls.Add(this.comboBoxMateriel);
            this.GroupBoxInterventions.Controls.Add(this.maskedTextBox3);
            this.GroupBoxInterventions.Controls.Add(this.textBoxCommentaire);
            this.GroupBoxInterventions.Controls.Add(this.maskedTextBoxHeure);
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
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(199, 92);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(329, 29);
            this.dateTimePickerDate.TabIndex = 22;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPrix.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrix.Location = new System.Drawing.Point(67, 285);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(134, 29);
            this.textBoxPrix.TabIndex = 21;
            // 
            // labelMateriel
            // 
            this.labelMateriel.AutoSize = true;
            this.labelMateriel.Font = new System.Drawing.Font("Arial", 11F);
            this.labelMateriel.ForeColor = System.Drawing.Color.Black;
            this.labelMateriel.Location = new System.Drawing.Point(239, 285);
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
            this.labelPrix.Location = new System.Drawing.Point(9, 285);
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
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Font = new System.Drawing.Font("Arial", 12F);
            this.labelHeure.ForeColor = System.Drawing.Color.Black;
            this.labelHeure.Location = new System.Drawing.Point(566, 92);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(194, 23);
            this.labelHeure.TabIndex = 17;
            this.labelHeure.Text = "Heure d\'intervention :";
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
            this.comboBoxMateriel.Location = new System.Drawing.Point(331, 282);
            this.comboBoxMateriel.Name = "comboBoxMateriel";
            this.comboBoxMateriel.Size = new System.Drawing.Size(326, 29);
            this.comboBoxMateriel.TabIndex = 14;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Arial", 11F);
            this.maskedTextBox3.Location = new System.Drawing.Point(58, 331);
            this.maskedTextBox3.Mask = "0000.00€";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(97, 29);
            this.maskedTextBox3.TabIndex = 11;
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
            // maskedTextBoxHeure
            // 
            this.maskedTextBoxHeure.Font = new System.Drawing.Font("Arial", 11F);
            this.maskedTextBoxHeure.Location = new System.Drawing.Point(766, 91);
            this.maskedTextBoxHeure.Mask = "00:00";
            this.maskedTextBoxHeure.Name = "maskedTextBoxHeure";
            this.maskedTextBoxHeure.Size = new System.Drawing.Size(65, 29);
            this.maskedTextBoxHeure.TabIndex = 7;
            this.maskedTextBoxHeure.ValidatingType = typeof(System.DateTime);
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
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeure;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.ComboBox comboBoxMateriel;
        private System.Windows.Forms.Button buttonCreerIntervention;
        private System.Windows.Forms.Label labelObjet;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMateriel;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}

