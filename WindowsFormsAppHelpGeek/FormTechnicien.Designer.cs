namespace WindowsFormsAppOrdiCare
{
    partial class FormTechnicien
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
            this.buttonCleanTechnicien = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBoxMarqueText = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStatutTechnicien = new System.Windows.Forms.TextBox();
            this.labelTelTechnicien = new System.Windows.Forms.Label();
            this.textBoxTelTechnicien = new System.Windows.Forms.TextBox();
            this.textBoxMailTechnicien = new System.Windows.Forms.TextBox();
            this.labelMailTechnicien = new System.Windows.Forms.Label();
            this.labelNomTechnicien = new System.Windows.Forms.Label();
            this.textBoxNomTechnicien = new System.Windows.Forms.TextBox();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.listBoxTechniciens = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxMarqueText.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCleanTechnicien
            // 
            this.buttonCleanTechnicien.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCleanTechnicien.Location = new System.Drawing.Point(34, 352);
            this.buttonCleanTechnicien.Name = "buttonCleanTechnicien";
            this.buttonCleanTechnicien.Size = new System.Drawing.Size(162, 31);
            this.buttonCleanTechnicien.TabIndex = 27;
            this.buttonCleanTechnicien.Text = "Vider les cellules";
            this.buttonCleanTechnicien.UseVisualStyleBackColor = true;
            this.buttonCleanTechnicien.Click += new System.EventHandler(this.buttonCleanTechnicien_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonSupprimer.Location = new System.Drawing.Point(574, 299);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(121, 31);
            this.buttonSupprimer.TabIndex = 26;
            this.buttonSupprimer.Text = "Licencier";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(429, 299);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(121, 31);
            this.buttonModifier.TabIndex = 25;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAjouter.Location = new System.Drawing.Point(286, 299);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(121, 31);
            this.buttonAjouter.TabIndex = 24;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // groupBoxMarqueText
            // 
            this.groupBoxMarqueText.Controls.Add(this.label1);
            this.groupBoxMarqueText.Controls.Add(this.textBoxStatutTechnicien);
            this.groupBoxMarqueText.Controls.Add(this.labelTelTechnicien);
            this.groupBoxMarqueText.Controls.Add(this.textBoxTelTechnicien);
            this.groupBoxMarqueText.Controls.Add(this.textBoxMailTechnicien);
            this.groupBoxMarqueText.Controls.Add(this.labelMailTechnicien);
            this.groupBoxMarqueText.Controls.Add(this.labelNomTechnicien);
            this.groupBoxMarqueText.Controls.Add(this.textBoxNomTechnicien);
            this.groupBoxMarqueText.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarqueText.Location = new System.Drawing.Point(286, 34);
            this.groupBoxMarqueText.Name = "groupBoxMarqueText";
            this.groupBoxMarqueText.Size = new System.Drawing.Size(415, 244);
            this.groupBoxMarqueText.TabIndex = 23;
            this.groupBoxMarqueText.TabStop = false;
            this.groupBoxMarqueText.Text = "Plus d\'informations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Statut :";
            // 
            // textBoxStatutTechnicien
            // 
            this.textBoxStatutTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxStatutTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxStatutTechnicien.Location = new System.Drawing.Point(95, 186);
            this.textBoxStatutTechnicien.Name = "textBoxStatutTechnicien";
            this.textBoxStatutTechnicien.Size = new System.Drawing.Size(303, 29);
            this.textBoxStatutTechnicien.TabIndex = 28;
            // 
            // labelTelTechnicien
            // 
            this.labelTelTechnicien.AutoSize = true;
            this.labelTelTechnicien.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTelTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelTelTechnicien.Location = new System.Drawing.Point(6, 132);
            this.labelTelTechnicien.Name = "labelTelTechnicien";
            this.labelTelTechnicien.Size = new System.Drawing.Size(47, 23);
            this.labelTelTechnicien.TabIndex = 27;
            this.labelTelTechnicien.Text = "Tel :";
            // 
            // textBoxTelTechnicien
            // 
            this.textBoxTelTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxTelTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxTelTechnicien.Location = new System.Drawing.Point(95, 131);
            this.textBoxTelTechnicien.Name = "textBoxTelTechnicien";
            this.textBoxTelTechnicien.Size = new System.Drawing.Size(303, 29);
            this.textBoxTelTechnicien.TabIndex = 26;
            // 
            // textBoxMailTechnicien
            // 
            this.textBoxMailTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMailTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxMailTechnicien.Location = new System.Drawing.Point(95, 81);
            this.textBoxMailTechnicien.Name = "textBoxMailTechnicien";
            this.textBoxMailTechnicien.Size = new System.Drawing.Size(303, 29);
            this.textBoxMailTechnicien.TabIndex = 25;
            // 
            // labelMailTechnicien
            // 
            this.labelMailTechnicien.AutoSize = true;
            this.labelMailTechnicien.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMailTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelMailTechnicien.Location = new System.Drawing.Point(6, 82);
            this.labelMailTechnicien.Name = "labelMailTechnicien";
            this.labelMailTechnicien.Size = new System.Drawing.Size(58, 23);
            this.labelMailTechnicien.TabIndex = 24;
            this.labelMailTechnicien.Text = "Mail :";
            // 
            // labelNomTechnicien
            // 
            this.labelNomTechnicien.AutoSize = true;
            this.labelNomTechnicien.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNomTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelNomTechnicien.Location = new System.Drawing.Point(6, 36);
            this.labelNomTechnicien.Name = "labelNomTechnicien";
            this.labelNomTechnicien.Size = new System.Drawing.Size(62, 23);
            this.labelNomTechnicien.TabIndex = 23;
            this.labelNomTechnicien.Text = "Nom :";
            // 
            // textBoxNomTechnicien
            // 
            this.textBoxNomTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxNomTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomTechnicien.Location = new System.Drawing.Point(95, 35);
            this.textBoxNomTechnicien.Name = "textBoxNomTechnicien";
            this.textBoxNomTechnicien.Size = new System.Drawing.Size(303, 29);
            this.textBoxNomTechnicien.TabIndex = 22;
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.listBoxTechniciens);
            this.groupBoxClient.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxClient.Location = new System.Drawing.Point(10, 18);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(270, 320);
            this.groupBoxClient.TabIndex = 22;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Liste des Techniciens";
            // 
            // listBoxTechniciens
            // 
            this.listBoxTechniciens.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxTechniciens.FormattingEnabled = true;
            this.listBoxTechniciens.ItemHeight = 21;
            this.listBoxTechniciens.Location = new System.Drawing.Point(6, 35);
            this.listBoxTechniciens.Name = "listBoxTechniciens";
            this.listBoxTechniciens.Size = new System.Drawing.Size(258, 277);
            this.listBoxTechniciens.TabIndex = 8;
            this.listBoxTechniciens.SelectedIndexChanged += new System.EventHandler(this.listBoxTechniciens_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(585, 347);
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
            this.buttonOK.Location = new System.Drawing.Point(435, 347);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(129, 39);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormTechnicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 419);
            this.Controls.Add(this.buttonCleanTechnicien);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBoxMarqueText);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTechnicien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "66";
            this.groupBoxMarqueText.ResumeLayout(false);
            this.groupBoxMarqueText.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCleanTechnicien;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.GroupBox groupBoxMarqueText;
        private System.Windows.Forms.Label labelTelTechnicien;
        private System.Windows.Forms.TextBox textBoxTelTechnicien;
        private System.Windows.Forms.TextBox textBoxMailTechnicien;
        private System.Windows.Forms.Label labelMailTechnicien;
        private System.Windows.Forms.Label labelNomTechnicien;
        private System.Windows.Forms.TextBox textBoxNomTechnicien;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.ListBox listBoxTechniciens;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStatutTechnicien;
    }
}