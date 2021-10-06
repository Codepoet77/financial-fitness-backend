using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialFitness.Data.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Summary { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public DateTimeOffset Occurrence { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Amount { get; set; }

        [Required]
        public int TransactionType { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
