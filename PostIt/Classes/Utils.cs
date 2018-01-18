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
        public List<Categorie> AllCategories()
        {
            List<Categorie> categories = new List<Categorie>()
            {
                new Categorie { Nom="Message", Abrv="MSG", Actif=true },
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

        public List<Statut> AllStatuts()
        {
            List<Statut> statuts = new List<Statut>()
            {
                new Statut { Nom="En cours", Abrv="ENC", Actif=true },
                new Statut { Nom="Terminé", Abrv="FIN", Actif=true },
                new Statut { Nom="A venir", Abrv="AVN", Actif=true }
            };

            return statuts;
        }
    }
}
