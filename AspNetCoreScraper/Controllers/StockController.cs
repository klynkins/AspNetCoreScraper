using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreScraper.Services;
using AspNetCoreScraper.Models;

namespace AspNetCoreScraper.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _stockService.GetIncompleteItemsAsync();
            var model = new StockViewModel()
            {
                Items = items
            };

            return View(model);
        }
    }
}