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
            this.buttonCleanClient.Location = new System.Drawing.Point(287, 375);
            this.buttonCleanClient.Name = "buttonCleanClient";
            this.buttonCleanClient.Size = new System.Drawing.Size(162, 31);
            this.buttonCleanClient.TabIndex = 27;
            this.buttonCleanClient.Text = "Vider les cellules";
            this.buttonCleanClient.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSupprimer.Location = new System.Drawing.Point(745, 250);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(121, 31);
            this.buttonSupprimer.TabIndex = 26;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(745, 168);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(121, 31);
            this.buttonModifier.TabIndex = 25;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAjouter.Location = new System.Drawing.Point(745, 90);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(121, 31);
            this.buttonAjouter.TabIndex = 24;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
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
            this.groupBoxMarqueText.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarqueText.Location = new System.Drawing.Point(287, 25);
            this.groupBoxMarqueText.Name = "groupBoxMarqueText";
            this.groupBoxMarqueText.Size = new System.Drawing.Size(452, 344);
            this.groupBoxMarqueText.TabIndex = 23;
            this.groupBoxMarqueText.TabStop = false;
            this.groupBoxMarqueText.Text = "Plus d\'informations";
            // 
            // textBoxClientProduit
            // 
            this.textBoxClientProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxClientProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxClientProduit.Location = new System.Drawing.Point(143, 310);
            this.textBoxClientProduit.Name = "textBoxClientProduit";
            this.textBoxClientProduit.Size = new System.Drawing.Size(303, 29);
            this.textBoxClientProduit.TabIndex = 36;
            // 
            // textBoxMarqueProduit
            // 
            this.textBoxMarqueProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMarqueProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxMarqueProduit.Location = new System.Drawing.Point(143, 268);
            this.textBoxMarqueProduit.Name = "textBoxMarqueProduit";
            this.textBoxMarqueProduit.Size = new System.Drawing.Size(303, 29);
            this.textBoxMarqueProduit.TabIndex = 35;
            // 
            // textBoxMBTFProduit
            // 
            this.textBoxMBTFProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxMBTFProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxMBTFProduit.Location = new System.Drawing.Point(143, 219);
            this.textBoxMBTFProduit.Name = "textBoxMBTFProduit";
            this.textBoxMBTFProduit.Size = new System.Drawing.Size(303, 29);
            this.textBoxMBTFProduit.TabIndex = 34;
            // 
            // labelClientProduit
            // 
            this.labelClientProduit.AutoSize = true;
            this.labelClientProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelClientProduit.ForeColor = System.Drawing.Color.Black;
            this.labelClientProduit.Location = new System.Drawing.Point(6, 310);
            this.labelClientProduit.Name = "labelClientProduit";
            this.labelClientProduit.Size = new System.Drawing.Size(71, 23);
            this.labelClientProduit.TabIndex = 33;
            this.labelClientProduit.Text = "Client :";
            // 
            // labelMarqueProduit
            // 
            this.labelMarqueProduit.AutoSize = true;
            this.labelMarqueProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMarqueProduit.ForeColor = System.Drawing.Color.Black;
            this.labelMarqueProduit.Location = new System.Drawing.Point(6, 268);
            this.labelMarqueProduit.Name = "labelMarqueProduit";
            this.labelMarqueProduit.Size = new System.Drawing.Size(89, 23);
            this.labelMarqueProduit.TabIndex = 32;
            this.labelMarqueProduit.Text = "Marque :";
            // 
            // labelMBTFProduit
            // 
            this.labelMBTFProduit.AutoSize = true;
            this.labelMBTFProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMBTFProduit.ForeColor = System.Drawing.Color.Black;
            this.labelMBTFProduit.Location = new System.Drawing.Point(6, 225);
            this.labelMBTFProduit.Name = "labelMBTFProduit";
            this.labelMBTFProduit.Size = new System.Drawing.Size(76, 23);
            this.labelMBTFProduit.TabIndex = 31;
            this.labelMBTFProduit.Text = "MBTF :";
            // 
            // textBoxCodeProduit
            // 
            this.textBoxCodeProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxCodeProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxCodeProduit.Location = new System.Drawing.Point(143, 175);
            this.textBoxCodeProduit.Name = "textBoxCodeProduit";
            this.textBoxCodeProduit.Size = new System.Drawing.Size(303, 29);
            this.textBoxCodeProduit.TabIndex = 30;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd / MMMM / yyyy";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 11F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(143, 128);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(303, 29);
            this.dateTimePickerDate.TabIndex = 29;
            // 
            // labelCodeProduit
            // 
            this.labelCodeProduit.AutoSize = true;
            this.labelCodeProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelCodeProduit.ForeColor = System.Drawing.Color.Black;
            this.labelCodeProduit.Location = new System.Drawing.Point(6, 176);
            this.labelCodeProduit.Name = "labelCodeProduit";
            this.labelCodeProduit.Size = new System.Drawing.Size(69, 23);
            this.labelCodeProduit.TabIndex = 28;
            this.labelCodeProduit.Text = "Code :";
            // 
            // labelDateProduit
            // 
            this.labelDateProduit.AutoSize = true;
            this.labelDateProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDateProduit.ForeColor = System.Drawing.Color.Black;
            this.labelDateProduit.Location = new System.Drawing.Point(6, 132);
            this.labelDateProduit.Name = "labelDateProduit";
            this.labelDateProduit.Size = new System.Drawing.Size(64, 23);
            this.labelDateProduit.TabIndex = 27;
            this.labelDateProduit.Text = "Date :";
            // 
            // textBoxDescriptionProduit
            // 
            this.textBoxDescriptionProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxDescriptionProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxDescriptionProduit.Location = new System.Drawing.Point(143, 81);
            this.textBoxDescriptionProduit.Name = "textBoxDescriptionProduit";
            this.textBoxDescriptionProduit.Size = new System.Drawing.Size(303, 29);
            this.textBoxDescriptionProduit.TabIndex = 25;
            // 
            // labelDescriptionProduit
            // 
            this.labelDescriptionProduit.AutoSize = true;
            this.labelDescriptionProduit.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDescriptionProduit.ForeColor = System.Drawing.Color.Black;
            this.labelDescriptionProduit.Location = new System.Drawing.Point(6, 82);
            this.labelDescriptionProduit.Name = "labelDescriptionProduit";
            this.labelDescriptionProduit.Size = new System.Drawing.Size(120, 23);
            this.labelDescriptionProduit.TabIndex = 24;
            this.labelDescriptionProduit.Text = "Description :";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNomClient.ForeColor = System.Drawing.Color.Black;
            this.labelNomClient.Location = new System.Drawing.Point(6, 36);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(62, 23);
            this.labelNomClient.TabIndex = 23;
            this.labelNomClient.Text = "Nom :";
            // 
            // textBoxNomProduit
            // 
            this.textBoxNomProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxNomProduit.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomProduit.Location = new System.Drawing.Point(143, 35);
            this.textBoxNomProduit.Name = "textBoxNomProduit";
            this.textBoxNomProduit.Size = new System.Drawing.Size(303, 29);
            this.textBoxNomProduit.TabIndex = 22;
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.Controls.Add(this.listBoxProduit);
            this.groupBoxProduit.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduit.Location = new System.Drawing.Point(12, 25);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Size = new System.Drawing.Size(252, 344);
            this.groupBoxProduit.TabIndex = 22;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Liste des Produits";
            // 
            // listBoxProduit
            // 
            this.listBoxProduit.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxProduit.FormattingEnabled = true;
            this.listBoxProduit.ItemHeight = 21;
            this.listBoxProduit.Location = new System.Drawing.Point(6, 35);
            this.listBoxProduit.Name = "listBoxProduit";
            this.listBoxProduit.Size = new System.Drawing.Size(240, 298);
            this.listBoxProduit.TabIndex = 8;
            //this.listBoxProduit.SelectedIndexChanged += new System.EventHandler(this.listBoxProduit_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(610, 370);
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
            this.buttonOK.Location = new System.Drawing.Point(465, 370);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(129, 39);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.buttonCleanClient);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBoxMarqueText);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProduit";
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