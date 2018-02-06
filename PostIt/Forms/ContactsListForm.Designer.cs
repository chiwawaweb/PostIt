namespace PostIt.Forms
{
    partial class ContactsListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsListForm));
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsbNewContact = new System.Windows.Forms.ToolStripButton();
            this.TsbView = new System.Windows.Forms.ToolStripButton();
            this.TsbDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxTypeSearch = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.timerActualisation = new System.Windows.Forms.Timer(this.components);
            this.TsbActualiser = new System.Windows.Forms.ToolStripButton();
            this.TsbRaz = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeColumns = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContacts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContacts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContacts.Location = new System.Drawing.Point(0, 109);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersWidth = 30;
            this.dgvContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContacts.RowTemplate.ReadOnly = true;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.ShowCellErrors = false;
            this.dgvContacts.ShowCellToolTips = false;
            this.dgvContacts.ShowEditingIcon = false;
            this.dgvContacts.ShowRowErrors = false;
            this.dgvContacts.Size = new System.Drawing.Size(1569, 864);
            this.dgvContacts.TabIndex = 0;
            this.dgvContacts.TabStop = false;
            this.dgvContacts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellDoubleClick);
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNewContact,
            this.TsbView,
            this.TsbDelete,
            this.TsbActualiser,
            this.TsbRaz});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1569, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // TsbNewContact
            // 
            this.TsbNewContact.Image = ((System.Drawing.Image)(resources.GetObject("TsbNewContact.Image")));
            this.TsbNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNewContact.Name = "TsbNewContact";
            this.TsbNewContact.Size = new System.Drawing.Size(183, 28);
            this.TsbNewContact.Text = "Nouveau contact";
            this.TsbNewContact.Click += new System.EventHandler(this.TsbNewContact_Click);
            // 
            // TsbView
            // 
            this.TsbView.Image = ((System.Drawing.Image)(resources.GetObject("TsbView.Image")));
            this.TsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbView.Name = "TsbView";
            this.TsbView.Size = new System.Drawing.Size(98, 28);
            this.TsbView.Text = "Détails";
            this.TsbView.Click += new System.EventHandler(this.TsbView_Click);
            // 
            // TsbDelete
            // 
            this.TsbDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("TsbDelete.Image")));
            this.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDelete.Name = "TsbDelete";
            this.TsbDelete.Size = new System.Drawing.Size(219, 28);
            this.TsbDelete.Text = "Supprimer le contact";
            this.TsbDelete.Click += new System.EventHandler(this.TsbDelete_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 990);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.statusStrip.Size = new System.Drawing.Size(1569, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recherche :";
            // 
            // CbxTypeSearch
            // 
            this.CbxTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTypeSearch.FormattingEnabled = true;
            this.CbxTypeSearch.Location = new System.Drawing.Point(526, 60);
            this.CbxTypeSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbxTypeSearch.Name = "CbxTypeSearch";
            this.CbxTypeSearch.Size = new System.Drawing.Size(322, 31);
            this.CbxTypeSearch.TabIndex = 4;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(136, 62);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(380, 30);
            this.TxtSearch.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(858, 59);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(147, 40);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Chercher";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.Location = new System.Drawing.Point(1012, 59);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(49, 40);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // timerActualisation
            // 
            this.timerActualisation.Enabled = true;
            this.timerActualisation.Interval = 30000;
            this.timerActualisation.Tick += new System.EventHandler(this.timerActualisation_Tick);
            // 
            // TsbActualiser
            // 
            this.TsbActualiser.Image = ((System.Drawing.Image)(resources.GetObject("TsbActualiser.Image")));
            this.TsbActualiser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbActualiser.Name = "TsbActualiser";
            this.TsbActualiser.Size = new System.Drawing.Size(124, 28);
            this.TsbActualiser.Text = "Actualiser";
            this.TsbActualiser.Click += new System.EventHandler(this.TsbActualiser_Click);
            // 
            // TsbRaz
            // 
            this.TsbRaz.Image = ((System.Drawing.Image)(resources.GetObject("TsbRaz.Image")));
            this.TsbRaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbRaz.Name = "TsbRaz";
            this.TsbRaz.Size = new System.Drawing.Size(125, 28);
            this.TsbRaz.Text = "RàZ Filtre";
            this.TsbRaz.Click += new System.EventHandler(this.TsbRaz_Click);
            // 
            // ContactsListForm
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 1012);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CbxTypeSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvContacts);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ContactsListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Annuaire ";
            this.Load += new System.EventHandler(this.ContactsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton TsbNewContact;
        private System.Windows.Forms.ToolStripButton TsbView;
        private System.Windows.Forms.ToolStripButton TsbDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTypeSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Timer timerActualisation;
        private System.Windows.Forms.ToolStripButton TsbActualiser;
        private System.Windows.Forms.ToolStripButton TsbRaz;
    }
}