using System.ComponentModel.DataAnnotations;

namespace EstebanNarvaez_MVC2.Models
{
    public class EstudianteUDLA
    {
        public String IdBanner { get; set; }
        [MaxLength(100)]
        public String Nombre { get; set; }
        [EmailAddress]
        public String Correo { get; set; }
        public Carrera Carrera { get; set; }
    }
}
