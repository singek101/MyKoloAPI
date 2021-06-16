using Microsoft.AspNetCore.Mvc;
using MyKoloAPI.Data;
using MyKoloAPI.DTOs;
using MyKoloAPI.Models;
using System;
using System.Threading.Tasks;

namespace MyKoloAPI.Controllers
{
    [ApiController]
    [Route("expenses")]
    public class ExpensesController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ExpensesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AddExpense(AddExpenseDto requestBody)
        {
            //amount,description
            Expense expense = new Expense()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = requestBody.UserId,
                Amount = requestBody.Amount,
                Description = requestBody.Description
            };

            _context.Set<Expense>().Add(expense);
            _context.SaveChanges();
            return Ok(expense.Id);

        }

    }
}
