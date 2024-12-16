namespace WindowsFormsAppOrdiCare
{
    partial class FormIntervention
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
            this.buttonCleanClient = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.groupBoxMarqueText = new System.Windows.Forms.GroupBox();
            this.textBoxMarqueIntervention = new System.Windows.Forms.TextBox();
            this.textBoxPrixIntervention = new System.Windows.Forms.TextBox();
            this.textBoxClientIntervention = new System.Windows.Forms.TextBox();
            this.textBoxMaterielIntervention = new System.Windows.Forms.TextBox();
            this.textBoxCommentaireIntervention = new System.Windows.Forms.TextBox();
            this.textBoxHeureIntervention = new System.Windows.Forms.TextBox();
            this.textBoxDateIntervention = new System.Windows.Forms.TextBox();
            this.textBoxObjectIntervention = new System.Windows.Forms.TextBox();
            this.groupBoxIntervention = new System.Windows.Forms.GroupBox();
            this.listBoxIntervention = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxMarqueText.SuspendLayout();
            this.groupBoxIntervention.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCleanClient
            // 
            this.buttonCleanClient.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCleanClient.Location = new System.Drawing.Point(27, 281);
            this.buttonCleanClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCleanClient.Name = "buttonCleanClient";
            this.buttonCleanClient.Size = new System.Drawing.Size(122, 25);
            this.buttonCleanClient.TabIndex = 27;
            this.buttonCleanClient.Text = "Vider les cellules";
            this.buttonCleanClient.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSupprimer.Location = new System.Drawing.Point(602, 332);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 25);
            this.buttonSupprimer.TabIndex = 26;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(480, 332);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 25);
            this.buttonModifier.TabIndex = 25;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // groupBoxMarqueText
            // 
            this.groupBoxMarqueText.Controls.Add(this.textBoxMarqueIntervention);
            this.groupBoxMarqueText.Controls.Add(this.textBoxPrixIntervention);
            this.groupBoxMarqueText.Controls.Add(this.textBoxClientIntervention);
            this.groupBoxMarqueText.Controls.Add(this.textBoxMaterielIntervention);
            this.groupBoxMarqueText.Controls.Add(this.textBoxCommentaireIntervention);
            this.groupBoxMarqueText.Controls.Add(this.textBoxHeureIntervention);
            this.groupBoxMarqueText.Controls.Add(this.textBoxDateIntervention);
            this.groupBoxMarqueText.Controls.Add(this.textBoxObjectIntervention);
            this.groupBoxMarqueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarqueText.Location = new System.Drawing.Point(248, 10);
            this.groupBoxMarqueText.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMarqueText.Name = "groupBoxMarqueText";
            this.groupBoxMarqueText.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMarqueText.Size = new System.Drawing.Size(451, 277);
            this.groupBoxMarqueText.TabIndex = 23;
            this.groupBoxMarqueText.TabStop = false;
            this.groupBoxMarqueText.Text = "Plus d\'informations";
            // 
            // textBoxMarqueIntervention
            // 
            this.textBoxMarqueIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMarqueIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxMarqueIntervention.Location = new System.Drawing.Point(4, 199);
            this.textBoxMarqueIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarqueIntervention.Name = "textBoxMarqueIntervention";
            this.textBoxMarqueIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxMarqueIntervention.TabIndex = 33;
            // 
            // textBoxPrixIntervention
            // 
            this.textBoxPrixIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPrixIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrixIntervention.Location = new System.Drawing.Point(4, 228);
            this.textBoxPrixIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrixIntervention.Name = "textBoxPrixIntervention";
            this.textBoxPrixIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxPrixIntervention.TabIndex = 32;
            // 
            // textBoxClientIntervention
            // 
            this.textBoxClientIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxClientIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxClientIntervention.Location = new System.Drawing.Point(4, 171);
            this.textBoxClientIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClientIntervention.Name = "textBoxClientIntervention";
            this.textBoxClientIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxClientIntervention.TabIndex = 31;
            // 
            // textBoxMaterielIntervention
            // 
            this.textBoxMaterielIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMaterielIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaterielIntervention.Location = new System.Drawing.Point(4, 142);
            this.textBoxMaterielIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaterielIntervention.Name = "textBoxMaterielIntervention";
            this.textBoxMaterielIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxMaterielIntervention.TabIndex = 30;
            // 
            // textBoxCommentaireIntervention
            // 
            this.textBoxCommentaireIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxCommentaireIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxCommentaireIntervention.Location = new System.Drawing.Point(4, 114);
            this.textBoxCommentaireIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCommentaireIntervention.Name = "textBoxCommentaireIntervention";
            this.textBoxCommentaireIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxCommentaireIntervention.TabIndex = 29;
            // 
            // textBoxHeureIntervention
            // 
            this.textBoxHeureIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxHeureIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxHeureIntervention.Location = new System.Drawing.Point(4, 85);
            this.textBoxHeureIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHeureIntervention.Name = "textBoxHeureIntervention";
            this.textBoxHeureIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxHeureIntervention.TabIndex = 28;
            // 
            // textBoxDateIntervention
            // 
            this.textBoxDateIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxDateIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxDateIntervention.Location = new System.Drawing.Point(4, 57);
            this.textBoxDateIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDateIntervention.Name = "textBoxDateIntervention";
            this.textBoxDateIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxDateIntervention.TabIndex = 27;
            // 
            // textBoxObjectIntervention
            // 
            this.textBoxObjectIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxObjectIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxObjectIntervention.Location = new System.Drawing.Point(4, 28);
            this.textBoxObjectIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObjectIntervention.Name = "textBoxObjectIntervention";
            this.textBoxObjectIntervention.Size = new System.Drawing.Size(443, 24);
            this.textBoxObjectIntervention.TabIndex = 26;
            // 
            // groupBoxIntervention
            // 
            this.groupBoxIntervention.Controls.Add(this.listBoxIntervention);
            this.groupBoxIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxIntervention.Location = new System.Drawing.Point(9, 10);
            this.groupBoxIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxIntervention.Name = "groupBoxIntervention";
            this.groupBoxIntervention.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxIntervention.Size = new System.Drawing.Size(221, 260);
            this.groupBoxIntervention.TabIndex = 22;
            this.groupBoxIntervention.TabStop = false;
            this.groupBoxIntervention.Text = "Liste des interventions";
            // 
            // listBoxIntervention
            // 
            this.listBoxIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxIntervention.FormattingEnabled = true;
            this.listBoxIntervention.ItemHeight = 17;
            this.listBoxIntervention.Location = new System.Drawing.Point(4, 28);
            this.listBoxIntervention.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIntervention.Name = "listBoxIntervention";
            this.listBoxIntervention.Size = new System.Drawing.Size(213, 225);
            this.listBoxIntervention.TabIndex = 8;
            this.listBoxIntervention.SelectedIndexChanged += new System.EventHandler(this.listBoxIntervention_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(610, 370);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 32);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonOK.Location = new System.Drawing.Point(497, 370);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 32);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 414);
            this.Controls.Add(this.buttonCleanClient);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.groupBoxMarqueText);
            this.Controls.Add(this.groupBoxIntervention);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIntervention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrdiCare";
            this.groupBoxMarqueText.ResumeLayout(false);
            this.groupBoxMarqueText.PerformLayout();
            this.groupBoxIntervention.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCleanClient;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.GroupBox groupBoxMarqueText;
        private System.Windows.Forms.GroupBox groupBoxIntervention;
        private System.Windows.Forms.ListBox listBoxIntervention;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxCommentaireIntervention;
        private System.Windows.Forms.TextBox textBoxHeureIntervention;
        private System.Windows.Forms.TextBox textBoxDateIntervention;
        private System.Windows.Forms.TextBox textBoxObjectIntervention;
        private System.Windows.Forms.TextBox textBoxClientIntervention;
        private System.Windows.Forms.TextBox textBoxMaterielIntervention;
        private System.Windows.Forms.TextBox textBoxPrixIntervention;
        private System.Windows.Forms.TextBox textBoxMarqueIntervention;
    }
}