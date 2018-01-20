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
        [Column("DATE")]
        public DateTime Date { get; set; }
        [Required]
        [Column("EVENEMENT_ID")]
        public int EvenementId { get; set; }
        [Required]
        [ForeignKey("EvenementId")]
        public virtual Evenement evenements { get; set; }
        [Required]
        [Column("OPERATEUR")]
        public string Operateur { get; set; }
        [Required]
        [Column("ANNOTATION")]
        public string Commentaire { get; set; }
        [Column("SUPPRIME")]
        public bool Supprime { get; set; }
        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
        [Column("UPDATED_AT")]
        public DateTime UpdatedAt { get; set; }
    }
}
