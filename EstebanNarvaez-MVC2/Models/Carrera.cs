using System.ComponentModel.DataAnnotations;

namespace EstebanNarvaez_MVC2.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
