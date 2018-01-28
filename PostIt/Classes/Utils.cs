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
                new Categorie { Nom="Demande prix", Abrv="DPX", Actif=true },
                new Categorie { Nom="Suivi de réparation", Abrv="REP", Actif=true },
                new Categorie { Nom="Pochette photo/video perdue", Abrv="PHO", Actif=true },
                new Categorie { Nom="Rappel agenda", Abrv="AGD", Actif=true },
                new Categorie { Nom="Livraison à convenir", Abrv="LIV", Actif=true },
                new Categorie { Nom="Suivi de commande", Abrv="CDS", Actif=true },
                new Categorie { Nom="Attente virement", Abrv="VIR", Actif=true },
                new Categorie { Nom="Demande de transfert", Abrv="TRS", Actif=false },
                new Categorie { Nom="A faire", Abrv="TAF", Actif=true },
                new Categorie { Nom="Réservation/Précommande", Abrv="RES", Actif=true }
            };

            return categories.OrderBy(o => o.Nom).ToList();
        }

        public List<Statut> AllStatutsActives()
        {
            List<Statut> statuts = new List<Statut>()
            {
                new Statut { Id=0, Nom="En cours", Abrv="ENC", Actif=true },
                new Statut { Id=1, Nom="Terminé", Abrv="FIN", Actif=true },
                new Statut { Id=2, Nom="A venir", Abrv="AVN", Actif=true },
                new Statut { Id=3, Nom="Annulé", Abrv="ANN", Actif=false}
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
