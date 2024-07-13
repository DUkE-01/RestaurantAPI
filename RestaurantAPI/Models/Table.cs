using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class Table
    {
        public int Id { get; set; }

        [Required]
        public int Capacity { get; set; }

        public string Description { get; set; }

        public string Status { get; set; } // Enumeración (Disponible, en proceso de atención, atendida)
    }
}
