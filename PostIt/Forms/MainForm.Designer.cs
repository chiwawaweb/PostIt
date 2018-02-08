namespace PostIt.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annuaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réorganiserLesFenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsbEvenements = new System.Windows.Forms.ToolStripButton();
            this.TsbAnnuaire = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(751, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postitToolStripMenuItem,
            this.annuaireToolStripMenuItem,
            this.toolStripMenuItem4,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // postitToolStripMenuItem
            // 
            this.postitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("postitToolStripMenuItem.Image")));
            this.postitToolStripMenuItem.Name = "postitToolStripMenuItem";
            this.postitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.postitToolStripMenuItem.Text = "Post\'it";
            this.postitToolStripMenuItem.Click += new System.EventHandler(this.PostitToolStripMenuItem_Click);
            // 
            // annuaireToolStripMenuItem
            // 
            this.annuaireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("annuaireToolStripMenuItem.Image")));
            this.annuaireToolStripMenuItem.Name = "annuaireToolStripMenuItem";
            this.annuaireToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.annuaireToolStripMenuItem.Text = "Annuaire";
            this.annuaireToolStripMenuItem.Click += new System.EventHandler(this.AnnuaireToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(130, 6);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paramètresToolStripMenuItem.Image")));
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.ParamètresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.réorganiserLesFenêtresToolStripMenuItem,
            this.toolStripMenuItem5,
            this.miseÀJourToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Enabled = false;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aideToolStripMenuItem.Text = "Aide ?";
            this.aideToolStripMenuItem.Visible = false;
            // 
            // réorganiserLesFenêtresToolStripMenuItem
            // 
            this.réorganiserLesFenêtresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("réorganiserLesFenêtresToolStripMenuItem.Image")));
            this.réorganiserLesFenêtresToolStripMenuItem.Name = "réorganiserLesFenêtresToolStripMenuItem";
            this.réorganiserLesFenêtresToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.réorganiserLesFenêtresToolStripMenuItem.Text = "Réorganiser les fenêtres";
            this.réorganiserLesFenêtresToolStripMenuItem.Click += new System.EventHandler(this.RéorganiserLesFenêtresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(195, 6);
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("miseÀJourToolStripMenuItem.Image")));
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.miseÀJourToolStripMenuItem.Text = "Mise à jour...";
            this.miseÀJourToolStripMenuItem.Click += new System.EventHandler(this.MiseÀJourToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 6);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aProposToolStripMenuItem.Image")));
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aProposToolStripMenuItem.Text = "A propos...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.AProposToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbEvenements,
            this.TsbAnnuaire});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(751, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.Visible = false;
            // 
            // TsbEvenements
            // 
            this.TsbEvenements.Image = ((System.Drawing.Image)(resources.GetObject("TsbEvenements.Image")));
            this.TsbEvenements.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEvenements.Name = "TsbEvenements";
            this.TsbEvenements.Size = new System.Drawing.Size(68, 28);
            this.TsbEvenements.Text = "Post\'it";
            this.TsbEvenements.Click += new System.EventHandler(this.TsbEvenements_Click);
            // 
            // TsbAnnuaire
            // 
            this.TsbAnnuaire.Image = ((System.Drawing.Image)(resources.GetObject("TsbAnnuaire.Image")));
            this.TsbAnnuaire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAnnuaire.Name = "TsbAnnuaire";
            this.TsbAnnuaire.Size = new System.Drawing.Size(83, 28);
            this.TsbAnnuaire.Text = "Annuaire";
            this.TsbAnnuaire.Click += new System.EventHandler(this.TsbAnnuaire_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslVersion});
            this.statusStrip.Location = new System.Drawing.Point(0, 449);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(751, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // TsslVersion
            // 
            this.TsslVersion.Name = "TsslVersion";
            this.TsslVersion.Size = new System.Drawing.Size(46, 17);
            this.TsslVersion.Text = "Version";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 471);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Post\'it";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem annuaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TsslVersion;
        private System.Windows.Forms.ToolStripMenuItem postitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem réorganiserLesFenêtresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripButton TsbEvenements;
        private System.Windows.Forms.ToolStripButton TsbAnnuaire;
    }
}