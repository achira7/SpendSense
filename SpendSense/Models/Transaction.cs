using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpendSense.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //Foreign Key
        public int CategoryID {  get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }

        public DateTime Date {  get; set; } = DateTime.Now;
    }
}
