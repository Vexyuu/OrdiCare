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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarque));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.listBoxMarque = new System.Windows.Forms.ListBox();
            this.groupBoxMarque = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMarqueText = new System.Windows.Forms.GroupBox();
            this.groupBoxMarque.SuspendLayout();
            this.groupBoxMarqueText.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(486, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 39);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonOK.Location = new System.Drawing.Point(336, 285);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(129, 39);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // listBoxMarque
            // 
            this.listBoxMarque.Font = new System.Drawing.Font("Arial", 11F);
            this.listBoxMarque.FormattingEnabled = true;
            this.listBoxMarque.ItemHeight = 21;
            this.listBoxMarque.Location = new System.Drawing.Point(16, 35);
            this.listBoxMarque.Name = "listBoxMarque";
            this.listBoxMarque.Size = new System.Drawing.Size(203, 277);
            this.listBoxMarque.TabIndex = 8;
            // 
            // groupBoxMarque
            // 
            this.groupBoxMarque.Controls.Add(this.listBoxMarque);
            this.groupBoxMarque.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxMarque.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMarque.Name = "groupBoxMarque";
            this.groupBoxMarque.Size = new System.Drawing.Size(238, 320);
            this.groupBoxMarque.TabIndex = 9;
            this.groupBoxMarque.TabStop = false;
            this.groupBoxMarque.Text = "Liste des marques";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 171);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxMarqueText
            // 
            this.groupBoxMarqueText.Controls.Add(this.label1);
            this.groupBoxMarqueText.Location = new System.Drawing.Point(293, 47);
            this.groupBoxMarqueText.Name = "groupBoxMarqueText";
            this.groupBoxMarqueText.Size = new System.Drawing.Size(363, 205);
            this.groupBoxMarqueText.TabIndex = 11;
            this.groupBoxMarqueText.TabStop = false;
            // 
            // FormMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 353);
            this.Controls.Add(this.groupBoxMarqueText);
            this.Controls.Add(this.groupBoxMarque);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marques";
            this.groupBoxMarque.ResumeLayout(false);
            this.groupBoxMarqueText.ResumeLayout(false);
            this.groupBoxMarqueText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ListBox listBoxMarque;
        private System.Windows.Forms.GroupBox groupBoxMarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMarqueText;
    }
}