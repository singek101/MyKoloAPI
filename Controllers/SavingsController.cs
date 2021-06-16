using Microsoft.AspNetCore.Mvc;
using MyKoloAPI.Data;
using MyKoloAPI.DTOs;
using MyKoloAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKoloAPI.Controllers
{
    [ApiController]
    [Route("savings")]
    public class SavingsController : ControllerBase
    {
        private  readonly ApplicationDbContext _context;
        public SavingsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
       public IActionResult AddSavings(AddSavingsDto requestBody)
        {
            //amount,description
            Savings savings  = new Savings()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = requestBody.UserId,
                Amount = requestBody.Amount,
                Description = requestBody.Description
            };

            _context.Set<Savings>().Add(savings);
            _context.SaveChanges();
            return Ok(savings.Id);

        }
    }
}
