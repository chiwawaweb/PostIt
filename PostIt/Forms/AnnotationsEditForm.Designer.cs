﻿namespace PostIt.Forms
{
    partial class AnnotationsEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnotationsEditForm));
            this.CbxOperateur = new System.Windows.Forms.ComboBox();
            this.TxtCommentaire = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAnnotations = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnFermer = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnotations)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxOperateur
            // 
            this.CbxOperateur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CbxOperateur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxOperateur.BackColor = System.Drawing.SystemColors.Info;
            this.CbxOperateur.FormattingEnabled = true;
            this.CbxOperateur.Location = new System.Drawing.Point(838, 514);
            this.CbxOperateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxOperateur.Name = "CbxOperateur";
            this.CbxOperateur.Size = new System.Drawing.Size(294, 31);
            this.CbxOperateur.TabIndex = 1;
            this.CbxOperateur.Enter += new System.EventHandler(this.CbxOperateur_Enter);
            // 
            // TxtCommentaire
            // 
            this.TxtCommentaire.AcceptsReturn = true;
            this.TxtCommentaire.BackColor = System.Drawing.SystemColors.Info;
            this.TxtCommentaire.Location = new System.Drawing.Point(14, 517);
            this.TxtCommentaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCommentaire.Multiline = true;
            this.TxtCommentaire.Name = "TxtCommentaire";
            this.TxtCommentaire.Size = new System.Drawing.Size(814, 96);
            this.TxtCommentaire.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(838, 560);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(294, 53);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Ajouter l\'annotation";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1036, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opérateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nouvelle annotation";
            // 
            // dgvAnnotations
            // 
            this.dgvAnnotations.AllowUserToAddRows = false;
            this.dgvAnnotations.AllowUserToDeleteRows = false;
            this.dgvAnnotations.AllowUserToResizeColumns = false;
            this.dgvAnnotations.AllowUserToResizeRows = false;
            this.dgvAnnotations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnnotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnnotations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnnotations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnnotations.Location = new System.Drawing.Point(14, 75);
            this.dgvAnnotations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAnnotations.Name = "dgvAnnotations";
            this.dgvAnnotations.ReadOnly = true;
            this.dgvAnnotations.RowHeadersVisible = false;
            this.dgvAnnotations.RowTemplate.Height = 28;
            this.dgvAnnotations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnnotations.Size = new System.Drawing.Size(1118, 401);
            this.dgvAnnotations.TabIndex = 5;
            this.dgvAnnotations.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFermer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1149, 32);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnFermer
            // 
            this.BtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("BtnFermer.Image")));
            this.BtnFermer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 29);
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // AnnotationsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 655);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAnnotations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtCommentaire);
            this.Controls.Add(this.CbxOperateur);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnnotationsEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Annotations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnnotationsEditForm_FormClosed);
            this.Load += new System.EventHandler(this.AnnotationsEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnotations)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxOperateur;
        private System.Windows.Forms.TextBox TxtCommentaire;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAnnotations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnFermer;
    }
}