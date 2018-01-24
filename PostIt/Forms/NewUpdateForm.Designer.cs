namespace PostIt.Forms
{
    partial class NewUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUpdateForm));
            this.icone = new System.Windows.Forms.PictureBox();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_majdownload = new System.Windows.Forms.Label();
            this.lbl_majencours = new System.Windows.Forms.Label();
            this.lbl_majdispo = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.icone)).BeginInit();
            this.SuspendLayout();
            // 
            // icone
            // 
            this.icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icone.ErrorImage = null;
            this.icone.Image = ((System.Drawing.Image)(resources.GetObject("icone.Image")));
            this.icone.InitialImage = null;
            this.icone.Location = new System.Drawing.Point(23, 21);
            this.icone.Name = "icone";
            this.icone.Size = new System.Drawing.Size(72, 72);
            this.icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icone.TabIndex = 29;
            this.icone.TabStop = false;
            // 
            // btn_no
            // 
            this.btn_no.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_no.Location = new System.Drawing.Point(263, 65);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 28;
            this.btn_no.TabStop = false;
            this.btn_no.Text = "Plus tard...";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(182, 65);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(75, 23);
            this.btn_yes.TabIndex = 27;
            this.btn_yes.TabStop = false;
            this.btn_yes.Text = "Mettre à jour";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(263, 65);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 25;
            this.btn_next.TabStop = false;
            this.btn_next.Text = "Suivant >>>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_majdownload
            // 
            this.lbl_majdownload.AutoSize = true;
            this.lbl_majdownload.Location = new System.Drawing.Point(102, 35);
            this.lbl_majdownload.Name = "lbl_majdownload";
            this.lbl_majdownload.Size = new System.Drawing.Size(236, 13);
            this.lbl_majdownload.TabIndex = 24;
            this.lbl_majdownload.Text = "Souhaitez-vous télécharger la nouvelle version ?";
            // 
            // lbl_majencours
            // 
            this.lbl_majencours.AutoSize = true;
            this.lbl_majencours.Location = new System.Drawing.Point(102, 33);
            this.lbl_majencours.Name = "lbl_majencours";
            this.lbl_majencours.Size = new System.Drawing.Size(202, 13);
            this.lbl_majencours.TabIndex = 23;
            this.lbl_majencours.Text = "Mise à jour en cours de téléchargement...";
            this.lbl_majencours.Visible = false;
            // 
            // lbl_majdispo
            // 
            this.lbl_majdispo.AutoSize = true;
            this.lbl_majdispo.Location = new System.Drawing.Point(102, 18);
            this.lbl_majdispo.Name = "lbl_majdispo";
            this.lbl_majdispo.Size = new System.Drawing.Size(156, 13);
            this.lbl_majdispo.TabIndex = 22;
            this.lbl_majdispo.Text = "Une mise à jour est disponible...";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.progressBar.Location = new System.Drawing.Point(105, 65);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(233, 23);
            this.progressBar.TabIndex = 26;
            this.progressBar.Visible = false;
            // 
            // NewUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 111);
            this.Controls.Add(this.icone);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_majdownload);
            this.Controls.Add(this.lbl_majencours);
            this.Controls.Add(this.lbl_majdispo);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mise à jour disponible";
            ((System.ComponentModel.ISupportInitialize)(this.icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icone;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_majdownload;
        private System.Windows.Forms.Label lbl_majencours;
        private System.Windows.Forms.Label lbl_majdispo;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}