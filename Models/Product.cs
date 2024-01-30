using static CartprojectG2.Models.CartDetail;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CartprojectG2.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int CategorieId { get; set; }

        public Categorie Categorie { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }

        [NotMapped]
        public string CategorieName { get; set; }
    }
}
