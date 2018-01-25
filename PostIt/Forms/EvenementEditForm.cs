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

            AnnotationsBtnUpdate();

            /* Titre du formulaire */
            LblTitre.Text = formTitle;
        }

        private void NewPostIt()
        {
            formTitle = "Création d'un Post'it";
        }
        
        private void AnnotationsBtnUpdate()
        {
            /* Détermine si des annotations existent déjà et mets à jour le bouton annotations*/
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

                /* Bouton clignotant */
                Timer.Enabled = true;
            }
            else
            {
                Timer.Enabled = false;
            }
        }

        private void LoadPostIt()
        {
            formTitle = "Consultation d'un Post'it";
            BtnCommentaires.Visible = true;
            BtnModifier.Visible = true;
            CbxOperateur.Visible = false;
            CbxCategorie.Visible = false;
            TxtTiers.Visible = false;
            TxtDescription.ReadOnly = true;
            TxtDescription.TabStop = false;
            TxtDescription.BackColor = Color.White;
            DtpEcheance.Visible = false;
            LblEcheanceView.Visible = true;
            LblOperateurView.Visible = true;
            LblTiersView.Visible = true;
            LblCategorieView.Visible = true;

            /* Récupération des données */
            operateur = evenementProvider.GetEvenementById(_id).Operateur;
            categorie = evenementProvider.GetEvenementById(_id).Categorie;
            tiers = evenementProvider.GetEvenementById(_id).Tiers;
            description = evenementProvider.GetEvenementById(_id).Description;
            echeance = evenementProvider.GetEvenementById(_id).Echeance;

            /* Affichage des donnees */
            CbxOperateur.Text = operateur;
            LblOperateurView.Text = operateur;
            CbxCategorie.Text = categorie;
            LblCategorieView.Text = categorie;
            TxtTiers.Text = tiers;
            LblTiersView.Text = tiers;
            TxtDescription.Text = description;
            DtpEcheance.Value = echeance;
            LblEcheanceView.Text = echeance.ToString("dd/MM/yyyy");

            /* Modification des boutons */
            BtnEnregistrer.Visible = false;
            BtnAnnuler.Visible = false;
            BtnFermer.Visible = true;
            BtnReculeEcheance.Visible = true;
            BtnAvanceEcheance.Visible = true;
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

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modification n'est pas encore disponible...", "Fonction à venir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReculeEcheance_Click(object sender, EventArgs e)
        {
            ModifEcheance(-1);
        }

        private void BtnAvanceEcheance_Click(object sender, EventArgs e)
        {
            ModifEcheance(1);
        }

        private void ModifEcheance(int nbDays)
        {
            Evenement evenement = evenementProvider.GetEvenementById(_id);

            evenement.Echeance = echeance.AddDays(nbDays);
            evenementProvider.Update(evenement);
            echeance = evenement.Echeance;
            LblEcheanceView.Text = echeance.ToString("dd/MM/yyyy");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (BtnCommentaires.BackColor != Color.Yellow)
            {
                Color btnColor = BtnCommentaires.BackColor;
                BtnCommentaires.BackColor = Color.Yellow;
            }
            else
            {
                BtnCommentaires.BackColor = SystemColors.ButtonFace;
                BtnCommentaires.UseVisualStyleBackColor = true;
            }
        }

        private void AddCommentaire()
        {
            AnnotationsEditForm frm = new AnnotationsEditForm(this, _id);
            frm.ShowDialog();
        }

        private void SavePostIt()
        {
            /* Récupération des données */
            date = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            operateur = utils.RemoveDiacritics(CbxOperateur.Text.ToUpper().Trim());
            categorie = CbxCategorie.Text.Trim();
            tiers = utils.RemoveDiacritics(TxtTiers.Text.ToUpper().Trim());
            description = utils.RemoveDiacritics(TxtDescription.Text.ToUpper().Trim());
            statut = "En cours";
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

        public void RefreshData()
        {
            /* Mets à jour le bouton des annotations */
            AnnotationsBtnUpdate();
        }

        
    }
}
