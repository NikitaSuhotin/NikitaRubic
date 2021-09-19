using System;
using System.Collections.Generic;
using System.Linq;
using NikitaRubic.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace NikitaRubic.Controllers
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            : base(options)
        {

        }
        public DbSet<Budget> Budgets { get; set; }
    }
}