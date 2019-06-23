using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreScraper.Models
{
    public class Stock
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
        public string UserId { get; set; }

        public string Symbol { get; set; }
        //public string LastPrice { get; set; }
        //public string Change { get; set; }
        //public string PChange { get; set; }
        //public string Currency { get; set; }
        //public DateTime MarketTime { get; set; }
        //public string Volume { get; set; }
        //public string AVolume { get; set; }
        //public string MarketCap { get; set; }
    }
}
