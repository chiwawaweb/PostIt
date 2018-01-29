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
        }

        private void CreateTable(List<Contact> list, int _idRetour)
        {
            idRetour = _idRetour;

            /* Initialisation du Datagridview des évenements*/
            dgvContacts.Rows.Clear();
            dgvContacts.Columns.Clear();

            /* Mise en forme du tableau */
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "ID";
            idCol.HeaderText = "#";
            idCol.Width = 50;
            idCol.Visible = true;
            idCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn typeCol = new DataGridViewTextBoxColumn();
            typeCol.Name = "Type";
            typeCol.HeaderText = "CATEGORIE";
            typeCol.Width = 100;
            typeCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn nomCol = new DataGridViewTextBoxColumn();
            nomCol.Name = "Nom";
            nomCol.HeaderText = "NOM";
            nomCol.Width = 250;
            nomCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn telCol = new DataGridViewTextBoxColumn();
            telCol.Name = "Téléphone";
            telCol.HeaderText = "TELEPHONE";
            telCol.Width = 120;
            telCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn faxCol = new DataGridViewTextBoxColumn();
            faxCol.Name = "Fax";
            faxCol.HeaderText = "FAX";
            faxCol.Width = 120;
            faxCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn gsmCol = new DataGridViewTextBoxColumn();
            gsmCol.Name = "Gsm";
            gsmCol.HeaderText = "GSM";
            gsmCol.Width = 120;
            gsmCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn emailCol = new DataGridViewTextBoxColumn();
            emailCol.Name = "Email";
            emailCol.HeaderText = "EMAIL";
            emailCol.Width = 170;
            emailCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;



            /* Création des colonnes */
            dgvContacts.Columns.Add(idCol);
            dgvContacts.Columns.Add(typeCol);
            dgvContacts.Columns.Add(nomCol);
            dgvContacts.Columns.Add(telCol);
            dgvContacts.Columns.Add(faxCol);
            dgvContacts.Columns.Add(gsmCol);
            dgvContacts.Columns.Add(emailCol);
        }

        public void RefreshData(bool firstLine = false)
        {
            //string searchText = utils.RemoveDiacritics(TxtSearch.Text);

            List<Contact> list;
            list = contactProvider.Search();

            if (firstLine == true)
            {
                idRetour = 0;
            }

            CreateTable(list, idRetour);
        }

        private void ContactsListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void TsbNewContact_Click(object sender, EventArgs e)
        {
            ContactEditForm frm = new ContactEditForm();
            frm.ShowDialog();
        }
    }
}
