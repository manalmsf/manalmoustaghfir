using CartprojectG2;
using CartprojectG2.Data;
using CartprojectG2.Models;
using Microsoft.EntityFrameworkCore;

namespace CartprojectG2 { 

public class HomeRepository : IHomeRepository
{
    private readonly ApplicationDbContext _db;

    public HomeRepository(ApplicationDbContext db)
    {
        _db = db;
    }
        public async Task<IEnumerable<Categorie>> Categories()
        {
            return await _db.Categories.ToListAsync();
        }
      
    public async Task<IEnumerable<Product>> GetProducts(string sterm = "", int categoryId = 0)
    {
        sterm = sterm.ToLower();

        IEnumerable<Product> products = await (from product in _db.Products
                                               join categorie in _db.Categories
                                               on product.CategorieId equals categorie.Id
                                               where string.IsNullOrWhiteSpace(sterm) || (product != null && product.ProductName.ToLower().StartsWith(sterm))
                                               select new Product
                                               {
                                                   Id = product.Id,
                                                   Image = product.Image,
                                                   ProductName = product.ProductName,
                                                   CategorieId = product.CategorieId,
                                                   Price = product.Price,
                                                   CategorieName = categorie.CategorieName,
                                               }).ToListAsync();
        if (categoryId > 0)
        {

            products = products.Where(a => a.CategorieId == categoryId).ToList();
        }
        return products;
    }
}
}
