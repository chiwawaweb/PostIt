using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int _id;

        Utils utils = new Utils();

        AnnotationProvider annotationProvider = new AnnotationProvider();

        public AnnotationsEditForm(int Id)
        {
            _id = Id;
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
                Close();
            }

            

        }

        private void AddDatabase()
        {
            /* Création de l'annotation */
            
                Annotation annotation = new Annotation();
                annotation.Date = DateTime.Now;
                annotation.Commentaire = commentaire;
                annotation.Operateur = operateur;
                annotation.CreatedAt = DateTime.Now;
                annotation.EvenementId = _id;
                
                annotationProvider.Create(annotation);
                //context.Annotations.Add(annotation);
                //context.SaveChanges();
            
            
        }

        private void UpdateDatabase()
        {

        }
    }
}
;