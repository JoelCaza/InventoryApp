using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class Kardex
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
