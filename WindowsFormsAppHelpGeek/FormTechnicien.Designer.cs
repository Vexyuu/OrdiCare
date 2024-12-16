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
            this.buttonCleanTechnicien.Location = new System.Drawing.Point(26, 286);
            this.buttonCleanTechnicien.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCleanTechnicien.Name = "buttonCleanTechnicien";
            this.buttonCleanTechnicien.Size = new System.Drawing.Size(122, 25);
            this.buttonCleanTechnicien.TabIndex = 27;
            this.buttonCleanTechnicien.Text = "Vider les cellules";
            this.buttonCleanTechnicien.UseVisualStyleBackColor = true;
            this.buttonCleanTechnicien.Click += new System.EventHandler(this.buttonCleanTechnicien_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSupprimer.ForeColor = System.Drawing.Color.Red;
            this.buttonSupprimer.Location = new System.Drawing.Point(430, 243);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 25);
            this.buttonSupprimer.TabIndex = 26;
            this.buttonSupprimer.Text = "Licencier";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(322, 243);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 25);
            this.buttonModifier.TabIndex = 25;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAjouter.Location = new System.Drawing.Point(214, 243);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(91, 25);
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
            this.groupBoxMarqueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarqueText.Location = new System.Drawing.Point(214, 28);
            this.groupBoxMarqueText.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMarqueText.Name = "groupBoxMarqueText";
            this.groupBoxMarqueText.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMarqueText.Size = new System.Drawing.Size(311, 198);
            this.groupBoxMarqueText.TabIndex = 23;
            this.groupBoxMarqueText.TabStop = false;
            this.groupBoxMarqueText.Text = "Plus d\'informations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Statut :";
            // 
            // textBoxStatutTechnicien
            // 
            this.textBoxStatutTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxStatutTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxStatutTechnicien.Location = new System.Drawing.Point(71, 151);
            this.textBoxStatutTechnicien.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStatutTechnicien.Name = "textBoxStatutTechnicien";
            this.textBoxStatutTechnicien.Size = new System.Drawing.Size(228, 24);
            this.textBoxStatutTechnicien.TabIndex = 28;
            // 
            // labelTelTechnicien
            // 
            this.labelTelTechnicien.AutoSize = true;
            this.labelTelTechnicien.Font = new System.Drawing.Font("Arial", 12F);
            this.labelTelTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelTelTechnicien.Location = new System.Drawing.Point(4, 107);
            this.labelTelTechnicien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelTechnicien.Name = "labelTelTechnicien";
            this.labelTelTechnicien.Size = new System.Drawing.Size(35, 18);
            this.labelTelTechnicien.TabIndex = 27;
            this.labelTelTechnicien.Text = "Tel :";
            // 
            // textBoxTelTechnicien
            // 
            this.textBoxTelTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxTelTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxTelTechnicien.Location = new System.Drawing.Point(71, 106);
            this.textBoxTelTechnicien.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelTechnicien.Name = "textBoxTelTechnicien";
            this.textBoxTelTechnicien.Size = new System.Drawing.Size(228, 24);
            this.textBoxTelTechnicien.TabIndex = 26;
            // 
            // textBoxMailTechnicien
            // 
            this.textBoxMailTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMailTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxMailTechnicien.Location = new System.Drawing.Point(71, 66);
            this.textBoxMailTechnicien.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMailTechnicien.Name = "textBoxMailTechnicien";
            this.textBoxMailTechnicien.Size = new System.Drawing.Size(228, 24);
            this.textBoxMailTechnicien.TabIndex = 25;
            // 
            // labelMailTechnicien
            // 
            this.labelMailTechnicien.AutoSize = true;
            this.labelMailTechnicien.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMailTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelMailTechnicien.Location = new System.Drawing.Point(4, 67);
            this.labelMailTechnicien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMailTechnicien.Name = "labelMailTechnicien";
            this.labelMailTechnicien.Size = new System.Drawing.Size(45, 18);
            this.labelMailTechnicien.TabIndex = 24;
            this.labelMailTechnicien.Text = "Mail :";
            // 
            // labelNomTechnicien
            // 
            this.labelNomTechnicien.AutoSize = true;
            this.labelNomTechnicien.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNomTechnicien.ForeColor = System.Drawing.Color.Black;
            this.labelNomTechnicien.Location = new System.Drawing.Point(4, 29);
            this.labelNomTechnicien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomTechnicien.Name = "labelNomTechnicien";
            this.labelNomTechnicien.Size = new System.Drawing.Size(49, 18);
            this.labelNomTechnicien.TabIndex = 23;
            this.labelNomTechnicien.Text = "Nom :";
            // 
            // textBoxNomTechnicien
            // 
            this.textBoxNomTechnicien.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxNomTechnicien.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomTechnicien.Location = new System.Drawing.Point(71, 28);
            this.textBoxNomTechnicien.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomTechnicien.Name = "textBoxNomTechnicien";
            this.textBoxNomTechnicien.Size = new System.Drawing.Size(228, 24);
            this.textBoxNomTechnicien.TabIndex = 22;
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.listBoxTechniciens);
            this.groupBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxClient.Location = new System.Drawing.Point(8, 15);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxClient.Size = new System.Drawing.Size(202, 260);
            this.groupBoxClient.TabIndex = 22;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Liste des Techniciens";
            // 
            // listBoxTechniciens
            // 
            this.listBoxTechniciens.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxTechniciens.FormattingEnabled = true;
            this.listBoxTechniciens.ItemHeight = 17;
            this.listBoxTechniciens.Location = new System.Drawing.Point(4, 28);
            this.listBoxTechniciens.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTechniciens.Name = "listBoxTechniciens";
            this.listBoxTechniciens.Size = new System.Drawing.Size(194, 225);
            this.listBoxTechniciens.TabIndex = 8;
            this.listBoxTechniciens.SelectedIndexChanged += new System.EventHandler(this.listBoxTechniciens_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(439, 282);
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
            this.buttonOK.Location = new System.Drawing.Point(326, 282);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 32);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormTechnicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 340);
            this.Controls.Add(this.buttonCleanTechnicien);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBoxMarqueText);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTechnicien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrdiCare";
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