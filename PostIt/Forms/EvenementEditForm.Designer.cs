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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvenementEditForm));
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
            this.BtnCommentaires = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.LblTitre = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnFermer = new System.Windows.Forms.Button();
            this.LblOperateurView = new System.Windows.Forms.Label();
            this.LblCategorieView = new System.Windows.Forms.Label();
            this.LblTiersView = new System.Windows.Forms.Label();
            this.LblEcheanceView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblOperateur
            // 
            this.LblOperateur.AutoSize = true;
            this.LblOperateur.Location = new System.Drawing.Point(36, 72);
            this.LblOperateur.Name = "LblOperateur";
            this.LblOperateur.Size = new System.Drawing.Size(104, 20);
            this.LblOperateur.TabIndex = 0;
            this.LblOperateur.Text = "Collaborateur";
            // 
            // CbxOperateur
            // 
            this.CbxOperateur.FormattingEnabled = true;
            this.CbxOperateur.Location = new System.Drawing.Point(36, 95);
            this.CbxOperateur.Name = "CbxOperateur";
            this.CbxOperateur.Size = new System.Drawing.Size(278, 28);
            this.CbxOperateur.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(372, 95);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(266, 28);
            this.CbxCategorie.TabIndex = 1;
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(368, 72);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(78, 20);
            this.LblCategorie.TabIndex = 2;
            this.LblCategorie.Text = "Catégorie";
            // 
            // TxtTiers
            // 
            this.TxtTiers.Location = new System.Drawing.Point(36, 166);
            this.TxtTiers.Name = "TxtTiers";
            this.TxtTiers.Size = new System.Drawing.Size(278, 26);
            this.TxtTiers.TabIndex = 2;
            // 
            // LblTiers
            // 
            this.LblTiers.AutoSize = true;
            this.LblTiers.Location = new System.Drawing.Point(36, 143);
            this.LblTiers.Name = "LblTiers";
            this.LblTiers.Size = new System.Drawing.Size(113, 20);
            this.LblTiers.TabIndex = 5;
            this.LblTiers.Text = "Tiers concerné";
            // 
            // TxtDescription
            // 
            this.TxtDescription.AcceptsReturn = true;
            this.TxtDescription.Location = new System.Drawing.Point(36, 231);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(602, 156);
            this.TxtDescription.TabIndex = 3;
            // 
            // CbxStatut
            // 
            this.CbxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatut.FormattingEnabled = true;
            this.CbxStatut.Location = new System.Drawing.Point(36, 431);
            this.CbxStatut.Name = "CbxStatut";
            this.CbxStatut.Size = new System.Drawing.Size(138, 28);
            this.CbxStatut.TabIndex = 4;
            this.CbxStatut.Visible = false;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(36, 208);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(166, 20);
            this.LblDescription.TabIndex = 8;
            this.LblDescription.Text = "Description / Message";
            // 
            // LblStatut
            // 
            this.LblStatut.AutoSize = true;
            this.LblStatut.Location = new System.Drawing.Point(36, 408);
            this.LblStatut.Name = "LblStatut";
            this.LblStatut.Size = new System.Drawing.Size(122, 20);
            this.LblStatut.TabIndex = 9;
            this.LblStatut.Text = "Statut du Post\'it";
            this.LblStatut.Visible = false;
            // 
            // DtpEcheance
            // 
            this.DtpEcheance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEcheance.Location = new System.Drawing.Point(498, 432);
            this.DtpEcheance.Name = "DtpEcheance";
            this.DtpEcheance.Size = new System.Drawing.Size(140, 26);
            this.DtpEcheance.TabIndex = 5;
            // 
            // LblEcheance
            // 
            this.LblEcheance.AutoSize = true;
            this.LblEcheance.Location = new System.Drawing.Point(494, 409);
            this.LblEcheance.Name = "LblEcheance";
            this.LblEcheance.Size = new System.Drawing.Size(81, 20);
            this.LblEcheance.TabIndex = 11;
            this.LblEcheance.Text = "Echéance";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(330, 506);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(138, 52);
            this.BtnAnnuler.TabIndex = 8;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Location = new System.Drawing.Point(474, 506);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(166, 52);
            this.BtnEnregistrer.TabIndex = 7;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // BtnCommentaires
            // 
            this.BtnCommentaires.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCommentaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommentaires.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCommentaires.Location = new System.Drawing.Point(36, 506);
            this.BtnCommentaires.Name = "BtnCommentaires";
            this.BtnCommentaires.Size = new System.Drawing.Size(218, 52);
            this.BtnCommentaires.TabIndex = 12;
            this.BtnCommentaires.Text = "Nouvelle annotation";
            this.BtnCommentaires.UseVisualStyleBackColor = true;
            this.BtnCommentaires.Visible = false;
            this.BtnCommentaires.Click += new System.EventHandler(this.BtnCommentaires_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.Location = new System.Drawing.Point(628, 8);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(42, 43);
            this.BtnModifier.TabIndex = 13;
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Visible = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(680, 598);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rectangleShape1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(452, 37);
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LblTitre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.ForeColor = System.Drawing.Color.White;
            this.LblTitre.Location = new System.Drawing.Point(36, 18);
            this.LblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(223, 27);
            this.LblTitre.TabIndex = 15;
            this.LblTitre.Text = "Edition d\'un Post\'it";
            // 
            // Timer
            // 
            this.Timer.Interval = 750;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Location = new System.Drawing.Point(474, 506);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(164, 52);
            this.BtnFermer.TabIndex = 16;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Visible = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // LblOperateurView
            // 
            this.LblOperateurView.AutoSize = true;
            this.LblOperateurView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperateurView.Location = new System.Drawing.Point(37, 98);
            this.LblOperateurView.Name = "LblOperateurView";
            this.LblOperateurView.Size = new System.Drawing.Size(117, 20);
            this.LblOperateurView.TabIndex = 17;
            this.LblOperateurView.Text = "Collaborateur";
            this.LblOperateurView.Visible = false;
            // 
            // LblCategorieView
            // 
            this.LblCategorieView.AutoSize = true;
            this.LblCategorieView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategorieView.Location = new System.Drawing.Point(381, 95);
            this.LblCategorieView.Name = "LblCategorieView";
            this.LblCategorieView.Size = new System.Drawing.Size(87, 20);
            this.LblCategorieView.TabIndex = 18;
            this.LblCategorieView.Text = "Categorie";
            this.LblCategorieView.Visible = false;
            // 
            // LblTiersView
            // 
            this.LblTiersView.AutoSize = true;
            this.LblTiersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiersView.Location = new System.Drawing.Point(37, 169);
            this.LblTiersView.Name = "LblTiersView";
            this.LblTiersView.Size = new System.Drawing.Size(48, 20);
            this.LblTiersView.TabIndex = 19;
            this.LblTiersView.Text = "Tiers";
            this.LblTiersView.Visible = false;
            // 
            // LblEcheanceView
            // 
            this.LblEcheanceView.AutoSize = true;
            this.LblEcheanceView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEcheanceView.Location = new System.Drawing.Point(494, 437);
            this.LblEcheanceView.Name = "LblEcheanceView";
            this.LblEcheanceView.Size = new System.Drawing.Size(89, 20);
            this.LblEcheanceView.TabIndex = 20;
            this.LblEcheanceView.Text = "Echeance";
            // 
            // EvenementEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 598);
            this.Controls.Add(this.LblEcheanceView);
            this.Controls.Add(this.LblTiersView);
            this.Controls.Add(this.LblCategorieView);
            this.Controls.Add(this.LblOperateurView);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.LblTitre);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnCommentaires);
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
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EvenementEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post\'it";
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
        private System.Windows.Forms.Button BtnCommentaires;
        private System.Windows.Forms.Button BtnModifier;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label LblOperateurView;
        private System.Windows.Forms.Label LblCategorieView;
        private System.Windows.Forms.Label LblTiersView;
        private System.Windows.Forms.Label LblEcheanceView;
    }
}