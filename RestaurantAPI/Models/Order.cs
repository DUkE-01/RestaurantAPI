using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int TableId { get; set; }

        public virtual Table Table { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }

        public decimal Subtotal { get; set; }

        public string Status { get; set; } // Enumeración (en proceso, completada)

        public DateTime CreatedAt { get; set; }
    }
}

