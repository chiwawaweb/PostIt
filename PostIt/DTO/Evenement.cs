using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt.DTO
{
    public class Evenement
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DATE")]
        public DateTime Date { get; set; }
        [Required]
        [Column("CATEGORIE")]
        public string Categorie { get; set; }
        [Required]
        [Column("OPERATEUR")]
        public string Operateur { get; set; }
        [Column("TIERS")]
        public string Tiers { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("STATUT")]
        public string Statut { get; set; }
        [Column("ECHEANCE")]
        public DateTime Echeance { get; set; }
        [Column("SUPPRIME")]
        public bool Supprime { get; set; }
        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
        [Column("UPDATED_AT")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Annotation> annotations { get; set; }
    }
}
