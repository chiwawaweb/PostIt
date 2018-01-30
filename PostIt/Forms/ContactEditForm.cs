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
    public partial class ContactEditForm : Form
    {
        string type, societe, nom, prenom, adresse1, adresse2, cp, ville, pays, tel, fax, gsm, email;

        

        bool contactUpdateMode;
        int _id;
        DateTime createdAt, updatedAt;

        Utils utils = new Utils();

        ContactsListForm _owner;

        ContactProvider contactProvider = new ContactProvider();


        public ContactEditForm(ContactsListForm owner, bool update, int id = 0)
        {
            _owner = owner;
            _id = id;
            contactUpdateMode = update;
            FormClosed += new FormClosedEventHandler(ContactEditForm_FormClosed);

            InitializeComponent();

            /* Combobox Catégories */
            var dsCategorie = new List<CategorieContact>();
            CategorieContact categorieVide = new CategorieContact();
            categorieVide.Nom = "";
            dsCategorie.Add(categorieVide);
            foreach (CategorieContact categorie in utils.AllCategoriesContactsActives())
            {
                if (categorie.Actif == true)
                {
                    dsCategorie.Add(categorie);
                }
            }
            CbxType.DataSource = dsCategorie;
            CbxType.DisplayMember = "FullName";
            CbxType.ValueMember = "FullName";

            /* Combobox Pays */
            var dsPays = new List<Pays>();
            Pays paysVide = new Pays();
            paysVide.Nom = "";
            dsPays.Add(paysVide);
            foreach (Pays pays in utils.AllPaysActives())
            {
                if (pays.Actif == true)
                {
                    dsPays.Add(pays);
                }
            }
            CbxPays.DataSource = dsPays;
            CbxPays.DisplayMember = "FullName";
            CbxPays.ValueMember = "FullName";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveContact();
        }

        private void SaveContact()
        {
            /* Récupération des données */
            type = CbxType.Text.Trim();
            societe = utils.RemoveDiacritics(TxtSociete.Text.Trim().ToUpper());
            nom = TxtNom.Text.Trim().ToUpper();
            prenom = TxtNom.Text.Trim().ToUpper();
            adresse1 = TxtAdresse1.Text.Trim().ToUpper();
            adresse2 = TxtAdresse2.Text.Trim().ToUpper();
            cp = TxtCp.Text.Trim().ToUpper();
            ville = TxtVille.Text.Trim().ToUpper();
            pays = CbxPays.Text.Trim().ToUpper();
            tel = TxtTel.Text.Trim();
            fax = TxtFax.Text.Trim();
            gsm = TxtGsm.Text.Trim();
            email = TxtEmail.Text.ToLower();

            /* Vérification des données */
            bool erreurs = false;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            if (type.Length<2)
            {
                erreurs = true;
                errMsg += "- Catégorie non spécifiée\n";
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
                    if (contactUpdateMode == true)
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

        }

        private void ContactEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }
    }
}
