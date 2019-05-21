using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreScraper.Models;

namespace AspNetCoreScraper.Services
{
    public class FakeStockService : IStockService
    {
        public Task<Stock[]> GetIncompleteStocksAsync()
        {
         var stock1 = new Stock
         {
             ID = 1,
             Symbol = "AZN"
         };
        return Task.FromResult(new[] {stock1 });
        }
    }
       
}

