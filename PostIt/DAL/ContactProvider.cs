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
        public List<Contact> Search(string keywords, string type)
        {
            using (Context context = new Context())
            {
                try
                {
                    var contacts = from b in context.Contacts
                                   orderby b.Nom, b.Prenom, b.Societe ascending
                                   where (
                                          (b.Nom.Contains(keywords))
                                            || (b.Prenom.Contains(keywords))
                                            || (b.Societe.Contains(keywords))
                                           )
                                           && (b.Type.Contains(type))
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

        public void Delete(Contact Contact)
        {
            using (Context context = new Context())
            {

                try
                {
                    context.Contacts.Attach(Contact);
                    context.Contacts.Remove(Contact);
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
