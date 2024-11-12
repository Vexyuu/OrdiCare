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
            this.buttonCleanClient.Location = new System.Drawing.Point(36, 346);
            this.buttonCleanClient.Name = "buttonCleanClient";
            this.buttonCleanClient.Size = new System.Drawing.Size(162, 31);
            this.buttonCleanClient.TabIndex = 27;
            this.buttonCleanClient.Text = "Vider les cellules";
            this.buttonCleanClient.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSupprimer.Location = new System.Drawing.Point(802, 408);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(121, 31);
            this.buttonSupprimer.TabIndex = 26;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(640, 408);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(121, 31);
            this.buttonModifier.TabIndex = 25;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
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
            this.groupBoxMarqueText.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarqueText.Location = new System.Drawing.Point(331, 12);
            this.groupBoxMarqueText.Name = "groupBoxMarqueText";
            this.groupBoxMarqueText.Size = new System.Drawing.Size(601, 341);
            this.groupBoxMarqueText.TabIndex = 23;
            this.groupBoxMarqueText.TabStop = false;
            this.groupBoxMarqueText.Text = "Plus d\'informations";
            // 
            // textBoxMarqueIntervention
            // 
            this.textBoxMarqueIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMarqueIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxMarqueIntervention.Location = new System.Drawing.Point(6, 245);
            this.textBoxMarqueIntervention.Name = "textBoxMarqueIntervention";
            this.textBoxMarqueIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxMarqueIntervention.TabIndex = 33;
            // 
            // textBoxPrixIntervention
            // 
            this.textBoxPrixIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxPrixIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrixIntervention.Location = new System.Drawing.Point(6, 280);
            this.textBoxPrixIntervention.Name = "textBoxPrixIntervention";
            this.textBoxPrixIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxPrixIntervention.TabIndex = 32;
            // 
            // textBoxClientIntervention
            // 
            this.textBoxClientIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxClientIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxClientIntervention.Location = new System.Drawing.Point(6, 210);
            this.textBoxClientIntervention.Name = "textBoxClientIntervention";
            this.textBoxClientIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxClientIntervention.TabIndex = 31;
            // 
            // textBoxMaterielIntervention
            // 
            this.textBoxMaterielIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMaterielIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaterielIntervention.Location = new System.Drawing.Point(6, 175);
            this.textBoxMaterielIntervention.Name = "textBoxMaterielIntervention";
            this.textBoxMaterielIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxMaterielIntervention.TabIndex = 30;
            // 
            // textBoxCommentaireIntervention
            // 
            this.textBoxCommentaireIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxCommentaireIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxCommentaireIntervention.Location = new System.Drawing.Point(6, 140);
            this.textBoxCommentaireIntervention.Name = "textBoxCommentaireIntervention";
            this.textBoxCommentaireIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxCommentaireIntervention.TabIndex = 29;
            // 
            // textBoxHeureIntervention
            // 
            this.textBoxHeureIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxHeureIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxHeureIntervention.Location = new System.Drawing.Point(6, 105);
            this.textBoxHeureIntervention.Name = "textBoxHeureIntervention";
            this.textBoxHeureIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxHeureIntervention.TabIndex = 28;
            // 
            // textBoxDateIntervention
            // 
            this.textBoxDateIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxDateIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxDateIntervention.Location = new System.Drawing.Point(6, 70);
            this.textBoxDateIntervention.Name = "textBoxDateIntervention";
            this.textBoxDateIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxDateIntervention.TabIndex = 27;
            // 
            // textBoxObjectIntervention
            // 
            this.textBoxObjectIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxObjectIntervention.ForeColor = System.Drawing.Color.Black;
            this.textBoxObjectIntervention.Location = new System.Drawing.Point(6, 35);
            this.textBoxObjectIntervention.Name = "textBoxObjectIntervention";
            this.textBoxObjectIntervention.Size = new System.Drawing.Size(589, 29);
            this.textBoxObjectIntervention.TabIndex = 26;
            // 
            // groupBoxIntervention
            // 
            this.groupBoxIntervention.Controls.Add(this.listBoxIntervention);
            this.groupBoxIntervention.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxIntervention.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIntervention.Name = "groupBoxIntervention";
            this.groupBoxIntervention.Size = new System.Drawing.Size(295, 320);
            this.groupBoxIntervention.TabIndex = 22;
            this.groupBoxIntervention.TabStop = false;
            this.groupBoxIntervention.Text = "Liste des interventions";
            // 
            // listBoxIntervention
            // 
            this.listBoxIntervention.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxIntervention.FormattingEnabled = true;
            this.listBoxIntervention.ItemHeight = 21;
            this.listBoxIntervention.Location = new System.Drawing.Point(6, 35);
            this.listBoxIntervention.Name = "listBoxIntervention";
            this.listBoxIntervention.Size = new System.Drawing.Size(283, 277);
            this.listBoxIntervention.TabIndex = 8;
            this.listBoxIntervention.SelectedIndexChanged += new System.EventHandler(this.listBoxIntervention_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(813, 456);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 39);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonOK.Location = new System.Drawing.Point(663, 456);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(129, 39);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 509);
            this.Controls.Add(this.buttonCleanClient);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.groupBoxMarqueText);
            this.Controls.Add(this.groupBoxIntervention);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIntervention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormIntervention";
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