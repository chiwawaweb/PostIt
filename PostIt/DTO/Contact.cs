using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt.DTO
{
    public class Contact
    {
        public int? Id {get; set;}
        public string Type { get; set; }
        public string Societe { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mob { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
