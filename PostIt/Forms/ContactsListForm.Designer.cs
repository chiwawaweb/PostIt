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
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(0, 95);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersWidth = 30;
            this.dgvContacts.RowTemplate.Height = 28;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.ShowCellErrors = false;
            this.dgvContacts.ShowCellToolTips = false;
            this.dgvContacts.ShowEditingIcon = false;
            this.dgvContacts.ShowRowErrors = false;
            this.dgvContacts.Size = new System.Drawing.Size(1431, 751);
            this.dgvContacts.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNewContact,
            this.TsbView,
            this.TsbDelete});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1431, 32);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // TsbNewContact
            // 
            this.TsbNewContact.Image = ((System.Drawing.Image)(resources.GetObject("TsbNewContact.Image")));
            this.TsbNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNewContact.Name = "TsbNewContact";
            this.TsbNewContact.Size = new System.Drawing.Size(174, 29);
            this.TsbNewContact.Text = "Nouveau contact";
            this.TsbNewContact.Click += new System.EventHandler(this.TsbNewContact_Click);
            // 
            // TsbView
            // 
            this.TsbView.Image = ((System.Drawing.Image)(resources.GetObject("TsbView.Image")));
            this.TsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbView.Name = "TsbView";
            this.TsbView.Size = new System.Drawing.Size(93, 29);
            this.TsbView.Text = "Détails";
            this.TsbView.Click += new System.EventHandler(this.TsbView_Click);
            // 
            // TsbDelete
            // 
            this.TsbDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("TsbDelete.Image")));
            this.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDelete.Name = "TsbDelete";
            this.TsbDelete.Size = new System.Drawing.Size(204, 29);
            this.TsbDelete.Text = "Supprimer le contact";
            this.TsbDelete.Click += new System.EventHandler(this.TsbDelete_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 858);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1431, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recherche ";
            // 
            // CbxTypeSearch
            // 
            this.CbxTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTypeSearch.FormattingEnabled = true;
            this.CbxTypeSearch.Location = new System.Drawing.Point(453, 61);
            this.CbxTypeSearch.Name = "CbxTypeSearch";
            this.CbxTypeSearch.Size = new System.Drawing.Size(263, 28);
            this.CbxTypeSearch.TabIndex = 4;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(111, 54);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(311, 26);
            this.TxtSearch.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(744, 49);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(184, 31);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Chercher";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ContactsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 880);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CbxTypeSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvContacts);
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
    }
}