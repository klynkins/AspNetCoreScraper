﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreScraper.Models;

namespace AspNetCoreScraper.Services
{
    public class IStockService
    {
        Task<Stock[]> GetIncompleteItemsAsync();
    }
}
