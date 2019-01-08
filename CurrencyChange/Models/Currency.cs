using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyChange.Models
{
    public class Currency
    {
        [Key]
        public string Id { get; set; }
        public int Ratio { get; set; }
    }
}
