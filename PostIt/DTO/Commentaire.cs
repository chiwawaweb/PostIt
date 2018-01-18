using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt.DTO
{
    public class Commentaire
    {
        public int? Id { get; set; }
        public int IdEvenement { get; set; }
        public DateTime Date { get; set; }
        public string Operateur { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
