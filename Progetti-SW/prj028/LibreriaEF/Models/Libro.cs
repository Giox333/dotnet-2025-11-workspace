using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibreriaEF.Data;

namespace LibreriaEF.Models
{
    [Table("Libri")]
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titolo { get; set; } = string.Empty;

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Prezzo { get; set; }

        public int? AutoreId { get; set; }

        // Navigazione
        [ForeignKey("AutoreId")]
        public virtual Autore? Autore { get; set; }
    }
}