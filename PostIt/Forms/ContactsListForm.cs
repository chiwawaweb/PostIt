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

        private void CreateTable(List<Evenement> list, int _idRetour)
        {
            idRetour = _idRetour;

            /* Initialisation du Datagridview des évenements*/
            dgvContacts.Rows.Clear();
            dgvContacts.Columns.Clear();

            /* Mise en forme du tableau */
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "#";
            idColumn.Width = 50;
            idColumn.Visible = true;
            idColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            


            /* Création des colonnes */
            dgvContacts.Columns.Add(idColumn);


        }



        private void EvenementsListForm_Load(object sender, EventArgs e)
        {
            //RefreshData();

        }
    }
}
