﻿using CartprojectG2.Models;
using CartprojectG2.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CartprojectG2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger,IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        public async Task<IActionResult> Index(string sterm = "", int categoryId = 0)

        {
            IEnumerable<Product> products = await _homeRepository.GetProducts(sterm, categoryId);
            IEnumerable<Categorie> categories = await _homeRepository.Categories();

            ProductDisplayModel productModel = new ProductDisplayModel
            {
                Products=products,
                Categories=categories,
                sTerm = sterm,
                CategorieId = categoryId

            };
            return View(productModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
