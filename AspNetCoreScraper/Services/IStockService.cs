using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreScraper.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreScraper.Services
{
    public interface IStockService
    {
        Task<Stock[]> GetIncompleteItemsAsync(IdentityUser user);
        Task<bool> AddItemAsync(Stock newItem, IdentityUser user);
        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);
    }
}
