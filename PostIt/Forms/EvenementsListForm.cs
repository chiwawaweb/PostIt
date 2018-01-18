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

namespace PostIt.Forms
{
    public partial class EvenementsListForm : Form
    {
        private static int idRetour;

        public EvenementsListForm()
        {
            InitializeComponent();
        }

        //private void CreateTable(List<Evenement> list, int _idRetour)
        private void CreateTable(int _idRetour)
        {
            idRetour = _idRetour;

            /* Initialisation du Datagridview des évenements*/
            dgvEvenements.Rows.Clear();
            dgvEvenements.Columns.Clear();

            /* Mise en forme du tableau */
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "#";
            idColumn.Width = 50;
            idColumn.Visible = true;
            idColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "DATE";
            dateColumn.Width = 85;
            dateColumn.MinimumWidth = 85;
            dateColumn.FillWeight = 1;
            dateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn categorieColumn = new DataGridViewTextBoxColumn();
            categorieColumn.Name = "Categorie";
            categorieColumn.HeaderText = "CATEGORIE";
            categorieColumn.Width = 130;
            categorieColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn statutColumn = new DataGridViewTextBoxColumn();
            statutColumn.Name = "Statut";
            statutColumn.HeaderText = "STATUT";
            statutColumn.Width = 80;
            statutColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn tiersColumn = new DataGridViewTextBoxColumn();
            tiersColumn.Name = "Tiers";
            tiersColumn.HeaderText = "TIERS";
            tiersColumn.Width = 180;
            tiersColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.Name = "Description";
            descriptionColumn.HeaderText = "DESCRIPTION";
            descriptionColumn.Width = 550;
            descriptionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn operateurColumn = new DataGridViewTextBoxColumn();
            operateurColumn.Name = "Suivi par";
            operateurColumn.HeaderText = "SUIVI PAR";
            operateurColumn.Width = 140;
            operateurColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            dgvEvenements.Columns.Add(idColumn);
            dgvEvenements.Columns.Add(dateColumn);
            dgvEvenements.Columns.Add(categorieColumn);
            dgvEvenements.Columns.Add(statutColumn);
            dgvEvenements.Columns.Add(tiersColumn);
            dgvEvenements.Columns.Add(descriptionColumn);
            dgvEvenements.Columns.Add(operateurColumn);

        }

        public void RefreshData()
        {
            List<Evenement> list;
            //list = transfertProvider.Search(TxtSearch.Text, DtpDebut.Value, DtpFin.Value); // à completer avec mots cles / dates

            //CreateTable(list, idRetour);
            CreateTable(idRetour);


        }

        private void EvenementsListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            WindowState = FormWindowState.Maximized;
        }
    }
}
