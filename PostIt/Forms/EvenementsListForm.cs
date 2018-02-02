using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostIt.DAL;
using PostIt.DTO;
using PostIt.Classes;

namespace PostIt.Forms
{
    public partial class EvenementsListForm : Form
    {
        private static int idRetour;

        Utils utils = new Utils();

        EvenementProvider evenementProvider = new EvenementProvider();

        public EvenementsListForm()
        {
            InitializeComponent();

            /* Combobox Catégorie */
            var dsCategorie = new List<CategorieEvenement>();
            CategorieEvenement categorieVide = new CategorieEvenement();
            categorieVide.Nom = "";
            dsCategorie.Add(categorieVide);
            foreach (CategorieEvenement categorie in utils.AllCategoriesEvenementsActives())
            {
                if (categorie.Actif == true)
                {
                    dsCategorie.Add(categorie);
                }
            }
            CbxSearchCategorie.DataSource = dsCategorie;
            CbxSearchCategorie.DisplayMember = "FullName";
            CbxSearchCategorie.ValueMember = "FullName";

            ResetFiltre();
        }

        private void CreateTable(List<Evenement> list, int _idRetour)
        {
            idRetour = _idRetour;

            /* Initialisation du Datagridview des évenements*/
            dgvEvenements.Rows.Clear();
            dgvEvenements.Columns.Clear();

            /* Mise en forme du tableau */
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "#";
            idColumn.Width = 60;
            idColumn.Visible = true;
            idColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "DATE";
            dateColumn.Width = 85;
            dateColumn.MinimumWidth = 85;
            dateColumn.FillWeight = 1;
            dateColumn.Visible = false;
            dateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn categorieColumn = new DataGridViewTextBoxColumn();
            categorieColumn.Name = "Categorie";
            categorieColumn.HeaderText = "CATEGORIE";
            categorieColumn.Width = 210;
            categorieColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn statutColumn = new DataGridViewTextBoxColumn();
            statutColumn.Name = "Statut";
            statutColumn.HeaderText = "STATUT";
            statutColumn.Width = 85;
            statutColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn tiersColumn = new DataGridViewTextBoxColumn();
            tiersColumn.Name = "Tiers";
            tiersColumn.HeaderText = "TIERS";
            tiersColumn.Width = 200;
            tiersColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.Name = "Description";
            descriptionColumn.HeaderText = "DESCRIPTION";
            descriptionColumn.Width = 460;
            descriptionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn echeanceColumn = new DataGridViewTextBoxColumn();
            echeanceColumn.Name = "Echeance";
            echeanceColumn.HeaderText = "ECHEANCE";
            echeanceColumn.Width = 85;
            echeanceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            echeanceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn operateurColumn = new DataGridViewTextBoxColumn();
            operateurColumn.Name = "Suivi par";
            operateurColumn.HeaderText = "SUIVI PAR";
            operateurColumn.Width = 140;
            operateurColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            dgvEvenements.Columns.Add(idColumn);
            dgvEvenements.Columns.Add(echeanceColumn);
            dgvEvenements.Columns.Add(categorieColumn);
            dgvEvenements.Columns.Add(statutColumn);
            dgvEvenements.Columns.Add(tiersColumn);
            dgvEvenements.Columns.Add(descriptionColumn);
            dgvEvenements.Columns.Add(dateColumn);
            dgvEvenements.Columns.Add(operateurColumn);

            /* Empeche le tri des colonnes */
            dgvEvenements.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEvenements.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEvenements.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEvenements.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEvenements.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEvenements.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEvenements.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEvenements.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvEvenements.Rows.Add();

                string id = list[i].Id.ToString("000000");
                DateTime date = list[i].Date;
                string categorie = list[i].Categorie;
                string statut = list[i].Statut;
                string tiers = list[i].Tiers;
                string description = list[i].Description;
                DateTime echeance = list[i].Echeance;
                string operateur = list[i].Operateur;
                
                dgvEvenements.Rows[number].Cells[0].Value = id;
                dgvEvenements.Rows[number].Cells[1].Value = echeance.ToString("dd/MM/yyyy");
                dgvEvenements.Rows[number].Cells[2].Value = categorie;
                dgvEvenements.Rows[number].Cells[3].Value = statut;
                dgvEvenements.Rows[number].Cells[4].Value = tiers;
                dgvEvenements.Rows[number].Cells[5].Value = description;
                dgvEvenements.Rows[number].Cells[6].Value = date.ToString("dd/MM/yyyy");
                dgvEvenements.Rows[number].Cells[7].Value = operateur;

                /* Coloration des lignes en fonction de l'échance */
                if (echeance == Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    rowColorChange(number, Color.Black, Color.FromArgb(255, 133, 51), FontStyle.Regular);
                }

                if (echeance < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    rowColorChange(number, Color.White, Color.Red, FontStyle.Bold);
                }

                if (echeance == Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString()))
                {
                    rowColorChange(number, Color.Black, Color.FromArgb(255, 255, 102), FontStyle.Regular);
                }

                /* Vérifie si événement terminé */
                if (statut == "Terminé" || statut == "Annulé")
                {
                    rowColorChange(number, Color.Gray, Color.White, FontStyle.Strikeout);
                }

                /* pointe sur l'enregistrement courant */
                if (list[i].Id == idRetour)
                {
                    dgvEvenements.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        /// <summary>
        /// Change le style d'une ligne
        /// </summary>
        /// <param name="row">ID de la ligne</param>
        /// <param name="fore">Couleur de police</param>
        /// <param name="back">Couleur de fond</param>
        private void rowColorChange(int row, Color fore, Color back, FontStyle fontStyle)
        {
            dgvEvenements.Rows[row].DefaultCellStyle.ForeColor = fore;
            dgvEvenements.Rows[row].DefaultCellStyle.BackColor = back;
            dgvEvenements.Rows[row].DefaultCellStyle.Font = new Font(this.Font, fontStyle);
        }

        public void RefreshData(bool firstLine = false)
        {
            DateTime dateDebut = Convert.ToDateTime(DtpDebut.Value.ToShortDateString());
            DateTime dateFin = Convert.ToDateTime(DtpFin.Value.ToShortDateString());
            //string searchText = utils.RemoveDiacritics(TxtSearch.Text);
            string searchText = TxtSearch.Text;

            List<Evenement> list;
            list = evenementProvider.Search(searchText, CbxSearchCategorie.Text, RadEncours.Checked, RadTermine.Checked, RadAnnule.Checked, dateDebut, dateFin);

            if (firstLine == true)
            {
                idRetour = 0;
            }

            CreateTable(list, idRetour);
        }

        private void EvenementsListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            //WindowState = FormWindowState.Maximized;
            
        }

        private void TslAdd_Click(object sender, EventArgs e)
        {
            NewPostIt();
        }

        private void NewPostIt()
        {
            EvenementEditForm frm = new EvenementEditForm(this, false);
            frm.ShowDialog();
        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            NewPostIt();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            UpdatePostIt();
        }

        private void UpdatePostIt()
        {
            if (dgvEvenements.RowCount > 0)
            {
                int ID = int.Parse(dgvEvenements.CurrentRow.Cells[0].Value.ToString());
                idRetour = ID;
                EvenementEditForm frm = new EvenementEditForm(this, true, ID);
                frm.ShowDialog();
            }
        }

        private void dgvEvenements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePostIt();
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            ChangeStatut("Terminé");
        }

        /// <summary>
        /// Changement de statut du post'it
        /// </summary>
        /// <param name="statut">Annulé ou Terminé</param>
        private void ChangeStatut(string statut)
        {
            if (dgvEvenements.RowCount > 0)
            {
                if (dgvEvenements.CurrentRow.Cells[3].Value.ToString() == "Terminé" || dgvEvenements.CurrentRow.Cells[3].Value.ToString() == "Annulé")
                {
                    /* Deja traite ou annule */
                    MessageBox.Show("Ce post'it ne peut plus changer de statut !", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Etes-vous certain de vouloir modifier le statut de ce post'it ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int ID = int.Parse(dgvEvenements.CurrentRow.Cells[0].Value.ToString());
                        Evenement evenement = evenementProvider.GetEvenementById(ID);
                        evenement.Statut = statut;
                        evenementProvider.Update(evenement);

                        /* Ajout d'une annotation */
                        string commentaire = statut;
                        AnnotationProvider annotationProvider = new AnnotationProvider();
                        Annotation annotation = new Annotation();
                        annotation.Date = DateTime.Now;
                        annotation.Commentaire = commentaire;
                        annotation.Operateur = "-";
                        annotation.CreatedAt = DateTime.Now;
                        annotation.EvenementId = ID;
                        annotationProvider.Create(evenement, annotation);

                        RefreshData();
                    }
                }
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            ChangeStatut("Annulé");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFiltre();
        }

        private void ResetFiltre()
        {
            CbxSearchCategorie.Text = "";
            TxtSearch.Text = "";
            RadEncours.Checked = true;
            DtpDebut.Value = DateTime.Now.AddMonths(-3);
            DtpFin.Value = DateTime.Now.AddDays(30);
        }

        private void TsbActualiser_Click(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        private void TsbReset_Click(object sender, EventArgs e)
        {
            ResetFiltre();
        }

        /// <summary>
        /// Actualisation de la liste.
        /// </summary>
        private void ActualiserListe()
        {
            if (dgvEvenements.RowCount > 0)
            {
                idRetour = int.Parse(dgvEvenements.CurrentRow.Cells[0].Value.ToString());
                RefreshData();
            }
        }

        /// <summary>
        /// Actualisation automatique de la liste à intervalle régulier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerActualisation_Tick(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        private void CbxSearchCategorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RadEncours_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RadTermine_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RadAnnule_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
