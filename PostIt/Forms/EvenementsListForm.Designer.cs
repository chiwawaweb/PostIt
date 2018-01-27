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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvenementsListForm));
            this.dgvEvenements = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BtnNouveau = new System.Windows.Forms.ToolStripButton();
            this.BtnModifier = new System.Windows.Forms.ToolStripButton();
            this.BtnFin = new System.Windows.Forms.ToolStripButton();
            this.BtnAnnuler = new System.Windows.Forms.ToolStripButton();
            this.TsbActualiser = new System.Windows.Forms.ToolStripButton();
            this.TsbReset = new System.Windows.Forms.ToolStripButton();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.DtpDebut = new System.Windows.Forms.DateTimePicker();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GrpFiltre = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkAnnule = new System.Windows.Forms.CheckBox();
            this.ChkTermine = new System.Windows.Forms.CheckBox();
            this.ChkEnCours = new System.Windows.Forms.CheckBox();
            this.LblSearchText = new System.Windows.Forms.Label();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.CbxSearchCategorie = new System.Windows.Forms.ComboBox();
            this.timerActualisation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenements)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.GrpFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvenements
            // 
            this.dgvEvenements.AllowUserToAddRows = false;
            this.dgvEvenements.AllowUserToDeleteRows = false;
            this.dgvEvenements.AllowUserToResizeColumns = false;
            this.dgvEvenements.AllowUserToResizeRows = false;
            this.dgvEvenements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvenements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEvenements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvenements.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEvenements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEvenements.Location = new System.Drawing.Point(0, 166);
            this.dgvEvenements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEvenements.MultiSelect = false;
            this.dgvEvenements.Name = "dgvEvenements";
            this.dgvEvenements.ReadOnly = true;
            this.dgvEvenements.RowHeadersWidth = 25;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvenements.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEvenements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvenements.ShowCellErrors = false;
            this.dgvEvenements.ShowCellToolTips = false;
            this.dgvEvenements.ShowEditingIcon = false;
            this.dgvEvenements.ShowRowErrors = false;
            this.dgvEvenements.Size = new System.Drawing.Size(1300, 706);
            this.dgvEvenements.TabIndex = 0;
            this.dgvEvenements.TabStop = false;
            this.dgvEvenements.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenements_CellDoubleClick);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNouveau,
            this.BtnModifier,
            this.BtnFin,
            this.BtnAnnuler,
            this.TsbActualiser,
            this.TsbReset});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1300, 32);
            this.toolStrip.TabIndex = 1;
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
            // BtnModifier
            // 
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(157, 29);
            this.BtnModifier.Text = "Afficher détails";
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnFin
            // 
            this.BtnFin.Image = ((System.Drawing.Image)(resources.GetObject("BtnFin.Image")));
            this.BtnFin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.Size = new System.Drawing.Size(237, 29);
            this.BtnFin.Text = "Marquer comme terminé";
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnuler.Image")));
            this.BtnAnnuler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(172, 29);
            this.BtnAnnuler.Text = "Annuler le Post\'it";
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // TsbActualiser
            // 
            this.TsbActualiser.Image = ((System.Drawing.Image)(resources.GetObject("TsbActualiser.Image")));
            this.TsbActualiser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbActualiser.Name = "TsbActualiser";
            this.TsbActualiser.Size = new System.Drawing.Size(116, 29);
            this.TsbActualiser.Text = "Actualiser";
            this.TsbActualiser.Click += new System.EventHandler(this.TsbActualiser_Click);
            // 
            // TsbReset
            // 
            this.TsbReset.Image = ((System.Drawing.Image)(resources.GetObject("TsbReset.Image")));
            this.TsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbReset.Name = "TsbReset";
            this.TsbReset.Size = new System.Drawing.Size(121, 29);
            this.TsbReset.Text = "R.à.Z Filtre";
            this.TsbReset.Click += new System.EventHandler(this.TsbReset_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(280, 55);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(290, 26);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TabStop = false;
            // 
            // DtpFin
            // 
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(1298, 55);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(116, 26);
            this.DtpFin.TabIndex = 7;
            this.DtpFin.TabStop = false;
            this.DtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // DtpDebut
            // 
            this.DtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDebut.Location = new System.Drawing.Point(1118, 55);
            this.DtpDebut.Name = "DtpDebut";
            this.DtpDebut.Size = new System.Drawing.Size(116, 26);
            this.DtpDebut.TabIndex = 6;
            this.DtpDebut.TabStop = false;
            this.DtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // BtnReset
            // 
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.Location = new System.Drawing.Point(1545, 48);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(54, 40);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.TabStop = false;
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1424, 48);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(116, 40);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.Text = "Filtrer";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GrpFiltre
            // 
            this.GrpFiltre.Controls.Add(this.label2);
            this.GrpFiltre.Controls.Add(this.label1);
            this.GrpFiltre.Controls.Add(this.ChkAnnule);
            this.GrpFiltre.Controls.Add(this.BtnReset);
            this.GrpFiltre.Controls.Add(this.BtnSearch);
            this.GrpFiltre.Controls.Add(this.ChkTermine);
            this.GrpFiltre.Controls.Add(this.ChkEnCours);
            this.GrpFiltre.Controls.Add(this.DtpDebut);
            this.GrpFiltre.Controls.Add(this.LblSearchText);
            this.GrpFiltre.Controls.Add(this.DtpFin);
            this.GrpFiltre.Controls.Add(this.LblCategorie);
            this.GrpFiltre.Controls.Add(this.CbxSearchCategorie);
            this.GrpFiltre.Controls.Add(this.TxtSearch);
            this.GrpFiltre.Location = new System.Drawing.Point(3, 54);
            this.GrpFiltre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpFiltre.Name = "GrpFiltre";
            this.GrpFiltre.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpFiltre.Size = new System.Drawing.Size(1624, 103);
            this.GrpFiltre.TabIndex = 10;
            this.GrpFiltre.TabStop = false;
            this.GrpFiltre.Text = "Filtrer les résultats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1244, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "et le :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(963, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Echéance entre le :";
            // 
            // ChkAnnule
            // 
            this.ChkAnnule.AutoSize = true;
            this.ChkAnnule.Location = new System.Drawing.Point(813, 58);
            this.ChkAnnule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkAnnule.Name = "ChkAnnule";
            this.ChkAnnule.Size = new System.Drawing.Size(85, 24);
            this.ChkAnnule.TabIndex = 5;
            this.ChkAnnule.TabStop = false;
            this.ChkAnnule.Text = "Annulé";
            this.ChkAnnule.UseVisualStyleBackColor = true;
            this.ChkAnnule.CheckedChanged += new System.EventHandler(this.ChkAnnule_CheckedChanged);
            // 
            // ChkTermine
            // 
            this.ChkTermine.AutoSize = true;
            this.ChkTermine.Location = new System.Drawing.Point(708, 58);
            this.ChkTermine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkTermine.Name = "ChkTermine";
            this.ChkTermine.Size = new System.Drawing.Size(92, 24);
            this.ChkTermine.TabIndex = 4;
            this.ChkTermine.TabStop = false;
            this.ChkTermine.Text = "Terminé";
            this.ChkTermine.UseVisualStyleBackColor = true;
            this.ChkTermine.CheckedChanged += new System.EventHandler(this.ChkTermine_CheckedChanged);
            // 
            // ChkEnCours
            // 
            this.ChkEnCours.AutoSize = true;
            this.ChkEnCours.Checked = true;
            this.ChkEnCours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEnCours.Location = new System.Drawing.Point(596, 58);
            this.ChkEnCours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkEnCours.Name = "ChkEnCours";
            this.ChkEnCours.Size = new System.Drawing.Size(98, 24);
            this.ChkEnCours.TabIndex = 2;
            this.ChkEnCours.TabStop = false;
            this.ChkEnCours.Text = "En cours";
            this.ChkEnCours.UseVisualStyleBackColor = true;
            this.ChkEnCours.CheckedChanged += new System.EventHandler(this.ChkEnCours_CheckedChanged);
            // 
            // LblSearchText
            // 
            this.LblSearchText.AutoSize = true;
            this.LblSearchText.Location = new System.Drawing.Point(279, 31);
            this.LblSearchText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSearchText.Name = "LblSearchText";
            this.LblSearchText.Size = new System.Drawing.Size(128, 20);
            this.LblSearchText.TabIndex = 5;
            this.LblSearchText.Text = "Recherche libre :";
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(10, 31);
            this.LblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(86, 20);
            this.LblCategorie.TabIndex = 4;
            this.LblCategorie.Text = "Catégorie :";
            // 
            // CbxSearchCategorie
            // 
            this.CbxSearchCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSearchCategorie.FormattingEnabled = true;
            this.CbxSearchCategorie.Location = new System.Drawing.Point(15, 54);
            this.CbxSearchCategorie.Name = "CbxSearchCategorie";
            this.CbxSearchCategorie.Size = new System.Drawing.Size(258, 28);
            this.CbxSearchCategorie.TabIndex = 0;
            this.CbxSearchCategorie.TabStop = false;
            this.CbxSearchCategorie.SelectedIndexChanged += new System.EventHandler(this.CbxSearchCategorie_SelectedIndexChanged);
            // 
            // timerActualisation
            // 
            this.timerActualisation.Enabled = true;
            this.timerActualisation.Interval = 3000;
            this.timerActualisation.Tick += new System.EventHandler(this.timerActualisation_Tick);
            // 
            // EvenementsListForm
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 872);
            this.ControlBox = false;
            this.Controls.Add(this.GrpFiltre);
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
            this.GrpFiltre.ResumeLayout(false);
            this.GrpFiltre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvenements;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BtnModifier;
        private System.Windows.Forms.ToolStripButton BtnNouveau;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.DateTimePicker DtpDebut;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ToolStripButton BtnFin;
        private System.Windows.Forms.ToolStripButton BtnAnnuler;
        private System.Windows.Forms.GroupBox GrpFiltre;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.ComboBox CbxSearchCategorie;
        private System.Windows.Forms.CheckBox ChkAnnule;
        private System.Windows.Forms.CheckBox ChkTermine;
        private System.Windows.Forms.CheckBox ChkEnCours;
        private System.Windows.Forms.Label LblSearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton TsbActualiser;
        private System.Windows.Forms.ToolStripButton TsbReset;
        private System.Windows.Forms.Timer timerActualisation;
    }
}