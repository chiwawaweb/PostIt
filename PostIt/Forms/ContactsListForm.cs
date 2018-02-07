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
    public partial class ContactsListForm : Form
    {
        private static int idRetour;

        Utils utils = new Utils();

        ContactProvider contactProvider = new ContactProvider();

        public ContactsListForm()
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
            CbxTypeSearch.DataSource = dsCategorie;
            CbxTypeSearch.DisplayMember = "FullName";
            CbxTypeSearch.ValueMember = "FullName";
        }

        private void CreateTable(List<Contact> list, int _idRetour)
        {
            idRetour = _idRetour;

            /* Initialisation du Datagridview des évenements*/
            dgvContacts.Rows.Clear();
            dgvContacts.Columns.Clear();

            /* Mise en forme du tableau */
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "#",
                Width = 50,
                Visible = false
            };
            idCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn typeCol = new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "CATEGORIE",
                Width = 170
            };
            typeCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn nomCol = new DataGridViewTextBoxColumn
            {
                Name = "Nom",
                HeaderText = "NOM",
                Width = 400
            };
            nomCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn telCol = new DataGridViewTextBoxColumn
            {
                Name = "Téléphone",
                HeaderText = "TELEPHONE",
                Width = 120
            };
            telCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn faxCol = new DataGridViewTextBoxColumn
            {
                Name = "Fax",
                HeaderText = "FAX",
                Width = 120
            };
            faxCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn gsmCol = new DataGridViewTextBoxColumn
            {
                Name = "Gsm",
                HeaderText = "GSM",
                Width = 120
            };
            gsmCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn emailCol = new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "EMAIL",
                Width = 220
            };
            emailCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            dgvContacts.Columns.Add(idCol);
            dgvContacts.Columns.Add(typeCol);
            dgvContacts.Columns.Add(nomCol);
            dgvContacts.Columns.Add(telCol);
            dgvContacts.Columns.Add(faxCol);
            dgvContacts.Columns.Add(gsmCol);
            dgvContacts.Columns.Add(emailCol);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvContacts.Rows.Add();

                int? id = list[i].Id;
                string type = list[i].Type;
                string nom = (list[i].Societe + " " + list[i].Nom + " " + list[i].Prenom).Trim();
                string tel = list[i].Tel;
                string fax = list[i].Fax;
                string gsm = list[i].Mob;
                string email = list[i].Email;

                dgvContacts.Rows[number].Cells[0].Value = id;
                dgvContacts.Rows[number].Cells[1].Value = type;
                dgvContacts.Rows[number].Cells[2].Value = nom;
                dgvContacts.Rows[number].Cells[3].Value = tel;
                dgvContacts.Rows[number].Cells[4].Value = fax;
                dgvContacts.Rows[number].Cells[5].Value = gsm;
                dgvContacts.Rows[number].Cells[6].Value = email;

                /* pointe sur l'enregistrement courant */
                if (list[i].Id == idRetour)
                {
                    dgvContacts.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        public void RefreshData(bool firstLine = false)
        {
            //string searchText = utils.RemoveDiacritics(TxtSearch.Text);

            List<Contact> list;
            list = contactProvider.Search(TxtSearch.Text, CbxTypeSearch.Text);

            if (firstLine == true)
            {
                idRetour = 0;
            }

            CreateTable(list, idRetour);

            /* Mise à jour du nombre de contact dans la barre de statut */
            TslNbContacts.Text = "Nombre de contacts affichés : " + list.Count.ToString();
        }

        private void ContactsListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void TsbNewContact_Click(object sender, EventArgs e)
        {
            ContactEditForm frm = new ContactEditForm(this, false);
            frm.ShowDialog();
        }

        private void TsbView_Click(object sender, EventArgs e)
        {
            ViewContact();
        }

        private void ViewContact()
        {
            if (dgvContacts.RowCount > 0)
            {
                int ID = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                idRetour = ID;
                ContactEditForm frm = new ContactEditForm(this, true, ID);
                frm.ShowDialog();
            }
        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        private void DeleteContact()
        {
            if (dgvContacts.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("Etes-vous certain de vouloir supprimer ce contact ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                    contactProvider.Delete(new Contact { Id = ID });
                    RefreshData();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewContact();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFiltre();
        }

        private void ResetFiltre()
        {
            CbxTypeSearch.Text = "";
            TxtSearch.Text = "";
            RefreshData();
        }

        /// <summary>
        /// Actualisation de la liste.
        /// </summary>
        private void ActualiserListe()
        {
            if (dgvContacts.RowCount > 0)
            {
                idRetour = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                RefreshData();
            }
        }

        private void TimerActualisation_Tick(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        private void TsbActualiser_Click(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        private void TsbRaz_Click(object sender, EventArgs e)
        {
            ResetFiltre();
        }

        private void CbxTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
