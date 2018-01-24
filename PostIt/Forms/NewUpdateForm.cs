using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostIt.Forms
{
    public partial class NewUpdateForm : Form
    {
        static string updatePath = Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6)
            + @"\updates\";

        public NewUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            // URL du nouveau fichier
            string updateURL = "http://postit.chiwawaweb.com/lastupdate";

            Directory.CreateDirectory(updatePath);

            lbl_majdispo.Visible = false;
            lbl_majdownload.Visible = false;
            btn_yes.Visible = false;
            btn_no.Visible = false;
            progressBar.Visible = true;
            lbl_majencours.Visible = true;

            download(updateURL, updatePath + "update.exe");
        }

        private void download(string URL, string path)
        {
            WebClient wc = new WebClient();
            wc.DownloadProgressChanged += (s, e) =>
            {
                progressBar.Value = e.ProgressPercentage;
            };

            wc.DownloadFileCompleted += (s, e) =>
            {
                progressBar.Visible = false;
                btn_next.Visible = true;
                lbl_majencours.Text = "Le téléchargement de la mise à jour est terminé...";
            };

            wc.DownloadFileAsync(new Uri(URL), path);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Close();

            Process p = new Process();
            p.StartInfo.FileName = updatePath + "update.exe";
            p.Start();

            Application.Exit();
        }
    }
}
