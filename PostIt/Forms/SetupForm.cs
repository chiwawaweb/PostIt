using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using PostIt.Classes;

namespace PostIt.Forms
{
    public partial class SetupForm : Form
    {
        Utils utils = new Utils();
        MainForm _owner;

        public SetupForm(MainForm owner)
        {
            _owner = owner;

            InitializeComponent();

            TxtDbPath.Text = utils.ReadSetting("dbPath");
        }

        private void SaveSetup()
        {
            /* Récupération des paramètres */
            string dbPath = TxtDbPath.Text.ToLower().Trim();

            /* Enregistrement des paramètres */
            AddUpdateAppSettings("dbPath", dbPath);
            AddUpdateConnString("DefaultConnection", dbPath);
            Close();
            Application.Restart();
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        static void AddUpdateConnString(string name, string dataSource)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.ConnectionStrings.ConnectionStrings;

                settings[name].Name = name;
                settings[name].ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SetupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshForm();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSetup();
            
        }
    }
}
