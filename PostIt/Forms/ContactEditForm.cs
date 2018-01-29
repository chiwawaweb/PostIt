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
        Utils utils = new Utils();

        ContactsListForm _owner;

        ContactProvider contactProvider = new ContactProvider();


        public ContactEditForm()
        {
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
    }
}
