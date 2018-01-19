using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt.DTO
{
    public class Annotation
    {
        [Key]
        [Column("ID")]
        public int? Id { get; set; }
        [Required]
        public int IdEvenement { get; set; }
        [Required]
        [Column("DATE")]
        public DateTime Date { get; set; }
        [Required]
        [Column("REQUIRED")]
        public string Operateur { get; set; }
        [Required]
        [Column("ANNOTATION")]
        public string Commentaire { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
