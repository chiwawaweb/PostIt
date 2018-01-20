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

        public int? Create(Annotation Annotation)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Annotations.Add(Annotation);
                    context.SaveChanges();
                    int? id = Annotation.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public Annotation GetByEvenementId(int ID)
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Annotations.Find(ID);
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
