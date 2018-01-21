using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostIt.DTO;
using System.Data.Entity;

namespace PostIt.DAL
{
    public class AnnotationProvider
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

        public int? Create(Evenement evenement, Annotation annotation)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Annotations.Add(annotation);
                    context.Evenements.Attach(evenement);
                    context.Entry(evenement).State = EntityState.Modified;
                    context.SaveChanges();
                    int? id = annotation.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Annotation> GetByEvenementId(int _id)
        {
            using (Context context = new Context())
            {
                try
                {
                    var annotations = from b in context.Annotations
                                      where b.EvenementId == _id
                                      orderby b.Date descending
                                      select b;

                    return annotations.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
