using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyKoloAPI.Models;

namespace MyKoloAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        //dbcontext -> ORM -> real db
        //we use dbsets to rep our tables
        //dbset is a type of generic collection
        //dbset<T>
        public DbSet <User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Savings> Savings { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
