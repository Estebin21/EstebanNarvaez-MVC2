using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EstebanNarvaez_MVC2.Models
{
    public class EstudianteUDLA
    {
        [Key]
        public String IdBanner { get; set; }
        [MaxLength(100)]
        [Required]
        public String Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [EmailAddress]
        [AllowNull]
        public String Correo { get; set; }
        public bool TieneBeca {  get; set; }
        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }  

    }
}
