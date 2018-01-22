namespace PostIt.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxOperateur = new System.Windows.Forms.ComboBox();
            this.TxtCommentaire = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAnnotations = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnotations)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxOperateur
            // 
            this.CbxOperateur.BackColor = System.Drawing.SystemColors.Info;
            this.CbxOperateur.FormattingEnabled = true;
            this.CbxOperateur.Location = new System.Drawing.Point(568, 292);
            this.CbxOperateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxOperateur.Name = "CbxOperateur";
            this.CbxOperateur.Size = new System.Drawing.Size(163, 21);
            this.CbxOperateur.TabIndex = 1;
            // 
            // TxtCommentaire
            // 
            this.TxtCommentaire.AcceptsReturn = true;
            this.TxtCommentaire.BackColor = System.Drawing.SystemColors.Info;
            this.TxtCommentaire.Location = new System.Drawing.Point(8, 292);
            this.TxtCommentaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCommentaire.Multiline = true;
            this.TxtCommentaire.Name = "TxtCommentaire";
            this.TxtCommentaire.Size = new System.Drawing.Size(557, 56);
            this.TxtCommentaire.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(568, 318);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(163, 30);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Ajouter l\'annotation";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opérateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnnotations.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnnotations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAnnotations.Location = new System.Drawing.Point(8, 42);
            this.dgvAnnotations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAnnotations.Name = "dgvAnnotations";
            this.dgvAnnotations.ReadOnly = true;
            this.dgvAnnotations.RowHeadersVisible = false;
            this.dgvAnnotations.RowTemplate.Height = 28;
            this.dgvAnnotations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnnotations.Size = new System.Drawing.Size(723, 226);
            this.dgvAnnotations.TabIndex = 5;
            this.dgvAnnotations.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(568, 363);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(161, 21);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AnnotationsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 398);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.dgvAnnotations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtCommentaire);
            this.Controls.Add(this.CbxOperateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button BtnClose;
    }
}