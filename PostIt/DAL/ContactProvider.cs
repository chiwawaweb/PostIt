using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostIt.DAL;
using PostIt.DTO;

namespace PostIt.DAL
{
    public class ContactProvider
    {
        public List<Contact> Search()
        {
            using (Context context = new Context())
            {
                try
                {
                    var contacts = from b in context.Contacts
                                     orderby b.Nom ascending
                                     /*
                                     where (
                                            (
                                             (b.Statut == statutENC)
                                             || (b.Statut == statutANN)
                                             || (b.Statut == statutAVE)
                                             || (b.Statut == statutFIN)
                                            )
                                            && (b.Categorie.Contains(categorie))
                                            && (
                                                (b.Tiers.Contains(keywords))
                                                || (b.Description.Contains(keywords))
                                               )
                                            && (b.Echeance >= dateDebut)
                                            && (b.Echeance <= dateFin)
                                           )
                                           */
                                     select b;
                                     
                    return contacts.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
