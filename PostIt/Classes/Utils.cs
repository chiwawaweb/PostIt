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
        public List<CategorieEvenement> AllCategoriesEvenementsActives()
        {
            List<CategorieEvenement> categoriesEvenements = new List<CategorieEvenement>()
            {
                new CategorieEvenement { Nom="Message à un collaborateur", Abrv="MSG", Actif=true },
                new CategorieEvenement { Nom="Demande prix", Abrv="DPX", Actif=true },
                new CategorieEvenement { Nom="Suivi de réparation", Abrv="REP", Actif=true },
                new CategorieEvenement { Nom="Pochette photo/video perdue", Abrv="PHO", Actif=true },
                new CategorieEvenement { Nom="Rappel agenda", Abrv="AGD", Actif=true },
                new CategorieEvenement { Nom="Livraison à convenir", Abrv="LIV", Actif=true },
                new CategorieEvenement { Nom="Suivi de commande", Abrv="CDS", Actif=true },
                new CategorieEvenement { Nom="Attente virement", Abrv="VIR", Actif=true },
                new CategorieEvenement { Nom="Demande de transfert", Abrv="TRS", Actif=false },
                new CategorieEvenement { Nom="A faire", Abrv="TAF", Actif=true }
            };

            return categoriesEvenements.OrderBy(o => o.Nom).ToList();
        }

        public List<CategorieContact> AllCategoriesContactsActives()
        {
            List<CategorieContact> categoriesContacts = new List<CategorieContact>()
            {
                new CategorieContact { Nom="Fournisseur", Abrv="FRS", Actif=true },
                new CategorieContact { Nom="Interne", Abrv="INT", Actif=true },
                new CategorieContact { Nom="Service après-vente", Abrv="SAV", Actif=true },
            };

            return categoriesContacts.OrderBy(o => o.Nom).ToList();
        }

        public List<Pays> AllPaysActives()
        {
            List<Pays> pays = new List<Pays>()
            {
                new Pays { Nom="France", Abrv="FR", Actif=true },
                new Pays { Nom="Belgique", Abrv="BE", Actif=true },
                new Pays { Nom="Allemagne", Abrv="DE", Actif=true },
                new Pays { Nom="Luxembourg", Abrv="LU", Actif=true },
                new Pays { Nom="Suisse", Abrv="CH", Actif=true },
                new Pays { Nom="Pays-Bas", Abrv="NL", Actif=true },
                new Pays { Nom="Angleterre", Abrv="UK", Actif=true },
                new Pays { Nom="Espagne", Abrv="ES", Actif=true },
            };

            return pays.OrderBy(o => o.Nom).ToList();
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
