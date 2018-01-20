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
            this.BtnNouveau = new System.Windows.Forms.ToolStripButton();
            this.BtnModifier = new System.Windows.Forms.ToolStripButton();
            this.CbxSearchCategorie = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.DtpDebut = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.CbxStatut = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenements)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvenements
            // 
            this.dgvEvenements.AllowUserToAddRows = false;
            this.dgvEvenements.AllowUserToDeleteRows = false;
            this.dgvEvenements.AllowUserToResizeRows = false;
            this.dgvEvenements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvenements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEvenements.Location = new System.Drawing.Point(0, 60);
            this.dgvEvenements.MultiSelect = false;
            this.dgvEvenements.Name = "dgvEvenements";
            this.dgvEvenements.ReadOnly = true;
            this.dgvEvenements.RowHeadersVisible = false;
            this.dgvEvenements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvenements.ShowCellErrors = false;
            this.dgvEvenements.ShowCellToolTips = false;
            this.dgvEvenements.ShowEditingIcon = false;
            this.dgvEvenements.Size = new System.Drawing.Size(867, 507);
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
            this.toolStrip.Size = new System.Drawing.Size(867, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("BtnNouveau.Image")));
            this.BtnNouveau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(119, 28);
            this.BtnNouveau.Text = "Nouveau Post\'it";
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(80, 28);
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // CbxSearchCategorie
            // 
            this.CbxSearchCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSearchCategorie.FormattingEnabled = true;
            this.CbxSearchCategorie.Location = new System.Drawing.Point(51, 35);
            this.CbxSearchCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxSearchCategorie.Name = "CbxSearchCategorie";
            this.CbxSearchCategorie.Size = new System.Drawing.Size(210, 21);
            this.CbxSearchCategorie.TabIndex = 2;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(306, 36);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(165, 20);
            this.TxtSearch.TabIndex = 3;
            // 
            // DtpFin
            // 
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(621, 36);
            this.DtpFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(94, 20);
            this.DtpFin.TabIndex = 4;
            // 
            // DtpDebut
            // 
            this.DtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDebut.Location = new System.Drawing.Point(505, 36);
            this.DtpDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpDebut.Name = "DtpDebut";
            this.DtpDebut.Size = new System.Drawing.Size(93, 20);
            this.DtpDebut.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(972, 34);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 21);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "R.A.Z.";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtrer :";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(891, 33);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(77, 21);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "Filtrer";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // CbxStatut
            // 
            this.CbxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatut.FormattingEnabled = true;
            this.CbxStatut.Location = new System.Drawing.Point(763, 35);
            this.CbxStatut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxStatut.Name = "CbxStatut";
            this.CbxStatut.Size = new System.Drawing.Size(89, 21);
            this.CbxStatut.TabIndex = 9;
            // 
            // EvenementsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 567);
            this.ControlBox = false;
            this.Controls.Add(this.CbxStatut);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DtpDebut);
            this.Controls.Add(this.DtpFin);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CbxSearchCategorie);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvEvenements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ComboBox CbxStatut;
    }
}