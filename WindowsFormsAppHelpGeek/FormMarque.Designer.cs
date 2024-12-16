namespace WindowsFormsAppOrdiCare
{
    partial class FormMarque
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
            this.listBoxMarque = new System.Windows.Forms.ListBox();
            this.groupBoxMarque = new System.Windows.Forms.GroupBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AjouterImage = new System.Windows.Forms.Button();
            this.pictureBoxMarque = new System.Windows.Forms.PictureBox();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.textBoxNomMarque = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxMarque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarque)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMarque
            // 
            this.listBoxMarque.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxMarque.FormattingEnabled = true;
            this.listBoxMarque.ItemHeight = 17;
            this.listBoxMarque.Location = new System.Drawing.Point(12, 28);
            this.listBoxMarque.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMarque.Name = "listBoxMarque";
            this.listBoxMarque.Size = new System.Drawing.Size(153, 225);
            this.listBoxMarque.TabIndex = 8;
            this.listBoxMarque.SelectedIndexChanged += new System.EventHandler(this.listBoxMarque_SelectedIndexChanged);
            // 
            // groupBoxMarque
            // 
            this.groupBoxMarque.Controls.Add(this.listBoxMarque);
            this.groupBoxMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarque.Location = new System.Drawing.Point(9, 10);
            this.groupBoxMarque.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMarque.Name = "groupBoxMarque";
            this.groupBoxMarque.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMarque.Size = new System.Drawing.Size(178, 269);
            this.groupBoxMarque.TabIndex = 9;
            this.groupBoxMarque.TabStop = false;
            this.groupBoxMarque.Text = "Liste des marques";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonSupprimer.Location = new System.Drawing.Point(542, 294);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 25);
            this.buttonSupprimer.TabIndex = 24;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonModifier.Location = new System.Drawing.Point(394, 294);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 25);
            this.buttonModifier.TabIndex = 23;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAjouter.Location = new System.Drawing.Point(243, 294);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(91, 25);
            this.buttonAjouter.TabIndex = 22;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AjouterImage);
            this.groupBox1.Controls.Add(this.pictureBoxMarque);
            this.groupBox1.Controls.Add(this.labelNomClient);
            this.groupBox1.Controls.Add(this.textBoxNomMarque);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(212, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 269);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plus d\'informations";
            // 
            // AjouterImage
            // 
            this.AjouterImage.Font = new System.Drawing.Font("Arial", 10F);
            this.AjouterImage.Location = new System.Drawing.Point(4, 148);
            this.AjouterImage.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterImage.Name = "AjouterImage";
            this.AjouterImage.Size = new System.Drawing.Size(64, 25);
            this.AjouterImage.TabIndex = 25;
            this.AjouterImage.Text = "Image";
            this.AjouterImage.UseVisualStyleBackColor = true;
            this.AjouterImage.Click += new System.EventHandler(this.AjouterImage_Click);
            // 
            // pictureBoxMarque
            // 
            this.pictureBoxMarque.Location = new System.Drawing.Point(82, 68);
            this.pictureBoxMarque.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMarque.Name = "pictureBoxMarque";
            this.pictureBoxMarque.Size = new System.Drawing.Size(357, 185);
            this.pictureBoxMarque.TabIndex = 24;
            this.pictureBoxMarque.TabStop = false;
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNomClient.ForeColor = System.Drawing.Color.Black;
            this.labelNomClient.Location = new System.Drawing.Point(11, 30);
            this.labelNomClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(49, 18);
            this.labelNomClient.TabIndex = 23;
            this.labelNomClient.Text = "Nom :";
            // 
            // textBoxNomMarque
            // 
            this.textBoxNomMarque.Font = new System.Drawing.Font("Arial", 11F);
            this.textBoxNomMarque.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomMarque.Location = new System.Drawing.Point(82, 28);
            this.textBoxNomMarque.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomMarque.Name = "textBoxNomMarque";
            this.textBoxNomMarque.Size = new System.Drawing.Size(357, 24);
            this.textBoxNomMarque.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Arial", 11F);
            this.button1.Location = new System.Drawing.Point(554, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Arial", 11F);
            this.button2.Location = new System.Drawing.Point(441, 333);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 391);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxMarque);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrdiCare";
            this.groupBoxMarque.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMarque;
        private System.Windows.Forms.GroupBox groupBoxMarque;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.TextBox textBoxNomMarque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxMarque;
        private System.Windows.Forms.Button AjouterImage;
    }
}