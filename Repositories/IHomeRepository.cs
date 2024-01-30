using CartprojectG2.Models;
using Humanizer.Localisation;

namespace CartprojectG2
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> GetProducts(string sTerm = "", int categoryId = 0);
        Task<IEnumerable<Categorie>> Categories();
    }
}