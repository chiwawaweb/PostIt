namespace PostIt.Forms
{
    partial class EvenementEditForm
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
            this.LblOperateur = new System.Windows.Forms.Label();
            this.CbxOperateur = new System.Windows.Forms.ComboBox();
            this.CbxCategorie = new System.Windows.Forms.ComboBox();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.TxtTiers = new System.Windows.Forms.TextBox();
            this.LblTiers = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.CbxStatut = new System.Windows.Forms.ComboBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblStatut = new System.Windows.Forms.Label();
            this.DtpEcheance = new System.Windows.Forms.DateTimePicker();
            this.LblEcheance = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOperateur
            // 
            this.LblOperateur.AutoSize = true;
            this.LblOperateur.Location = new System.Drawing.Point(21, 25);
            this.LblOperateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOperateur.Name = "LblOperateur";
            this.LblOperateur.Size = new System.Drawing.Size(69, 13);
            this.LblOperateur.TabIndex = 0;
            this.LblOperateur.Text = "Collaborateur";
            // 
            // CbxOperateur
            // 
            this.CbxOperateur.FormattingEnabled = true;
            this.CbxOperateur.Location = new System.Drawing.Point(24, 40);
            this.CbxOperateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxOperateur.Name = "CbxOperateur";
            this.CbxOperateur.Size = new System.Drawing.Size(187, 21);
            this.CbxOperateur.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(226, 40);
            this.CbxCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(201, 21);
            this.CbxCategorie.TabIndex = 1;
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(223, 25);
            this.LblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(52, 13);
            this.LblCategorie.TabIndex = 2;
            this.LblCategorie.Text = "Catégorie";
            this.LblCategorie.Click += new System.EventHandler(this.LblCategorie_Click);
            // 
            // TxtTiers
            // 
            this.TxtTiers.Location = new System.Drawing.Point(24, 86);
            this.TxtTiers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTiers.Name = "TxtTiers";
            this.TxtTiers.Size = new System.Drawing.Size(187, 20);
            this.TxtTiers.TabIndex = 2;
            // 
            // LblTiers
            // 
            this.LblTiers.AutoSize = true;
            this.LblTiers.Location = new System.Drawing.Point(21, 71);
            this.LblTiers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTiers.Name = "LblTiers";
            this.LblTiers.Size = new System.Drawing.Size(30, 13);
            this.LblTiers.TabIndex = 5;
            this.LblTiers.Text = "Tiers";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(24, 128);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(403, 103);
            this.TxtDescription.TabIndex = 3;
            // 
            // CbxStatut
            // 
            this.CbxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatut.FormattingEnabled = true;
            this.CbxStatut.Location = new System.Drawing.Point(24, 258);
            this.CbxStatut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxStatut.Name = "CbxStatut";
            this.CbxStatut.Size = new System.Drawing.Size(187, 21);
            this.CbxStatut.TabIndex = 4;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(21, 113);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 8;
            this.LblDescription.Text = "Description";
            // 
            // LblStatut
            // 
            this.LblStatut.AutoSize = true;
            this.LblStatut.Location = new System.Drawing.Point(21, 243);
            this.LblStatut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStatut.Name = "LblStatut";
            this.LblStatut.Size = new System.Drawing.Size(35, 13);
            this.LblStatut.TabIndex = 9;
            this.LblStatut.Text = "Statut";
            // 
            // DtpEcheance
            // 
            this.DtpEcheance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEcheance.Location = new System.Drawing.Point(332, 259);
            this.DtpEcheance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpEcheance.Name = "DtpEcheance";
            this.DtpEcheance.Size = new System.Drawing.Size(95, 20);
            this.DtpEcheance.TabIndex = 5;
            // 
            // LblEcheance
            // 
            this.LblEcheance.AutoSize = true;
            this.LblEcheance.Location = new System.Drawing.Point(329, 244);
            this.LblEcheance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEcheance.Name = "LblEcheance";
            this.LblEcheance.Size = new System.Drawing.Size(56, 13);
            this.LblEcheance.TabIndex = 11;
            this.LblEcheance.Text = "Echéance";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(201, 307);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(111, 34);
            this.BtnAnnuler.TabIndex = 8;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Location = new System.Drawing.Point(316, 307);
            this.BtnEnregistrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(111, 34);
            this.BtnEnregistrer.TabIndex = 7;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // EvenementEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 367);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.LblEcheance);
            this.Controls.Add(this.DtpEcheance);
            this.Controls.Add(this.LblStatut);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.CbxStatut);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblTiers);
            this.Controls.Add(this.TxtTiers);
            this.Controls.Add(this.CbxCategorie);
            this.Controls.Add(this.LblCategorie);
            this.Controls.Add(this.CbxOperateur);
            this.Controls.Add(this.LblOperateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EvenementEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post\'It";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EvenementEditForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOperateur;
        private System.Windows.Forms.ComboBox CbxOperateur;
        private System.Windows.Forms.ComboBox CbxCategorie;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.TextBox TxtTiers;
        private System.Windows.Forms.Label LblTiers;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.ComboBox CbxStatut;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblStatut;
        private System.Windows.Forms.DateTimePicker DtpEcheance;
        private System.Windows.Forms.Label LblEcheance;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnEnregistrer;
    }
}