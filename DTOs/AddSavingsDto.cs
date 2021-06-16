using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKoloAPI.DTOs
{
    public class AddSavingsDto
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
