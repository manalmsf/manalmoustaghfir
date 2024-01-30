namespace CartprojectG2.Models.DTOs
{
    public class ProductDisplayModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Categorie> Categories { get; set; }
        public string sTerm { get; set; } = "";
        public int CategorieId { get; set; } = 0;
    }
}

