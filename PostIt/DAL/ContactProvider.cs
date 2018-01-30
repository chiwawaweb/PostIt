using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public int? Create(Contact Contact)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Contacts.Add(Contact);
                    context.SaveChanges();
                    int? id = Contact.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public Contact GetContactById(int ID)
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Contacts.Find(ID);
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Update(Contact Contact)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Contacts.Attach(Contact);
                    // Très important, signifier le fait que l'entité a été modifiée.
                    context.Entry(Contact).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
