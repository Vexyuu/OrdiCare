namespace WindowsFormsAppOrdiCare
{
    partial class FormProduit
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
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBoxMarqueText = new System.Windows.Forms.GroupBox();
            this.textBoxClientProduit = new System.Windows.Forms.TextBox();
            this.textBoxMarqueProduit = new System.Windows.Forms.TextBox();
            this.textBoxMBTFProduit = new System.Windows.Forms.TextBox();
            this.labelClientProduit = new System.Windows.Forms.Label();
            this.labelMarqueProduit = new System.Windows.Forms.Label();
            this.labelMBTFProduit = new System.Windows.Forms.Label();
            this.textBoxCodeProduit = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelCodeProduit = new System.Windows.Forms.Label();
            this.labelDateProduit = new System.Windows.Forms.Label();
            this.textBoxDescriptionProduit = new System.Windows.Forms.TextBox();
            this.labelDescriptionProduit = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.textBoxNomProduit = new System.Windows.Forms.TextBox();
            this.groupBoxProduit = new System.Windows.Forms.GroupBox();
            this.listBoxProduit = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxMarqueText.SuspendLayout();
            this.groupBoxProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCleanClient
            // 
            this.buttonCleanClient.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonCleanClient.Location = new System.Drawing.Point(215, 305);
            this.buttonCleanClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCleanClient.Name = "buttonCleanClient";
            this.buttonCleanClient.Size = new System.Drawing.Size(122, 25);
            this.buttonCleanClient.TabIndex = 27;
            this.buttonCleanClient.Text = "Vider les cellules";
            this.buttonCleanClient.UseVisualStyleBackColor = true;
            this.buttonCleanClient.Click += new System.EventHandler(this.buttonCleanClient_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSupprimer.Location = new System.Drawing.Point(559, 203);
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
            this.buttonModifier.Location = new System.Drawing.Point(559, 136);
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
            this.buttonAjouter.Location = new System.Drawing.Point(559, 73);
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
            this.groupBoxMarqueText.Controls.Add(this.textBoxClientProduit);
            this.groupBoxMarqueText.Controls.Add(this.textBoxMarqueProduit);
            this.groupBoxMarqueText.Controls.Add(this.textBoxMBTFProduit);
            this.groupBoxMarqueText.Controls.Add(this.labelClientProduit);
            this.groupBoxMarqueText.Controls.Add(this.labelMarqueProduit);
            this.groupBoxMarqueText.Controls.Add(this.labelMBTFProduit);
            this.groupBoxMarqueText.Controls.Add(this.textBoxCodeProduit);
            this.groupBoxMarqueText.Controls.Add(this.dateTimePickerDate);
            this.groupBoxMarqueText.Controls.Add(this.labelCodeProduit);
            this.groupBoxMarqueText.Controls.Add(this.labelDateProduit);
            this.groupBoxMarqueText.Controls.Add(this.textBoxDescriptionProduit);
            this.groupBoxMarqueText.Controls.Add(this.labelDescriptionProduit);
            this.groupBoxMarqueText.Controls.Add(this.labelNomClient);
            this.groupBoxMarqueText.Controls.Add(this.textBoxNomProduit);
            this.groupBoxMarqueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarqueText.Location = new System.Drawing.Point(215, 20);
            this.groupBoxMarqueText.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMarqueText.Name = "groupBoxMarqueText";
            this.groupBoxMarqueText.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMarqueText.Size = new System.Drawing.Size(339, 280);
            this.groupBoxMarqueText.TabIndex = 23;
            this.groupBoxMarqueText.TabStop = false;
            this.groupBoxMarqueText.Text = "Plus d\'informations";
            // 
            // textBoxClientProduit
            // 
            this.textBoxClientProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxClientProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxClientProduit.Location = new System.Drawing.Point(107, 252);
            this.textBoxClientProduit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClientProduit.Name = "textBoxClientProduit";
            this.textBoxClientProduit.Size = new System.Drawing.Size(228, 24);
            this.textBoxClientProduit.TabIndex = 36;
            // 
            // textBoxMarqueProduit
            // 
            this.textBoxMarqueProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMarqueProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxMarqueProduit.Location = new System.Drawing.Point(107, 218);
            this.textBoxMarqueProduit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarqueProduit.Name = "textBoxMarqueProduit";
            this.textBoxMarqueProduit.Size = new System.Drawing.Size(228, 24);
            this.textBoxMarqueProduit.TabIndex = 35;
            // 
            // textBoxMBTFProduit
            // 
            this.textBoxMBTFProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMBTFProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxMBTFProduit.Location = new System.Drawing.Point(107, 178);
            this.textBoxMBTFProduit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMBTFProduit.Name = "textBoxMBTFProduit";
            this.textBoxMBTFProduit.Size = new System.Drawing.Size(228, 24);
            this.textBoxMBTFProduit.TabIndex = 34;
            // 
            // labelClientProduit
            // 
            this.labelClientProduit.AutoSize = true;
            this.labelClientProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelClientProduit.ForeColor = System.Drawing.Color.Black;
            this.labelClientProduit.Location = new System.Drawing.Point(4, 252);
            this.labelClientProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientProduit.Name = "labelClientProduit";
            this.labelClientProduit.Size = new System.Drawing.Size(56, 18);
            this.labelClientProduit.TabIndex = 33;
            this.labelClientProduit.Text = "Client :";
            // 
            // labelMarqueProduit
            // 
            this.labelMarqueProduit.AutoSize = true;
            this.labelMarqueProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMarqueProduit.ForeColor = System.Drawing.Color.Black;
            this.labelMarqueProduit.Location = new System.Drawing.Point(4, 218);
            this.labelMarqueProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarqueProduit.Name = "labelMarqueProduit";
            this.labelMarqueProduit.Size = new System.Drawing.Size(69, 18);
            this.labelMarqueProduit.TabIndex = 32;
            this.labelMarqueProduit.Text = "Marque :";
            // 
            // labelMBTFProduit
            // 
            this.labelMBTFProduit.AutoSize = true;
            this.labelMBTFProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMBTFProduit.ForeColor = System.Drawing.Color.Black;
            this.labelMBTFProduit.Location = new System.Drawing.Point(4, 183);
            this.labelMBTFProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMBTFProduit.Name = "labelMBTFProduit";
            this.labelMBTFProduit.Size = new System.Drawing.Size(59, 18);
            this.labelMBTFProduit.TabIndex = 31;
            this.labelMBTFProduit.Text = "MBTF :";
            // 
            // textBoxCodeProduit
            // 
            this.textBoxCodeProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxCodeProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxCodeProduit.Location = new System.Drawing.Point(107, 142);
            this.textBoxCodeProduit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodeProduit.Name = "textBoxCodeProduit";
            this.textBoxCodeProduit.Size = new System.Drawing.Size(228, 24);
            this.textBoxCodeProduit.TabIndex = 30;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd / MMMM / yyyy";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(107, 104);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(228, 24);
            this.dateTimePickerDate.TabIndex = 29;
            // 
            // labelCodeProduit
            // 
            this.labelCodeProduit.AutoSize = true;
            this.labelCodeProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelCodeProduit.ForeColor = System.Drawing.Color.Black;
            this.labelCodeProduit.Location = new System.Drawing.Point(4, 143);
            this.labelCodeProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodeProduit.Name = "labelCodeProduit";
            this.labelCodeProduit.Size = new System.Drawing.Size(55, 18);
            this.labelCodeProduit.TabIndex = 28;
            this.labelCodeProduit.Text = "Code :";
            // 
            // labelDateProduit
            // 
            this.labelDateProduit.AutoSize = true;
            this.labelDateProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDateProduit.ForeColor = System.Drawing.Color.Black;
            this.labelDateProduit.Location = new System.Drawing.Point(4, 107);
            this.labelDateProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateProduit.Name = "labelDateProduit";
            this.labelDateProduit.Size = new System.Drawing.Size(50, 18);
            this.labelDateProduit.TabIndex = 27;
            this.labelDateProduit.Text = "Date :";
            // 
            // textBoxDescriptionProduit
            // 
            this.textBoxDescriptionProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxDescriptionProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxDescriptionProduit.Location = new System.Drawing.Point(107, 66);
            this.textBoxDescriptionProduit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescriptionProduit.Name = "textBoxDescriptionProduit";
            this.textBoxDescriptionProduit.Size = new System.Drawing.Size(228, 24);
            this.textBoxDescriptionProduit.TabIndex = 25;
            // 
            // labelDescriptionProduit
            // 
            this.labelDescriptionProduit.AutoSize = true;
            this.labelDescriptionProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDescriptionProduit.ForeColor = System.Drawing.Color.Black;
            this.labelDescriptionProduit.Location = new System.Drawing.Point(4, 67);
            this.labelDescriptionProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescriptionProduit.Name = "labelDescriptionProduit";
            this.labelDescriptionProduit.Size = new System.Drawing.Size(96, 18);
            this.labelDescriptionProduit.TabIndex = 24;
            this.labelDescriptionProduit.Text = "Description :";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNomClient.ForeColor = System.Drawing.Color.Black;
            this.labelNomClient.Location = new System.Drawing.Point(4, 29);
            this.labelNomClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(49, 18);
            this.labelNomClient.TabIndex = 23;
            this.labelNomClient.Text = "Nom :";
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
            this.groupBoxProduit.Controls.Add(this.listBoxProduit);
            this.groupBoxProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduit.Location = new System.Drawing.Point(9, 20);
            this.groupBoxProduit.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProduit.Size = new System.Drawing.Size(189, 280);
            this.groupBoxProduit.TabIndex = 22;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Liste des Produits";
            // 
            // listBoxProduit
            // 
            this.listBoxProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxProduit.FormattingEnabled = true;
            this.listBoxProduit.ItemHeight = 17;
            this.listBoxProduit.Location = new System.Drawing.Point(4, 28);
            this.listBoxProduit.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProduit.Name = "listBoxProduit";
            this.listBoxProduit.Size = new System.Drawing.Size(181, 242);
            this.listBoxProduit.TabIndex = 8;
            this.listBoxProduit.SelectedIndexChanged += new System.EventHandler(this.listBoxProduit_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(458, 301);
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
            this.buttonOK.Location = new System.Drawing.Point(349, 301);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 32);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 366);
            this.Controls.Add(this.buttonCleanClient);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBoxMarqueText);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrdiCare";
            this.groupBoxMarqueText.ResumeLayout(false);
            this.groupBoxMarqueText.PerformLayout();
            this.groupBoxProduit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCleanClient;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.GroupBox groupBoxMarqueText;
        private System.Windows.Forms.Label labelCodeProduit;
        private System.Windows.Forms.Label labelDateProduit;
        private System.Windows.Forms.TextBox textBoxDescriptionProduit;
        private System.Windows.Forms.Label labelDescriptionProduit;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.TextBox textBoxNomProduit;
        private System.Windows.Forms.GroupBox groupBoxProduit;
        private System.Windows.Forms.ListBox listBoxProduit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelClientProduit;
        private System.Windows.Forms.Label labelMarqueProduit;
        private System.Windows.Forms.Label labelMBTFProduit;
        private System.Windows.Forms.TextBox textBoxCodeProduit;
        private System.Windows.Forms.TextBox textBoxClientProduit;
        private System.Windows.Forms.TextBox textBoxMarqueProduit;
        private System.Windows.Forms.TextBox textBoxMBTFProduit;
    }
}