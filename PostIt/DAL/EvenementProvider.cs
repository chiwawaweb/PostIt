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
        string statutENC, statutAVE, statutFIN, statutANN;

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

        public List<Evenement> Search(string keywords, bool ENC, bool AVE, bool FIN, bool ANN, DateTime dateDebut, DateTime dateFin)
        {


            if (ENC == true)
                statutENC = "En cours";
                else statutENC = "";

            if (ANN == true)
                statutANN = "Annulé";
            else statutANN = "";

            if (AVE == true)
                statutAVE = "A venir";
            else statutAVE = "";

            if (FIN == true)
                statutFIN = "Terminé";
            else statutFIN = "";

            using (Context context = new Context())
            {
                try
                {
                    var evenements = from b in context.Evenements
                                     orderby b.Id descending

                                     where (
                                     
                                     (b.Statut == statutENC)
                                     || (b.Statut == statutANN)
                                     || (b.Statut == statutAVE)
                                     || (b.Statut == statutFIN)
                                     )
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

        public void Update(Evenement Evenement)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Evenements.Attach(Evenement);
                    // Très important, signifier le fait que l'entité a été modifiée.
                    context.Entry(Evenement).State = EntityState.Modified;
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
