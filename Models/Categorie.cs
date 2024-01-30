using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartprojectG2.Models
{
    [Table("Categorie")]
    public class Categorie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? CategorieName { get; set; }
        public List<Product> Products { get; set; }
    }
} 
