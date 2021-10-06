using FinancialFitness.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialFitness.Data
{
    public class FinancialFitnessDBContext : DbContext
    {
        public FinancialFitnessDBContext(DbContextOptions<FinancialFitnessDBContext> options) : base(options)
        {            
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
