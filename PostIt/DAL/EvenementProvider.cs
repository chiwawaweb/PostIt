using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostIt.DTO;
using System.Data.Entity;

namespace PostIt.DAL
{
    public class EvenementProvider
    {
        public int CountAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Evenements.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Evenement> Search(string keywords, DateTime dateDebut, DateTime dateFin)
        {
            using (Context context = new Context())
            {
                try
                {
                    var evenements = from b in context.Evenements
                                     orderby b.Id descending
                                     /*
                                     where (((b.Tiers.Contains(keywords)
                                        || (b.Operateur.Contains(keywords))
                                        
                                        )
                                     && (b.Date >= dateDebut)
                                     && (b.Date <= dateFin))
                                     )
                                     */
                                     select b;
                    return evenements.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<string> GetOperateurs()
        {
            using (Context context = new Context())
            {
                try
                {
                    var result = context.Evenements.Select(v => v.Operateur).Distinct();

                    var vendeurs = from b in context.Evenements
                                   orderby b.Operateur ascending

                                   select b
                                   ;
                    return result.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int? Create(Evenement Evenement)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Evenements.Add(Evenement);
                    context.SaveChanges();
                    int? id = Evenement.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public Evenement GetEvenementById(int ID)
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Evenements.Find(ID);
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
