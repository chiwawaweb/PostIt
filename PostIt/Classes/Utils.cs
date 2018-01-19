using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Mail;
using System.Windows.Forms;

namespace PostIt.Classes
{
    public class Utils
    {
        public List<Categorie> AllCategoriesActives()
        {
            List<Categorie> categories = new List<Categorie>()
            {
                new Categorie { Nom="Message à un collaborateur", Abrv="MSG", Actif=true },
                new Categorie { Nom="Demande prix", Abrv="DPX", Actif=true},
                new Categorie { Nom="Suivi réparation", Abrv="REP", Actif=true},
                new Categorie { Nom="Pochette photo/video", Abrv="PHO", Actif=true},
                new Categorie { Nom="Rappel agenda", Abrv="AGD", Actif=true},
                new Categorie { Nom="Livraison à convenir", Abrv="LIV", Actif=true},
                new Categorie { Nom="Echange produit DOA", Abrv="ECH", Actif=true},
                new Categorie { Nom="Commande spéciale", Abrv="CDS", Actif=true},
                new Categorie { Nom="Attente virement", Abrv="VIR", Actif=true},
                new Categorie { Nom="Demande de transfert", Abrv="TRS", Actif=false},
                new Categorie { Nom="Devis", Abrv="DEV", Actif=false}
            };

            return categories;
        }

        public List<Statut> AllStatutsActives()
        {
            List<Statut> statuts = new List<Statut>()
            {
                new Statut { Nom="En cours", Abrv="ENC", Actif=true },
                new Statut { Nom="Terminé", Abrv="FIN", Actif=true },
                new Statut { Nom="A venir", Abrv="AVN", Actif=true }
            };

            return statuts;
        }

        public string RemoveDiacritics(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

        public string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "";
            }
        }
    }
}
