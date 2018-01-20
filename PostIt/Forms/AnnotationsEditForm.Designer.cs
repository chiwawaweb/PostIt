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
            this.CbxOperateur = new System.Windows.Forms.ComboBox();
            this.TxtCommentaire = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAnnotations = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnotations)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxOperateur
            // 
            this.CbxOperateur.FormattingEnabled = true;
            this.CbxOperateur.Location = new System.Drawing.Point(852, 48);
            this.CbxOperateur.Name = "CbxOperateur";
            this.CbxOperateur.Size = new System.Drawing.Size(242, 28);
            this.CbxOperateur.TabIndex = 1;
            // 
            // TxtCommentaire
            // 
            this.TxtCommentaire.AcceptsReturn = true;
            this.TxtCommentaire.Location = new System.Drawing.Point(12, 48);
            this.TxtCommentaire.Multiline = true;
            this.TxtCommentaire.Name = "TxtCommentaire";
            this.TxtCommentaire.Size = new System.Drawing.Size(834, 84);
            this.TxtCommentaire.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(852, 88);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(244, 46);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Ajouter l\'annotation";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opérateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nouvelle annotation";
            // 
            // dgvAnnotations
            // 
            this.dgvAnnotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnotations.Location = new System.Drawing.Point(12, 175);
            this.dgvAnnotations.Name = "dgvAnnotations";
            this.dgvAnnotations.RowTemplate.Height = 28;
            this.dgvAnnotations.Size = new System.Drawing.Size(1084, 348);
            this.dgvAnnotations.TabIndex = 5;
            this.dgvAnnotations.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Annotations";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(855, 543);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(242, 32);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AnnotationsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 595);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAnnotations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtCommentaire);
            this.Controls.Add(this.CbxOperateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnnotationsEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Annotations";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClose;
    }
}