using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaEF.Models
{
    [Table("Autori")]
    public class Autore
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}

        [Required]
        [MaxLength(100)]
        public string Nome{get;set;} = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Cognome{get;set;} = string.Empty;

        [MaxLength(150)]
        public string? Email{get;set;}

        public virtual ICollection<Libro> Libri {get;set;} = new List<Libro>();

        [NotMapped]
        public string NomeCompleto => $"{Nome} {Cognome}";
    }
}