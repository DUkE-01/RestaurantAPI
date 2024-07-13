using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class Dish
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int ServingSize { get; set; }

        [Required]
        public string Category { get; set; } // Puede ser enumeración (Entrada, Plato fuerte, Postre, Bebida)

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
