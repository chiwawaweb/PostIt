using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt.Classes
{
    public class CategorieContact
    {
        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Abrv { get; set; }
        public bool Actif { get; set; }

        public string FullName => Nom;
    }
}
