using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostIt.Classes;
using PostIt.DAL;

namespace PostIt.Forms
{
    public partial class MainForm : Form
    {
        private string versionAppli =
            Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
            Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." +
            Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();

        const string lastVersionURL = "http://postit.chiwawaweb.com/download/lastversion.txt";

        Utils utils = new Utils();

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public MainForm()
        {
            InitializeComponent();

            EvenementProvider evenementProvider = new EvenementProvider();
            evenementProvider.CountAll();

            EvenementsListForm frm = new EvenementsListForm();
            frm.MdiParent = this;
            frm.Show();

            ContactsListForm frm2 = new ContactsListForm();
            frm2.MdiParent = this;
            frm2.Show();

            

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupForm frm = new SetupForm(this);
            frm.Show();
        }

        public void RefreshForm()
        {
            /* Mise à jour de certaines infos */
            // affiche la version dans la barre de titre
            TsslVersion.Text = "Version : " + versionAppli;

            if (checkUpdates() == 1)
            {
                updateAppli();
            }
        }

        private static bool CheckInternetConnection()
        {
            int Desc;
            if (InternetGetConnectedState(out Desc, 0))
            {
                // connexion internet OK
                return true;
            }
            else
            {
                // pas de connexion internet
                return false;
            }
        }

        private int checkUpdates()
        {
            if (CheckInternetConnection())
            {
                string lastVersionRemote;
                using (var webClient = new System.Net.WebClient())
                {
                    try
                    {
                        lastVersionRemote = webClient.DownloadString(lastVersionURL);

                        var localVersion = new Version(versionAppli);
                        var remoteVersion = new Version(lastVersionRemote);

                        var result = localVersion.CompareTo(remoteVersion);
                        if (result > 0)
                            return 2;
                        else if (result < 0)
                            return 1;
                        else
                            return 2;
                    }
                    catch
                    {
                        return 3;
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        private void updateAppli()
        {
            NewUpdateForm frm = new NewUpdateForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiseAJour();   
        }

        private void MiseAJour()
        {
            switch (checkUpdates())
            {
                case 0:
                    MessageBox.Show("Il n'y a pas de connexion internet actuellement. Merci de réessayer ultérieurement.", "Non connecté", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1:

                    updateAppli();
                    break;

                case 2:
                    MessageBox.Show("Vous avez la dernière version disponible.", "Recherche de mises à jour", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;

                case 3:
                    MessageBox.Show("Erreur serveur. Merci de réessayer ultérieurement.", "Erreur serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        private void annuaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactsListForm frm = new ContactsListForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
