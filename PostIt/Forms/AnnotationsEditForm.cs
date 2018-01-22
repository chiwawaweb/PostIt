using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostIt.Classes;
using PostIt.DAL;
using PostIt.DTO;

namespace PostIt.Forms
{
    public partial class AnnotationsEditForm : Form
    {
        string commentaire, operateur;
        bool annotationUpdateMode;
        int _id, idRetour;

        Utils utils = new Utils();

        AnnotationProvider annotationProvider = new AnnotationProvider();

        EvenementProvider evenementProvider = new EvenementProvider();

        EvenementEditForm _owner;

        public AnnotationsEditForm(EvenementEditForm owner, int Id)
        {
            _id = Id;
            _owner = owner;
            FormClosed += new FormClosedEventHandler(AnnotationsEditForm_FormClosed);
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveAnnotation();
        }

        private void SaveAnnotation()
        {
            /* Recuperation des donnees */
            commentaire = TxtCommentaire.Text.Trim();
            operateur = utils.RemoveDiacritics(CbxOperateur.Text.ToUpper().Trim());

            /* Verification des donnees */
            bool erreurs = false;
            string errMsg = "Votre saisie comporte des erreurs :\n\n";

            if (commentaire.Length<3)
            {
                erreurs = true;
                errMsg += "- Commentaire non spécifié \n";
            }

            if (operateur.Length<2)
            {
                erreurs = true;
                errMsg += "- Opérateur non spécifié \n";
            }

            if (erreurs == true)
            {
                MessageBox.Show(errMsg, "Erreurs dans la saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* Pas d'erreurs */
                switch (annotationUpdateMode)
                {

                    case false:
                        /* Mode création */
                        AddDatabase();
                        break;

                    case true:
                        /* Mode mise à jour */
                        UpdateDatabase();
                        break;
                }
                VideChamps();
                RefreshData();
            }
        }

        private void CreateTable(List<Annotation> list, int _idRetour)
        {
            _idRetour = _idRetour;

            /* Initialisation du tableau */
            dgvAnnotations.Rows.Clear();
            dgvAnnotations.Columns.Clear();

            /* Mise en forme du tableau */
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "#";
            idColumn.Width = 50;
            idColumn.Visible = false;
            idColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "DATE / HEURE";
            dateColumn.Width = 120;
            dateColumn.MinimumWidth = 120;
            dateColumn.FillWeight = 1;
            dateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn annotationColumn = new DataGridViewTextBoxColumn();
            annotationColumn.Name = "Annotation";
            annotationColumn.HeaderText = "ANNOTATION";
            annotationColumn.Width = 463;
            annotationColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn operateurColumn = new DataGridViewTextBoxColumn();
            operateurColumn.Name = "Operateur";
            operateurColumn.HeaderText = "OPERATEUR";
            operateurColumn.Width = 120;
            operateurColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            dgvAnnotations.Columns.Add(idColumn);
            dgvAnnotations.Columns.Add(dateColumn);
            dgvAnnotations.Columns.Add(annotationColumn);
            dgvAnnotations.Columns.Add(operateurColumn);

            /* Empeche le tri des colonnes */
            dgvAnnotations.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAnnotations.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAnnotations.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAnnotations.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvAnnotations.Rows.Add();

                string id = list[i].Id.ToString();
                DateTime date = list[i].Date;
                string annotation = list[i].Commentaire;
                string operateur = list[i].Operateur;

                dgvAnnotations.Rows[number].Cells[0].Value = id;
                dgvAnnotations.Rows[number].Cells[1].Value = date.ToString("dd/MM/yyyy HH:mm:ss");
                dgvAnnotations.Rows[number].Cells[2].Value = annotation;
                dgvAnnotations.Rows[number].Cells[3].Value = operateur;
            }
        }

        private void VideChamps()
        {
            TxtCommentaire.Text = "";
            CbxOperateur.Text = "";
            TxtCommentaire.Focus();
        }

        public void RefreshData()
        {
            List<Annotation> list;
            list = annotationProvider.GetByEvenementId(_id); // à completer avec mots cles / dates
            //list = evenementProvider.Search("", DateTime.Now.AddMonths(-1), DateTime.Now);

            CreateTable(list, idRetour);

        }

        private void AnnotationsEditForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void AnnotationsEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }

        private void AddDatabase()
        {
            Evenement evenement = evenementProvider.GetEvenementById(_id);
                
            /* Création de l'annotation */
            Annotation annotation = new Annotation();
            annotation.Date = DateTime.Now;
            annotation.Commentaire = commentaire;
            annotation.Operateur = operateur;
            annotation.CreatedAt = DateTime.Now;
            annotation.EvenementId = _id;

            annotationProvider.Create(evenement, annotation);
        }

        private void UpdateDatabase()
        {

        }
    }
}
;