namespace PostIt.Forms
{
    partial class EvenementsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvenementsListForm));
            this.dgvEvenements = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BtnModifier = new System.Windows.Forms.ToolStripButton();
            this.BtnNouveau = new System.Windows.Forms.ToolStripButton();
            this.CbxSearchCategorie = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.DtpDebut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenements)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvenements
            // 
            this.dgvEvenements.AllowUserToAddRows = false;
            this.dgvEvenements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvenements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenements.Location = new System.Drawing.Point(0, 87);
            this.dgvEvenements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEvenements.Name = "dgvEvenements";
            this.dgvEvenements.Size = new System.Drawing.Size(1250, 784);
            this.dgvEvenements.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNouveau,
            this.BtnModifier});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1250, 32);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BtnModifier
            // 
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(107, 29);
            this.BtnModifier.Text = "Modifier";
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("BtnNouveau.Image")));
            this.BtnNouveau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(164, 29);
            this.BtnNouveau.Text = "Nouveau Post\'it";
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // CbxSearchCategorie
            // 
            this.CbxSearchCategorie.FormattingEnabled = true;
            this.CbxSearchCategorie.Location = new System.Drawing.Point(353, 40);
            this.CbxSearchCategorie.Name = "CbxSearchCategorie";
            this.CbxSearchCategorie.Size = new System.Drawing.Size(239, 28);
            this.CbxSearchCategorie.TabIndex = 2;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(598, 39);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(231, 26);
            this.TxtSearch.TabIndex = 3;
            // 
            // DtpFin
            // 
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(1003, 42);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(139, 26);
            this.DtpFin.TabIndex = 4;
            // 
            // DtpDebut
            // 
            this.DtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDebut.Location = new System.Drawing.Point(850, 42);
            this.DtpDebut.Name = "DtpDebut";
            this.DtpDebut.Size = new System.Drawing.Size(137, 26);
            this.DtpDebut.TabIndex = 5;
            // 
            // EvenementsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 877);
            this.ControlBox = false;
            this.Controls.Add(this.DtpDebut);
            this.Controls.Add(this.DtpFin);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CbxSearchCategorie);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvEvenements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EvenementsListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.EvenementsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenements)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvenements;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BtnModifier;
        private System.Windows.Forms.ToolStripButton BtnNouveau;
        private System.Windows.Forms.ComboBox CbxSearchCategorie;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.DateTimePicker DtpDebut;
    }
}