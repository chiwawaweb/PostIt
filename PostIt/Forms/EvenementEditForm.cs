using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using PostIt.Classes;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using PostIt.DAL;
using PostIt.DTO;

namespace PostIt.Forms
{
    public partial class EvenementEditForm : Form
    {
        Utils utils = new Utils();

        string formTitle, operateur, categorie, tiers, description, statut;
        bool evenementUpdateMode;
        int _id;
        DateTime date, echeance;

        EvenementsListForm _owner;

        EvenementProvider evenementProvider = new EvenementProvider();
        AnnotationProvider annotationProvider = new AnnotationProvider();

        public EvenementEditForm(EvenementsListForm owner, bool update, int id = 0)
        {
            _owner = owner;
            _id = id;
            evenementUpdateMode = update;
            FormClosed += new FormClosedEventHandler(EvenementEditForm_FormClosed);
            InitializeComponent();

            /* Combobox Categorie */
            var dsCategorie = new List<Categorie>();
            foreach (Categorie categorie in utils.AllCategoriesActives())
            {
                if (categorie.Actif == true)
                {
                    dsCategorie.Add(categorie);
                }
            }
            CbxCategorie.DataSource = dsCategorie;
            CbxCategorie.DisplayMember = "FullName";
            CbxCategorie.ValueMember = "FullName";

            /* Combobox Statut */
            var dsStatut = new List<Statut>();
            foreach (Statut statut in utils.AllStatutsActives())
            {
                if (statut.Actif == true)
                {
                    dsStatut.Add(statut);
                }
            }
            CbxStatut.DataSource = dsStatut;
            CbxStatut.DisplayMember = "FullName";
            CbxStatut.ValueMember = "FullName";

            /* Combobox Opérateur */
            var dataSourceVendeur = new List<string>();
            dataSourceVendeur.Add("");
            foreach (string transfert in evenementProvider.GetOperateurs())
            {
                dataSourceVendeur.Add(transfert);
            }
            CbxOperateur.DataSource = dataSourceVendeur;
            CbxOperateur.DisplayMember = "Operateur";

            /* Date échéance à +7 jours par défaut */
            DtpEcheance.Value = DateTime.Now.AddDays(+1);


            switch (evenementUpdateMode)
            {
                /* Mode création */
                case false:
                    NewPostIt();
                    break;

                /* Mode mise à jour */
                case true:
                    LoadPostIt();
                    break;
            }

            /* Détermine si des annotations existent déjà */
            List<Annotation> list;
            list = annotationProvider.GetByEvenementId(_id);
            if (list.Count > 0)
            {
                string nbAnnotations = list.Count.ToString();
                if (list.Count > 1)
                {
                    BtnCommentaires.Text = nbAnnotations + " annotations";
                }
                else
                {
                    BtnCommentaires.Text = nbAnnotations + " annotation";
                }

                /* Couleur du bouton */
                BtnCommentaires.BackColor = Color.Yellow;
                
                
            }

            /* Titre du formulaire */
            LblTitre.Text = formTitle;
        }

        private void NewPostIt()
        {
            formTitle = "Création d'un Post'it";
        }
        
        private void LoadPostIt()
        {
            formTitle = "Modification d'un Post'iIt";
            BtnCommentaires.Visible = true;
            BtnModifier.Visible = true;
            CbxOperateur.Enabled = false;
            CbxCategorie.Enabled = false;
            TxtTiers.ReadOnly = true;
            TxtDescription.ReadOnly = true;
            CbxStatut.Enabled = false;
            DtpEcheance.Enabled = false;
        }

        private void LblCategorie_Click(object sender, EventArgs e)
        {

        }

        private void BtnCommentaires_Click(object sender, EventArgs e)
        {
            AddCommentaire();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EvenementEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            SavePostIt();
        }

        private void AddCommentaire()
        {
            AnnotationsEditForm frm = new AnnotationsEditForm(_id);
            frm.ShowDialog();
        }

        private void SavePostIt()
        {
            /* Récupération des données */
            date = Convert.ToDateTime(DateTime.Now);
            operateur = utils.RemoveDiacritics(CbxOperateur.Text.ToUpper().Trim());
            categorie = CbxCategorie.Text.Trim();
            tiers = utils.RemoveDiacritics(TxtTiers.Text.ToUpper().Trim());
            description = utils.RemoveDiacritics(TxtDescription.Text.ToUpper().Trim());
            statut = CbxStatut.Text.Trim();
            echeance = Convert.ToDateTime(DtpEcheance.Value.ToShortDateString());

            /* Vérification des données */
            bool erreurs = false;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            if (operateur.Length < 2)
            {
                erreurs = true;
                errMsg += "- Opérateur non spécifié ou trop court\n";
            }

            if (categorie.Length<3)
            {
                bool errors = true;
                errMsg += "- Catégorie incorrecte\n";
            }

            if (tiers.Length<2)
            {
                erreurs = true;
                errMsg += "- Tiers non spécifié ou trop court\n";
            }

            if (description.Length < 7)
            {
                erreurs = true;
                errMsg += "- Description ou message trop court\n";
            }

            if (statut.Length<3)
            {
                erreurs = true;
                errMsg += "- Statut incorrect\n";
            }


            if (erreurs == true)
            {
                MessageBox.Show(errMsg, "Erreurs dans la saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* Aucune erreur, on continue */
                using (Context context = new Context())
                {
                    if (evenementUpdateMode == true)
                    {
                        UpdateDatabase();
                    }
                    else
                    {
                        AddDatabase();
                    }
                    Close();
                }
            }
        }

        private void UpdateDatabase()
        {
            
        }

        private void AddDatabase()
        {
            Evenement evenement = new Evenement();

            evenement.Date = date;
            evenement.Categorie = categorie;
            evenement.Operateur = operateur;
            evenement.Tiers = tiers;
            evenement.Description = description;
            evenement.Statut = statut;
            evenement.Echeance = echeance;
            evenement.CreatedAt = DateTime.Now;

            evenementProvider.Create(evenement);
        }
    }
}
