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

        string formTitle, operateur, categorie, tiers, description;
        bool evenementUpdateMode;
        int _id;

        EvenementsListForm _owner;

        EvenementProvider evenementProvider = new EvenementProvider();

        public EvenementEditForm(EvenementsListForm owner, bool update, int id = 0)
        {
            _owner = owner;
            _id = id;
            evenementUpdateMode = update;
            FormClosed += new FormClosedEventHandler(EvenementEditForm_FormClosed);
            InitializeComponent();

            /* Combobox Categorie */
            var dsCategorie = new List<Categorie>();
            foreach (Categorie categorie in utils.AllCategories())
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
            foreach (Statut statut in utils.AllStatuts())
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
            DtpEcheance.Value = DateTime.Now.AddDays(+7);


            switch(evenementUpdateMode)
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

            /* Titre du formulaire */
            this.Text = formTitle;
        }

        private void NewPostIt()
        {
            formTitle = "Création d'un Post'It";
        }

        private void LoadPostIt()
        {
            formTitle = "Modification d'un Post'It";
        }

        private void LblCategorie_Click(object sender, EventArgs e)
        {

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

        private void SavePostIt()
        {
            /* récupération des données */
            operateur = utils.RemoveDiacritics(CbxOperateur.Text.ToUpper().Trim());
            categorie = utils.RemoveDiacritics(CbxCategorie.Text.ToUpper().Trim());
            tiers = utils.RemoveDiacritics(TxtTiers.Text.ToUpper().Trim());
            description = utils.RemoveDiacritics(TxtDescription.Text.ToUpper().Trim());


        }
    }
}
