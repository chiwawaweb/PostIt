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

namespace PostIt.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            EvenementProvider evenementProvider = new EvenementProvider();
            evenementProvider.CountAll();

            EvenementsListForm frm = new EvenementsListForm();
            frm.MdiParent = this;
            frm.Show();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
