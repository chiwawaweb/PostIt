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
            this.LblOperateur.Location = new System.Drawing.Point(32, 38);
            this.LblOperateur.Name = "LblOperateur";
            this.LblOperateur.Size = new System.Drawing.Size(104, 20);
            this.LblOperateur.TabIndex = 0;
            this.LblOperateur.Text = "Collaborateur";
            // 
            // CbxOperateur
            // 
            this.CbxOperateur.FormattingEnabled = true;
            this.CbxOperateur.Location = new System.Drawing.Point(36, 62);
            this.CbxOperateur.Name = "CbxOperateur";
            this.CbxOperateur.Size = new System.Drawing.Size(278, 28);
            this.CbxOperateur.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(339, 62);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(300, 28);
            this.CbxCategorie.TabIndex = 1;
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(334, 38);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(78, 20);
            this.LblCategorie.TabIndex = 2;
            this.LblCategorie.Text = "Catégorie";
            this.LblCategorie.Click += new System.EventHandler(this.LblCategorie_Click);
            // 
            // TxtTiers
            // 
            this.TxtTiers.Location = new System.Drawing.Point(36, 132);
            this.TxtTiers.Name = "TxtTiers";
            this.TxtTiers.Size = new System.Drawing.Size(278, 26);
            this.TxtTiers.TabIndex = 2;
            // 
            // LblTiers
            // 
            this.LblTiers.AutoSize = true;
            this.LblTiers.Location = new System.Drawing.Point(32, 109);
            this.LblTiers.Name = "LblTiers";
            this.LblTiers.Size = new System.Drawing.Size(43, 20);
            this.LblTiers.TabIndex = 5;
            this.LblTiers.Text = "Tiers";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(36, 197);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(602, 156);
            this.TxtDescription.TabIndex = 3;
            // 
            // CbxStatut
            // 
            this.CbxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatut.FormattingEnabled = true;
            this.CbxStatut.Location = new System.Drawing.Point(36, 397);
            this.CbxStatut.Name = "CbxStatut";
            this.CbxStatut.Size = new System.Drawing.Size(278, 28);
            this.CbxStatut.TabIndex = 4;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(32, 174);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(166, 20);
            this.LblDescription.TabIndex = 8;
            this.LblDescription.Text = "Description / Message";
            // 
            // LblStatut
            // 
            this.LblStatut.AutoSize = true;
            this.LblStatut.Location = new System.Drawing.Point(32, 374);
            this.LblStatut.Name = "LblStatut";
            this.LblStatut.Size = new System.Drawing.Size(53, 20);
            this.LblStatut.TabIndex = 9;
            this.LblStatut.Text = "Statut";
            // 
            // DtpEcheance
            // 
            this.DtpEcheance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEcheance.Location = new System.Drawing.Point(498, 398);
            this.DtpEcheance.Name = "DtpEcheance";
            this.DtpEcheance.Size = new System.Drawing.Size(140, 26);
            this.DtpEcheance.TabIndex = 5;
            // 
            // LblEcheance
            // 
            this.LblEcheance.AutoSize = true;
            this.LblEcheance.Location = new System.Drawing.Point(494, 375);
            this.LblEcheance.Name = "LblEcheance";
            this.LblEcheance.Size = new System.Drawing.Size(81, 20);
            this.LblEcheance.TabIndex = 11;
            this.LblEcheance.Text = "Echéance";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(302, 472);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(166, 52);
            this.BtnAnnuler.TabIndex = 8;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Location = new System.Drawing.Point(474, 472);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(166, 52);
            this.BtnEnregistrer.TabIndex = 7;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // EvenementEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 565);
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